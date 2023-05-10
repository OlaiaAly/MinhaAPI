using System.Collections.Generic;

namespace MinhaAPI.Data.Models
{
    public class CountryModel
    {
       
        public Name name { get; set; }
        public string[] capital { get; set; }
        public string region { get; set; }
        public string subregion { get; set; }
        public float area { get; set; }
        public string[] timezones { get; set; }
        public Flags flags { get; set; }
    }

}