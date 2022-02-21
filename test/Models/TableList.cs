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
        public IEnumerable<New> newsdtTr { get; set; }
        public IEnumerable<New> newsdtEn { get; set; }
        
        // Collaboration Language Lists
        public IEnumerable<Collaboration> collTr { get; set; }     
        public IEnumerable<Collaboration> collEn { get; set; }
        public IEnumerable<Collaboration> colldtTr { get; set; }     
        public IEnumerable<Collaboration> colldtEn { get; set; }

        // project Lists
        public IEnumerable<Project> projectTr { get; set; }
        public IEnumerable<Project> projectEn { get; set; }
         public IEnumerable<Project> projectdtTr { get; set; }
        public IEnumerable<Project> projectdtEn { get; set; }

        // Services Lists
        public IEnumerable<Service> serviceTr { get; set; }
        public IEnumerable<Service> serviceEn { get; set; }
        public IEnumerable<Service> servicedtTr { get; set; }
        public IEnumerable<Service> servicedtEn { get; set; }

        // Product Lists
        public IEnumerable<Product> productTr { get; set; }
        public IEnumerable<Product> productEn { get; set; }
        public IEnumerable<Product> productdetTr { get; set; }
        public IEnumerable<Product> productdetEn { get; set; }
         // AboutUs Lists
        public IEnumerable<AboutUs> aboutTr { get; set; }
        public IEnumerable<AboutUs> aboutEn { get; set; }




    }
}