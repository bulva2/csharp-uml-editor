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
    public partial class FormRename : Form
    {
        private Canvas _canvas { get; set; }
        public string? ObjName { get; set; }

        private string _windowName { get; set; }
        private string _title { get; set; }

        public FormRename(Canvas canvas, string windowName, string title)
        {
            _windowName = windowName;
            _canvas = canvas;
            _title = title;
            InitializeComponent();

            // Always lovely to find .NET Forms bug that has been part of the framework since 2015
            // https://stackoverflow.com/questions/27633483/my-windows-form-keeps-on-shrinking-resizing-on-build
            this.ControlBox = false;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxName.Text))
            {
                errorProvider.SetError(textBoxName, "Name cannot be empty!");
                return;
            }

            if (_canvas.DoesBoxNameExist(textBoxName.Text))
            {
                errorProvider.SetError(textBoxName, "Name already in use!");
                return;
            }

            ObjName = textBoxName.Text;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FormRename_Load(object sender, EventArgs e)
        {
            this.Text = _windowName;

            labelTitle.Text = _title;
            errorProvider.SetIconPadding(textBoxName, 5);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
