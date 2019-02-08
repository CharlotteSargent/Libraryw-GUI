using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Book
    {
        private int bookID;
        private string title;
        private string author;
        private int pages;

        public Book(int ID, string name, string writer, int number)
        {
            bookID = ID;
            title = name;
            author = writer;
            pages = number;
        }

        public int getBookID()
        {
            return bookID;
        }

        public void setBookID(int ID)
        {
            bookID = ID;
        }

        public string getTitle()
        {
            return title;
        }

        public void setTitle(string bookTitle)
        {
            title = bookTitle;
        }

        public string getAuthor()
        {
            return author;
        }

        public void setAuthor(string bookAuthor)
        {
            author = bookAuthor;
        }

        public int getPages()
        {
            return pages;
        }

        public void setPages(int bookPages)
        {
            pages = bookPages;
        }
    }
}
