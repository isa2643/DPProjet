using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternProjet
{
    public class VehicleCreator
    {
        private readonly VehicleBuilder _veh;

        public VehicleCreator(VehicleBuilder v)
        {
            _veh = v;
        }

        public void CreateVehicle()
        {
            _veh.CreationVehicule();
            Process.Assemblage(_veh);

        }

    }
}
