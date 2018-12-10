using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class LongDivision : ILongDivision
    {
        public IDividendHelper DividendHelper { get; }
        public IDivisorHelper DivisorHelper { get; }
        public IQuotientHelper QuotientHelper { get; }
        public List<string> LongDivide()
        {
            var body = new List<string>();

            body.Add(DivisorHelper.AddIdention(1) + DividendHelper.AddIdention(1));
            body.Add(DivisorHelper.Divisor + "|" + DividendHelper.Dividend);

            string numberString = "";
            int numberInt = 0;
            string quotientString = "";

            foreach (var item in DividendHelper.Dividend.ToString())
            {
                string currentCommand = "";
                numberString += item.ToString();
                numberInt = Convert.ToInt32(numberString);

                if (DivisorHelper.Divisor > numberInt)
                {
                    quotientString += "0";
                    continue;
                }

                int currentQuotient = numberInt / DivisorHelper.Divisor;
                quotientString += currentQuotient.ToString();
                body.Add(DivisorHelper.AddIdention(0) + "-" + (DivisorHelper.Divisor * currentQuotient));
                body.Add(DivisorHelper.AddIdention(0) + "___");
                body.Add(DivisorHelper.AddIdention(0) + (numberInt- (DivisorHelper.Divisor * currentQuotient)));
            }

            return body;
        }

        public LongDivision(IQuotientHelper quotientHelper)
        {
            DividendHelper = quotientHelper.DividendHelper;
            DivisorHelper = quotientHelper.DivisorHelper;
            QuotientHelper = quotientHelper;
        }
    }

    public interface ILongDivision
    {
        IDividendHelper DividendHelper { get; }
        IDivisorHelper DivisorHelper { get; }
        IQuotientHelper QuotientHelper { get; }
        List<string> LongDivide();
    }
}
