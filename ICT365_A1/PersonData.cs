using GMap.NET;
using PhoneNumbers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace ICT365_A1
{
    public class PersonData : MapConfig
    {
        //private static Dictionary<PhoneNumber, Person> people;
        //public Dictionary<PhoneNumber, Person> PeopleDictionary { get => people; set => people = value; }

        public Dictionary<PhoneNumber, Person> LoadPeople()
        {
            Console.WriteLine("Loading People Dictionary From File...");
            //people = new Dictionary<PhoneNumber, Person>();
            XElement pXEle = XElement.Load("hindsight-people.xml");
            XNamespace hsp = "http://projects.awgm.co/hindsightpeople";
            Dictionary<PhoneNumber, Person> p = new Dictionary<PhoneNumber, Person>();
             int totalItems = 0;
            
            


            foreach (var i in pXEle.Descendants(hsp + "Person"))
            {
                //Console.WriteLine(item);
                
                totalItems++;
                Person np = new Person();
                np.Name.FirstName = i.Element(hsp + "name").Element(hsp + "fname").Value;
                np.Name.LastName = i.Element(hsp + "name").Element(hsp + "lname").Value;
                PointLatLng loc = new PointLatLng();
                //Console.WriteLine("New Person Loaded: " + np.Name.ToString());

                np.ValidatePhoneNumber(i.Element(hsp + "phone").Value);

                loc.Lat = (double)i.Element(hsp + "address").Element(hsp + "location").Element(hsp + "lat");
                loc.Lng = (double)i.Element(hsp+"address").Element(hsp +"location").Element(hsp+"long");

                np.Address.Location = loc;
                //Console.WriteLine(newP.Address.Location);

                try
                {
                    p.Add(np.PhoneNumber, np);
                }
                catch (ArgumentException e)
                {
                    throw e;
                }
                np.Marker = AddPersonMarker(np);
            }
            Console.WriteLine("Total of " + totalItems + " People loaded.");
            return p;
        }

        public Dictionary<PhoneNumber, Person> AddPerson(Person np, Dictionary<PhoneNumber, Person> p)
        {
            p.Add(np.PhoneNumber, np);
            Console.WriteLine("New Person Added: " + np.Name.ToString());
            Console.WriteLine("Total of " + p.Count + " People loaded.");
            np.Marker = AddPersonMarker(np);

            return p;
        }

        public void SearchPeople(string searchQuery)
        {
            int searchResults = 0;
            Console.WriteLine("Searching People...");

            Console.WriteLine("Search Completed.");
            Console.WriteLine("Found " + searchResults + " Matching People");
        }

        

        //public static void SavePeople()
        //{

        //    string fileName ="";
        //    foreach (var i in people)
        //    {
        //        fileName = i.Value.GetType().ToString();

        //        XmlSerializer xs = new XmlSerializer(typeof(Person),
        //            "http://projects.awgm.co/hindsightpeople");
        //        var ns = new XmlSerializerNamespaces();
        //        ns.Add("hsp", "http://www.w3.org/2001/XMLSchema-instance");
        //        TextWriter tw = new StreamWriter(fileName);
        //        xs.Serialize(tw, i.Value, ns);

        //        //FileStream writer = new FileStream(fileName, FileMode.Create);
        //        //DataContractSerializer ser =
        //        //    new DataContractSerializer(typeof(Person));
        //        //ser.WriteObject(writer, i);
        //        //writer.Close();

        //    }
        //}
    }
}
