using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Command
    {
        public string Expression { get; set; }
        public bool IsUnderline { get; set; }
    }

    public class CommandCollection : List<Command>
    {
        public void InsertExpression(int index, string content, bool isUnderline)
        {
            var newCommand = new Command();
            newCommand.Expression = content;
            newCommand.IsUnderline = isUnderline;
            this.Insert(index, newCommand);
        }

        public void InsertExpression(int index, string content)
        {
            this.InsertExpression(index, content, false);
        }


        public void AddExpression(string content, bool isUnderline)
        {
            var newCommand = new Command();
            newCommand.Expression = content;
            newCommand.IsUnderline = isUnderline;
            this.Add(newCommand);
        }

        public void AddExpression(string content)
        {
            this.AddExpression(content, false);
        }
    }
}
