using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace CustomQuery
{
    public class Machine
    {
        public static string GetMachineIP()
        {
            try
            {
                string hostip = "";
                IPAddress[] ips = Dns.GetHostEntry(Dns.GetHostName()).AddressList;
                foreach (IPAddress ip in ips)
                {
                    if (ip.ToString().Length < 20 && !ip.ToString().StartsWith("192."))  //用于过滤ipv6的ip地址
                    {
                        if (string.IsNullOrEmpty(hostip))
                        {
                            hostip += ip.ToString();
                        }
                        else
                        {
                            hostip += "\n" + ip.ToString();
                        }
                    }
                }
                //hostip = hostip.Replace(".", "-");
                return hostip;
            }
            catch
            {
                return "unknownPC";
            }
        }
    }
}
