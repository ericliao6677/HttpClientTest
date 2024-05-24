namespace HttpClientTest.Domain.Entity.Event
{
    public class Calendar
    {

        public int total { get; set; }
        public Datum[] data { get; set; }

        public class Datum
        {
            public string distric { get; set; }
            public string address { get; set; }
            public string nlat { get; set; }
            public string elong { get; set; }
            public string tel { get; set; }
            public string fax { get; set; }
            public string ticket { get; set; }
            public string traffic { get; set; }
            public string parking { get; set; }
            public bool is_major { get; set; }
            public int id { get; set; }
            public string title { get; set; }
            public string description { get; set; }
            public string begin { get; set; }
            public string end { get; set; }
            public string posted { get; set; }
            public string modified { get; set; }
            public string url { get; set; }
            public object[] files { get; set; }
            public object[] links { get; set; }
        }

    }
}
