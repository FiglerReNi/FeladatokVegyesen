using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication20Modulzaro
{
    class Program
    {
        static void Main(string[] args)
        {
            //dhcp.csv = bérelt címek - ami ki van osztva;
            //excluded.csv = kizártak - nem szabad kiosztani;
            //reserved.csv = fenntartások - csak egymással párban kioszthatók;
            //test.csv = request(Mac cím - IP-t kell kiosztani hozzá)
            //release(IP cím - törölni kell(felszabadítani) a dhcp.csv-ből;

            //BEOLVASÁSOK
            string[] beolvasdhcp = File.ReadAllLines("dhcp.csv", Encoding.Default);
            string[] beolvasexcluded = File.ReadAllLines("excluded.csv", Encoding.Default);
            string[] beolvasreserved = File.ReadAllLines("reserved.csv", Encoding.Default);
            string[] beolvastest = File.ReadAllLines("test.csv", Encoding.Default);
            Dictionary<string, int> dhcp = new Dictionary<string, int>();    //string = mac címek (key); int = ip utolsó számtartománya (value)
            //StreamReader rd = File.OpenText("dhcp.csv");
            //while (!rd.EndOfStream)
            //{
            //    string sor = rd.ReadLine();
            //    string[] s = sor.Split(';');
            //    dhcp.Add(sor.Split(';')[0], int.Parse(sor.Split(';')[1].Split('.')[3]);
            //}
            //rd.Close();
            foreach (string sor in beolvasdhcp)
            {
                string mac = sor.Split(';')[0];
                int ip = int.Parse(sor.Split(';')[1].Split('.')[3]);
                dhcp.Add(mac, ip);
            }
            List<int> excluded = new List<int>();
            foreach (string sor in beolvasexcluded)
            {              
                int ip = int.Parse(sor.Split('.')[3]);
                excluded.Add(ip);
            }
            Dictionary<string, int> reserved = new Dictionary<string, int>();    //string = mac címek (key); int = ip utolsó számtartománya (value)
            foreach (string sor in beolvasreserved)
            {
                string mac = sor.Split(';')[0];
                int ip = int.Parse(sor.Split(';')[1].Split('.')[3]);
                reserved.Add(mac, ip);
            }
            //FELADAT
            foreach (string sor in beolvastest)
            {
                if (sor.Split(';')[0] == "release")
                {
                    int ip = int.Parse(sor.Split(';')[1].Split('.')[3]);
                    foreach (KeyValuePair<string, int> item in dhcp)
                    {   
                        if (ip == item.Value)
                        {
                            dhcp.Remove(item.Key);   //dictionary-ból törlés
                            break;
                        }
                    }
                }
                else
                {
                        if (!dhcp.ContainsKey(sor.Split(';')[1]))
                        {
                                if (reserved.ContainsKey(sor.Split(';')[1]))
                                {
                                    int reservedvalueip = reserved[sor.Split(';')[1]]; //kulccsal hivatkozhatunk a dictionary value értékére
                                    if (!dhcp.ContainsKey(sor.Split(';')[1]))
                                    {
                                        dhcp.Add(sor.Split(';')[1],reservedvalueip);
                                    }
                                }
                            
                                else
                                {
                                    int ip = 100;
                                    do
                                    {
                                        if (dhcp.ContainsValue(ip))
                                        {
                                            ip++;
                                        }
                                        else if (excluded.Contains(ip))
                                        {
                                            ip++;
                                        }
                                        else if (reserved.ContainsValue(ip))
                                        {
                                            ip++;
                                        }
                                        else
                                        {
                                         
                                            dhcp.Add(sor.Split(';')[1], ip);
                                            break;
                                        }
                                    }
                                    while (ip <= 199);   
                                }
                            }
                        
                        else
                        {
                            Console.WriteLine("Már szerepel");
                        }
                    }
                }
            
            //KIIRÁS
            string kiir = "";
            foreach (KeyValuePair<string, int> item in dhcp)
            {
                kiir += item.Key + ";" + "192.168.10." + item.Value + Environment.NewLine;
            }
            File.WriteAllText("dhcp_kesz.csv", kiir);

        }
    }
}
