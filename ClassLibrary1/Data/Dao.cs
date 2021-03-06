﻿using ConsoleAppTry.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleAppTry.Data
{//класс с сериализацией
    class Dao
    { 
        TVprogram program;
        // шлях до файлу
        string path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, @"MainAdminApp\bin\Debug\");
        public Dao(TVprogram program)
        {
            this.program = program;
        }
        public void Save()
        {
            using (Stream stream = File.Create(path + "tvprogram.bin"))
            {
                var serializer = new BinaryFormatter();
                serializer.Serialize(stream, program);
            }
        }
        public void Load()
        {
            using (Stream stream = File.OpenRead(path + "tvprogram.bin"))
            {
                var serializer = new BinaryFormatter();
                TVprogram st = (TVprogram)serializer.Deserialize(stream);
                Copy(st.tvshowList, program.tvshowList);
                Copy(st.userList, program.userList);
                Copy(st.dateList, program.dateList);
            }

            void Copy<T>(List<T> from, List<T> to)
            {
                to.Clear();
                to.AddRange(from);
            }
        }
    }
}
