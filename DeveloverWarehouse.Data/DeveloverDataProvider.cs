using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DeveloverWarehouse.Data
{
    public class DeveloverDataProvider
    {
        protected volatile static DeveloverEntities _instance = null;
        public static DeveloverEntities Instance
        {
            get
            {
                if(_instance == null)
                {
                    Mutex mutex = new Mutex();
                    mutex.WaitOne();

                    if(_instance == null)
                        _instance = new DeveloverEntities();

                    mutex.Close();
                }

                return _instance;
            }
        }

        protected DeveloverDataProvider() { }
    }
}
