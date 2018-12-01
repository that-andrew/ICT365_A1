using GMap.NET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using PhoneNumbers;
using GMap.NET.WindowsForms;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace ICT365_A1
{

    
    public class Person
    {
        //Private Variables
        private Name name;
        private PhoneNumber phoneNumber;
        private Address address;
        private GMapMarker marker;
        private string imagePath;

        //Public Variables
        public PhoneNumber PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public Address Address { get => address; set => address = value; }
        public Name Name { get => name; set => name = value; }
        public string ImagePath { get => imagePath; set => imagePath = value; }
        public GMapMarker Marker { get => marker; set => marker = value; }

        /// <summary>
        /// Initialise the Persons Variables
        /// </summary>
        public Person()
        {
            
            name = new Name();
            address = new Address();
            phoneNumber = new PhoneNumber();
            imagePath = "";
        }
        /// <summary>
        /// ToString() Override
        /// Returns the persons Name and Phone Number as a single string.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            
            return this.name.ToString() + " " + this.phoneNumber.ToString();
        }
        /// <summary>
        /// Boolean Phone number validation method for checking Phone Numbers
        /// </summary>
        /// <param name="p"></param>
        /// <returns name="Valid">Boolean</returns>
        private Boolean IsValidPh(PhoneNumber p)
        {
            //Assumed invalid until proven otherwise
             
            //Fresh instance of PhoneNumberUtil
            var phUtil = PhoneNumberUtil.GetInstance();
            //
            if (phUtil.IsValidNumber(p))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Method to recieve a Phone Number as a string,
        /// Validate it, and if Valid, store it.
        /// </summary>
        /// <param name="ph">string</param>
        public Boolean ValidatePhoneNumber(string ph)
        {
            var phUtil = PhoneNumberUtil.GetInstance();
            PhoneNumber newPh = new PhoneNumber();
            
            try
            {
               newPh = phUtil.Parse(ph, "AU");
            }
            catch (NumberParseException e)
            {
                throw e;
            }
            if (phUtil.IsValidNumber(newPh))
            {
                phoneNumber = newPh;
                return true;
            }
            return false;

        }





    }
}
