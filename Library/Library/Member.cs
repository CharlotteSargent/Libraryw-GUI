using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Member
    {
        //class variables
        private int memberID;
        private string name;
        private Book bookBorrowed;
        private bool currentLoan;


        //constructer
        public Member(int ID, string mName)
        {
            memberID = ID;
            name = mName;
            bookBorrowed = null;
            currentLoan = false;
        }

        public int getID()
        {
            return memberID;
        }

        public void setID(int ID)
        {
            memberID = ID;
        }

        public string getName()
        {
            return name;
        }

        public void setName(string mName)
        {
            name = mName;
        }

        public Book getBookB()
        {
            return bookBorrowed;
        }

        public void setBookB(Book borrowed)
        {
            bookBorrowed = borrowed;
        }

        public bool getCurrentL()
        {
            return currentLoan;
        }

        public void setCurrentL(bool current)
        {
            currentLoan = current;
        }

    }
}
