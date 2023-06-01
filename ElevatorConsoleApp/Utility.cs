namespace ElevatorConsoleApp
{
    public static class Utility
    {
        public static int GetInputNumber(string inputValue, int defaultValue)
        {
            return inputValue != null ? Convert.ToInt32(inputValue) : defaultValue;
        }

    }
}
