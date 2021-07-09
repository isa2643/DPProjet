using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternProjet
{
    public abstract class VehicleBuilder
    {
        protected Vehicle _vehicle;

        public void CreationVehicule()
        {
            _vehicle = new Vehicle();
        }

        public void Operations()
        {
            this.Debut();
            this.AjoutChassis();
            this.AjoutMoteur();
            this.Fin();
            this.Assemblage();
            
        }

        protected virtual void Debut()
        {
            Console.WriteLine("Debut Assemblage");
        }
        protected abstract void AjoutChassis();

        protected abstract void AjoutMoteur();

        protected virtual void Fin()
        {
            Console.WriteLine("Fin Assemblage");
        }

        protected abstract void Assemblage();

        protected abstract void AjoutPortes();



    }
}
