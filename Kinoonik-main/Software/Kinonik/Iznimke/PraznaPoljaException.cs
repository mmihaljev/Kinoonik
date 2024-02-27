using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinonik.Iznimke
{
    public class PraznaPoljaException : KinoException
    {
        public PraznaPoljaException(string poruka)
            : base(poruka)
        {

        }
    }
}
