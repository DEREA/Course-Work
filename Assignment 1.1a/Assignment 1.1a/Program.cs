using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Assignment_Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /*
            Console.WriteLine("////");

            txtFile.ForEach(Console.WriteLine);

            Console.WriteLine("////");
            */

            ReadTextFile();
              
            Console.Read();
        }

        public static void ReadTextFile() 
        {
            string path = @"C:\Users\k254l\Desktop\DataFile.txt";
            string[] lines = File.ReadAllLines(path);

            List<string> txtFile = new List<string>();

            

            PatientData patient = new PatientData();
            patient.setNum(6);
            patient.setName("James");
            patient.setSurName("M");
            patient.setGroupe("group");
            patient.setGender("Male");
            patient.setWeight(88.2);
            //0,"James","M","group","male",78.0

            // string addstring = "" + Convert.ToString(patient.getNum) + "," + patient.getName + "," + patient.getSurName + ",";
            string addstring = "6,James,M,group,male," + 78.0;

            txtFile.Add(addstring);

            //txtFile.Sort();

            Console.WriteLine("Unsorted:");

            foreach (string line in lines)
            {

                txtFile.Add(line);
            }

            txtFile.ForEach(Console.WriteLine);

            

            string[] lns = new string[5];

            // string readln = txtFile.;

            List<PatientData> txt = new List<PatientData>();
            String ln ;
            for (int i=0;i<=txtFile.Count-1;i++) 
            {
                PatientData pOb = new PatientData();
                ln = txtFile[i];

                Console.WriteLine("_________"+ ln);

                lns = ln.Split(',');

                Console.WriteLine("---- " + lns[0]);
                Console.WriteLine("---- " + lns[1]);
                Console.WriteLine("---- " + lns[2]);
                Console.WriteLine("---- " + lns[3]);
                Console.WriteLine("---- " + lns[4]);
                Console.WriteLine("---- " + lns[5]);

                pOb.setNum(Convert.ToInt32(lns[0]));
                pOb.setName(lns[1]);
                pOb.setSurName(lns[2]);
                pOb.setGroupe(lns[3]);
                pOb.setGender(lns[4]);
                pOb.setWeight(56);

              

                //Console.WriteLine("BOOO" + lns[i]);

                txt.Add(pOb);

            }

            //txt.Sort(Comparison<T>);

             

           // PatientData[] pdArr = txt.ToArray();
            //BubbleSort(pdArr);

            txtFile.Sort();
            // txt=txt.OrderBy(pOb => pOb.getNum);
            //txt.Sort((p,q)=>p.getNum.CompareTo(q.getNum));
         //   List<PatientData> OrderedList= txt.OrderBy(PatientData => PatientData.getNum()).ToList;


            Console.WriteLine("");
            Console.WriteLine("Sorted:");
            Console.WriteLine("");
            // txt.Sort();
            // Console.WriteLine(txt[1]);
            //txt.ForEach(Console.WriteLine);





            for (int i = 0; i < txt.Count; i++)
            {
                Console.WriteLine("" + txtFile[i]);
            }

        }

        public static int[] BubbleSort(int[] arr)
        {
            int sub;

            for (int i = 0; i <= arr.Length - 2; i++)
            {
                for (int j = 0; j <= arr.Length - 2; j++)
                {

                    if (arr[j] < arr[j + 1])
                    {
                        sub = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = sub;
                    }
                }

            }

            return arr;

        }



        class PatientData
        {

           // List<string> txtFile = new List<string>();

            private int num = 0;
            private string name = "Unknown";
            private string surname = "Unknown";
            private string group = "Unknown";
            private string gender = "Other";
            private double weight = 0.0;


            public int getNum() 
            {
                return num;
            }

            public void setNum(int num) 
            {
                this.num = num;
            }


            public string getName()
            {
                return name;
            }

            public void setName(string name)
            {
                this.name = name;
            }

            public string getSurName()
            {
                return surname;
            }

            public void setSurName(string surname)
            {
                this.surname = surname;
            }



            public string getGroup()
            {
                return group;
            }

            public void setGroupe(string group)
            {
                this.group = group;
            }


            public string getGender()
            {
                return gender;
            }

            public void setGender(string gender)
            {
                this.gender= gender;
            }


            public double getweight()
            {
                return weight;
            }

            public void setWeight(double weight)
            {
                this.weight = weight;
            }

            public override string ToString()
            {
                String xd = "" + this.num + " " + this.name +" "+ this.surname +" "+ this.group +" "+ this.gender +" "+ this.weight;
                return xd;
            }

        }

    }
}
