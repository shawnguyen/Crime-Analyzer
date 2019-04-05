using System;
using System.Collections.Generic;
using System.Linq;

namespace CrimeAnalyzer
{
    public static class Reader
    {
        private static List<CrimeStatsData> crimeStatsDataFile = new List<CrimeStatsData>();
        
        private static bool Read(string csvFile)
        {
            try
            {
                string[] dataLines = File.ReadAllLines(csvFile);

                var line = Reader.Readline();

                var values = line.Split(',');
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
                Environment.Exit(1);
            }
        }
    }
}