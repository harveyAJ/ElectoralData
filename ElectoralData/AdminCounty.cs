// <copyright file="AdminCounty.cs" company="McLaren Applied Technologies Ltd.">
// Copyright (c) McLaren Applied Technologies Ltd.</copyright>

using System.Collections.Generic;
using ElectoralData.Interfaces;

namespace ElectoralData
{
    public sealed class AdminCounty : AdminAreaBase
    {
        private readonly IList<AdminDistrict> districts = new List<AdminDistrict>();

        public AdminCounty(string code, string name) : base(code, name)
        {
        }

        public override IAdminArea GetParent()
        {
            return null;
        }

        public override IEnumerable<IAdminArea> GetChildren()
        {
            return districts;
        }

        public void AddDistrict(AdminDistrict district)
        {
            if (district != null)
            {
                this.districts.Add(district);
            }
        }

        public override int GetHashCode()
        {
            var hashCode = (this.code != null ? this.code.GetHashCode() : 0);
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

            var other = (AdminCounty)obj;
            return code.Equals(other.code) && name.Equals(other.name);
        }
    }
}