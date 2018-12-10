using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Library
{
    public class TextToImage : ITextToImage
    {
        public string FilePath { get; }
        public void Draw(string content)
        {
            Font font = new Font(new FontFamily("Consolas"), 36f);

            Image image = new Bitmap(10, 10);
            Graphics graphics = Graphics.FromImage(image);
            SizeF size = graphics.MeasureString(content, font);

            image.Dispose();
            graphics.Dispose();

            image = new Bitmap(Convert.ToInt32(size.Width), Convert.ToInt32(size.Height));
            graphics = Graphics.FromImage(image);
            graphics.Clear(Color.Aquamarine);

            Brush textBrush = new SolidBrush(Color.Black);
            graphics.DrawString(content,font,textBrush,0,0);
            graphics.Save();

            textBrush.Dispose();
            graphics.Dispose();

            image.Save(FilePath);
        }

        public TextToImage(string filePath)
        {
            FilePath = filePath;
        }
    }
    public interface ITextToImage
    {
        string FilePath { get; }
        void Draw(string content);
    }
}
