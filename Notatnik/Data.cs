﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace Notatnik
{
    public class Data
    {
        private NotatkiLateInit data;
        private Data()
        {
            data = new NotatkiLateInit(new ObservableCollection<Notatka>());

            Notatka notatka1 = new Notatka(Kategorie.Instance), notatka2 = new Notatka(Kategorie.Instance);
            notatka1.Tytul = "Nowa notatka 1";
            notatka1.Autor = "Autor1";
            notatka2.Tytul = "Nowa notatka 2";
            notatka2.Autor = "Autor2";
            notatka1.Tekst.Blocks.Add(new Paragraph(new Run("przykładowy tekst1")));
            notatka2.Tekst.Blocks.Add(new Paragraph(new Run("przykładowy tekst2")));
            data.Add(notatka1);
            data.Add(notatka2);            
        }

        private static Data singleton = null;
        public static Data Instance
        {
            get
            {
                if (singleton == null)
                    singleton = new Data();
                return singleton;
            }
        }

        public NotatkiLateInit Notatki
        {
            get { return data; }
        }
    }
}
