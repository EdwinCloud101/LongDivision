namespace Library
{
    public class DividendHelper : IDividendHelper
    {
        public int Dividend { get; }
        public int GetCharacters()
        {
            return Dividend.ToString().Length;
        }

        public string AddIdention(int plusThis)
        {
            return CommonHelper.AddText("_", this.GetCharacters() + plusThis);
        }

        public DividendHelper(int dividend)
        {
            Dividend = dividend;
        }
    }

    public interface IDividendHelper
    {
        int Dividend { get; }
        int GetCharacters();
        string AddIdention(int plusThis);
    }
}
