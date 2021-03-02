using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_project
{
    class Address
    {
        private string fulladdress;

        private string roadNo;

        public string RoadNo
        {
            get { return roadNo; }
            set { roadNo = value; }
        }

        private string houseNo;

        public string HouseNo
        {
            get { return houseNo; }
            set { houseNo = value; }
        }

        private string city;

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        private string country;

        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        public Address() { }
        public Address(string roadNo, string houseNo, string city, string country)
        {
            this.roadNo = roadNo;
            this.houseNo = houseNo;
            this.city = city;
            this.country = country;
        }

        public string GetAddress()
        {
            fulladdress = "Road# " + roadNo + "\nHouse# " + houseNo + "\nCity: " + city + "\nCountry: " + country;
            return fulladdress;
        }
    }
}
