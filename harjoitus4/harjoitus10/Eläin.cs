using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus10
{
    abstract class Eläin
    {
        public string Nimi { get; set; }

        public abstract void MakeASound();
    }
}
