﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6_7_1
{
    class CPersonaItaliana : CPersona
    {
        public new string Saludar()
        {
            return base.Saludar("Italiana");
        }
    }
}
