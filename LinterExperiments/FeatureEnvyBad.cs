﻿namespace LinterExperiments
{
    class FeatureEnvyBad : FeatureEnvyBase
    {
        private ContactInfo _contactInfo;

        public FeatureEnvyBad(ContactInfo contactInfo)
        {
            _contactInfo = contactInfo;
        }
        [BenchmarkCategory("smells")][Benchmark] public override string GetFullAddress()
        {
            return _contactInfo.StreetName + ";" + _contactInfo.City + "," + _contactInfo.Zip + ";" + _contactInfo.State + ";" + _contactInfo.Country;
        }
    }
}