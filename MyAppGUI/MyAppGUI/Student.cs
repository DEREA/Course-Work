using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAppGUI
{
    public class Student
    {


        private String StName = "Unknown";
        private String StSurname = "Unknown";
        private int StGrade = 8;

        public String getName()
        {

            return this.StName;
        }

        public String setName(String StName)
        {

            if (this.StName != "" && this.StName != null)
            {
                this.StName = StName;
                return StName;
            }
            else
            {
                return StName;
            }

        }

        public int getGrade()
        {
            return this.StGrade;
        }

        public int setGrade(int StGrade)
        {
            this.StGrade = StGrade;
            return 1;
        }

        public String getSurname()
        {

            return this.StSurname;
        }

        public String setSurname(String StSurname)
        {

            if (this.StSurname != "" && this.StSurname != null)
            {
                this.StSurname = StSurname;
                return StSurname;
            }
            else
            {
                return StSurname;
            }
        }


        public override String ToString()
        {
            String XD = StName + " " + StSurname + "      Grade: " + StGrade;
            //Console.WriteLine(XD);
            return XD;
        }



        public class BSCITStudent : Student
        {


            private String[] modules = { "BSC_IT_EPM301", "BSC_IT_SCT575", "BSC_IT_MNL806" };

            public override string ToString()
            {
                String x = "";
                for (int i = 0; i < modules.Length - 1; i++)
                {
                    x = x + modules[i] + ",";
                }
                x = "I am the BSC IT Student and this is my info:\n" + x;
                return x;
            }
            public String getModules() {
                String moduleReturn = "";
                for (int i=0;i<=modules.Length-1;i++) {

                    moduleReturn = moduleReturn +","+ modules[i];
                
                }


                return moduleReturn;
            
            }
        }


        public class MLMStudent : Student
        {


          private  String[] modules = { "MLM_EPM301", "MLM_SCT575", "MLM_MNL806" };

            public override string ToString()
            {
                String x = "";
                for (int i = 0; i < modules.Length - 1; i++)
                {
                    x = x + modules[i] + ",";
                }
                x = "I am the MLM Student and this is my info:\n" + x;
                return x;
            }
            public String getModules()
            {
                String moduleReturn = "";
                for (int i = 0; i <= modules.Length - 1; i++)
                {

                    moduleReturn = moduleReturn + "," + modules[i];

                }


                return moduleReturn;

            }
        }


        public class BcomStudent : Student
        {


          private  String[] modules = { "BCM_CFT457", "BCM_RMG101", "BCM_" };

            public override string ToString()
            {
                String x = "";
                for (int i = 0; i < modules.Length - 1; i++)
                {
                    x = x + modules[i] + ",";
                }
                x = "I am the BSC IT Student and this is my info:\n" + x;
                return x;
            }

            public String getModules()
            {
                String moduleReturn = "";
                for (int i = 0; i <= modules.Length - 1; i++)
                {

                    moduleReturn = moduleReturn + "," + modules[i];

                }


                return moduleReturn;

            }
        }


    }


 















}
