using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactureDevoir.wind
{
    public class reportlist
    {
        public string NomClient { get; set; }
        public string Numeroclient { get; set; }
        public int code { get; set; }
        public string email { get; set; }
        public string societer { get; set; }
        public string ville { get; set; }
        public int numero { get; set; }
        public string immatriculation { get; set; }
        public double numeroTVA { get; set; }
        public string emissionfacture { get; set; }
        public double fraiederecouvrement { get; set; }
        public int tauxderetard { get; set; }
        public string Nom { get; set; }
        public double sommeapayer { get; set; }
        public int quantite { get; set; }
        public byte[] Photo { get; set; }
        public byte[] Logo { get; set; }

        public reportlist(byte[] photo, byte[] logo)
        {
            report();
            Photo = photo;
            Logo = logo;
        }
        private void report()
        {
            NomClient = InforrmationClient.l1;
            email = InforrmationClient.l3;
            Numeroclient = InforrmationClient.l4;
            societer = InforrmationClient.l7;
            ville = InforrmationClient.l8;
            numero = InformationFacture.l1;
            immatriculation = InformationFacture.l2;
            numeroTVA = InformationFacture.l3;
            code = InformationFacture.l4;
            fraiederecouvrement = InformationFacture.l5;
            tauxderetard = InformationFacture.l6;
            Nom = InformationProduct.L1;
            sommeapayer = InformationProduct.L2;
            quantite = InformationProduct.L3;
            emissionfacture = DateTime.Now.ToLongDateString();
        }

    }
}
