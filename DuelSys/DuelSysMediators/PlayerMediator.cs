using DuelSysEntities;
using DuelSysMediators.Interfaces;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DuelSysMediators
{
    public class PlayerMediator: DataAccess, IPlayerData
    {
        public PlayerMediator()
        {

        }

        public bool AddPlayer(Player player)
        {
            if (ConnOpen())
            {


                try
                {
                    query = "INSERT INTO player (Username, Password) VALUES (@username, @password)";
                    SqlQuery(query);

                    AddWithValue("@username", player.Username);
                    AddWithValue("@password", player.Password);

                    NonQueryEx();

                    return true;

                }
                catch (Exception ex)
                {
                    
                    return false;
                }
                finally
                {
                    Close();
                }


            }
            else
            {
                return false;
            }


        }


        public List<Player> GetPlayers()
        {
            List<Player> players = new List<Player>();

            if (ConnOpen())
            {


                try
                {
                    query = "SELECT * FROM player";
                    SqlQuery(query);

                    MySqlDataReader dt = command.ExecuteReader();
                    while (dt.Read())
                    {
                        Player player = new Player(Convert.ToInt32(dt["ID"]), dt["Username"].ToString(), dt["Password"].ToString());
                        players.Add(player);
                    }

                    dt.Close();
                    return players;
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    Close();
                }


            }

            return players;

        }


        //public bool EditMember(Player player)
        //{
        //    if (ConnOpen())
        //    {
        //        query = "UPDATE player SET Username = @Username, Password = @Password  WHERE ID = @ID";

        //        SqlQuery(query);
        //        AddWithValue("@ID", player.Id);
        //        AddWithValue("@Username", player.Username);
        //        AddWithValue("@Password", player.Password);

        //        NonQueryEx();

        //        Close();
        //        return true;
        //    }
        //    else
        //    {
        //        Close();
        //        return false;
        //    }
        //}
    }
}
