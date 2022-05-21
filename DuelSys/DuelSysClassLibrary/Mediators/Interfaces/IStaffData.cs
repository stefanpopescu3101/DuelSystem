using DuelSysClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DuelSysClassLibrary.Mediators
{
    public interface IStaffData
    {
        bool AddStaff(Staff staff);
        bool RemoveStaff(Staff staff);
        List<Staff> GetStaffs();
        bool UpdateInfo(Staff staff);
    }
}
