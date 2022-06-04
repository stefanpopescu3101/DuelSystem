using DuelSysEntities;
using DuelSysMediators.Interfaces;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DuelSysMediators
{
    public class MatchMediator : DataAccess, IMatchData
    {
        private DataAccess dataAccess;

        public MatchMediator()
        {
            this.dataAccess = new DataAccess();
        }

        public List<Match> GetMatches()
        {
            List<Match> matches = new List<Match>();

            if (ConnOpen())
            {
                try
                {
                    query = "SELECT * FROM matches";
                    SqlQuery(query);

                    using (MySqlDataReader dataReader = command.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            Match match = match = new Match(Convert.ToInt32(dataReader["MatchID"]), Convert.ToInt32(dataReader["RoundID"]), Convert.ToInt32(dataReader["Player1ID"]), dataReader["Player1Name"].ToString(), Convert.ToInt32(dataReader["Player2ID"]), dataReader["Player2Name"].ToString());

                            matches.Add(match);
                        }
                        dataReader.Close();
                        return matches;
                    }

                }
                catch (Exception ex)
                {

                }
                finally
                {
                    Close();
                }
            }
            return matches;
        }

        public bool AddMatch(Match match)
        {


            if (ConnOpen())
            {
                try
                {
                    query = "INSERT INTO matches (MatchID, RoundID, Player1ID, Player1Name, Player2ID, Player2Name) VALUES (@MatchID, @RoundID, @Player1ID, @Player1Name, @Player2ID, @Player2Name)";

                    SqlQuery(query);

                    AddWithValue("@MatchID", match.MatchID);
                    AddWithValue("@RoundID", match.RoundID);
                    AddWithValue("@Player1ID", match.Player1ID);
                    AddWithValue("@Player1Name", match.Player1Name);
                    AddWithValue("@Player2ID", match.Player2ID);
                    AddWithValue("@Player2Name", match.Player2Name);


                    NonQueryEx();

                    match.MatchID = Convert.ToInt32(command.LastInsertedId);

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
    }
}
