using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travail_Final__Boites_
{
    public class Boite : IEnumerable
    {
        private List<string> lignes;

        public Boite()
        {
            lignes = new List<string>();
        }

        public Boite(string texte)
        {
            lignes = texte.Split('\n').ToList();
        }

        public Boite(ComboVertical comboVertical)
        {
            lignes = new List<string>();
        }

        public Boite(ComboHorizontal comboHorizontal)
        {
            lignes = new List<string>();
        }

        public bool isEmpty => !lignes.Any();

        public void Redimensionner()
        {

        }

        public Cadre ToCadre()
        {
            return new Cadre(this);
        }

        public static void Afficher(Boite boite)
        {
            if (boite.isEmpty)
            {
                
            }

            foreach (var ligne in boite)
                Console.WriteLine(boite.ToCadre());
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return lignes.GetEnumerator();
        }
    }
}
