namespace ICT365_A1
{
    public class Name
    {
        private static string firstName;
        private static string lastName;

        public Name()
        {
        }
        /// <summary>
        /// Constructor
        /// Stores the first name and last name passed in
        /// </summary>
        /// <param name="fName"></param>
        /// <param name="lName"></param>
        public Name(string fName, string lName)
        {
            firstName = fName;
            lastName = lName;
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        /// <summary>
        /// ToString() Override
        /// Returns the first name and last as a single string
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return firstName + " " + lastName;
        }
       


    }
    
}
