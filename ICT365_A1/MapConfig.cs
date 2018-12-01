using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using PhoneNumbers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT365_A1
{
    public partial class MapConfig : MapForm
    {
        
        private static Dictionary<PhoneNumber, Person> peopleDictionary;
        private static Dictionary<DateTime, Event> eventDictionary;
        public static EventData eventData;
        public static PersonData personData;
        public static Dictionary<DateTime, Event> EventDictionary { get => eventDictionary; set => eventDictionary = value; }
        public static Dictionary<PhoneNumber, Person> PeopleDictionary { get => peopleDictionary; set => peopleDictionary = value; }

        public void LoadData()
        {
            EventData eventData = new EventData();
            PersonData personData = new PersonData();
            PeopleDictionary = personData.LoadPeople();
            EventDictionary = eventData.LoadEvents();

        }
        public GMapOverlay UpdateOverlays()
        {
            //3RD PARTY REFERENCE
            //http://link.awgm.co/6

            

            GMapOverlay overlay = new GMapOverlay{Id = "Markers"};

            foreach (var e in EventDictionary)
            {
                e.Value.Marker = AddEventMarker(e.Value);
                overlay.Markers.Add(e.Value.Marker);
            }
            

            foreach (var p in PeopleDictionary)
            {
                p.Value.Marker = AddPersonMarker(p.Value);
                overlay.Markers.Add(p.Value.Marker);
            }
            
            Console.WriteLine("Event Markers: "+EventDictionary.Count);
            Console.WriteLine("People Markers: "+PeopleDictionary.Count);
            Console.WriteLine("Total Markers: " + overlay.Markers.Count);

            return overlay;
        }
        public GMapMarker AddEventMarker(Event e)
        {
            double lat = e.GetLocation().Lat;
            double lon = e.GetLocation().Lng;
            Console.WriteLine("New Event Marker at "+e.Location);
            GMapMarker marker = new GMarkerGoogle(
                new PointLatLng(lat, lon),
                    GMarkerGoogleType.blue_pushpin
                )
            {
                ToolTipText = "EVENT\n\n" 
                + e.EventId + "\n" 
                + e.DateTimeStamp + "\n"
                + e.Context + "\n"
                + e.Location.ToString()
                
            };
            marker.ToolTip.Fill = Brushes.LightBlue;
            marker.ToolTip.Foreground = Brushes.DarkBlue;
            marker.ToolTip.Stroke = Pens.DarkBlue;
            marker.ToolTip.TextPadding = new Size(20, 20);
            marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker.Tag = e.EventId;

            return marker;
        }
        public GMapMarker AddPersonMarker(Person p)
        {
            double lat = p.Address.Location.Lat;
            double lon = p.Address.Location.Lng;
            Console.WriteLine("New Person Marker at: "+p.Address.Location);
            GMapMarker marker = new GMarkerGoogle(
                new PointLatLng(lat, lon),
                    //new Bitmap(p.ImagePath)
                    GMarkerGoogleType.green_big_go
                )
            {
                ToolTipText = "PERSON\n\n"
                + p.Name + "\n" 
                + p.PhoneNumber.ToString() + "\n" 
                + p.Address.Location.ToString() + "\n" 
                + p.Address.ToString()
            };
            marker.ToolTip.Fill = Brushes.DarkBlue;
            marker.ToolTip.Foreground = Brushes.LightBlue;
            marker.ToolTip.Stroke = Pens.LightBlue;
            marker.ToolTip.TextPadding = new Size(20, 20);
            marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker.Tag = p.PhoneNumber;
            
            return marker;
        }
    }
}
