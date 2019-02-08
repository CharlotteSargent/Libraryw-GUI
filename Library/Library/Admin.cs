using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Admin
    {
        private int adminID;
        private string adminName;
        private string password;

        public Admin(int ID, string name, string pword)
        {
            adminID = ID;
            adminName = name;
            password = pword;
        }

        public int getAdminID()
        {
            return adminID;
        }

        public void setAdminID(int adID)
        {
            adminID = adID;
        }

        public string getAdminName()
        {
            return adminName;
        }

        public void setAdminName(string adName)
        {
            adminName = adName;
        }

        public string getPassword()
        {
            return password;
        }

        public void setPassword(string pass)
        {
            password = pass;
        }

        public void borrowBook(Member member, Book book)
        {
            member.setBookB(book);
            member.setCurrentL(true);
        }

        public void returnBook(Member member, Book book)
        {
            member.setBookB(null);
            member.setCurrentL(false);
        }
    }
}
