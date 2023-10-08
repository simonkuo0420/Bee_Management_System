using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bee_Management_System
{
    internal class NectarCollector : Bee
    {
        /// <summary>
        /// 每班收集的花蜜
        /// </summary>
        public const float NECTAR_COLLECTED_PER_SHIFT = 33.25F;
        public override float CostPerShift { get { return 1.95F; } }

        public NectarCollector() : base("Nectar Collector") { }

        protected override void DoJob()
        {
            HoneyVault.CollectNectar(NECTAR_COLLECTED_PER_SHIFT);
        }
    }
}
