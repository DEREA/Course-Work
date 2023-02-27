using System;
using System.Collections;
namespace ITDCA_Assignment_Q3._4
{
    class Program
    {
        static void Main(string[] args)
        {

            SingleCall newCall1 = new SingleCall();

            newCall1.setPhoneNumber("0852563276");
            newCall1.setAlias("X-Company Deliveryies");

            SingleCall newCall2 = new SingleCall();

            newCall2.setPhoneNumber("0765468979");
           

            SingleCall newCall3 = new SingleCall();

            newCall3.setPhoneNumber("0842264828");
            newCall3.setAlias("X Business rep");

            Queue callQueue = new Queue();

            callQueue.Enqueue(newCall1);
            callQueue.Enqueue(newCall2);
            callQueue.Enqueue(newCall3);

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(callQueue.Dequeue());
            }

        }


        public class SingleCall 
        {

            private String PhoneNumber="Unknown";

            private String alias = "Unknown";



            public String getPhoneNumber() 
            {

                return PhoneNumber;
            }


            public void setPhoneNumber(String PhoneNum) 
            {

                this.PhoneNumber = PhoneNum;

            }


            public String getAlias()
            {

                return alias;
            }


            public void setAlias(String Alias)
            {

                this.alias = Alias;

            }



            public override string ToString()
            {
                string a = PhoneNumber;

                return a;
            }



        }


    }
}
