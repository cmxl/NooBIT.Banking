using NooBIT.Banking.Extensions;
using NooBIT.Banking.Account.Strategies;
using System.Linq;

namespace NooBIT.Banking
{
    public class IBANValidator
    {
        public bool Validate(string iban)
        {
            var (definition, rest) = iban.SplitAt(4);
            var (bankleitzahl, kontonummer) = rest.SplitAt(8);

            return ValidateInternal(definition, bankleitzahl, kontonummer);
        }

        private bool ValidateInternal(string definition, string bankleitzahl, string kontonummer)
        {
            var method = GetCalculationMethod(bankleitzahl);
            var numbers = kontonummer.Select(x => x - 48).ToArray();
            return method.Validate(numbers);
        }

        private CalculationMethod GetCalculationMethod(string bankleitzahl) => new CalculationMethod91();
    }
}
