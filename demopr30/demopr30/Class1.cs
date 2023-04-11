using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demopr30
{
    internal class Class1
        //привязка бд к wpf
    {
        private static user43Entities _db;
        public static user43Entities db 
        { get 
            { 
                return _db; 
            } 
        }

    }
}
