using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bee_Management_System
{
    internal class HoneyManufacturer : Bee
    {

        public const float NECTAR_PROCESSED_PER_SHIFT = 33.15F;
        public override float CostPerShift { get { return 1.7F; } }
        public HoneyManufacturer() : base("Honey Manufacturer") { }

        protected override void DoJob()
        {
            HoneyVault.CovertNectarToHoney(NECTAR_PROCESSED_PER_SHIFT);
        }

    }
}
