using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bee_Management_System
{
    static class HoneyVault
    {
        public const float NECTAR_CONVERSION_RATIO = .19F; //花蜜轉化率
        public const float LOW_LEVEL_WARNING = 10F; //低級警告
        private static float honey = 25f; //蜂蜜初始值 25f
        private static float nectar = 100f; // 花蜜初始值 100f

        /// <summary>
        /// 將每班收集的花蜜放入花蜜庫
        /// </summary>
        /// <param name="amount"></param>
        public static void CollectNectar(float amount)
        {
            if(amount > 0f) nectar += amount;
        }

        /// <summary>
        /// 會將花蜜轉成蜂蜜
        /// </summary>
        /// <param name="amount"></param>
        public static void CovertNectarToHoney(float amount)
        {
            float nectarToConvert = amount;
            if (nectarToConvert > nectar) nectarToConvert = nectar;
            nectar -= nectarToConvert;
            honey += nectarToConvert * NECTAR_CONVERSION_RATIO;
        }

        /// <summary>
        /// 蜜蜂使用多少蜂蜜來工作
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public static bool ConsumeHoney(float amount)
        {
            if(honey >= amount)
            {
                honey -= amount;
                return true;
            }
            return false;
        }

        /// <summary>
        /// 報告密庫裡面的蜂蜜和花蜜數量，如果蜂蜜或花蜜低於警告會附上警告信息
        /// </summary>
        public static string StatusReport
        {
            get 
            {
                string status = $"{honey:0.0} units of honey\n" + $"{nectar:0.0} units of nectar";
                string warnings = "";
                if (honey < LOW_LEVEL_WARNING) warnings += "\nLOW HONEY - ADD A HONEY MANUFACTURER";
                if (nectar < LOW_LEVEL_WARNING) warnings += "\nLOW NECTAR - ADD A NECTAR COLLECTOR";
                return status + warnings;
            }
        }
    }
}
