using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace test.Models
{
    public class ProductandNew
    {
        public IEnumerable<New> NewSlidTr { get; set; }
        public IEnumerable<New> NewSlidEn { get; set; }

        public IEnumerable<Product> PrdcardTr { get; set; }
        public IEnumerable<Product> PrdcardEn { get; set; }

        public IEnumerable<HomePage> HomePageEng { get; set; }
        public IEnumerable<HomePage> HomePageTr { get; set; }

    }
}