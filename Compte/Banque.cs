using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compte
{
    class Banque
    {
        public Banque()
        {
            mesComptes = new List<Compte>();
        }
        
        private List<Compte> mesComptes;

    private List<Compte> MesComptes
        {
            get { return mesComptes; }
            set { mesComptes = value; }
        }

        public Compte Compte { get; private set; }

        public void ajouterCompte(int leNumero, string lenom,double leSolde,double leDecouvertSolde)
        {


            Compte = new Compte(leNumero, lenom, leSolde, leDecouvertSolde);
       







        }
    }
}
