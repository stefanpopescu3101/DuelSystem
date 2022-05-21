using DuelSysClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DuelSysClassLibrary.Mediators.FakeData
{
    public class FakeStaffData : IStaffData
    {
        List<Staff> staffs;
        public FakeStaffData()
        {
            staffs = new List<Staff>();
            staffs.Add(new Staff("Sean", "Paul", 123456789, "sean.paul@gmail.com", 0734567859, "Male", false,  "username", "password"));
            staffs.Add(new Staff("Seann", "Paull", 123456789, "sean.paul@gmail.com", 0734567859, "Male", false, "username2", "password2"));
            staffs.Add(new Staff("Seannn", "Paulll", 123456789, "sean.paul@gmail.com", 0734567859, "Male", false, "username3", "password3"));
            staffs.Add(new Staff("Seannnn", "Paullll", 123456789, "sean.paul@gmail.com", 0734567859, "Male", false, "username4", "password4"));
            staffs.Add(new Staff("Seannnnn", "Paulllll", 123456789, "sean.paul@gmail.com", 0734567859, "Male", false, "username5", "password5"));
            staffs.Add(new Staff(1, "Seana", "Paula", 123456789, "sean.paul@gmail.com", 0734567859, "Male", false, "username6", "password6"));
        }

        public bool AddStaff(Staff staff)
        {
            return true; 
        }

        public List<Staff> GetStaffs()
        {
            return staffs;
        }

        public bool RemoveStaff(Staff staff)
        {
            return true;
        }

        public bool UpdateInfo(Staff staff)
        {
            return true;
        }
    }
}
