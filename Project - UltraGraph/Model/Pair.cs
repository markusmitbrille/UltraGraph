﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkusRezai.Project.UltraGraph.Model
{
    public class Pair<T1, T2>
    {
        public T1 Value1 { get; private set; }
        public T2 Value2 { get; private set; }

        public Pair(T1 value1, T2 value2)
        {
            Value1 = value1;
            Value2 = value2;
        }
    }
}
