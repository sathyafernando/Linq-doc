using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinqOperatorExample
{
    public class LinqToXml
    {
        static void Main(string[] args)
        {
            XDocument xmlDocument = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XComment("sdasdas"),
                new XElement("Student",
                new XElement("Student", new XAttribute("Id", 101),
                          new XElement("Name", "Sathya"),
                          new XElement("Age", 10),
                          new XElement("Gender", "Female")),

                     new XElement("Student", new XAttribute("Id", 102),
                          new XElement("Name", "Sara"),
                          new XElement("Age", 50),
                           new XElement("Gender", "Female")),

                    new XElement("Student", new XAttribute("Id", 103),
                          new XElement("Name", "Mahesh"),
                          new XElement("Age", 90) ,
                          new XElement("Gender", "Male"))
                          
                          ));
            xmlDocument.Save("C:\\ducument");


        }
    }
}
