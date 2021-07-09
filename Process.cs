using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternProjet
{
    public class Process
    {
        public static void Assemblage(VehicleBuilder classeAbstraite)
        {
            classeAbstraite.Operations();
        }
    }
}
