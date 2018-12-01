using GeoCoordinatePortable;
using GMap.NET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ICT365_A1
{
    public class EventData : MapConfig
    {
        //private static Dictionary<DateTime, Event> events;
        //public Dictionary<DateTime, Event> EventDictionary { get => events; set => events = value; }

        public Dictionary<DateTime, Event> LoadEvents()
        {
            Dictionary<DateTime, Event> e = new Dictionary<DateTime, Event>();
            Console.WriteLine("Loading Event Dictionary Dictionary From File...");
            int totalItems = 0;
            XNamespace hse = "http://projects.awgm.co/hindsightevents";
            XElement eventsDoc = XElement.Load(@"hindsight-events.xml");

            foreach (var i in eventsDoc.Descendants(hse+"Event"))
            {
                //Console.WriteLine(item);
                totalItems++;
                string dateString = "";
                Event ne = new Event();
                PointLatLng loc = new PointLatLng();
                //Console.WriteLine("Loaded " + i.Name.LocalName +" "+ i.Element(hse + "eventid").Value);

                ne.EventId = i.Element(hse+"eventid").Value;
                loc.Lat = (double)i.Element(hse + "location").Element(hse + "lat");
                loc.Lng = (double)i.Element(hse + "location").Element(hse + "long");
                ne.SetLocation(loc);
                dateString = i.Element(hse + "datetimestamp").Value;
                ne.DateTimeStamp = DateTime.Parse(dateString,System.Globalization.CultureInfo.InvariantCulture);
                ne.Context = (string)i.Element(hse + "context").FirstAttribute.Value;
                ne.ContextData = i.Element(hse + "context");
                e.Add(ne.DateTimeStamp, ne);
                
                //Console.WriteLine("Event ID: " + processEvent.EventId);
                //Console.WriteLine("Location: " + processEvent.GetLocation());
                //Console.WriteLine("Date/Time Stamp: " + processEvent.DateTimeStamp);
                //Console.WriteLine("Context: " + processEvent.Context);
                //Console.WriteLine("Context Data: " + processEvent.ContextData);
            }
            Console.WriteLine("Total of "+totalItems +" events loaded.");
            return e;
        }
        public Dictionary<DateTime, Event> AddEvent(Event newEvent, Dictionary<DateTime, Event> e)
        {
            e.Add(newEvent.DateTimeStamp, newEvent);
            Console.WriteLine("New Event Added: " + newEvent.DateTimeStamp);

            return e;
        }

        public void SearchEvent(string searchQuery)
        {
            int searchResults = 0;
            Console.WriteLine("Searching EventDictionary...");

            Console.WriteLine("Search Completed.");
            Console.WriteLine("Found " + searchResults + " Matching Events");
        }
        
    }

}
