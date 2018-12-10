using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;
using NUnit.Framework;

namespace Console.Tests
{
    [TestFixture]
    public class LongDivisionTests
    {
        [Test]
        public void TextToImageTest()
        {
            ITextToImage textToImage = new TextToImage(@"D:\Temp\1.png");
            textToImage.Draw("Edwin");
        }

        [Test]
        public void Test1()
        {
            IDividendHelper dividendHelper = new DividendHelper(137);
            IDivisorHelper divisorHelper = new DivisorHelper(2);
            IQuotientHelper quotientHelper = new QuotientHelper(dividendHelper,divisorHelper);

            ILongDivision longDivision = new LongDivision(quotientHelper);
            List<string> divisionBody = longDivision.LongDivide();

            ICommandExport export = new CommandExport(divisionBody);
            export.ExportToImage(@"D:\Temp\2.png");

            Assert.IsTrue(divisionBody.Count > 2);
        }
    }
}
