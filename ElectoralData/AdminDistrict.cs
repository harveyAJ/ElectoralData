// <copyright file="AdminDistrict.cs" company="McLaren Applied Technologies Ltd.">
// Copyright (c) McLaren Applied Technologies Ltd.</copyright>

using System.Collections.Generic;
using ElectoralData.Interfaces;

namespace ElectoralData
{
    public sealed class AdminDistrict : AdminAreaBase
    {
        private readonly AdminCounty county;
        private readonly IList<AdminWard> wards = new List<AdminWard>();

        public AdminDistrict(AdminCounty county, string code, string name) : base(code, name)
        {
            this.county = county;
        }

        public override IAdminArea GetParent()
        {
            return this.county;
        }

        public override IEnumerable<IAdminArea> GetChildren()
        {
            return wards;
        }

        public void AddWard(AdminWard ward)
        {
            if (ward != null)
            {
                wards.Add(ward);
            }
        }

        public override int GetHashCode()
        {
            var hashCode = (this.county != null ? this.county.GetHashCode() : 0);
            hashCode = (hashCode * 397) ^ (this.code != null ? this.code.GetHashCode() : 0);
            hashCode = (hashCode * 397) ^ (this.name != null ? this.name.GetHashCode() : 0);
            return hashCode;
        }

        public override bool Equals(object obj)
        {
            if (this == obj)
            {
                return true;
            }

            if (obj == null)
            {
                return false;
            }

            if (this.GetType() != obj.GetType())
            {
                return false;
            }

            var other = (AdminDistrict)obj;
            return this.county.Equals(other.county) && code.Equals(other.code) && name.Equals(other.name);
        }
    }
}