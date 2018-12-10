using System;

namespace Library
{
    public class QuotientHelper : IQuotientHelper
    {
        public IDividendHelper DividendHelper { get; }
        public IDivisorHelper DivisorHelper { get; }
        public decimal Quotient { get; private set; }
        public void Divide()
        {
            Quotient = Convert.ToDecimal(Convert.ToDecimal(DividendHelper.Dividend.ToString()) / Convert.ToDecimal(DivisorHelper.Divisor.ToString()));
        }

        public QuotientHelper(IDividendHelper dividendHelper, IDivisorHelper divisorHelper)
        {
            DividendHelper = dividendHelper;
            DivisorHelper = divisorHelper;
            this.Divide();
        }
    }

    public interface IQuotientHelper
    {
        IDividendHelper DividendHelper { get; }
        IDivisorHelper DivisorHelper { get; }
        decimal Quotient { get; }
        void Divide();
    }
}
