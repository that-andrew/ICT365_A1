using GMap.NET;

namespace ICT365_A1
{
    public class Address
    {
        private string number;
        private string street;
        private string city;
        private string state;
        private string country;
        private string postCode;
        private PointLatLng location;

        public string Number { get => number; set => number = value; }
        public string Street { get => street; set => street = value; }
        public string City { get => city; set => city = value; }
        public string State { get => state; set => state = value; }
        public string Country { get => country; set => country = value; }
        public string PostCode { get => postCode; set => postCode = value; }
        public PointLatLng Location { get => location; set => location = value; }

        /// <summary>
        /// ToString() Override
        /// Combines all the individual elements of the street address
        /// into a single string
        /// </summary>
        /// <returns name="addressString"></returns>
        public override string ToString()
        {
            string addressString = "";
            addressString =
                number + " " +
                street + " " +
                city + " " +
                country + " " +
                postCode + " ";
            return addressString;
        }

        
        
        





    }
    
}
