namespace HttpClientTest.Domain.Entity.Media
{
    public class Audio
    {
        public int total { get; set; }
        public Datum[] data { get; set; }

        public class Datum
        {
            public int id { get; set; }
            public string title { get; set; }
            public object summary { get; set; }
            public string url { get; set; }
            public object file_ext { get; set; }
            public string modified { get; set; }
        }
    }
}
