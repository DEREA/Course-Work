using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITPCA_Exam_Q1
{
    class Class1
    {
        //1.1 overloading
        // overloading is when multiple methods have the same name but are differentiated by the method's parameters
        // In this case, both PrintFullName methods have the same name but can be specifically called through the use of the different input parameters
        public string PrintFullName(string name,string middlename, string Surname)
        {
            return name + " " +middlename+" " +Surname;
        }

        public string PrintFullName(string name, string Surname)
        {
            return name + "" + Surname;
        }


        public override string ToString() 
        {
            return "I am an adult";
        }


        class Class2 : Class1 
        {
            //1.2 overriding
            // overriding is when the method in the child class has the same name and parameters as the one in the parent class
            public override string ToString()
            {
                return "*Baby sounds*(This is a baby and is not able to speak)";
            }



        }

   
    
    }





}
