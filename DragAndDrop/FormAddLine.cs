using DragAndDrop.Boxes;
using System.Windows.Forms;

namespace DragAndDrop
{
	public partial class FormAddLine : Form
	{
		public Box? _targetBox;

		public string? _relationship;
		public string? _relationshipPlace;
		public bool _isNoneRelation;

		public string? srcClassCardinality;
		public string? tgtClassCardinality;
		public FormAddLine(Box baseBox, List<Box> boxes)
		{
			InitializeComponent();

			line_sourceClassRelationCB.Enabled = false;
			line_tgtClassRelationCB.Enabled = false;

			line_sourceClassRelationRB.CheckedChanged += CheckChangedRadios;
			line_tgtClassRelationRB.CheckedChanged += CheckChangedRadios;
			line_noRelationRB.CheckedChanged += CheckChangedRadios;

			

			//add boxes to combobox
			foreach (Box box in boxes)
			{
				if (box != baseBox)
					line_TargetBoxCB.Items.Add(box);
			}

			line_noRelationRB.Checked = true;
			line_srcClassMultiplicityCB.SelectedIndex = 0;
			line_tgtClassMultiplicityCB.SelectedIndex = 0;
		}

		private void CheckChangedRadios(object? sender, EventArgs e)
		{
			if (line_sourceClassRelationRB.Checked)
			{
				line_sourceClassRelationCB.Enabled = true;
				line_tgtClassRelationCB.Enabled = false;
			}
			else if (line_tgtClassRelationRB.Checked)
			{
				line_sourceClassRelationCB.Enabled = false;
				line_tgtClassRelationCB.Enabled = true;
			}
			else if (line_noRelationRB.Checked)
			{
				line_sourceClassRelationCB.Enabled = false;
				line_tgtClassRelationCB.Enabled = false;
			}
		}

		private void line_addB_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(line_TargetBoxCB.Text))
			{
				errorProvider.SetError(line_TargetBoxCB, "Target box is required!");
				MessageBox.Show("Target class is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (line_srcClassMultiplicityCB.SelectedItem == null)
			{
				errorProvider.SetError(line_srcClassMultiplicityCB, "Source class multiplicity is required!");
				return;
			}

			if (line_tgtClassMultiplicityCB.SelectedItem == null)
			{
				errorProvider.SetError(line_tgtClassMultiplicityCB, "Target class multiplicity is required!");
				return;
			}

			srcClassCardinality = (string)line_srcClassMultiplicityCB.SelectedItem;
			tgtClassCardinality = (string)line_tgtClassMultiplicityCB.SelectedItem;

			if (srcClassCardinality == "none")
				srcClassCardinality = "";

			if (tgtClassCardinality == "none")
				tgtClassCardinality = "none";

			if (line_sourceClassRelationRB.Checked)
			{
				if (line_sourceClassRelationCB.SelectedItem == null)
				{
					errorProvider.SetError(line_sourceClassRelationCB, "Relation is required!");
					return;
				}

				_relationship = line_sourceClassRelationCB.Text;
				_relationshipPlace = "source";
				_isNoneRelation = false;
			}
			else if (line_tgtClassRelationRB.Checked)
			{
				if (line_tgtClassRelationCB.SelectedItem == null)
				{
					errorProvider.SetError(line_tgtClassRelationCB, "Relation is required!");
					return;
				}

				_relationship = line_tgtClassRelationCB.Text;
				_relationshipPlace = "target";
				_isNoneRelation = false;
			}
			else
			{
				_isNoneRelation = true;
			}

			if (line_TargetBoxCB.SelectedItem == null)
				return;

			_targetBox = (Box)line_TargetBoxCB.SelectedItem;
			DialogResult = DialogResult.OK;
		}

		private void FormAddLine_Load(object sender, EventArgs e)
		{
			errorProvider.SetIconPadding(line_TargetBoxCB, 5);
		}
	}
}
