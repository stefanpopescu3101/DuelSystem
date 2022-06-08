using DuelSysEntities;
using DuelSysManagers;
using DuelSysMediators.FakeData;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestDuelSys
{
    [TestClass]
    public class TournamentManagerTest
    {
        TournamentManager tournamentManager;

        [TestInitialize()]
        public void Startup()
        {
            tournamentManager = new TournamentManager(new FakeTournamentData());
        }


        [TestMethod]
        public void AddTournamentTest()
        {
            //arrange

            Tournament tournament = new Tournament("badminton", "It is a sport", "16/05/2022", "20/05/2022", 4, 10, "Eindhoven", "robin-rounds", 0, 0, 0, "ENROLL");


            //act
            bool check = tournamentManager.AddTournament(tournament);

            //assert
            Assert.AreEqual(check, true);
        }

        [TestMethod]
        public void RemoveTournamentTest()
        {
            //arrange
            int success = 0;
            Tournament tournament = new Tournament("badminton", "It is a sport", "16/05/2022", "20/05/2022", 4, 10, "Eindhoven", "robin-rounds", 0, 0, 0, "ENROLL");


            //act
            tournamentManager.AddTournament(tournament);
            if (tournamentManager.RemoveTournament(tournament))
            {
                success++;
            }

            //assert
            Assert.AreEqual(success, 1);
        }

        [TestMethod]
        public void GetTournamentsTest()
        {
            //arrange



            //act


            //assert
            Assert.AreEqual(tournamentManager.GetTournaments().Count, 6);
        }

        [TestMethod]
        public void UpdateInfoTest()
        {
            //arrange
            Tournament tournament = new Tournament("badminton", "It is a sport", "16/05/2022", "20/05/2022", 4, 10, "Eindhoven", "robin-rounds", 0, 0, 0, "ENROLL");


            //act
            tournamentManager.UpdateInfo(tournament, "tennis", "It is a sport", "16/05/2022", "20/05/2022", 4, 10, "Eindhoven", "ENROLL");

            //assert
            Assert.AreEqual(tournament.SportType, "tennis");
        }

        [TestMethod]
        public void GetTournamentTest()
        {
            //arrange
            int success = 0;


            //act
            if (tournamentManager.GetTournament(1) != null)
            {
                success++;
            }

            //assert
            Assert.AreEqual(success, 1);
        }

        [TestMethod]
        public void SearchTournamentsTest()
        {
            //arrange
            string sportType = "badminton";


            //act


            //assert
            Assert.AreEqual(tournamentManager.SearchTournaments(sportType).Count, 6);
        }
    }
}
