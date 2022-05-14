using DuelSys.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DuelSys.Mediators
{
    public interface IStaffData
    {
        void AddStaff(Staff staff);
        void RemoveStaff(Staff staff);
        List<Staff> GetStaffs();
        void UpdateInfo(Staff staff);
    }
}
