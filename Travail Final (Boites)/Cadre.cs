using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travail_Final__Boites_
{
    public class Cadre
    {
        private Boite boite;

        public Cadre(Boite b)
        {
            boite = b;
        }

        private List<string> Build()
        {
            if (!boite.Lignes.Any()) { return GetEmptyCadre(); }
            var buildingList = new List<string>();
            buildingList.Add(GetFirstOrLastLine());
            foreach(var ligne in boite.Lignes)
            {
                buildingList.Add($"|{ligne}{GetTrimEnd(ligne)}");
            }
            buildingList.Add(GetFirstOrLastLine());
            return buildingList;
        }

        private string GetTrimEnd(string ligne)
        {
            return new StringBuilder().Append(' ', boite.Largeur - ligne.Count()).Append("|").ToString();
        }

        private string GetFirstOrLastLine()
        {
            StringBuilder stringBuilder = new StringBuilder();
            return stringBuilder.Append("+").Append('-', boite.Lignes.Aggregate("", (max, cur) => max.Length > cur.Length ? max : cur).Count()).Append("+").ToString();
        }

        private List<string> GetEmptyCadre()
        {
            return new List<string> { "++", "++" };
        }

        override public string ToString()
        {
            return String.Join(Environment.NewLine, Build().ToArray());
        }
    }
}
