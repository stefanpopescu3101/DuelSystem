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
    public class PlayerManagerTest
    {
        PlayerManager playerManager;

        [TestInitialize]
        public void StartUp()
        {
            playerManager = new PlayerManager(new FakePlayerData());
        }

        [TestMethod]
        public void CheckCredentialsSuccessTest()
        {
            //arrange


            //act
            Player player = playerManager.CheckCredentials("username", "password");

            //error message

            //assert
            Assert.AreEqual(player.Username, "username");
            Assert.AreEqual(player.Password, "password");

        }

        [TestMethod]
        public void AddMemberTest()
        {
            //arrange

            Player player = new Player("s", "s");


            //act
            bool check = playerManager.AddPlayer(player);

            //assert
            Assert.AreEqual(check, true);
        }

        [TestMethod]
        public void GetMembersTest()
        {
            Assert.AreEqual(playerManager.GetAllPlayers().Count, 4);
        }

        //[TestMethod]
        //public void UpdateMemberTest()
        //{
        //    //arrange
        //    Member member = new Member(1, "s", "s");

        //    //act
        //    memberManager.EditMember(member, "ss", "ss");

        //    //assert
        //    Assert.AreEqual(member.Username, "ss");
        //    Assert.AreEqual(member.Password, "ss");

        //}
    }
}
