using DuelSysEntities;
using DuelSysMediators.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DuelSysMediators.FakeData
{
    public class FakePlayerData: IPlayerData
    {
        List<Player> players;
        public FakePlayerData()
        {
            players = new List<Player>();
            players.Add(new Player(1, "aa", "bb"));
            players.Add(new Player("bb", "cc"));
            players.Add(new Player("cc", "dd"));
            players.Add(new Player("dd", "ee"));
        }

        public bool AddPlayer(Player player)
        {
            return true;
        }

        //public bool EditMember(Player member)
        //{
        //    return true;
        //}

        public List<Player> GetPlayers()
        {
            return players;
        }
    }
}
