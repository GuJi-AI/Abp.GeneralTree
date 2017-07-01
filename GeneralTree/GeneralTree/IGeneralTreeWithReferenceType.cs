﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities;

namespace Abp.GeneralTree.GeneralTree
{
    public interface IGeneralTreeWithReferenceType<TTree, TPrimaryKey> : IEntity<TPrimaryKey>
        where TPrimaryKey : class
    {
        string Name { get; set; }

        string FullName { get; set; }

        string Code { get; set; }

        int Level { get; set; }

        TTree Parent { get; set; }

        TPrimaryKey ParentId { get; set; }

        ICollection<TTree> Children { get; set; }
    }
}
