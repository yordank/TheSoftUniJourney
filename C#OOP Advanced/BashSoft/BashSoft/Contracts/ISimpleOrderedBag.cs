﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BashSoft.Contracts
{
    using System;
    using System.Collections.Generic;

    public interface ISimpleOrderedBag<T> : IEnumerable<T>
        where T : IComparable<T>
    {
        bool Remove(T element);

        int Capacity { get; }

        int Size { get; }

        void Add(T element);

        void AddAll(ICollection<T> collection);

        string JoinWith(string joiner);
    }
}