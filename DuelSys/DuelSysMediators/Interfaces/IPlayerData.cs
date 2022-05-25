using DuelSysEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DuelSysMediators.Interfaces
{
    public interface IPlayerData
    {
        bool AddPlayer(Player player);
        public List<Player> GetPlayers();

    }
}
