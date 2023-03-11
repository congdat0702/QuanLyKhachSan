using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace QLKhachSan
{
    class connection
    {
        public static string getConnectString()
        {
            return ConfigurationManager.AppSettings["MainConnection"];
        }
    }
}
