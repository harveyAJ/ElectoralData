// <copyright file="AdminWard.cs" company="McLaren Applied Technologies Ltd.">
// Copyright (c) McLaren Applied Technologies Ltd.</copyright>

using System.Collections.Generic;
using ElectoralData.Interfaces;

namespace ElectoralData
{
    public sealed class AdminWard : AdminAreaBase
    {
        private readonly AdminDistrict district;

        public AdminWard(AdminDistrict district, string code, string name) : base(code, name)
        {
            this.district = district;
        }

        public override IAdminArea GetParent()
        {
            return this.district;
        }

        public override IEnumerable<IAdminArea> GetChildren()
        {
            return new List<IAdminArea>();
        }

        public override int GetHashCode()
        {
            var hashCode = (this.district != null ? this.district.GetHashCode() : 0);
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

            var other = (AdminWard)obj;
            return this.district.Equals(other.district) && code.Equals(other.code) && name.Equals(other.name);
        }
    }
}