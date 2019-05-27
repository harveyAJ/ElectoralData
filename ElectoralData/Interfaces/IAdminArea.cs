// <copyright file="IAdminArea.cs" company="McLaren Applied Technologies Ltd.">
// Copyright (c) McLaren Applied Technologies Ltd.</copyright>

using System.Collections.Generic;

namespace ElectoralData.Interfaces
{
    public interface IAdminArea
    {
        string Code { get; }

        string Name { get; }

        bool HasParent { get; }

        bool HasChildren { get; }

        IAdminArea GetParent();

        IEnumerable<IAdminArea> GetChildren();
    }
}