using System;
using System.Collections.Generic;
using System.Text;
using static GoogleHashCode2020.GlovalVar;

namespace GoogleHashCode2020
{
    public class Library
    {
        /////////////////////////////////////////////
        // FROM PROBLEM
        public int id;
        public Book[] setOfBooks; // id of the books
        public int nBooks;
        public int days;
        public int booksPerDay;
        /////////////////////////////////////////////

        public int estimatePunctuation;



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

        public void LibraryPunctuation()
        {
            LibraryPunctuation(0);
            
        }

        public void LibraryPunctuation(int threshold)
        {
            int howMany = (nDays - days) * booksPerDay + threshold;


        }


    }
}
