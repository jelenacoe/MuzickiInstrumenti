using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MuzickiInstrumenti
{
    class Kontrabas : MuzickiInstrument
    {
        public Kontrabas(VrstaInstrumentaEnum vrstaInstrumenta): base(vrstaInstrumenta){}


        public override string Sviraj()
        {
            return String.Format("Trenutno svira kontrabas (vrsta instrumenta : {0})", VrstaInstrumenta);
        }
    }
}
