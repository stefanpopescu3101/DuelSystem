using DuelSysEntities;
using DuelSysMediators.Interfaces;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DuelSysMediators
{
    public class RoundMediator : DataAccess, IRoundData
    {
        private DataAccess dataAccess;

        public RoundMediator()
        {
            this.dataAccess = new DataAccess();
        }

        public List<Round> GetRounds()
        {
            List<Round> rounds = new List<Round>();

            if (ConnOpen())
            {
                try
                {
                    query = "SELECT * FROM rounds";
                    SqlQuery(query);

                    using (MySqlDataReader dataReader = command.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            Round round = round = new Round(Convert.ToInt32(dataReader["RoundID"]), Convert.ToInt32(dataReader["TournamentID"]), Convert.ToBoolean(dataReader["Status"]));

                            rounds.Add(round);
                        }
                        dataReader.Close();
                        return rounds;
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
            return rounds;
        }

        public bool AddRound(Round round)
        {


            if (ConnOpen())
            {
                try
                {
                    query = "INSERT INTO rounds (RoundID, TournamentID, Status) VALUES (@RoundID, @TournamentID, @Status)";

                    SqlQuery(query);

                    AddWithValue("@RoundID", round.RoundID);
                    AddWithValue("@TournamentID", round.TournamentID);
                    AddWithValue("@Status", round.Status);
                    

                    NonQueryEx();

                    round.RoundID = Convert.ToInt32(command.LastInsertedId);

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
