// <copyright file="IAdminAreas.cs" company="McLaren Applied Technologies Ltd.">
// Copyright (c) McLaren Applied Technologies Ltd.</copyright>

using System.Collections.Generic;

namespace ElectoralData.Interfaces
{
    public interface IAdminAreas
    {
        IEnumerable<AdminCounty> Counties { get; }

        IEnumerable<AdminDistrict> Districts { get; }

        IEnumerable<AdminWard> Wards { get; }

        AdminCounty GetCounty(string countyCode);

        AdminDistrict GetDistrict(string countyCode, string districtCode);

        AdminWard GetWard(string countyCode, string districtCode, string wardCode);
    }
}