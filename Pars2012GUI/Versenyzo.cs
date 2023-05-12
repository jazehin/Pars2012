using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pars2012GUI
{
    internal class Versenyzo
    {
        public string Nev { get; private set; }
        public string Csoport { get; private set; }
        public string NemzetEsKod { get; private set; }
        public double[] Dobasok { get; private set; }

        public Versenyzo(string[] tomb)
        {
            Nev = tomb[0];
            Csoport = tomb[1];
            NemzetEsKod = tomb[2];
            Dobasok = new double[3]; 
            for (int i = 0; i < 3; i++)
            {
                if      (tomb[3 + i] == "X") Dobasok[i] = -1.0;
                else if (tomb[3 + i] == "-") Dobasok[i] = -2.0;
                else                         Dobasok[i] = Convert.ToDouble(tomb[3 + i]);
            }
        }

        public double Eredmeny
        {
            get
            {
                return Dobasok.Max();
            }
        }

        public string Nemzet
        {
            get
            {
                return NemzetEsKod.Substring(0, NemzetEsKod.IndexOf('(') - 1).Trim();
            }
        }

        public string Kod
        {
            get
            {
                return NemzetEsKod.Substring(NemzetEsKod.IndexOf('(') + 1, 3);
            }
        }

        public string DobasokStr
        {
            get
            {
                string str = "";
                for (int i = 0;i < 3;i++)
                {
                    if (Dobasok[i] == -1.0) str += "X";
                    else if (Dobasok[i] == -2.0) str += "-";
                    else str += Convert.ToString(Dobasok[i]);
                    if (i < 2) str += ";";
                }
                return str;
            }
        }

    }
}
