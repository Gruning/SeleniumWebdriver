using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriver.Configuration.CustomException
{
    public class NoSuitableDirverFound: Exception
    {
        public NoSuitableDirverFound(string msg): base(msg)
        {

        }
    }
}
