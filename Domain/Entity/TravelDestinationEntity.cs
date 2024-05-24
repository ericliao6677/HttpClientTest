namespace HttpClientTest.Domain.Entity
{
    public class TravelDestinationEntity
    {


        public int total { get; set; }
        public Datum[] data { get; set; }

        public class Datum
        {
            public int id { get; set; }
            public string name { get; set; }
            public object name_zh { get; set; }
            public int open_status { get; set; }
            public string introduction { get; set; }
            public string open_time { get; set; }
            public string zipcode { get; set; }
            public string distric { get; set; }
            public string address { get; set; }
            public string tel { get; set; }
            public string fax { get; set; }
            public string email { get; set; }
            public string months { get; set; }
            public float nlat { get; set; }
            public float elong { get; set; }
            public string official_site { get; set; }
            public string facebook { get; set; }
            public string ticket { get; set; }
            public string remind { get; set; }
            public string staytime { get; set; }
            public string modified { get; set; }
            public string url { get; set; }
            public Category[] category { get; set; }
            public Target[] target { get; set; }
            public Service[] service { get; set; }
            public Friendly[] friendly { get; set; }
            public Image[] images { get; set; }
            public object[] files { get; set; }
            public Link[] links { get; set; }
        }

        public class Category
        {
            public int id { get; set; }
            public string name { get; set; }
        }

        public class Target
        {
            public int id { get; set; }
            public string name { get; set; }
        }

        public class Service
        {
            public int id { get; set; }
            public string name { get; set; }
        }

        public class Friendly
        {
            public int id { get; set; }
            public string name { get; set; }
        }

        public class Image
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
