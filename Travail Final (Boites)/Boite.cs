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
            lignes = new List<string>();
            SetDimensions();
        }

        public Boite(ComboHorizontal comboHorizontal)
        {
            lignes = new List<string>();
            SetDimensions();
        }

        public void SetDimensions()
        {
            hauteur = lignes.Count;
            largeur = lignes.OrderByDescending(ligne => ligne.Length).First().Length;
        }

        public void Redimensionner()
        {

        }

        public Cadre ToCadre()
        {
            return new Cadre(this);
        }

        public static void Afficher(Boite boite)
        {
            foreach (var ligne in boite)
                Console.WriteLine(boite.ToCadre());
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return lignes.GetEnumerator();
        }
    }
}
