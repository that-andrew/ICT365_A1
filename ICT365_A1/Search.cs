using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT365_A1
{
    public class Search : MapConfig
    {
        /// <summary>
        /// Recieves the search string (searchTerm)
        /// loads the current Event Dictionary
        /// Creates a new Dictionary for the matches
        /// assesses the searchTerm string for the most suitable 
        /// aspect of the event to search for a match
        /// </summary>
        /// <param name="searchTerm"></param>
        public static List<Event> NewSearch(string searchTerm)
        {
            List<Event> stringResults = new List<Event>();
            Dictionary<DateTime, Event> resultsList = new Dictionary<DateTime, Event>();
            Console.WriteLine("Starting new search for: \""+searchTerm+"\"");

            if (DateTime.TryParse(searchTerm,out DateTime result))
            {
                resultsList = SearchByDate(searchTerm,resultsList);
                stringResults = ResultsListString(resultsList);
            }
            return stringResults;
        }
        /// <summary>
        /// Searches the current events based on the recieved string
        /// (dateTimeStamp) and adds it to the results list
        /// </summary>
        /// <param name="searchTerm"></param>
        private static Dictionary<DateTime, Event> SearchByDate(string searchTerm, Dictionary<DateTime, Event> rl)
        {
            DateTime searchDateTime;
            var foundEvent = new Event();
            searchDateTime = DateTime.Parse(searchTerm);

            if (EventDictionary.TryGetValue(searchDateTime, out foundEvent))
            {
                rl.Add(searchDateTime, foundEvent);
            }
            return rl;
        }

        /// <summary>
        /// Creates a list of the events in the resultsList Dictionary
        /// </summary>
        /// <returns name="List<Event>"></returns>
        public static List<Event> ResultsListString(Dictionary<DateTime, Event> rl)
        {
            List<Event> sr = new List<Event>();
            foreach ( var i in rl)
            { 
                sr.Add(i.Value);
            }
            return sr;
        }

    }
}
