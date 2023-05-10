using System.Collections.Generic;

namespace MinhaAPI.Data.Models
{

    public class  Name
    {
        public string common { get; set; }
        public string official { get; set; }
        public Nativename nativename { get; set; }
    }

    public class Nativename
    {
        public Fra fra { get; set; }
        public Run run { get; set; }
    }


    public class Run
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Fra
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Flags
    {
        public string png { get; set; }
        public string svg { get; set; }
        public string alt { get; set; }
    }



}