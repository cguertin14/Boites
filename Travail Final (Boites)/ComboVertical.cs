using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travail_Final__Boites_
{
    public class ComboVertical : IBoite
    {
        private Boite first, second;
        public  Boite First => first;
        public  Boite Second => second;

        public ComboVertical(Boite b1, Boite b2)
        {
            first = b1;
            second = b2;
        }
    }
}
