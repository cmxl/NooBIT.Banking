using Xunit;

namespace NooBIT.Banking.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("2974118000")]
        [InlineData("5281741000")]
        [InlineData("9952810000")]
        public void Test1(string kontonummer)
        {
            var definition = "AA00";
            var blz = "12345678";
            var validator = new IBANValidator();
            var valid = validator.Validate(definition + blz + kontonummer);
            Assert.True(valid);
        }
    }
}
