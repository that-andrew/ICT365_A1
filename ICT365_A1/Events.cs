using GeoCoordinatePortable;
using GMap.NET;
using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Drawing;


namespace ICT365_A1
{
    public class Event
    {
        public string EventId { get; set; }

        private PointLatLng location;

        public PointLatLng GetLocation()
        {
            return location;
        }
        public void SetLocation(PointLatLng value)
        {
            location = value;
        }
        public DateTime DateTimeStamp { get; set; }
        public string Context { get; set; }
        public Object ContextData { get; set; }
        public GMapMarker Marker { get; set; }
        public PointLatLng Location { get => location; set => location = value; }
        public Event GetEvent()
        {
            return this;
        }
        public override string ToString()
        {
            string eventstring = "";

                eventstring = $"Event ID: {EventId}Date/Time: {DateTimeStamp}Context: {Context}Location: " + GetLocation();

            return eventstring;
        }
        public void NewImageEvent(XElement element)
        {
            Console.WriteLine("Adding Image Event");
            Console.WriteLine(element.Elements());

        }
        public void NewVideoEvent(XElement element)
        {
            Console.WriteLine("Adding Video Event");
            Console.WriteLine(element.Elements());

        }
        public void NewTrackEvent(XElement element)
        {
            Console.WriteLine("Adding Track Event");
            Console.WriteLine(element.Elements());

        }
        public void NewTwitterEvent(XElement element)
        {
            Console.WriteLine("Adding Twitter Event");
            Console.WriteLine(element.Elements());

        }
        public void NewFacebookEvent(XElement element)
        {
            Console.WriteLine("Adding Facebook Event");
            Console.WriteLine(element.Elements());

        }
        public class ImageEvent : Event
        {
            private Image image;

            public ImageEvent(Image i)
            {
                this.image = i;
                this.image.Save(this.EventId + ".jpeg");

            }
            public Image GetImage()
            {
                return image;
            }
            public void SetImage(Image i)
            {
                this.image = i;
                this.image.Save(this.EventId + ".jpeg");
            }
        }
        public class VideoEvent : Event
        {
            private Uri videoPath;

            public VideoEvent(string p)
            {
                videoPath = new Uri(p);
            }
            public Uri GetVideo()
            {
                return videoPath;
            }
            public void SetVideo(Uri u)
            {
                videoPath = u;
            }
        }
        public class TrackEvent : Event
        {
            private PointLatLng start;
            private PointLatLng end;

            public TrackEvent(PointLatLng s, PointLatLng e)
            {
                start = s;
                end = e;
            }
        }
        public class TwitterEvent : Event
        {

        }
        public class FacebookEvent : Event
        {

        }
    }


}   
