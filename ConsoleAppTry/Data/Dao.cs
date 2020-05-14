using ConsoleAppTry.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleAppTry.Data
{//класс с сериализацией
    class Dao
    {
        TVprogram tvprogram;
        const string filePath = "tvprogram.bin";
        public Dao(TVprogram tvprogram)
        {
            this.tvprogram = tvprogram;
        }
        public void Save()
        {
            using (Stream stream = File.Create(filePath))
            {
                var serializer = new BinaryFormatter();
                serializer.Serialize(stream, tvprogram);
                serializer.Serialize(stream,tvprogram.user);
                serializer.Serialize(stream, tvprogram.favourite);
            }
        }
        public void Load()
        {
            using (Stream stream = File.OpenRead(filePath))
            {
                var serializer = new BinaryFormatter();
                TVprogram st = (TVprogram)serializer.Deserialize(stream);
                Copy(st.tvshow, tvprogram.tvshow);
                Copy(st.user, tvprogram.user);
                Copy(st.favourite, tvprogram.favourite);
            }

            void Copy<T>(List<T> from, List<T> to)
            {
                to.Clear();
                to.AddRange(from);
            }
        }
    }
}
