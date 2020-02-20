using System;
using System.Collections.Generic;
using System.Text;

namespace GoogleHashCode2020
{
    class Simple
    {
        public static string projectPath = System.IO.Directory.GetCurrentDirectory().Substring(0, System.IO.Directory.GetCurrentDirectory().Length - 24);
        public static void main(Library[] libraries, Book[] books, int days) {
            
            List<Int32> scanned = new List<Int32>();
            string res="";
            string outText = "";
            string libs = "";

            int dayNow = 0;
            int dayLib = 0;

            int i = libraries.Length - 1;
            int j = 0;
            int l = 0;
            int b = 0;
            int bpd = 0;

            while (dayNow < days && i > -1) {
                if (libraries[i].days + dayNow < days - 1)
                {
                    dayNow += libraries[i].days;
                    l++;

                    res += libraries[i].id + "\n";

                    j = libraries[i].setOfBooks.Length - 1;
                    dayLib = dayNow;
                    bpd = libraries[i].booksPerDay;

                    libs = "";
                    b = 0;

                    while (dayLib < days && j > -1)
                    {
                        Book book = libraries[i].setOfBooks[j];
                        
                        if (!scanned.Contains(book.id))
                        {
                            libs += book.id + " ";
                            scanned.Add(book.id);
                            b++;
                            dayLib += 1 / bpd;
                        }
                        j--;

                    }
                    res += b + "\n";
                    res += libs + "\n";
                }
                i--;
            }
            outText = l + "\n";
            outText += res;
            Console.WriteLine(outText);
            System.IO.File.WriteAllText(projectPath+"\\"+"outText.txt", outText);
        }
    }
}
