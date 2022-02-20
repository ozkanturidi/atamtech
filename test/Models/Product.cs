using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace test.Models
{
    public class Product
    {
        //Product main Content
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public string photoUrl { get; set; }
        public string photoUrl2 { get; set; }
        public string photoUrl3 { get; set; }
        public string photoUrl4 { get; set; }
        public string shortdef { get; set; }


        // -------Operations-------
        public string Deploymenttime { get; set; }
        public string autonomousflight { get; set; }
        public string landingmethod { get; set; }
        public string cruisespeed { get; set; }
        public string tolerablewindspeed { get; set; }
        public string flighttime { get; set; }
        public string flightdistance { get; set; }
        public string flightspeed { get; set; }
        public string flightaltitude { get; set; }
        public string operatingtemp { get; set; }
        public string weathercond { get; set; }
        public string gcps { get; set; }


        //----HARDWARE----

        public string aircrafttype { get; set; }
        public string wingspan { get; set; }
        public string rotorsNum { get; set; }
        public string takeoffweight { get; set; }
        public string payloadweight { get; set; }
        public string telemetryrange { get; set; }



        //----Software----

        public string controlmethod { get; set; }
        public string operatingsystem { get; set; }
        public string photogrammetrysoftware { get; set; }
        public string inputfiles { get; set; }
        public string updates { get; set; }

        //-----FEATURES----
        public string dataloggingsystem { get; set; }
        public string optionalmodules { get; set; }
        public string variouspayloads { get; set; }
        public string transportCase { get; set; }

        //----------Localization

        public bool language { get; set; }


    }
}