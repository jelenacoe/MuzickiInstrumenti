using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MuzickiInstrumenti
{
    class Saksofon : MuzickiInstrument
    {
        public Saksofon(VrstaInstrumentaEnum vrstaInstrumenta): base(vrstaInstrumenta){}
        
        public override string Sviraj()
        {
            return String.Format("Trenutno svira saksofon (vrsta instrumenta : {0})", VrstaInstrumenta);
        }
    }
}
