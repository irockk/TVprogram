using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTry.Models
{
    [Serializable]
    class User //пользователь = логин + пароль
    {
            public string Login { set; get; }
            public string Password { set; get; }
    }
}
