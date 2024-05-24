namespace HttpClientTest.Domain.Entity.Event
{
    public class News
    {
        public int total { get; set; }
        public Datum[] data { get; set; }


        public class Datum
        {
            public int id { get; set; }
            public string title { get; set; }
            public string description { get; set; }
            public object begin { get; set; }
            public object end { get; set; }
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
