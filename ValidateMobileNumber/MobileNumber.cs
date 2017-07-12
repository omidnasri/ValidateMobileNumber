using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ValidateMobileNumber
{
    [TestClass]
    public class MobileNumber
    {
        private const string Pattern = @"^((((\+989)|(00989))|(09)|(989))(10|11|12|13|14|15|16|17|18|19|20|21|30|31|32|33|34|35|36|37|38|39|90))(\d{7})$";

        [TestMethod]
        [DataRow("09123456789")]
        [DataRow("989123456789")]
        [DataRow("+989123456789")]
        [DataRow("00989123456789")]
        public void ValidationMobileNumber(string value)
        {
            Assert.IsTrue(Regex.IsMatch(input: value, pattern: Pattern));
        }

        [TestMethod]
        [DataRow("091234567890")]
        [DataRow("989773456789")]
        [DataRow("+989773456789")]
        [DataRow("00989773456789")]
        public void ThrowExceptionNotValidationMobileNumber(string value)
        {
            Assert.IsFalse(Regex.IsMatch(input: value, pattern: Pattern));
        }
    }
}
