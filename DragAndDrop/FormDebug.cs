using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
