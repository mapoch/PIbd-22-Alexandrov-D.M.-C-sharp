using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace var1_lab1
{
    class HangarNotFoundException : Exception
    {
        public HangarNotFoundException(int i) : base("Самолёт по месту " + i + " не найден") 
        { }
    }
}
