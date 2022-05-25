using DuelSysEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DuelSysMediators.Interfaces
{
    public interface IStaffData
    {
        bool AddStaff(Staff staff);
        bool RemoveStaff(Staff staff);
        List<Staff> GetStaffs();
        bool UpdateInfo(Staff staff);
    }
}
