namespace DfindTest.Main
{
    public class ProblemB
    {
        public static int GetRemovingCandlesCount(int D, int R, int T)
        {
            int result = (R - T - D + 1) / 2;

            return result;
        }
    }
}
