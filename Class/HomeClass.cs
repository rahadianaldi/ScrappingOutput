using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M6_EAI_Scrapping_Output.Class
{
    public class HomeClass
    {
    }

    public class Buku
    {
        public string id { get; set; }
        public string title { get; set; }
        public string price { get; set; }
        public string sold { get; set; }
        public string condition { get; set; }
        public string assurance { get; set; }
        public string weight { get; set; }
        public string seller { get; set; }
        public string description { get; set; }
    }

    public class ListBuku
    {
        public string ErrorCode { get; set; }
        public string ErrorDesc { get; set; }
        public List<Buku> buku { get; set; }
    }
}
