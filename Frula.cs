using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MuzickiInstrumenti
{
    class Frula : MuzickiInstrument
    {
        public Frula(VrstaInstrumentaEnum vrstaInstrumenta): base(vrstaInstrumenta){}


        public override string Sviraj()
        {
            return String.Format("Trenutno svira frula (vrsta instrumenta : {0})", VrstaInstrumenta);
        }
    }
}
