using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetZombillenium
{
    class Attraction
    {
        private bool besoinSpecifique;
        private TimeSpan dureeMaintenance;
        private List<Monstre> equipe;
        private int identifiant;
        private bool maintenance;
        private string natureMaintenance;
        private int nbMinMonstre;
        private string nom;
        private bool ouvert;
        private string typeDeBesoin;

        public Attraction(bool besoinSpecifique, TimeSpan dureeMaintenance, int identifiant, bool maintenance, string natureMaintenance, int nbMinMonstre, string nom, bool ouvert, string typeDeBesoin)
        {
            this.besoinSpecifique = besoinSpecifique;
            this.dureeMaintenance = dureeMaintenance;
            this.equipe = new List<Monstre>();
            this.identifiant = identifiant;
            this.maintenance = maintenance;
            this.natureMaintenance = natureMaintenance;
            this.nbMinMonstre = nbMinMonstre;
            this.nom = nom;
            this.ouvert = ouvert;
            this.typeDeBesoin = typeDeBesoin;
        }
        public Attraction(int identifiant)
        {
            this.identifiant = identifiant;
        }

        


    }
}
