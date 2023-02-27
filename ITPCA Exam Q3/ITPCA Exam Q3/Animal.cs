using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITPCA_Exam_Q3
{
    class Animal
    {
       private string animalName = "Unknown";
       private int numOfLegs = 0;

        public string MakeSound() 
        {

            //3.4 polymorphism
            //Polymorphism is the idea that an object can have many forms and as such gives a class the ability to be different depending on an object's data
            if (animalName.Equals("Cow"))
            {
                return "Moo";
            }
            else if (animalName.Equals("Sheep"))
            {
                return "Baaa";
            }
            else if (animalName.Equals("cat"))
            {
                return "Meow";
            }
            else 
            {
                return "Unknown sound";
            }
        }


    }


    //3.1 Inheritance
    // The bird class is a child class of the Animal class (The parent class) and as such, it inherits the attributes of the parent class.
    class Bird : Animal 
    {
        //3.3 encapsulation
        // Encapsulation is the grouping and restricting of direct access to data and the way that internal operations function. This is done in the form of classes and private attributes within them.
        private string birdType = "Unknown";
        private string birdSound = "Tweet Tweet";
        private string birdIndexCode = "434481899";
        //3.2 abstraction
        // This is the hiding of certain details pertaining to the class in which, only the essentail details are displayed
        // Only the essential information about the bird is being returned by the Tostring
        public override string ToString() 
        {
            return "Essential Bird Information: \n"+"Bird type: "+birdType+"\nBird sound: "+birdSound;
        }

        
    }

}
