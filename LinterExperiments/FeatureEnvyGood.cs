namespace LinterExperiments
{
    public class FeatureEnvyGood : FeatureEnvyBase
    {
        private string city = "Aalborg";
        private string state = "Jylland";
        private string streetName = "Frederik Bajers Vej";
        public string zip = "9000";
        public string country = "Danmark";

        public override string GetFullAddress()
        {
            return streetName + ";" + city + ";" + zip + ";" + state + ";" + country;
        }

    }
}