using DragAndDrop.Enums;
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
    public partial class FormPropertyEdit : Form
    {
        public string? PropertyName;
        public string? DataType;
        public AccessModifier? Modifier = new AccessModifier();

        public FormPropertyEdit()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxName.Text))
            {
                errorProvider.SetError(textBoxName, "Name is required!");
                return;
            }

            if (string.IsNullOrEmpty(textBoxDataType.Text))
            {
                errorProvider.SetError(textBoxDataType, "Data type is required!");
                return;
            }

            if (comboBox.SelectedItem == null)
            {
                errorProvider.SetError(comboBox, "Access modifier is required!");
                return;
            }

            PropertyName = textBoxName.Text;
            DataType = textBoxDataType.Text;
            Modifier = (AccessModifier)comboBox.SelectedIndex;
            DialogResult = DialogResult.OK;

            this.Close();
        }

        private void FormPropertyEdit_Load(object sender, EventArgs e)
        {
            errorProvider.SetIconPadding(textBoxName, 5);
        }
    }
}
