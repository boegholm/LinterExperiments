namespace LinterExperiments
{
    public class InLineGood : InLineBase
    {
        public override void InLine()
        {
            int thomasAge = 15;
            int sophieAge = 32;

            thomasAge += 2;
            thomasAge = thomasAge * 7;
            thomasAge -= 4;
            thomasAge = thomasAge / 7;
            thomasAge = thomasAge + 1;

            sophieAge += 2;
            sophieAge = sophieAge * 7;
            sophieAge -= 4;
            sophieAge = sophieAge / 7;
            sophieAge = sophieAge + 1;
        }
    }
}