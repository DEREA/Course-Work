using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace DictionaryAndIPClass
{
    class Program
    {
        

        public class IPAddresses : System.Collections.DictionaryBase
        {
            public IPAddresses()
            {
            }
            public void Add(string name, string ip)
            {
                base.InnerHashtable.Add(name, ip);
            }
            public string Item(string name)
            {
                return base.InnerHashtable[name].ToString();
            }
            public void Remove(string name)
            {
                base.InnerHashtable.Remove(name);
            }



        }//end of IPAddresses





        class YourClass
        {




            static void Main()
            {



                IPAddresses myIPs = new IPAddresses();
                myIPs.Add("Mike", "192.155.12.1");
                myIPs.Add("David", "192.155.12.2");
                myIPs.Add("Bernica", "192.155.12.3");

                Console.WriteLine("There are " + myIPs.Count + " IP addresses");
                Console.WriteLine("David's ip address: " + myIPs.Item("David"));



                var myList = new List<KeyValuePair<string, string>>();

                // adding elements
                myList.Add(new KeyValuePair<string, string>(myIPs.Item("Mike"), "192.155.12.1"));
                myList.Add(new KeyValuePair<string, string>(myIPs.Item("David"), "192.155.12.2"));
                myList.Add(new KeyValuePair<string, string>(myIPs.Item("Bernica"), "192.155.12.3"));



                myIPs.Clear();

                Console.WriteLine("Clearing");

                Console.WriteLine("There are " + myIPs.Count + " IP addresses");



            }//end of main method



        }//end of YourClass
    }
}
