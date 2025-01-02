namespace DragAndDrop
{
    public partial class FormDebug : Form
    {
        public TextBoxWriter DebugWriter { get; set; }

        public FormDebug()
        {
            InitializeComponent();
            DebugWriter = new TextBoxWriter(debugTextBox);
        }

        private void debugTextBox_DoubleClick(object sender, EventArgs e)
        {
            Console.WriteLine("Double Click Debug!");
        }
    }
}
