﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceoglamaOrnegi
{
    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Veri tabanına kayıt edildi.");
        }
    }
}
