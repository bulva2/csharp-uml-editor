using DragAndDrop.Boxes;
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
	public partial class FormAddLine : Form
	{
		public Box _targetBox;
		public FormAddLine(Box baseBox, List<Box> boxes)
		{
			InitializeComponent();

			foreach(Box box in boxes)
			{
				if(box!= baseBox)
					line_TargetBoxCB.Items.Add(box);
			}

			line_addB.Click += (sender, args) =>
			{
				if (line_TargetBoxCB.SelectedItem == null)
					return;

				_targetBox = (Box)line_TargetBoxCB.SelectedItem;
				DialogResult result = DialogResult.OK;
				Close();
			};
		}
	}
}
