using Ganss.Excel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace readfromexcel_01
{
    class Program
    {
        static string file = "FolkeskoleDK13-09-2021.xlsx";
        static void Main(string[] args)
        {
          
            do
            {

                IEnumerable<Institution> institutions = new ExcelMapper(file).Fetch<Institution>();

                Console.Write("Start med at skrive navnet på skolen: ");
                string insName = Console.ReadLine();
              
                IEnumerable<Institution> selectedSchools = institutions.Where(i => i.INST_NAVN.StartsWith(insName, StringComparison.InvariantCultureIgnoreCase));

                if (!selectedSchools.Any())
                {
                    Console.WriteLine("Ingen skoler fundet...");
                }
                else
                {
                    Console.WriteLine("Følgende skoler er fundet");
                    foreach (Institution ins in selectedSchools)
                    {
                        
                        Console.WriteLine(ins);
                    }
                }

            } while (Console.ReadKey().KeyChar != 'x');

        }
    }
}
