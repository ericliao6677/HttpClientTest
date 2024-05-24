namespace HttpClientTest.Domain.Entity.Event
{
    public class Activity
    {

        public int total { get; set; }
        public Datum[] data { get; set; }


        public class Datum
        {
            public string distric { get; set; }
            public string address { get; set; }
            public string nlat { get; set; }
            public string elong { get; set; }
            public string organizer { get; set; }
            public string co_rganizer { get; set; }
            public string contact { get; set; }
            public string tel { get; set; }
            public string fax { get; set; }
            public string ticket { get; set; }
            public string traffic { get; set; }
            public string parking { get; set; }
            public int id { get; set; }
            public string title { get; set; }
            public string description { get; set; }
            public string begin { get; set; }
            public string end { get; set; }
            public string posted { get; set; }
            public string modified { get; set; }
            public string url { get; set; }
            public File[] files { get; set; }
            public Link[] links { get; set; }
        }

        public class File
        {
            public string src { get; set; }
            public string subject { get; set; }
            public string ext { get; set; }
        }

        public class Link
        {
            public string src { get; set; }
            public string subject { get; set; }
        }

    }
}
