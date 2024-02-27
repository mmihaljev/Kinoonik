using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinonik.Iznimke
{
    public class SjedaloException : KinoException
    {
        public SjedaloException(string poruka) 
            : base(poruka)
        {

        }
    }
}
