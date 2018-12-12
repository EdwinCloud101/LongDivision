using System;
using System.Collections.Generic;
using System.Text;

namespace Library.TextToImage
{
    public class PrettyCommand : IPrettyCommand
    {
        public string NoUnderlineForSpace(string raw)
        {
            //
        }
    }


    /// <summary>
    /// Enhance command view
    /// </summary>
    public interface IPrettyCommand
    {
        string NoUnderlineForSpace(string raw);
    }
}
