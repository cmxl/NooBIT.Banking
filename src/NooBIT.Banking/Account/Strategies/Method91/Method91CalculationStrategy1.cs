namespace NooBIT.Banking.Account.Strategies
{
    public class Method91CalculationStrategy1 : CalculationStrategy
    {
        private const int CHECKDIGIT_INDEX = 6;
        private const int MODULO = 11;

        public override int Calculate(int[] numbers)
        {
            var sum = 0;
            for (var i = 0; i < CHECKDIGIT_INDEX; i++)
            {
                sum += numbers[i] * (CHECKDIGIT_INDEX + 1 - i);
            }

            var mod = sum % MODULO;
            var checkDigit = MODULO - mod;

            if (checkDigit == 10 || mod == 0)
                return 0;

            return checkDigit;
        }
    }
}
