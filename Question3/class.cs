using System;
using System.Xml;
//Question3
//Write a webservice that accepts the following XML document as the payload:
namespace Questions3
{
    class Class
    {
        static void Main(string[] args)
        {
            string path = @"..\..\..\Questions\Questions3\data.xml";
            XmlDocument doc = new XmlDocument();
            
            // Load the xml document
            doc.Load(path);
        }
    }     
}       