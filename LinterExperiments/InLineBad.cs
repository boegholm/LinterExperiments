namespace LinterExperiments
{
    public class InLineBad : InLineBase
    {

        private int WackyComputations(int age)
        {
            age += 2;
            age = age * 7;
            age -= 4;
            age = age / 7;
            age = age + 1;

            return age;
        }

        public override void InLine()
        {
            int thomasAge = 15;
            int sophieAge = 32;

            thomasAge = WackyComputations(thomasAge);
            sophieAge = WackyComputations(sophieAge);
        }
    }
}