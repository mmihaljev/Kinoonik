using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinonik
{
    public class Film
    {
        public int idFilma { get; set; }
        public string nazivFilma { get; set; }
        public int trajanjeFilma { get; set; }
        public string redateljFilma { get; set; }
        public string opisFilma { get; set; }
        public double cijenaKarte { get; set; }

        public override string ToString()
        {
            return nazivFilma;
        }

    }
}
