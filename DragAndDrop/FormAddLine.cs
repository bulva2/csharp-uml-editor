﻿using DragAndDrop.Boxes;
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
		public Box? _targetBox;

		public string? _relationship;
		public string? _relationshipPlace;
		public bool _isNoneRelation;
		public FormAddLine(Box baseBox, List<Box> boxes)
		{
			InitializeComponent();

			line_sourceClassRelationCB.Enabled = false;
			line_tgtClassRelationCB.Enabled = false;
			
			line_sourceClassRelationRB.CheckedChanged += CheckChangedRadios;
			line_tgtClassRelationRB.CheckedChanged += CheckChangedRadios;
			line_noRelationRB.CheckedChanged += CheckChangedRadios;

			line_noRelationRB.Enabled = true;

			//add boxes to combobox
			foreach (Box box in boxes)
			{
				if(box!= baseBox)
					line_TargetBoxCB.Items.Add(box);
			}

			line_addB.Click += (sender, args) =>
			{
				if (line_TargetBoxCB.SelectedItem == null)
					return;

				if (line_sourceClassRelationRB.Checked)
				{
					_relationship = line_sourceClassRelationCB.Text;
					_relationshipPlace = "source";
					_isNoneRelation = false;
				}
				else if (line_tgtClassRelationRB.Checked)
				{
					_relationship = line_tgtClassRelationCB.Text;
					_relationshipPlace = "target";
					_isNoneRelation = false;
				}
				else
				{
					_isNoneRelation = true;
				}

				_targetBox = (Box)line_TargetBoxCB.SelectedItem;
				DialogResult = DialogResult.OK;
				Close();
			};
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
	}
}
