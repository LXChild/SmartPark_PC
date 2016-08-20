using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SmartPark
{
    class DelegateUpdateUI
    {
        //声明一个delegate（委托）类型：updateDelegate，该类型可以搭载返回值为空，参数只有一个(long型)的方法。
        public delegate void updateDelegate(string info);
        //声明一个updateDelegate类型的对象。该对象代表了返回值为空，参数只有一个(long型)的方法。它可以搭载N个方法。  
        public updateDelegate mainThread;
    }
}
