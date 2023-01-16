using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pars2012
{
    internal class Versenyzo
    {
        readonly string _nev;
        readonly char _csoport;
        readonly string _nemzetEsKod;
        readonly double[] _dobasok = new double[3];

        public Versenyzo(string sor)
        {
            string[] adatok = sor.Split(';');
            _nev = adatok[0];
            _csoport = adatok[1][0];
            _nemzetEsKod = adatok[2];

            for (int i = 3; i < adatok.Length; i++)
            {
                switch (adatok[i])
                {
                    case "X":
                        _dobasok[i - 3] = -1f;
                        break;
                    case "-":
                        _dobasok[i - 3] = -2f;
                        break;
                    default:
                        _dobasok[i - 3] = double.Parse(adatok[i]);
                        break;
                }
            }
        }

        public string Nev { get => _nev; }
        public char Csoport { get => _csoport;  }
        public string Nemzet { get => _nemzetEsKod.Substring(0, _nemzetEsKod.Length - 6); }
        public string Kod { get => _nemzetEsKod.Substring(_nemzetEsKod.Length - 4, 3); }
        public double[] Dobasok { get => _dobasok; }
        public string DobasokAsString
        {
            get
            {
                string[] dobasok = new string[_dobasok.Length];
                for (int i = 0; i < dobasok.Length; i++)
                {
                    switch (Dobasok[i])
                    {
                        case -2:
                            dobasok[i] = "-";
                            break;
                        case -1:
                            dobasok[i] = "X";
                            break;
                        default:
                            dobasok[i] = $"{Dobasok[i]}";
                            break;
                    }
                }
                return $"{dobasok[0]};{dobasok[1]};{dobasok[2]}";
            }
        }
        public double Eredmeny { get =>Dobasok.Max(); }

        public override string ToString()
        {
            return $"{Nev};{Csoport};{Nemzet};{Kod};{DobasokAsString};{Eredmeny}";
        }

    }
}
