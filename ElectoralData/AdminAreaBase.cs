// <copyright file="BaseAdminArea.cs" company="McLaren Applied Technologies Ltd.">
// Copyright (c) McLaren Applied Technologies Ltd.</copyright>

using System.Collections.Generic;
using System.Linq;
using System.Text;
using ElectoralData.Interfaces;

namespace ElectoralData
{
    public abstract class AdminAreaBase : IAdminArea
    {
        protected readonly string code;
        protected readonly string name;

        protected AdminAreaBase(string code, string name)
        {
            this.code = code;
            this.name = name;
        }

        public string Code => this.code;

        public string Name => this.name;

        public bool HasParent => this.GetParent() != null;

        public bool HasChildren => this.GetChildren().Any();

        public abstract IAdminArea GetParent();

        public abstract IEnumerable<IAdminArea> GetChildren();

        public override string ToString()
        {
            var levels = new LinkedList<IAdminArea>();
            IAdminArea pointer = this;

            do
            {
                levels.AddFirst(pointer);
                pointer = pointer.GetParent();
            } while (pointer != null);

            int lvl = 0;

            var buffer = new StringBuilder();

            foreach (var level in levels)
            {
                for (int j = 0; j < lvl; j++)
                {
                    buffer.Append("  ");
                }

                buffer.Append(level.Code);
                buffer.Append(" ");
                buffer.Append(level.Name);
                buffer.AppendLine();
                lvl++;
            }

            return buffer.ToString();
        }
    }
}