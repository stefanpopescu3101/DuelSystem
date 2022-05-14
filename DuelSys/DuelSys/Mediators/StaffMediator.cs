using DuelSys.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DuelSys.Mediators
{
    public class StaffMediator : DataAccess, IStaffData
    {
        private DataAccess dataAccess;
        public StaffMediator()
        {
            dataAccess = new DataAccess();
        }

        public List<Staff> GetStaffs()
        {
            List<Staff> staffs = new List<Staff>();

            if (ConnOpen())
            {
                try
                {
                    query = "SELECT * FROM staff";
                    SqlQuery(query);

                    using (MySqlDataReader dataReader = command.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            Staff staff = staff = new Staff(Convert.ToInt32(dataReader["Id"]), dataReader["FirstName"].ToString(), dataReader["LastName"].ToString(),
                                 Convert.ToInt32(dataReader["CNP"]), dataReader["Email"].ToString(), Convert.ToInt32(dataReader["Phone"]),
                                dataReader["Gender"].ToString(), Convert.ToBoolean(dataReader["Admin"]), dataReader["Username"].ToString(), dataReader["Password"].ToString());

                            staffs.Add(staff);
                        }
                        dataReader.Close();
                        return staffs;
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
            return staffs;
        }

        public bool UpdateInfo(Staff staff)
        {
            if (ConnOpen())
            {
                try
                {
                    query = "UPDATE staff SET FirstName=@FirstName, LastName=@LastName, CNP=@CNP,  Email=@Email, Phone=@Phone, Gender=@Gender, Username=@Username, Password=@Password WHERE Id=@ID";

                    SqlQuery(query);

                    AddWithValue("@ID", staff.ID);
                    AddWithValue("@FirstName", staff.FirstName);
                    AddWithValue("@LastName", staff.LastName);
                    AddWithValue("@CNP", staff.CNP);
                    AddWithValue("@Email", staff.Email);
                    AddWithValue("@Phone", staff.Phone);
                    AddWithValue("@Gender", staff.Gender);
                    AddWithValue("@Username", staff.Username);
                    AddWithValue("@Password", staff.Password);

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

        public bool AddStaff(Staff staff)
        {


            if (ConnOpen())
            {
                try
                {
                    query = "INSERT INTO staff (Id, FirstName, LastName , CNP, Email, Phone, Gender, Admin, Username, Password) VALUES (@ID, @FirstName, @LastName, @CNP, @Email, @Phone, @Gender, @Admin, @Username, @Password)";

                    SqlQuery(query);

                    AddWithValue("@ID", staff.ID);
                    AddWithValue("@FirstName", staff.FirstName);
                    AddWithValue("@LastName", staff.LastName);
                    AddWithValue("@CNP", staff.CNP);
                    AddWithValue("@Email", staff.Email);
                    AddWithValue("@Phone", staff.Phone);
                    AddWithValue("@Gender", staff.Gender);
                    AddWithValue("@Admin", staff.Admin);
                    AddWithValue("@Username", staff.Username);
                    AddWithValue("@Password", staff.Password);

                    NonQueryEx();

                    staff.ID = Convert.ToInt32(command.LastInsertedId);

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

        public bool RemoveStaff(Staff staff)
        {
            if (ConnOpen())
            {
                try
                {
                    query = "DELETE from staff WHERE Id = @ID";
                    SqlQuery(query);
                    AddWithValue("@ID", staff.ID);
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
