using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternProjet
{
    public class Moto : VehicleBuilder
    {
        protected override void AjoutMoteur()
        {
            Console.WriteLine("Ajout du moteur pour moto");
        }

        protected override void Assemblage()
        {
            var db = SingletonDB.Instance;
            db.GetDBConnection();

            //DB_VehiculesEntities db = new DB_VehiculesEntities();

            //using (db)
            //{
            var ListeVehicules = db.GetDBConnection().VEHICULEs.Where(x => x.type.Equals("moto")).ToList();

                foreach (VEHICULE v in ListeVehicules)
                {
                    Console.Write(String.Join(",", v.type));
                    Console.Write(String.Join(",", v.marque));
                    Console.Write(String.Join(",", v.modele));
                    Console.Write(String.Join(",", v.nombre_roue));
                    Console.WriteLine(String.Join(",", v.nombre_chevaux));
                }
            //}
        }

        protected override void Fin()
        {
            Console.WriteLine("Fin de l'assemblage des motos");
        }

        protected override void AjoutChassis()
        {
            Console.WriteLine("Ajout de chassis pour moto");
        }

        protected override void AjoutPortes()
        {
            Console.WriteLine("Pas besoin de portes pour les motos");
        }
    }
}
