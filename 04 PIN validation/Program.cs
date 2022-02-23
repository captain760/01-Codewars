namespace _04_PIN_validation
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    public class Kata
    {
        public static bool ValidatePin(string pin)
        {
            bool isValid = true;
            if (pin.Length != 4 && pin.Length != 6) return false;
            else
            {

                for (int i = 0; i < pin.Length; i++)
                {
                    if ((int)pin[i] <= 47 || (int)pin[i] >= 58)
                    {
                        isValid = false;
                        break;
                    }
                }
            }
            return isValid;

        }
    }
}
