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
        public CommandCollection LongDivide()
        {
            var body = new CommandCollection();

            body.AddExpression(DivisorHelper.Divisor + "|" + DividendHelper.Dividend);

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

                decimal currentQuotient = numberInt / DivisorHelper.Divisor;
                quotientString += currentQuotient.ToString();
                //body.AddExpression(DivisorHelper.AddIdention(0) + "-" + (DivisorHelper.Divisor * currentQuotient), true);
                //body.AddExpression(DivisorHelper.AddIdention(1) + (numberInt - (DivisorHelper.Divisor * currentQuotient)));
            }
            body.InsertExpression(0, DivisorHelper.AddIdention(0) + quotientString, true);

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
        CommandCollection LongDivide();
    }
}
