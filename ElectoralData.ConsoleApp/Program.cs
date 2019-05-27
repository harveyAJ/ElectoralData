using System;
using System.Collections.Generic;
using ElectoralData.Interfaces;

namespace ElectoralData.ConsoleApp
{
    internal class Program
    {
        private const string Northants = "34";
        private const string Surrey = "43";

        private static void Main(string[] args)
        {
            // 1. Parse csv file
            var filePath = @"local_gov.csv";
            var adminAreas = new FileAdminAreas(filePath);

            var wards = new List<AdminWard>();

            var northantWards = GetWards(adminAreas.GetCounty(Northants));
            wards.AddRange(northantWards);

            var surreyWards = GetWards(adminAreas.GetCounty(Surrey));
            wards.AddRange(surreyWards);


            // 2. Sort wards by name
            //wards.Sort(new AdminWardComparer());

            foreach (var ward in wards)
            {
                Console.WriteLine(ward);
            }


            Console.WriteLine("Press ENTER to exit.");
            Console.ReadLine();
        }

        private static IReadOnlyList<AdminWard> GetWards(IAdminArea county)
        {
            var wards = new List<AdminWard>();
            foreach (var district in county.GetChildren())
            {
                foreach (AdminWard ward in district.GetChildren())
                {
                    wards.Add(ward);
                }
            }
            
            return wards;
        }
    }
}
