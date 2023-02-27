using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_1_Q1
{
    class ContactInfo
    {
        private String FirstName = "Unknown";
        private String Surname = "Unknown";
        private String PhoneNumber = "Unknown";
        private String StreetAddress = "Unknown";



        public String getName() {

            return this.FirstName;
        }


        public String getSurname() {

            return this.Surname;
        }


        public String getPhoneNumber() {
           
            return this.PhoneNumber;

        }


        public String getStreetAddress() {

            return this.StreetAddress;
        
        }

        public String SetName(String FirstName) {

            this.FirstName = FirstName;
            return FirstName;
        }

        public String SetSurname(String Surname)
        {

            this.Surname = Surname;
            return Surname;
        }


        public String SetPhoneNumber(String PhoneNumber)
        {
            this.PhoneNumber = PhoneNumber;
            return PhoneNumber;

        }

        public String SetAddress(String Address)
        {
            this.StreetAddress = Address;
            return Address;

        }







        public override string ToString()
        {
            return base.ToString();
        }















    }
}
