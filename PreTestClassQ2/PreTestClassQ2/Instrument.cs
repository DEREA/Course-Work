using System;
using System.Collections.Generic;
using System.Text;

namespace PreTestClassQ2
{
    class Instrument
    {
        private string make="Unknown";
        private double price = 0.0;

        public string getMake() 
        {
            return make;
        }

        public double getPrice() 
        {
            return price;
        }


       public void setMake(String newMake) 
        {
            this.make=newMake;
        }

        public void setPrice(double newPrice) 
        {
            this.price = newPrice;
        }





       public string Play() {
            return "Bing Bing Bong (That's the sound of the instrument being played)";
        }

    }

    class guitar : Instrument
    {
        private string[] guitarType=new string[] {"acoustic","base","electric"};
        public override string ToString()
        {
            return "The guitar is playing";
        }
    }

    class drums : Instrument
    {
       private int numOfCymbals=0;
       private bool isElectronic = false;


        public int getNumOfCymbals() 
        {
            return numOfCymbals;
        }

        public bool getIsElectronic() 
        {
            return isElectronic;
        }


        public void setNumOfCymbals(int newNumOfCymbals) 
        {
            this.numOfCymbals = newNumOfCymbals;
        }

        public void setIsElectronic(bool newIsElectronic) 
        {
            this.isElectronic = newIsElectronic;
        }


        void calcBeat(int beat) 
        { 

        }

        void calcBeat(int beat, int beat2) 
        {

        }




    }

}

