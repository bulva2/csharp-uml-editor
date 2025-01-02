using DragAndDrop.Enums;

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
			if (method_accessModifierCB.SelectedItem == null)
			{
				errorProvider.SetError(method_accessModifierCB, "Access modifier is required!");
				return;
			}
			if (string.IsNullOrEmpty(method_nameTB.Text))
			{
				errorProvider.SetError(method_nameTB, "Name is required!");
				return;
			}
			if(string.IsNullOrEmpty(method_returnTypeTB.Text))
			{
				errorProvider.SetError(method_returnTypeTB, "Return type is required");
				return;
			}
			
			
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
