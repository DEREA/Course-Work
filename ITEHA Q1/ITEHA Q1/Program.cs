using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITEHA_Q1
{
    class Program
    {
        static void Main(string[] args)
        {

            


            StudentClass St1=new StudentClass();
            StudentClass St2 = new StudentClass();
            StudentClass St3 = new StudentClass();
            StudentClass St4 = new StudentClass();
            StudentClass St5 = new StudentClass();

            St1.setStudentNumber("1234");
            St1.setStudentName("Sheunesu Makura");
            St1.setDegree("BSc Computer Science");


            St2.setStudentNumber("1122");
            St2.setStudentName("Thando Mandela");
            St2.setDegree("BSc IT");

            St3.setStudentNumber("1233");
            St3.setStudentName("Xolisa Phila");
            St3.setDegree("BCom Marketing");

            St4.setStudentNumber("1204");
            St4.setStudentName("Palesa Mohlare");
            St4.setDegree("BSc Biomedicine");

            St5.setStudentNumber("1144");
            St5.setStudentName("Andries van der Merwe");
            St5.setDegree("BCom Law");


            StudentClass[] StArray = new StudentClass[5];

            StArray[0] = St1;
            StArray[1] = St2;
            StArray[2] = St3;
            StArray[3] = St4;
            StArray[4] = St5;


            StudentPatternClass StList = new StudentPatternClass();
            StList.setStArray(StArray);

            StList.toString();
           

            StudentDOClass Do = new StudentDOClass();
            
            Do.setPatternClass(StList);

            Do.toString();

            

           

            for (int i = 0; i < 5; i++)
            {

                Console.Write("Student Number = "+StArray[i].getStudentNumber()+", ");
                Console.Write("Student Name = "+StArray[i].getStudentName()+", ");
                Console.Write("Degree = "+StArray[i].getDegree()+"\n");
            }

          //  Console.WriteLine(St1.getStudentName());
            
           

            Console.ReadLine();

        }
    }
}
