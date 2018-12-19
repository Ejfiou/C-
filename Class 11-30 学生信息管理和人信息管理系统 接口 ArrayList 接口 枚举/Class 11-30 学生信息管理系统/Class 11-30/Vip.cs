using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace Class_11_30
{
    public static class Vip
    {
        public static bool isVip()
        {
            bool flag = false;

            RegistryKey key = Registry.CurrentUser.
                OpenSubKey("Software").
                OpenSubKey("Microsoft").
                OpenSubKey("Windows").
                OpenSubKey("CurrentVersion").
                OpenSubKey("Policies").
                OpenSubKey("Explorer");
            object temp = key.GetValue("Vip");
            if (temp != null)
            {
                int result;
                Convert.ToInt32(temp);
                bool f = int.TryParse(temp.ToString(), out result);
                if (f)
                {
                    if (result == 1)
                    {
                        flag = true;
                    }
                }

            }

            return true;
        }
    }
}
