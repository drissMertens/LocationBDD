using System;
using System.Collections.Generic;
using System.Text;
using LocationBDD;

namespace LocationSpecFlow.Fake
{
    class FakeDataVehicule
    {
        public List<Vehicule> Vehicules { get; set; }

        public FakeDataVehicule()
        {
            this.Vehicules = new List<Vehicule>();
        }
    }
}
