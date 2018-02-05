using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using OT.Foundation;

namespace Scripts.GSF.FrameWork
{
    public abstract class Module
    {
        /// <summary>
        /// 调用它以释放模块
        /// </summary>
        public virtual void Release()
        {
            this.Log("Release");
        }
    }
}
