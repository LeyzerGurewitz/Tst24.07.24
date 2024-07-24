using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tst.Configuration
{
    internal static class TstConfiguration
    {
        public static string tstPath = Path.Combine(
            Directory.GetCurrentDirectory(),
            "tst.xml"
            );
    }
}
