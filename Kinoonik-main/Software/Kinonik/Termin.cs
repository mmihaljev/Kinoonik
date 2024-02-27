using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinonik
{
    public class Termin
    {
        public int idTermina { get; set; }
        public int idDvorane { get; set; }
        public int idFilma { get; set; }
        public DateTime pocetak { get; set; }
        public DateTime zavrsetak { get; set; }
        public Film film { get; set; }

    }
}
