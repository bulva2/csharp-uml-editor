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
	public partial class FormMethodAdder : Form
	{
		public string? methodName;
		public string? returnType;
		public string? arguments;
		public AccessModifier? modifier = new AccessModifier();
		public FormMethodAdder()
		{
			InitializeComponent();
		}

		private void method_cancelB_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void method_addB_Click(object sender, EventArgs e)
		{
			methodName = method_nameTB.Text;
			returnType = method_returnTypeTB.Text;
			arguments = method_argsTB.Text;
			modifier = (AccessModifier)method_accessModifierCB.SelectedIndex;

			DialogResult = DialogResult.OK;
		}

		private void FormMethodAdder_Load(object sender, EventArgs e)
		{

		}
	}
}
