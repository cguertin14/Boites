using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travail_Final__Boites_
{
    class Program
    {
        static void Main(string[] args)
        {
            Boite b = new Boite();
            Boite.Afficher(b);
            Boite.Afficher(new Boite("yo"));
            string texte = "Man! Hey!!!\nceci est un test\nmultiligne";
            string aut_texte = "Ceci\nitou, genre";
            Boite b0 = new Boite(texte);
            Boite b1 = new Boite(aut_texte);
            Boite.Afficher(b0);
            Boite.Afficher(b1);
            ComboVertical cv = new ComboVertical(b0, b1);
            Boite.Afficher(new Boite(cv));
            ComboHorizontal ch = new ComboHorizontal(b0, b1);
            Boite.Afficher(new Boite(ch));
            ComboVertical cvplus = new ComboVertical(new Boite(cv), new Boite(ch));
            Boite.Afficher(new Boite(cvplus));
            ComboHorizontal chplus = new ComboHorizontal(new Boite(cv), new Boite(ch));
            Boite.Afficher(new Boite(chplus));
            ComboVertical cvv = new ComboVertical(new Boite(chplus), new Boite("coucou"));
            Boite.Afficher(new Boite(cvv));
            Boite.Afficher(new Boite(
               new ComboHorizontal(
                  new Boite("a\nb\nc\nd\ne"),
                     new Boite(
                        new ComboVertical(
                           new Boite("allo"), new Boite("yo")
                        )
                     )
                  )
               )
            );
            Boite.Afficher(
               new Boite(new ComboHorizontal(new Boite("Yo"), new Boite()))
            );
            Boite.Afficher(
               new Boite(new ComboHorizontal(new Boite(), new Boite("Ya")))
            );
            Boite.Afficher(
               new Boite(new ComboHorizontal(new Boite(), new Boite()))
            );
            Boite.Afficher(
               new Boite(new ComboVertical(new Boite(), new Boite()))
            );
            Boite.Afficher(
               new Boite(new ComboVertical(new Boite("Yip"), new Boite()))
            );
            Boite.Afficher(
               new Boite(new ComboVertical(new Boite(), new Boite("Yap")))
            );
        }
    }
}
