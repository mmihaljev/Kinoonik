using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinonik
{
    public class Dvorana
    {
        public int idDvorane { get; set; }
        public int idKina { get; set; }
        public string nazivDvorane { get; set; }

        public override string ToString()
        {
            return nazivDvorane;
        }

    }
}
