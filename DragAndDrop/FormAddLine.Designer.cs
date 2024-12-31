namespace DragAndDrop
{
	partial class FormAddLine
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			tableLayoutPanel1 = new TableLayoutPanel();
			line_TargetBoxCB = new ComboBox();
			line_targetBoxL = new Label();
			tableLayoutPanel2 = new TableLayoutPanel();
			line_addB = new Button();
			tableLayoutPanel1.SuspendLayout();
			tableLayoutPanel2.SuspendLayout();
			SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 2;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
			tableLayoutPanel1.Controls.Add(line_TargetBoxCB, 1, 0);
			tableLayoutPanel1.Controls.Add(line_targetBoxL, 0, 0);
			tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 1);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(0, 0);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 2;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
			tableLayoutPanel1.Size = new Size(380, 96);
			tableLayoutPanel1.TabIndex = 0;
			// 
			// line_TargetBoxCB
			// 
			line_TargetBoxCB.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			line_TargetBoxCB.FormattingEnabled = true;
			line_TargetBoxCB.Location = new Point(117, 17);
			line_TargetBoxCB.Name = "line_TargetBoxCB";
			line_TargetBoxCB.Size = new Size(260, 23);
			line_TargetBoxCB.TabIndex = 0;
			// 
			// line_targetBoxL
			// 
			line_targetBoxL.AutoSize = true;
			line_targetBoxL.Dock = DockStyle.Fill;
			line_targetBoxL.Location = new Point(3, 0);
			line_targetBoxL.Name = "line_targetBoxL";
			line_targetBoxL.Size = new Size(108, 57);
			line_targetBoxL.TabIndex = 1;
			line_targetBoxL.Text = "Target Class:";
			line_targetBoxL.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.ColumnCount = 2;
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.Controls.Add(line_addB, 0, 0);
			tableLayoutPanel2.Dock = DockStyle.Fill;
			tableLayoutPanel2.Location = new Point(117, 60);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 1;
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.Size = new Size(260, 33);
			tableLayoutPanel2.TabIndex = 2;
			// 
			// line_addB
			// 
			line_addB.DialogResult = DialogResult.OK;
			line_addB.Dock = DockStyle.Fill;
			line_addB.Location = new Point(3, 3);
			line_addB.Name = "line_addB";
			line_addB.Size = new Size(124, 27);
			line_addB.TabIndex = 0;
			line_addB.Text = "Add";
			line_addB.UseVisualStyleBackColor = true;
			// 
			// FormAddLine
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(380, 96);
			Controls.Add(tableLayoutPanel1);
			Name = "FormAddLine";
			Text = "FormAddLine";
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			tableLayoutPanel2.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel tableLayoutPanel1;
		private ComboBox line_TargetBoxCB;
		private Label line_targetBoxL;
		private TableLayoutPanel tableLayoutPanel2;
		private Button line_addB;
	}
}