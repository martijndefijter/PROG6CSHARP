﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MensErgerJeNiet.Model
{
    class BordMaker
    {
        public BordMaker()
        {
        }

        public Collection<Vak> maakBord()
        {
            Collection<Vak> l = new Collection<Vak>();

            l.Add(new StartVak("rood"));                    //0 rood start
            for (int i = 1; i < 9; i++)                 //1-8 leeg vakje
            {
                l.Add(new Vak());
                l.ElementAt(i - 1).VolgendVak = l.ElementAt(i);
                l.ElementAt(i).VorigVak = l.ElementAt(i - 1);
            }
            l.Add(new PoortVak());                    //9 blauw poortvakje
            l.ElementAt(8).VolgendVak = l.ElementAt(9);
            l.ElementAt(9).VorigVak = l.ElementAt(8);
            l.Add(new StartVak("blauw"));                    //10 blauw start
            l.ElementAt(9).VolgendVak = l.ElementAt(10);
            l.ElementAt(10).VorigVak = l.ElementAt(9);
            for (int i = 11; i < 19; i++)               //11-18 leeg vakje
            {
                l.Add(new Vak());
                l.ElementAt(i - 1).VolgendVak = l.ElementAt(i);
                l.ElementAt(i).VorigVak = l.ElementAt(i - 1);
            }
            l.Add(new PoortVak());                    //19 groen poortvakje
            l.ElementAt(18).VolgendVak = l.ElementAt(19);
            l.ElementAt(19).VorigVak = l.ElementAt(18);
            l.Add(new StartVak("groen"));            //20 groen startvakje
            l.ElementAt(19).VolgendVak = l.ElementAt(20);
            l.ElementAt(20).VorigVak = l.ElementAt(19);
            for (int i = 21; i < 29; i++)               //21-28 leeg vakje
            {
                l.Add(new Vak());
                l.ElementAt(i - 1).VolgendVak = l.ElementAt(i);
                l.ElementAt(i).VorigVak = l.ElementAt(i - 1);
            }
            l.Add(new PoortVak());                    //29 geel poortvakje
            l.ElementAt(28).VolgendVak = l.ElementAt(29);
            l.ElementAt(29).VorigVak = l.ElementAt(28);
            l.Add(new StartVak("geel"));                    //30 geel startvakje
            l.ElementAt(29).VolgendVak = l.ElementAt(30);
            l.ElementAt(30).VorigVak = l.ElementAt(29);
            for (int i = 31; i < 39; i++)               //31-38 lege vakjes
            {
                l.Add(new Vak());
                l.ElementAt(i - 1).VolgendVak = l.ElementAt(i);
                l.ElementAt(i).VorigVak = l.ElementAt(i - 1);
            }
            l.Add(new PoortVak());                    //39 rood poortvakje
            l.ElementAt(38).VolgendVak = l.ElementAt(39);
            l.ElementAt(39).VolgendVak = l.ElementAt(0);
            l.Add(new ThuisVak("blauw"));       //40-43 blauwe thuisvakken
            l.ElementAt(9).ZijVak = l.ElementAt(40);
            l.ElementAt(40).VorigVak = l.ElementAt(9);
            l.Add(new ThuisVak("blauw"));
            l.ElementAt(40).VolgendVak = l.ElementAt(41);
            l.ElementAt(41).VorigVak = l.ElementAt(40);
            l.Add(new ThuisVak("blauw"));
            l.ElementAt(41).VolgendVak = l.ElementAt(42);
            l.ElementAt(42).VorigVak = l.ElementAt(41);
            l.Add(new ThuisVak("blauw"));
            l.ElementAt(42).VolgendVak = l.ElementAt(43);
            l.ElementAt(43).VorigVak = l.ElementAt(42);
            /////////
            l.Add(new ThuisVak("groen"));
            l.ElementAt(19).ZijVak = l.ElementAt(44);     //44-47 groene thuisvakken
            l.ElementAt(44).VorigVak = l.ElementAt(19);
            l.Add(new ThuisVak("groen"));
            l.ElementAt(44).VolgendVak = l.ElementAt(45);
            l.ElementAt(45).VorigVak = l.ElementAt(44);
            l.Add(new ThuisVak("groen"));
            l.ElementAt(45).VolgendVak = l.ElementAt(46);
            l.ElementAt(46).VorigVak = l.ElementAt(45);
            l.Add(new ThuisVak("groen"));
            l.ElementAt(46).VolgendVak = l.ElementAt(47);
            l.ElementAt(47).VorigVak = l.ElementAt(46);
            ////////
            l.Add(new ThuisVak("geel"));
            l.ElementAt(29).ZijVak = l.ElementAt(48);     //48-51 gele thuisvakken
            l.ElementAt(48).VorigVak = l.ElementAt(29);
            l.Add(new ThuisVak("geel"));
            l.ElementAt(48).VolgendVak = l.ElementAt(49);
            l.ElementAt(49).VorigVak = l.ElementAt(48);
            l.Add(new ThuisVak("geel"));
            l.ElementAt(49).VolgendVak = l.ElementAt(50);
            l.ElementAt(50).VorigVak = l.ElementAt(49);
            l.Add(new ThuisVak("geel"));
            l.ElementAt(50).VolgendVak = l.ElementAt(51);
            l.ElementAt(51).VorigVak = l.ElementAt(50);
            ////////
            l.Add(new ThuisVak("rood"));
            l.ElementAt(39).ZijVak = l.ElementAt(52);     //52-55 rode thuisvakken
            l.ElementAt(52).VorigVak = l.ElementAt(19);
            l.Add(new ThuisVak("rood"));
            l.ElementAt(52).VolgendVak = l.ElementAt(53);
            l.ElementAt(53).VorigVak = l.ElementAt(52);
            l.Add(new ThuisVak("rood"));
            l.ElementAt(53).VolgendVak = l.ElementAt(54);
            l.ElementAt(54).VorigVak = l.ElementAt(53);
            l.Add(new ThuisVak("rood"));
            l.ElementAt(54).VolgendVak = l.ElementAt(55);
            l.ElementAt(55).VorigVak = l.ElementAt(54);
            return l;
        }

    }
}
