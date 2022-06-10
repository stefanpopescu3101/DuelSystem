using DuelSysEntities;
using DuelSysMediators.Interfaces;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DuelSysMediators
{
    public class DoubleGameMatchMediator : DataAccess, IDoubleGameMatchData
    {
        private DataAccess dataAccess;
        public DoubleGameMatchMediator()
        {
            this.dataAccess = new DataAccess();
        }

        public List<DoubleGameMatch> GetDoubleGameMatches()
        {
            List<DoubleGameMatch> matches = new List<DoubleGameMatch>();

            if (ConnOpen())
            {
                try
                {
                    query = "SELECT * FROM doublegamematches";
                    SqlQuery(query);

                    using (MySqlDataReader dataReader = command.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            DoubleGameMatch match = match = new DoubleGameMatch(Convert.ToInt32(dataReader["MatchID"]), Convert.ToInt32(dataReader["RoundID"]), Convert.ToInt32(dataReader["Player1ID"]),dataReader["Player1Name"].ToString(), Convert.ToInt32(dataReader["Player2ID"]), dataReader["Player2Name"].ToString(), Convert.ToInt32(dataReader["Player1Match1Score"]), Convert.ToInt32(dataReader["Player2Match1Score"]), Convert.ToInt32(dataReader["Player1Match2Score"]), Convert.ToInt32(dataReader["Player2Match2Score"]), Convert.ToInt32(dataReader["Winner"]));

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

        public bool AddDoubleGameMatch(DoubleGameMatch match)
        {


            if (ConnOpen())
            {
                try
                {
                    query = "INSERT INTO doublegamematches (MatchID, RoundID, Player1ID, Player1Name, Player2ID, Player2Name, Player1Match1Score, Player2Match1Score, Player1Match2Score, Player2Match2Score, Winner) VALUES (@MatchID, @RoundID, @Player1ID, @Player1Name, @Player2ID, @Player2Name, @Player1Match1Score, @Player2Match1Score, @Player1Match2Score, @Player2Match2Score, @Winner)";

                    SqlQuery(query);

                    AddWithValue("@MatchID", match.MatchID);
                    AddWithValue("@RoundID", match.RoundID);
                    AddWithValue("@Player1ID", match.Player1ID);
                    AddWithValue("@Player1Name", match.Player1Name);
                    AddWithValue("@Player2ID", match.Player2ID);
                    AddWithValue("@Player2Name", match.Player2Name);
                    AddWithValue("@Player1Match1Score", match.Player1Match1Score);
                    AddWithValue("@Player2Match1Score", match.Player2Match1Score);
                    AddWithValue("@Player1Match2Score", match.Player1Match2Score);
                    AddWithValue("@Player2Match2Score", match.Player2Match2Score);
                    AddWithValue("@Winner", match.WinnerID);


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


        public bool UpdateMatch(DoubleGameMatch match)
        {
            if (ConnOpen())
            {
                try
                {
                    query = "UPDATE doublegamematches SET Player1Match1Score=@Player1Match1Score, Player2Match1Score=@Player2Match1Score, Player1Match2Score=@Player1Match2Score, Player2Match2Score=@Player2Match2Score, Winner=@Winner WHERE MatchID=@ID";

                    SqlQuery(query);

                    AddWithValue("@ID", match.MatchID);
                    AddWithValue("@Player1Match1Score", match.Player1Match1Score);
                    AddWithValue("@Player2Match1Score", match.Player2Match1Score);
                    AddWithValue("@Player1Match2Score", match.Player1Match2Score);
                    AddWithValue("@Player2Match2Score", match.Player2Match2Score);
                    AddWithValue("@Winner", match.WinnerID);


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
    }
}
