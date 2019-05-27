// <copyright file="FileAdminAreas.cs" company="McLaren Applied Technologies Ltd.">
// Copyright (c) McLaren Applied Technologies Ltd.</copyright>

using ElectoralData.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;

namespace ElectoralData
{
    public class FileAdminAreas : IAdminAreas
    {
        public IEnumerable<AdminCounty> Counties { get; }

        public IEnumerable<AdminDistrict> Districts { get; }

        public IEnumerable<AdminWard> Wards { get; }

        public FileAdminAreas(string filePath)
        {
            try
            {
                var lines = File.ReadAllLines(filePath);
                this.ParseCsv(lines);
            }
            catch (IOException e)
            {
                Console.WriteLine(e);
            }
        }

        private void ParseCsv(IEnumerable<string> lines)
        {
            // TODO
            throw new NotImplementedException();
        }

        public AdminCounty GetCounty(string countyCode)
        {
            // TODO
            throw new NotImplementedException();
        }

        public AdminDistrict GetDistrict(string countyCode, string districtCode)
        {
            // TODO
            throw new NotImplementedException();
        }

        public AdminWard GetWard(string countyCode, string districtCode, string wardCode)
        {
            // TODO
            throw new NotImplementedException();
        }
    }
}