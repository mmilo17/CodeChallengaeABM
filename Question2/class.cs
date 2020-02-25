using System;
using System.Xml;
//Question2
//Taking the following XML document, write code to extract the RefText values for the
//following RefCodes: ‘MWB’, ‘TRV’ and ‘CAR’
namespace Questions2
{
    enum Questions2
    {
        TRV, MWB, CAR
    }

    class Class
    {
        static void Main(string[] args)
        {
            string path = @"..\..\..\Questions\Questions2\data.xml";
            XmlDocument doc = new XmlDocument();
            
            // Load the xml document
            doc.Load(path);

            // Get the elements as arrays. This is to account for the possibility that there are multiple nodes with the same refCode.
            var trvValues = GetRefCodeValues(doc, desiredRefCodes.TRV.ToString());
            var mwbValues = GetRefCodeValues(doc, desiredRefCodes.MWB.ToString());
            var carValues = GetRefCodeValues(doc, desiredRefCodes.CAR.ToString());

            // Output to display the results
            // output for TRV
            foreach (var item in trvValues)
            {
                Console.WriteLine("TRV: " + item);
            }
            // Output for MWB
            foreach (var item in mwbValues)
            {
                Console.WriteLine("MWB: " + item);
            }
            // Output for CAR
            foreach (var item in carValues)
            {
                Console.WriteLine("CAR: " + item);
            }

        }

        /// <summary>
        /// Outputs an array of the values contained within Xml nodes with the specified reference code
        /// </summary>
        /// <param name="nodeList"></param>
        /// <param name="refCode"></param>
        /// <returns></returns>
        public static string[] GetRefCodeValues(XmlDocument xmlDoc, string refCode)
        {
            XmlNodeList nodeList = xmlDoc.SelectNodes($"descendant::Reference[@RefCode='{refCode}']");

            var valueArray = new string[nodeList.Count];
            for (int i = 0; i < nodeList.Count; i++)
            {
                valueArray[i] = nodeList[i].InnerText;
            }
            return valueArray;
        }
    }
}