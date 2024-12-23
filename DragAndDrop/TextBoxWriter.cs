using System.Text;

namespace DragAndDrop
{
    public class TextBoxWriter : TextWriter
    {
        private readonly TextBox _textBox;

        public override Encoding Encoding => Encoding.UTF8;
           
        public TextBoxWriter(TextBox textBox)
        {
            _textBox = textBox;
        }

        public override void Write(string? value)
        {
            try
            {
                if (_textBox.InvokeRequired)
                {
                    _textBox.Invoke(new Action<string?>(Write), value);
                }
                else
                {
                    _textBox.AppendText(value);
                }
            }
            catch (ObjectDisposedException)
            {
                return;
            }
        }

        public override void WriteLine(string? value)
        {
            try
            {
                if (_textBox.InvokeRequired)
                {
                    _textBox.Invoke(new Action<string?>(WriteLine), value);
                }
                else
                {
                    _textBox.AppendText(value + Environment.NewLine);
                }
            }
            catch (ObjectDisposedException)
            {
                return;
            }
        }
    }
}
