using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Classes
{
    class DBConnect
    {
        private static ConnectString ConnectObject;
        public static ConnectString()
        {
            if (ConnectObject == null)
            {
                ConnectObject = new ConnectString();
            }
            return ConnectObject;
        }
    }
}
