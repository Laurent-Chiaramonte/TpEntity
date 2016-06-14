using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseDal
{
    public class TpInitializer : DropCreateDatabaseAlways<TpContext>
    {
        protected override void Seed(TpContext db)
        {
            // Clients
            Client cl1 = new Client(1, "Panzani", "34, avenue de corot", "13013", "Marseille", "0491609023");
            Client cl2 = new Client(2, "Heineken", "14, rue François Chardigny", "13011", "Marseille", "0491691322");

            db.Clients.Add(cl1);
            db.Clients.Add(cl2);

            //Centres
            CentreInformatique ceinfo1 = new CentreInformatique(1, "34, avenue de corot", "13013", "Marseille", "0491609023",
                1);
            CentreInformatique ceinfo2 = new CentreInformatique(2, "11, chemin du littoral", "13015", "Marseille", "0491601462",
                1);
            CentreInformatique ceinfo3 = new CentreInformatique(3, "14, rue François Chardigny", "13011", "Marseille", "0491691322",
                2);
            db.CentresInformatique.Add(ceinfo1);
            db.CentresInformatique.Add(ceinfo2);
            db.CentresInformatique.Add(ceinfo3);

            //Contrats
            Contrat ct1 = new Contrat(1, 24.65, new DateTime(2011, 02, 12), 1, cl1, ceinfo1);
            Contrat ct2 = new Contrat(2, 13.480, new DateTime(2011, 03, 13), 1, cl1, ceinfo2);
            Contrat ct3 = new Contrat(3, 32.740, new DateTime(2016, 04, 15), 1, cl2, ceinfo3);
            db.Contrats.Add(ct1);
            db.Contrats.Add(ct2);
            db.Contrats.Add(ct3);

        }
    }
}
