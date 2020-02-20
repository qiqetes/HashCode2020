using System;

namespace GoogleHashCode2020
{
    class Program
    {
        static void Main(string[] args)
        {
            string projectPath = System.IO.Directory.GetCurrentDirectory().Substring(0, System.IO.Directory.GetCurrentDirectory().Length - 9);
            string inputPath = projectPath + "\\inputData";
            string outputPath = projectPath + "\\outputData";

            string[] inputFileNames = new string[] { "b_small.in", "c_medium.in", "d_quite_big.in", "e_also_big.in" };


            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(inputPath + "\\" + inputFileNames[3]);
        }
    }
}
