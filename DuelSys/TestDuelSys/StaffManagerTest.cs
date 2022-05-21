using DuelSysClassLibrary.Entities;
using DuelSysClassLibrary.Managers;
using DuelSysClassLibrary.Mediators.FakeData;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestDuelSys
{
    [TestClass]
    public class StaffManagerTest
    {
        StaffManager staffManager;

        [TestInitialize()]
        public void Startup()
        {
            staffManager = new StaffManager(new FakeStaffData());
        }

        [TestMethod]
        public void CheckCredentialsSuccessTest()
        {
            //arrange


            //act
            Staff staff = staffManager.CheckCredentials("username", "password");

            //error message

            //assert
            Assert.AreEqual(staff.Username, "username");
            Assert.AreEqual(staff.Password, "password");
        }

        [TestMethod]
        public void AddStaffTest()
        {
            //arrange

            Staff staff = new Staff("Sean", "Paul", 123456789, "sean.paul@gmail.com", 0734567859, "Male", false, "username1", "password1");


            //act
            bool check = staffManager.AddStaff(staff);

            //assert
            Assert.AreEqual(check, true);
        }

        [TestMethod]
        public void RemoveStaffTest()
        {
            //arrange
            int success = 0;
            Staff staff = new Staff("Sean", "Paul", 123456789, "sean.paul@gmail.com", 0734567859, "Male", false, "username1", "password1");


            //act
            staffManager.AddStaff(staff);
            if (staffManager.RemoveStaff(staff))
            {
                success++;
            }

            //assert
            Assert.AreEqual(success, 1);
        }

        [TestMethod]
        public void GetStaffsTest()
        {
            //arrange



            //act


            //assert
            Assert.AreEqual(staffManager.GetStaffs().Count, 6);
        }

        [TestMethod]
        public void UpdateInfoTest()
        {
            //arrange
            Staff staff = new Staff("Sean", "Paul", 123456789, "sean.paul@gmail.com", 0734567859, "Male", false, "username1", "password1");


            //act
            staffManager.UpdateInfo(staff, "Seann", "Paul", 123456789, "sean.paul@gmail.com", 0734567859, "Male", "username1");

            //assert
            Assert.AreEqual(staff.FirstName, "Seann");
        }

        [TestMethod]
        public void GetStaffTest()
        {
            //arrange
            int success = 0;


            //act
            if (staffManager.GetStaff(1) != null)
            {
                success++;
            }

            //assert
            Assert.AreEqual(success, 1);
        }

        [TestMethod]
        public void SearchStaffsTest()
        {
            //arrange
            string lastName = "Sean";


            //act


            //assert
            Assert.AreEqual(staffManager.SearchStaffs(lastName).Count, 1);
        }
    }
}
