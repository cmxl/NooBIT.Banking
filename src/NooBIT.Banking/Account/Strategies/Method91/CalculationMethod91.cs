using System.Collections.Generic;

namespace NooBIT.Banking.Account.Strategies
{
    public class CalculationMethod91 : CalculationMethod
    {
        private static readonly int _checkDigitIndex = 6;

        public CalculationMethod91()
        {
            _calculationStrategies = new List<CalculationStrategy>
            {
                new Method91CalculationStrategy1(),
                //new Method91CalculationStrategy2(),
                //new Method91CalculationStrategy3(),
                //new Method91CalculationStrategy4()
            };
        }

        private readonly List<CalculationStrategy> _calculationStrategies;

        public override bool Validate(int[] numbers)
        {
            foreach (var strategy in _calculationStrategies)
            {
                var checkDigit = strategy.Calculate(numbers);
                if (checkDigit == numbers[_checkDigitIndex])
                    return true;
            }

            return false;
        }
    }
}
