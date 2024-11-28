﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerstyringssystem
{
    internal interface IProduct
    {
        string Name { get; set; }
        double Price { get; set; }

        void PrintInfo();
    }
}
