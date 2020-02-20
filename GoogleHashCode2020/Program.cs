using System;
using System.Collections.Generic;
using static GoogleHashCode2020.GlovalVar;

namespace GoogleHashCode2020
{
    class Program
    {
        static void Main(string[] args)
        {
            string projectPath = System.IO.Directory.GetCurrentDirectory().Substring(0, System.IO.Directory.GetCurrentDirectory().Length - 24);
            string inputPath = projectPath + "\\inputData";
            string outputPath = projectPath + "\\outputData";

            string[] inputFileNames = new string[] { "a_example.txt", "b_read_on.txt", "c_incunabula.txt", "d_tough_choices.txt", "e_so_many_books.txt", "f_libraries_of_the_world.txt" };



            // INTERPRET INPUT DATA, DON'T CHANGE IT
            string line;
            int lineCount = 0; 
            System.IO.StreamReader file = new System.IO.StreamReader(inputPath + "\\" + inputFileNames[0]); // CHANGE TTHIS TO CHANGE FILE


            
            while((line = file.ReadLine()) != null)
            {
                string[] raw = line.Split(' ');
                if (raw.Length < 2) break;
                if(lineCount == 0)
                {
                    nBooks = Int32.Parse(raw[0]);
                    books = new Book[nBooks];
                    nLibraries = Int32.Parse(raw[1]);
                    libraries = new Library[nLibraries];
                    nDays = Int32.Parse(raw[2]);
                }
                else if(lineCount == 1)
                {
                    for (int i = 0; i < raw.Length; i++)
                    {
                        books[i] = new Book(i, Int32.Parse(raw[i]));
                    }
                }
                else{
                    if(lineCount % 2 == 0)
                    {
                        libraries[(lineCount - 2) / 2] = new Library((lineCount - 2) / 2, Int32.Parse(raw[0]), Int32.Parse(raw[1]), Int32.Parse(raw[2]));
                        libraries[(lineCount - 2) / 2].SetOfBooks = new Book[libraries[(lineCount - 2) / 2].nBooks];
                    }
                    else
                    {
                        Library lib = libraries[(lineCount - 2) / 2];
                        for (int i = 0; i < lib.nBooks; i++)
                        {
                            lib.SetOfBooks[i] = books[Int32.Parse(raw[i])];
                        }

                        // SORT? comment this if you dont want them to have books sorted from the start
                        lib.SortBooks();
                    }
                }

                lineCount++;
            }


            Simple.main(libraries, books, nDays);

        }
    }
}
