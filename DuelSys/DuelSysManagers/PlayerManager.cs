using DuelSysEntities;
using DuelSysMediators.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DuelSysManagers
{
    public class PlayerManager
    {
        private List<Player> players;



        private IPlayerData playerMediator;
        public PlayerManager(IPlayerData src)
        {
            this.players = new List<Player>();

            this.playerMediator = src;

        }

        public bool AddPlayer(Player player)
        {
            if (player != null)
            {
                players.Add(player);
                playerMediator.AddPlayer(player);
                return true;
            }
            else
            {
                return false;
            }

        }

        public Player CheckCredentials(string username, string password)
        {
            foreach (Player player in GetAllPlayers())
            {
                if (player.Username == username && player.Password == password)
                {
                    return player;
                }
            }
            return null;
        }

        //public void EditPlayer(Player player, string username, string password)
        //{
        //    player.UpdateInfo(username, password);
        //    playerMediator.EditPlayer(player);
        //}
        public Player GetPlayer(string username)
        {
            foreach (Player player in GetAllPlayers())
            {
                if (player.Username == username)
                {
                    return player;
                }
            }
            return null;
        }

        public Player GetPlayerByID(int id)
        {
            foreach (Player player in GetAllPlayers())
            {
                if (player.Id == id)
                {
                    return player;
                }
            }
            return null;
        }

        public List<Player> GetAllPlayers()
        {
            players = playerMediator.GetPlayers();
            return players;
        }
    }
}
