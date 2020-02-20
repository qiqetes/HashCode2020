using System;
using System.Collections.Generic;
using System.Text;

namespace GoogleHashCode2020
{
    public class Book
    {
        int id;
        public int score;
        public Book(int id, int sc)
        {
            this.id = id;
            this.score = sc;
        }

        public Book(int sc)
        {
            score = sc;
        }
    }
}
