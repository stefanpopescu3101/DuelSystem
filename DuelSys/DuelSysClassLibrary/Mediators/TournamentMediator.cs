using DuelSys.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DuelSys.Mediators
{
    public class TournamentMediator : DataAccess, ITournamentData
    {
        private DataAccess dataAccess;
        public TournamentMediator()
        {
            dataAccess = new DataAccess();
        }

        public List<Tournament> GetTournaments()
        {
            List<Tournament> tournaments = new List<Tournament>();

            if (ConnOpen())
            {
                try
                {
                    query = "SELECT * FROM tournament";
                    SqlQuery(query);

                    using (MySqlDataReader dataReader = command.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            Tournament doctor = doctor = new Tournament(Convert.ToInt32(dataReader["Id"]), dataReader["SportType"].ToString(), dataReader["Description"].ToString(),
                                dataReader["StartDate"].ToString(), dataReader["EndDate"].ToString(), Convert.ToInt32(dataReader["MinPlayers"]), Convert.ToInt32(dataReader["MaxPlayers"]),
                                dataReader["Location"].ToString(), dataReader["TournamentType"].ToString());

                            tournaments.Add(doctor);
                        }
                        dataReader.Close();
                        return tournaments;
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
            return tournaments;
        }

        public bool UpdateInfo(Tournament tournament)
        {
            if (ConnOpen())
            {
                try
                {
                    query = "UPDATE tournament SET SportType=@SportType, Description=@Description, StartDate=@StartDate, EndDate=@EndDate,  MinPlayers=@MinPlayers, MaxPlayers=@MaxPlayers, Location=@Location WHERE Id=@ID";

                    SqlQuery(query);

                    AddWithValue("@ID", tournament.ID);
                    AddWithValue("@SportType", tournament.SportType);
                    AddWithValue("@Description", tournament.Description);
                    AddWithValue("@StartDate", tournament.StartDate);
                    AddWithValue("@EndDate", tournament.EndDate);
                    AddWithValue("@MinPlayers", tournament.MinPlayers);
                    AddWithValue("@MaxPlayers", tournament.MaxPlayers);
                    AddWithValue("@Location", tournament.Location);
                    

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

        public bool AddTournament(Tournament tournament)
        {


            if (ConnOpen())
            {
                try
                {
                    query = "INSERT INTO tournament (Id, SportType, Description, StartDate , EndDate, MinPlayers, MaxPlayers, Location, TournamentType) VALUES (@ID, @SportType, @Description, @StartDate, @EndDate, @MinPlayers, @MaxPlayers, @Location, @TournamentType)";

                    SqlQuery(query);

                    AddWithValue("@ID", tournament.ID);
                    AddWithValue("@SportType", tournament.SportType);
                    AddWithValue("@Description", tournament.Description);
                    AddWithValue("@StartDate", tournament.StartDate);
                    AddWithValue("@EndDate", tournament.EndDate);
                    AddWithValue("@MinPlayers", tournament.MinPlayers);
                    AddWithValue("@MaxPlayers", tournament.MaxPlayers);
                    AddWithValue("@Location", tournament.Location);
                    AddWithValue("@TournamentType", tournament.TournamentType);
                    

                    NonQueryEx();

                    tournament.ID = Convert.ToInt32(command.LastInsertedId);

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

        public bool RemoveTournament(Tournament tournament)
        {
            if (ConnOpen())
            {
                try
                {
                    query = "DELETE from tournament WHERE Id = @ID";
                    SqlQuery(query);
                    AddWithValue("@ID", tournament.ID);
                    NonQueryEx();

                    Close();
                    return true;
                }
                catch
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
