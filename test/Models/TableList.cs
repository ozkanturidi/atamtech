using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace test.Models
{
    public class TableList
    {
       
        /// News Language Lists
        public IEnumerable<New> newsTr { get; set; }
        public IEnumerable<New> newsEn { get; set; }
        
        // Collaboration Language Lists
        public IEnumerable<Collaboration> collTr { get; set; }     
        public IEnumerable<Collaboration> collEn { get; set; }

        // project Lists
        public IEnumerable<Project> projectTr { get; set; }
        public IEnumerable<Project> projectEn { get; set; }

        // Services Lists
        public IEnumerable<Service> serviceTr { get; set; }
        public IEnumerable<Service> serviceEn { get; set; }

        // Product Lists
        public IEnumerable<Product> productTr { get; set; }
        public IEnumerable<Product> productEn { get; set; }
         // AboutUs Lists
        public IEnumerable<AboutUs> aboutTr { get; set; }
        public IEnumerable<AboutUs> aboutEn { get; set; }

        public IEnumerable<HomePage> HomepageTr { get; set; }
        public IEnumerable<HomePage> HomepageEn { get; set; }


    }
}