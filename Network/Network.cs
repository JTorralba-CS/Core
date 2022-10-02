using System;
using System.Collections.Generic;
using System.Net;

namespace Core
{
    public static class Network
    {
        public static String[] IP(String Host)
        {
            return IP(Host, 0);
        }

        public static String[] IP(String Host, Byte Version)
        {
            IPAddress[] IP_Address_List = Dns.GetHostEntry(Host).AddressList;
            List<String> IP_Address_List_New = new List<String>();

            foreach (IPAddress Item in IP_Address_List)
            {
                switch (Version)
                {
                    case 4:
                        if (Item.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                        {
                            IP_Address_List_New.Add(Item.ToString());
                        }
                        break;
                    case 6:
                        if (Item.AddressFamily == System.Net.Sockets.AddressFamily.InterNetworkV6)
                        {
                            IP_Address_List_New.Add(Item.ToString());
                        }
                        break;
                    default:
                        IP_Address_List_New.Add(Item.ToString());
                        break;
                }
            }

            return IP_Address_List_New.ToArray();
        }
    }
}
