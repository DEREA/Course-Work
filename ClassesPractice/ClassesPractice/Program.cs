using System;
using System.Security.Cryptography;

namespace ClassesPractice
{
    class Program
    {
        static void Main(string[] args)
        {
          /*
            Student BigManRandySavage = new Student(); //Testing Student class

            BigManRandySavage.setName("EERR");
            BigManRandySavage.setGrade(9);
            BigManRandySavage.setSurname ("SKRR SKRR");
            Console.WriteLine(BigManRandySavage);
            Console.WriteLine("Hello world");
            */

            Student[] ListOfStudents = new Student[25];
            /*
                   String eerr= NamePicker(); //Testing the auto generator

                    Console.WriteLine(eerr);

                    String randSurname = SurnamePicker(); //Testing the auto generator
                    Console.WriteLine(randSurname);

            */



            for (int i = 0; i <= ListOfStudents.Length - 1; i++)
            {
                Student newSt = new Student();
               newSt.setName(NamePicker());
                newSt.setSurname(SurnamePicker());
                newSt.setGrade(GradePicker());

                ListOfStudents[i] = newSt;

            }


            for (int i = 0; i <= ListOfStudents.Length - 1; i++)
            {
                Console.WriteLine(ListOfStudents[i]);

            }





















        }

        public static String NamePicker()
        {
            String chooseName = "";
            Random rnd = new Random();
            int randNum= rnd.Next(1, 12);

            switch (randNum) {

                case 1:
                    chooseName = "Matthew";
                   break;

                case 2:
                    chooseName = "Daniel";
                    break;
                case 3:
                    chooseName = "Christopher";
                    break;
                case 4:
                    chooseName = "Charles";
                    break;
                case 5:
                    chooseName = "Thomas";
                    break;
                case 6:
                    chooseName = "Joseph";
                    break;
                case 7:
                    chooseName = "Richard";
                    break;

                case 8:
                    chooseName = "David";
                    break;
                case 9:
                    chooseName = "William";
                    break;
                case 10:
                    chooseName = "Michael";
                    break;
                case 11:
                    chooseName = "Robert";
                    break;
                    chooseName = "John";
                case 12:
                    chooseName = "James";
                    break;

            }


            return chooseName;
        }








        public static String SurnamePicker()
        {
            String chooseName = "";
            Random rnd = new Random();
            int randNum = rnd.Next(1, 12);

            switch (randNum)
            {

                case 1:
                    chooseName = "Mclaws";
                    break;

                case 2:
                    chooseName = "Breeze";
                    break;
                case 3:
                    chooseName = "Waltch";
                    break;
                case 4:
                    chooseName = "Connors";
                    break;
                case 5:
                    chooseName = "Deacon";
                    break;
                case 6:
                    chooseName = "Palin";
                    break;
                case 7:
                    chooseName = "Vining";
                    break;

                case 8:
                    chooseName = "Davidson";
                    break;
                case 9:
                    chooseName = "Langley";
                    break;
                case 10:
                    chooseName = "Howes";
                    break;
                case 11:
                    chooseName = "Miller";
                    break;
                    chooseName = "Davis";
                case 12:
                    chooseName = "Jones";
                    break;

            }


            return chooseName;
        }

        public static int GradePicker() {

            Random rnd = new Random();
            int randNum = rnd.Next(8, 12);


            return randNum;
        }







    }

}
