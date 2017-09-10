using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class Logger
    {
        private static volatile Logger logger;
        private static readonly object sysLock = new object(); 

        private Logger()
        {

        }

        public static Logger GetLogger()
        {
            if(logger == null)
            {
                lock(sysLock)
                {
                    if(logger == null)
                    {
                        logger = new Logger(); 
                    }
                }
            }

            return logger;
        }
    }
}
