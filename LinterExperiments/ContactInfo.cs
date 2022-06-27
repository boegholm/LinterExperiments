namespace LinterExperiments
{
    public class ContactInfo
    {
        private string streetName = "Frederik Bajers Vej";
        private string city = "Aalborg";
        private string state = "Jylland";
        private string zip = "9000";
        private string country = "Danmark";

        public string Country
        {
            get => country;
            set => country = value;
        }

        public string Zip
        {
            get => zip;
            set => zip = value;
        }

        public string State
        {
            get => state;
            set => state = value;
        }

        public string City
        {
            get => city;
            set => city = value;
        }

        public string StreetName
        {
            get => streetName;
            set => streetName = value;
        }
    }
}