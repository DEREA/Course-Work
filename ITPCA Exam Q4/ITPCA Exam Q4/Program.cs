using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace ITPCA_Exam_Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            //string studentID;
           // string Name;
            //string departments;

            //Will be found at this location ITPCA Exam Q4\ITPCA Exam Q4\bin\Debug

            XmlTextWriter writer = new XmlTextWriter("StudentInfo.xml", System.Text.Encoding.UTF8);
            writer.WriteStartDocument(true);
            writer.Formatting = Formatting.Indented;
            writer.Indentation = 2;
            writer.WriteStartElement("Student");
            createNode("1 ", "Bob ", "Eng ", writer);
            createNode("2 ", "Jeff ", "IT ", writer);
            createNode("3 ", "Caren ", "IT ", writer);
            createNode("4 ", "Jill ", "IT ", writer);
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();

            XmlDataDocument xmldoc = new XmlDataDocument();
            XmlNodeList xmlnode;
            int i = 0;
            string str = null;
            FileStream fs = new FileStream("StudentInfo.xml", FileMode.Open, FileAccess.Read);
            xmldoc.Load(fs);
            xmlnode = xmldoc.GetElementsByTagName("Student");
            for (i = 0; i <= xmlnode.Count - 1; i++)
            {
                xmlnode[i].ChildNodes.Item(0).InnerText.Trim();
                str = xmlnode[i].ChildNodes.Item(0).InnerText.Trim() + "  " + xmlnode[i].ChildNodes.Item(1).InnerText.Trim() + "  " + xmlnode[i].ChildNodes.Item(2).InnerText.Trim();
                Console.WriteLine(str);

            }
            void createNode(string pID, string pName, string pPrice, XmlTextWriter XWriter)
            {
                writer.WriteStartElement("Product");
                writer.WriteStartElement("Product_id");
                writer.WriteString(pID);
                writer.WriteEndElement();
                writer.WriteStartElement("Product_name");
                writer.WriteString(pName);
                writer.WriteEndElement();
                writer.WriteStartElement("Product_price");
                writer.WriteString(pPrice);
                writer.WriteEndElement();
                writer.WriteEndElement();


            }
        }
    }
}
