using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class CommandExport : ICommandExport
    {
        private readonly List<string> _commandList;

        public void ExportToImage(string filePath)
        {
            string content = "";

            foreach (var item in _commandList)
            {
                content += item + Environment.NewLine;
            }

            ITextToImage textToImage = new TextToImage(filePath);
            textToImage.Draw(content);
        }

        public CommandExport(List<string> commandList)
        {
            _commandList = commandList;
        }
    }

    public interface ICommandExport
    {
        void ExportToImage(string filePath);
    }
}
