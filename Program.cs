using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MuzickiInstrumenti
{
    class Program
    {
        static void Main()
        {
            List<MuzickiInstrument> instrumenti = new List<MuzickiInstrument>();
            
            Kontrabas kontrabas1 = new Kontrabas(VrstaInstrumentaEnum.Zicani);
            Kontrabas kontrabas2 = new Kontrabas(VrstaInstrumentaEnum.Zicani);

            instrumenti.Add(kontrabas1);
            instrumenti.Add(kontrabas2);

            Violina violina1 = new Violina(VrstaInstrumentaEnum.Zicani);

            instrumenti.Add(violina1);

            Saksofon saksofon1 = new Saksofon(VrstaInstrumentaEnum.Duvacki);

            instrumenti.Add(saksofon1);

            Frula frula1 = new Frula(VrstaInstrumentaEnum.Duvacki);
            Frula frula2 = new Frula(VrstaInstrumentaEnum.Duvacki);

            instrumenti.Add(frula1);
            instrumenti.Add(frula2);

            for (int i = 0; i < instrumenti.Count; i++)
            {
                Console.WriteLine(instrumenti[i].Sviraj());
            }

            Console.ReadLine();

        }
    }
}
