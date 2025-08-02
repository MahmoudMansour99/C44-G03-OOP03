using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    internal class TypeC : TypeB
    {
        public TypeC()
        {
            B = 1; // Internal
            C = 2; // Public
            X = 3; // 
            Y = 4;
            Z = 5;
        }
    }
}
