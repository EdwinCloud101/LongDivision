using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class DivisorHelper : IDivisorHelper
    {
        public int Divisor { get; }
        public int GetCharacters()
        {
            return Divisor.ToString().Length;
        }

        public string AddIdention(int plusThis)
        {
            return this.AddIdention(plusThis, " ");
        }

        public string AddIdention(int plusThis, string useThis)
        {
            return CommonHelper.AddText(useThis, this.GetCharacters() + plusThis);
        }

        public DivisorHelper(int divisor)
        {
            Divisor = divisor;
        }
    }

    public interface IDivisorHelper
    {
        int Divisor { get; }
        int GetCharacters();
        string AddIdention(int plusThis);
        string AddIdention(int plusThis,string useThis);
    }
}
