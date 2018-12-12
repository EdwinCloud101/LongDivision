using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class CommandExport : ICommandExport
    {
        private readonly CommandCollection _commandList;

        public void ExportToImage(string filePath)
        {
            ITextToImage textToImage = new TextToImage(filePath);
            textToImage.PrepareCanvas();

            string content = "";

            foreach (var item in _commandList)
            {
                textToImage.AddWord(item.Expression + Environment.NewLine, item.IsUnderline);
                textToImage.BreakLine();
            }

            textToImage.Save();
        }

        public CommandExport(CommandCollection commandCollection)
        {
            _commandList = commandCollection;
        }
    }

    public interface ICommandExport
    {
        void ExportToImage(string filePath);
    }
}
