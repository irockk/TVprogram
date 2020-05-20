using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTry.Models
{
    [Serializable]
    class Favourite //любимые = коллекция передач + пользователь
    {
        public Favourite(List<TVshow> show, User userLogin)
        {
            TVshow = show;
            UserLogin = userLogin;
        }
        public List<TVshow> TVshow {set; get; }
        public User UserLogin {set; get; }
    }
}
