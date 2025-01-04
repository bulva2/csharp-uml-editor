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
			components = new System.ComponentModel.Container();
			tableLayoutPanel1 = new TableLayoutPanel();
			tableLayoutPanel3 = new TableLayoutPanel();
			line_addB = new Button();
			line_TargetBoxCB = new ComboBox();
			line_targetBoxL = new Label();
			label1 = new Label();
			line_srcClassMultiplicityCB = new ComboBox();
			line_tgtClassMultiplicityL = new Label();
			label2 = new Label();
			line_tgtClassMultiplicityCB = new ComboBox();
			tableLayoutPanel2 = new TableLayoutPanel();
			line_sourceClassRelationRB = new RadioButton();
			line_tgtClassRelationRB = new RadioButton();
			line_sourceClassRelationCB = new ComboBox();
			line_tgtClassRelationCB = new ComboBox();
			line_noRelationRB = new RadioButton();
			errorProvider = new ErrorProvider(components);
			tableLayoutPanel1.SuspendLayout();
			tableLayoutPanel3.SuspendLayout();
			tableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
			SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 2;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
			tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 4);
			tableLayoutPanel1.Controls.Add(line_TargetBoxCB, 1, 1);
			tableLayoutPanel1.Controls.Add(line_targetBoxL, 0, 1);
			tableLayoutPanel1.Controls.Add(label1, 0, 0);
			tableLayoutPanel1.Controls.Add(line_srcClassMultiplicityCB, 1, 0);
			tableLayoutPanel1.Controls.Add(line_tgtClassMultiplicityL, 0, 2);
			tableLayoutPanel1.Controls.Add(label2, 0, 3);
			tableLayoutPanel1.Controls.Add(line_tgtClassMultiplicityCB, 1, 2);
			tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 3);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(0, 0);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 5;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 22.2222214F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 22.2222214F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 27.7777786F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
			tableLayoutPanel1.Size = new Size(460, 331);
			tableLayoutPanel1.TabIndex = 0;
			// 
			// tableLayoutPanel3
			// 
			tableLayoutPanel3.ColumnCount = 2;
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel3.Controls.Add(line_addB, 1, 0);
			tableLayoutPanel3.Dock = DockStyle.Fill;
			tableLayoutPanel3.Location = new Point(141, 295);
			tableLayoutPanel3.Name = "tableLayoutPanel3";
			tableLayoutPanel3.RowCount = 1;
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel3.Size = new Size(316, 33);
			tableLayoutPanel3.TabIndex = 3;
			// 
			// line_addB
			// 
			line_addB.DialogResult = DialogResult.OK;
			line_addB.Dock = DockStyle.Fill;
			line_addB.Location = new Point(161, 3);
			line_addB.Name = "line_addB";
			line_addB.Size = new Size(152, 27);
			line_addB.TabIndex = 0;
			line_addB.Text = "Add";
			line_addB.UseVisualStyleBackColor = true;
			line_addB.Click += line_addB_Click;
			// 
			// line_TargetBoxCB
			// 
			line_TargetBoxCB.Anchor = AnchorStyles.Left;
			line_TargetBoxCB.DropDownStyle = ComboBoxStyle.DropDownList;
			line_TargetBoxCB.FormattingEnabled = true;
			line_TargetBoxCB.Location = new Point(141, 80);
			line_TargetBoxCB.Name = "line_TargetBoxCB";
			line_TargetBoxCB.Size = new Size(250, 23);
			line_TargetBoxCB.TabIndex = 4;
			// 
			// line_targetBoxL
			// 
			line_targetBoxL.AutoSize = true;
			line_targetBoxL.Dock = DockStyle.Fill;
			line_targetBoxL.Location = new Point(3, 55);
			line_targetBoxL.Name = "line_targetBoxL";
			line_targetBoxL.Size = new Size(132, 73);
			line_targetBoxL.TabIndex = 5;
			line_targetBoxL.Text = "Target class:";
			line_targetBoxL.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Dock = DockStyle.Fill;
			label1.Location = new Point(3, 0);
			label1.Name = "label1";
			label1.Size = new Size(132, 55);
			label1.TabIndex = 6;
			label1.Text = "Source class multiplicity:";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// line_srcClassMultiplicityCB
			// 
			line_srcClassMultiplicityCB.Anchor = AnchorStyles.Left;
			line_srcClassMultiplicityCB.DropDownStyle = ComboBoxStyle.DropDownList;
			line_srcClassMultiplicityCB.FormattingEnabled = true;
			line_srcClassMultiplicityCB.Items.AddRange(new object[] { "none", "1", "*" });
			line_srcClassMultiplicityCB.Location = new Point(141, 16);
			line_srcClassMultiplicityCB.Name = "line_srcClassMultiplicityCB";
			line_srcClassMultiplicityCB.Size = new Size(250, 23);
			line_srcClassMultiplicityCB.TabIndex = 7;
			// 
			// line_tgtClassMultiplicityL
			// 
			line_tgtClassMultiplicityL.AutoSize = true;
			line_tgtClassMultiplicityL.Dock = DockStyle.Fill;
			line_tgtClassMultiplicityL.Location = new Point(3, 128);
			line_tgtClassMultiplicityL.Name = "line_tgtClassMultiplicityL";
			line_tgtClassMultiplicityL.Size = new Size(132, 73);
			line_tgtClassMultiplicityL.TabIndex = 8;
			line_tgtClassMultiplicityL.Text = "Target class multiplicity:";
			line_tgtClassMultiplicityL.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Dock = DockStyle.Fill;
			label2.Location = new Point(3, 201);
			label2.Name = "label2";
			label2.Size = new Size(132, 91);
			label2.TabIndex = 9;
			label2.Text = "Relationship:";
			label2.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// line_tgtClassMultiplicityCB
			// 
			line_tgtClassMultiplicityCB.Anchor = AnchorStyles.Left;
			line_tgtClassMultiplicityCB.DropDownStyle = ComboBoxStyle.DropDownList;
			line_tgtClassMultiplicityCB.FormattingEnabled = true;
			line_tgtClassMultiplicityCB.Items.AddRange(new object[] { "none", "1", "*" });
			line_tgtClassMultiplicityCB.Location = new Point(141, 153);
			line_tgtClassMultiplicityCB.Name = "line_tgtClassMultiplicityCB";
			line_tgtClassMultiplicityCB.Size = new Size(250, 23);
			line_tgtClassMultiplicityCB.TabIndex = 10;
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.ColumnCount = 2;
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.9999962F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0000076F));
			tableLayoutPanel2.Controls.Add(line_sourceClassRelationRB, 0, 0);
			tableLayoutPanel2.Controls.Add(line_tgtClassRelationRB, 0, 1);
			tableLayoutPanel2.Controls.Add(line_sourceClassRelationCB, 1, 0);
			tableLayoutPanel2.Controls.Add(line_tgtClassRelationCB, 1, 1);
			tableLayoutPanel2.Controls.Add(line_noRelationRB, 0, 2);
			tableLayoutPanel2.Dock = DockStyle.Fill;
			tableLayoutPanel2.Location = new Point(141, 204);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 3;
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
			tableLayoutPanel2.Size = new Size(316, 85);
			tableLayoutPanel2.TabIndex = 11;
			// 
			// line_sourceClassRelationRB
			// 
			line_sourceClassRelationRB.AutoSize = true;
			line_sourceClassRelationRB.Location = new Point(3, 3);
			line_sourceClassRelationRB.Name = "line_sourceClassRelationRB";
			line_sourceClassRelationRB.Size = new Size(89, 19);
			line_sourceClassRelationRB.TabIndex = 1;
			line_sourceClassRelationRB.TabStop = true;
			line_sourceClassRelationRB.Text = "Source class";
			line_sourceClassRelationRB.UseVisualStyleBackColor = true;
			// 
			// line_tgtClassRelationRB
			// 
			line_tgtClassRelationRB.AutoSize = true;
			line_tgtClassRelationRB.Location = new Point(3, 31);
			line_tgtClassRelationRB.Name = "line_tgtClassRelationRB";
			line_tgtClassRelationRB.Size = new Size(85, 19);
			line_tgtClassRelationRB.TabIndex = 2;
			line_tgtClassRelationRB.TabStop = true;
			line_tgtClassRelationRB.Text = "Target class";
			line_tgtClassRelationRB.UseVisualStyleBackColor = true;
			// 
			// line_sourceClassRelationCB
			// 
			line_sourceClassRelationCB.Anchor = AnchorStyles.Left;
			line_sourceClassRelationCB.DropDownStyle = ComboBoxStyle.DropDownList;
			line_sourceClassRelationCB.FormattingEnabled = true;
			line_sourceClassRelationCB.Items.AddRange(new object[] { "Association", "Agregation", "Composition", "Generalisation" });
			line_sourceClassRelationCB.Location = new Point(160, 3);
			line_sourceClassRelationCB.Name = "line_sourceClassRelationCB";
			line_sourceClassRelationCB.Size = new Size(125, 23);
			line_sourceClassRelationCB.TabIndex = 3;
			// 
			// line_tgtClassRelationCB
			// 
			line_tgtClassRelationCB.Anchor = AnchorStyles.Left;
			line_tgtClassRelationCB.DropDownStyle = ComboBoxStyle.DropDownList;
			line_tgtClassRelationCB.FormattingEnabled = true;
			line_tgtClassRelationCB.Items.AddRange(new object[] { "Association", "Agregation", "Composition", "Generalisation" });
			line_tgtClassRelationCB.Location = new Point(160, 31);
			line_tgtClassRelationCB.Name = "line_tgtClassRelationCB";
			line_tgtClassRelationCB.Size = new Size(125, 23);
			line_tgtClassRelationCB.TabIndex = 4;
			// 
			// line_noRelationRB
			// 
			line_noRelationRB.AutoSize = true;
			line_noRelationRB.Dock = DockStyle.Fill;
			line_noRelationRB.Location = new Point(3, 59);
			line_noRelationRB.Name = "line_noRelationRB";
			line_noRelationRB.Size = new Size(151, 23);
			line_noRelationRB.TabIndex = 5;
			line_noRelationRB.TabStop = true;
			line_noRelationRB.Text = "None";
			line_noRelationRB.UseVisualStyleBackColor = true;
			// 
			// errorProvider
			// 
			errorProvider.ContainerControl = this;
			// 
			// FormAddLine
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ControlLight;
			ClientSize = new Size(460, 331);
			Controls.Add(tableLayoutPanel1);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			MaximizeBox = false;
			Name = "FormAddLine";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Add new line";
			Load += FormAddLine_Load;
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			tableLayoutPanel3.ResumeLayout(false);
			tableLayoutPanel2.ResumeLayout(false);
			tableLayoutPanel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel tableLayoutPanel1;
		private TableLayoutPanel tableLayoutPanel3;
		private Button line_addB;
		private ComboBox line_TargetBoxCB;
		private Label line_targetBoxL;
		private Label label1;
		private ComboBox line_srcClassMultiplicityCB;
		private Label line_tgtClassMultiplicityL;
		private Label label2;
		private ComboBox line_tgtClassMultiplicityCB;
		private TableLayoutPanel tableLayoutPanel2;
		private RadioButton line_sourceClassRelationRB;
		private RadioButton line_tgtClassRelationRB;
		private ComboBox line_sourceClassRelationCB;
		private ComboBox line_tgtClassRelationCB;
		private RadioButton line_noRelationRB;
		private ErrorProvider errorProvider;
	}
}