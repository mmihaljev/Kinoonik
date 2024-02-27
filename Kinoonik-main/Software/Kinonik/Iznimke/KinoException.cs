using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinonik.Iznimke
{
    public class KinoException : ApplicationException
    {
        public string Poruka { get; set; }
        public KinoException(string poruka)
        {
            Poruka = poruka;
        }
    }
}
