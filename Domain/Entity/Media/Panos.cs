namespace HttpClientTest.Domain.Entity.Media;

public class Panos
{
    public int total { get; set; }
    public Datum[] data { get; set; }

    public class Datum
    {
        public int id { get; set; }
        public string title { get; set; }
        public string url { get; set; }
        public string modified { get; set; }
    }
}

