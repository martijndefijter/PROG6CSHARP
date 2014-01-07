﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MensErgerJeNiet
{
    public class Speler
    {
        public string Kleur { get; private set; }
        public Vak[] ThuisVakken { get; set; }
        public List<WachtVak> WachtVakken { get; set; }
        public StartVak StartVak { get; private set; }

        public Speler(string kleur, StartVak startVak)
        {
            this.Kleur = kleur;
            this.StartVak = startVak;
            ThuisVakken = new ThuisVak[4];
            WachtVakken = new List<WachtVak>();

            for (int i = 0; i <= 4; i++)
            {
                WachtVakken.Add(new WachtVak(new Pion(this), kleur));
            }
        }

        public bool ThuisVakkenVol()
        {
            int counter = 0;
            foreach (ThuisVak thuis in ThuisVakken)
            {
                if (thuis.HeeftPion() != null)
                {
                    counter++;
                }
            }
            if (counter == ThuisVakken.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
