namespace LinterExperiments
{
    public class GodClassBad : GodClassBase
    {
        private class Candidate
        {
            public Candidate(int id, string firstName, string lastName, string address, string degree, double gpa,
                List<string> previousWorkPlaces, DateTime interviewDate, int recruiterId, string recruiterName,
                int interviewerId, string interviewerName, string interviewerRemarks, decimal currentSalary,
                decimal expectedSalary)
            {
                this.id = id;
                this.firstName = firstName;
                this.lastName = lastName;
                this.address = address;
                this.degree = degree;
                this.gpa = gpa;
                this.previousWorkPlaces = previousWorkPlaces;
                this.interviewDate = interviewDate;
                this.recruiterId = recruiterId;
                this.recruiterName = recruiterName;
                this.interviewerId = interviewerId;
                this.interviewerName = interviewerName;
                this.interviewerRemarks = interviewerRemarks;
                this.currentSalary = currentSalary;
                this.expectedSalary = expectedSalary;
            }

            int id { get; set; }
            string firstName { get; set; }
            string lastName { get; set; }
            string address { get; set; }
            string degree { get; set; }
            double gpa { get; set; }
            List<string> previousWorkPlaces { get; set; }
            DateTime interviewDate { get; set; }
            int recruiterId { get; set; }
            string recruiterName { get; set; }
            int interviewerId { get; set; }
            string interviewerName { get; set; }
            public string interviewerRemarks { get; set; }
            decimal currentSalary { get; set; }
            decimal expectedSalary { get; set; }
        }
        [BenchmarkCategory("smells")][Benchmark] public override string GetCandidateInfo()
        {
            Candidate cand1 = new Candidate(1, "Mike", "Oxlong", "SpoonerStreet 14",
                "Bachelor in Software Engineering", 4.9,
                new List<string> { "McDonalds", "Ford Motors", "Google", "Amazon", "AVK" },
                new DateTime(2022, 3, 1, 9, 0, 0), 5,
                "John Doe", 3, "Ray Pinas",
                "Mike displays a lot of potential and enthusiasm, a training period of about 3 months will be required to get him into our system, but after that he should be a great asset to the company",
                8000, 950000);

            Candidate cand2 = new Candidate(2, "Ben", "Dover", "McAlleyStreet 3",
                "Masters in Information Technology", 4.2,
                new List<string> { "Subway", "John's computer parts", "TopData" },
                new DateTime(2022, 3, 1, 11, 0, 0), 5,
                "John Doe", 3, "Ray Pinas",
                "Ben is somewhat of a ditz, he came late to the meeting and refused to answer question in favor of throwing plant water in my face, very unproffesional",
                25000, 950000);

            Candidate cand3 = new Candidate(3, "Jenny", "Tallies", "Livingway 28",
                "Bachelors in Computer Sceince", 4.6,
                new List<string> { "Markus'", "Aalborg University", "Computer World", "Amazon" },
                 new DateTime(2022, 3, 1, 13, 0, 0), 5,
                "John Doe", 7, "Wayne Kerr",
                "Jeny sems to be vry niice and an good prson (Please note that Wayne is dyslexic)",
                150000, 950000);

            return cand1.interviewerRemarks + cand2.interviewerRemarks + cand3.interviewerRemarks;
        }
    }
}