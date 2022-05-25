using System;
using System.Collections.Generic;
using System.Text;

namespace DuelSysEntities
{
    public class Player
    {
        public string Username { get; private set; }
        public string Password { get; private set; }

        public int Id { get; private set; }

        public Player(string username, string password)
        {
            Username = username;
            Password = password;

        }

        public Player(int id, string username, string password)
        {
            Id = id;
            Username = username;
            Password = password;

        }

        public void UpdateInfo(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
