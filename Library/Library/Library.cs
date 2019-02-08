using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    static class Library
    {
        public static List<Book> bookCollection = new List<Book>();
        public static List<Member> members = new List<Member>();
        public static List<Loan> loans = new List<Loan>();
        public static List<Admin> admins = new List<Admin>();

        public static void printBookCollection()
        {
            for(int i = 0; i < bookCollection.Count(); i++)
            {
                Console.WriteLine(bookCollection[i].getTitle());
            }
        }

        public static void printMembers()
        {
            for (int i = 0; i < members.Count(); i++)
            {
                Console.WriteLine(members[i].getName());
                Console.WriteLine(members[i].getBookB().getTitle());                   
                Console.WriteLine(members[i].getCurrentL());
            }
        }

        public static void printLoans()
        {
            for (int i = 0; i < loans.Count(); i++)
            {
                Console.WriteLine(loans[i].getLoanID());
            }
        }

        public static void printAdmins()
        {
            for (int i = 0; i < admins.Count(); i++)
            {
                Console.WriteLine(admins[i].getAdminName());
            }
        }
    }
}
