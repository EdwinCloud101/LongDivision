using System;
using System.Drawing;

namespace Library.TextToImage
{
    public class TextToImage : ITextToImage
    {
        public string FilePath { get; }

        private Font _font;
        private Image _image;
        private Graphics _graphics;
        private SizeF _size;

        private int _line;

        private int _x;
        private int _y;

        public void PrepareCanvas()
        {
            _line = 0;
            _x = 0;
            _y = 0;

            _font = new Font(new FontFamily("Consolas"), 36f);
            _image = new Bitmap(10, 10);
            _graphics = Graphics.FromImage(_image);
            _size = _graphics.MeasureString("a", _font);

            _image.Dispose();
            _graphics.Dispose();

            //_image = new Bitmap(Convert.ToInt32(_size.Width), Convert.ToInt32(_size.Height));
            _image = new Bitmap(Convert.ToInt32(800), Convert.ToInt32(600));
            _graphics = Graphics.FromImage(_image);
            _graphics.Clear(Color.Aquamarine);
        }

        public void AddLine(string content, bool isUnderline)
        {
            Brush textBrush = new SolidBrush(Color.Black);
            _font = new Font(new FontFamily("Consolas"), 36f, isUnderline ? FontStyle.Underline : FontStyle.Regular);

            _graphics.DrawString(content, _font, textBrush, 0, _line);
            _line += 60;
            _graphics.Save();
            textBrush.Dispose();
        }

        public void AddWord(string content, bool isUnderline)
        {
            Brush textBrush = new SolidBrush(Color.Black);
            _font = new Font(new FontFamily("Consolas"), 36f, isUnderline ? FontStyle.Underline : FontStyle.Regular);
            _graphics.DrawString(content, _font, textBrush, _x, _y);
            _x += 160;
            _graphics.Save();
            textBrush.Dispose();
        }

        public void BreakLine()
        {
            _y += 60;
            _x = 0;
        }

        public void Save()
        {
            _graphics.Dispose();
            _image.Save(FilePath);
        }

        public TextToImage(string filePath)
        {
            FilePath = filePath;
        }
    }
    public interface ITextToImage
    {
        string FilePath { get; }
        void PrepareCanvas();
        void AddLine(string content, bool isUnderline);
        void AddWord(string content, bool isUnderline);
        void BreakLine();
        void Save();
    }
}
