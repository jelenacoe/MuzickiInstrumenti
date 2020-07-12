using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MuzickiInstrumenti
{
    class Violina : MuzickiInstrument
    {
        public Violina(VrstaInstrumentaEnum vrstaInstrumenta): base(vrstaInstrumenta){}

        public override string Sviraj()
        {
            return String.Format("Trenutno svira violina (vrsta instrumenta : {0})", VrstaInstrumenta);
        }
    }

}
