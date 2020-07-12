using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MuzickiInstrumenti
{
    public enum VrstaInstrumentaEnum { Zicani, Duvacki }
    abstract class MuzickiInstrument
    {        
        private  VrstaInstrumentaEnum vrstaInstrumenta;
        public MuzickiInstrument(VrstaInstrumentaEnum vrstaInstrumenta)
        {
            this.vrstaInstrumenta = vrstaInstrumenta;
        }


        public VrstaInstrumentaEnum VrstaInstrumenta
        {
            get { return vrstaInstrumenta; }

            protected set { vrstaInstrumenta = value; }
        }


        public abstract string Sviraj();
    }
}
