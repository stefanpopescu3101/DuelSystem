using System;
using System.Collections.Generic;
using System.Text;

namespace DuelSys.Entities
{
    public class Staff
    {
        public int id;
        
        private string firstName;
        private string lastName;
        private int cnp;
        private string email;
        private int phone;
        private string gender;
        private bool admin;
        private string username;
        private string password;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }


        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Name
        {
            get { return firstName + " " + lastName; }
        }

        public int CNP
        {
            get { return cnp; }
            set { cnp = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public int Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public bool Admin
        {
            get { return admin; }
        }

        public string Username
        {
            get { return username; }
        }

        public string Password
        {
            get { return password; }
        }
        public Staff(int id, string firstName, string lastName, int cnp, string email, int phone, string gender, bool admin, string username, string password)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.cnp = cnp;
            this.email = email;
            this.phone = phone;
            this.gender = gender;
            this.admin = admin;
            this.username = username;
            this.password = password;
        }

        public Staff(string firstName, string lastName, int cnp, string email, int phone, string gender, bool admin, string username, string password)
        {
            
            this.firstName = firstName;
            this.lastName = lastName;
            this.cnp = cnp;
            this.email = email;
            this.phone = phone;
            this.gender = gender;
            this.admin = admin;
            this.username = username;
            this.password = password;
        }

        public void UpdateInfo(string firstName, string lastName, int cnp, string email, int phone, string gender, string username)
        {
            
            this.firstName = firstName;
            this.lastName = lastName;
            this.cnp = cnp;
            this.email = email;
            this.phone = phone;
            this.gender = gender;
            this.username = username;
           
        }
    }
}
