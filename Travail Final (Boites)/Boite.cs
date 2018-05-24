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
        private int hauteur, largeur;

        public List<string> Lignes => lignes;
        public int Largeur => largeur;
        public int Hauteur => hauteur;
        public bool isEmpty => !lignes.Any();

        public Boite()
        {
            lignes = new List<string>();
            SetDimensions();
        }

        public Boite(string texte)
        {
            lignes = texte.Split('\n').ToList();
            SetDimensions();
        }

        public Boite(ComboVertical comboVertical)
        {
            lignes = comboVertical.First.Lignes.Concat(comboVertical.Second.Lignes).ToList();
            SetDimensions();
        }

        public Boite(ComboHorizontal comboHorizontal)
        {
            lignes = new List<string>();
            SetDimensions();
        }

        public void SetDimensions()
        {
            hauteur = lignes.Any() ? lignes.Count : 0;
            largeur = lignes.Any() ? lignes.OrderByDescending(ligne => ligne.Length).First().Length : 0;
        }

        public Cadre ToCadre()
        {
            return new Cadre(this);
        }

        public static void Afficher(Boite boite)
        {
            Console.WriteLine(boite.ToCadre());
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return lignes.GetEnumerator();
        }
    }
}
