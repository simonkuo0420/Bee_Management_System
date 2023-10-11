using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bee_Management_System
{
    abstract class Bee : IWorker
    {
        /// <summary>
        /// 定義每一班次吃掉的蜂蜜數量
        /// </summary>
        public abstract float CostPerShift { get; }

        /// <summary>
        /// 唯讀的Job屬性，存工作角色
        /// </summary>
        public string Job { get; private set; }

        public Bee(string job)
        {
            Job = job;
        }

        /// <summary>
        /// 先會判斷蜂巢的蜂蜜數量是否足夠，再去執行工作
        /// </summary>
        public void WorkTheNextShift()
        {
            //如果回傳true，代表蜂蜜足夠
            if (HoneyVault.ConsumeHoney(CostPerShift))
            {
                DoJob();
            }
        }

        /// <summary>
        /// 可覆寫的方法
        /// </summary>
        protected abstract void DoJob();
    }
}
