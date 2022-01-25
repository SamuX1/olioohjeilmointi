using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus10
{
    class Varis : Eläin, ICanFly 
    {
        private string v1;
        private int v2;

        public float WingSize { get; set; }
        int ICanFly.WingSize { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Varis(string _nimi, float _wingSize, string _sound)
        {
            Nimi = _nimi;
            WingSize = _wingSize;

        }

        public Varis(string v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public void Fly()
        {
            Console.WriteLine("{0} lentää. siipien koko on {1} ", Name, WingSize);

        public override void MakeASound()
        {
            Console.WriteLine("Kakaaw Kakaaw");
        }
    }
}
