﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceoglamaOrnegi
{
    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya kayıt eklendi.");
        }
    }
}