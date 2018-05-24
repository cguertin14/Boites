using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travail_Final__Boites_
{
    interface IBoite
    {
        void Cloner(Boite copy);
        int GetHauteur();
        int GetLargeur();
        void Redimensionner(int largeur, int hauteur);
    }
}
