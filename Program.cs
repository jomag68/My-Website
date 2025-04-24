using System;
using System.Xml;

class Program
{
    static void Main()
    {
        // Step 1: Load the XML file
        XmlDocument doc = new XmlDocument();
        doc.Load("profiles.xml");

        // Step 2: Get all <profile> elements
        XmlNodeList profiles = doc.GetElementsByTagName("profile");

        Console.WriteLine("Profile List:\n");

        // Step 3: Loop through each profile and display the data
        foreach (XmlNode profile in profiles)
        {
            string name = profile["name"] != null ? profile["name"].InnerText : "N/A";
            string age = profile["age"] != null ? profile["age"].InnerText : "N/A";
            string address = profile["address"] != null ? profile["address"].InnerText : "N/A";
            string email = profile["email"] != null ? profile["email"].InnerText : "N/A";

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Address: " + address);
            Console.WriteLine("Email: " + email);
            Console.WriteLine("------------------------");
        }
    }
}

