using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace var1_lab1
{
    public class HangarAlreadyHaveException : Exception
    {
        public HangarAlreadyHaveException() : base("В ангаре уже есть такой самолёт") { }
    }
}
