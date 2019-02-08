using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Loan
    {
        private int loanID;
        Member member;
        Book book;

        public Loan(int ID, Member person, Book item)
        {
            loanID = ID;
            member = person;
            book = item;
        }

        public int getLoanID()
        {
            return loanID;
        }

        public void setLoanID(int ID)
        {
            loanID = ID;
        }

        public Member getMember()
        {
            return member;
        }

        public void setMember(Member person)
        {
            member = person;
        }

        public Book getBook()
        {
            return book;
        }

        public void setBook(Book item)
        {
            book = item;
        }

    }
}
