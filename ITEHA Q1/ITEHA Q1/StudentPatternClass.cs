using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITEHA_Q1
{
    class StudentPatternClass
    {

      private StudentClass[] StArray =new StudentClass[5];



        public StudentClass[] getStArray() 
        {
            return StArray;
        }



        public void setStArray(StudentClass[] Students) 
        {

            this.StArray = Students;

        }

        public String toString()
        {
            String XD = "";

            for (int i = 0; i < 5; i++)
            {
                XD = XD + "Student Number: " + StArray[i].getStudentNumber()+", ";
                XD = XD + "Student Name: " + StArray[i].getStudentName() + ", ";
                XD = XD + "Degree: " + StArray[i].getDegree() + " \n";
            }

            return XD;
        }

    }
}
