﻿namespace LinterExperiments
{
    public class SelfAssignmentGood : SelfAssignmentBase
    {
        public override string SelfAssignment()
        {
            string a = "";
            string x = "Played College Ball you know ";
            string y = "Could have gone pro if I hadn't joined the navy ";
            string z = "Nanomachines Son ";


            a = z;

            return a + x + y + z;
        }
    }
}