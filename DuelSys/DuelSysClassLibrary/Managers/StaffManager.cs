using DuelSysClassLibrary.Entities;
using DuelSysClassLibrary.Mediators;
using System;
using System.Collections.Generic;
using System.Text;

namespace DuelSysClassLibrary.Managers
{
    public class StaffManager
    {
        private List<Staff> staffs;

        private IStaffData mediator;


        public StaffManager(IStaffData src)
        {
            staffs = new List<Staff>();
            mediator = src;
        }

        public bool AddStaff(Staff staff)
        {
            if (staff != null)
            {
                staffs.Add(staff);
                mediator.AddStaff(staff);
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool RemoveStaff(Staff staff)
        {
            foreach (Staff s in staffs)
            {
                if (s.ID == staff.ID)
                {
                    staffs.Remove(staff);
                    mediator.RemoveStaff(staff);

                    return true;
                }
            }
            return false;

        }

        public Staff CheckCredentials(string username, string password)
        {
            foreach (Staff staff in GetAllStaffs())
            {
                if (staff.Username == username && staff.Password == password)
                {
                    return staff;
                }
            }
            return null;
        }

        public Staff[] GetAllStaffs()
        {
            staffs = GetStaffs();
            return staffs.ToArray();
        }


        public List<Staff> GetStaffs()
        {
            staffs = mediator.GetStaffs();
            return staffs;
        }

        public Staff GetStaff(int id)
        {
            foreach (Staff staff in GetStaffs())
            {
                if (id == staff.id)
                {
                    return staff;
                }
            }

            return null;
        }

        public void UpdateInfo(Staff staff, string firstName, string lastName, int cnp, string email, int phone, string gender, string username)
        {
            staff.UpdateInfo(firstName, lastName, cnp, email, phone, gender, username);
            mediator.UpdateInfo(staff);
        }

        public List<Staff> SearchStaffs(string item)
        {
            this.staffs = GetStaffs();
            List<Staff> foundStaffs = new List<Staff>();

            foreach (Staff staff in staffs)
            {
                if (item == staff.FirstName || item == staff.LastName || item == staff.CNP.ToString())
                {
                    foundStaffs.Add(staff);

                }
            }

            return foundStaffs;
        }
    }
}
