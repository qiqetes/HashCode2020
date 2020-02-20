using System;
using System.Collections.Generic;
using System.Text;

namespace GoogleHashCode2020
{
    class Library
    {
        public int id;
        public Book[] setOfBooks; // id of the books
        public int nBooks;
        public int days;
        public int booksPerDay;

        public Book[] SetOfBooks { get => setOfBooks; set => setOfBooks = value; }

        public Library(int id, Book[] setOfBooks, int days, int booksPerDay)
        {
            this.id = id;
            this.setOfBooks = setOfBooks;
            this.days = days;
            this.booksPerDay = days;
        }
        public Library(int id, int nBooks, int days,  int booksPerDay )
        {
            this.id = id;
            this.days = days;
            this.booksPerDay = days;
            this.nBooks = nBooks;
        }

        public void SortBooks()
        {
            Array.Sort(setOfBooks, delegate (Book a, Book b)
            {
                return b.score - a.score;
            });
        }

        
    }
}
