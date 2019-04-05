using System;
using System.Collections.Generic;
using System.Linq;

namespace CrimeAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.Write("CrimeAnalyzer <crime_csv_file_path> <report_file_path>");
                Environment.Exit(1);
            }

            string csvFile = args[0];
            string reportFile = args[1];

            List<CrimeStatsData> crimeStatsDataFile = null;

            try
            {
                crimeStatsDataFile = Reader.Load(csvFile);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
                Environment.Exit(2);
            }

            var report = Writer.GenerateText(crimeStatsDataFile);

            try
            {
                System.IO.File.WriteAllText(reportFile, report);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
                Environment.Exit(3);
            }
        }
    }
}
