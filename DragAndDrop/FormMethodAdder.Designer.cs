namespace DragAndDrop
{
	partial class FormMethodAdder
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
			tableLayoutPanel2 = new TableLayoutPanel();
			method_addB = new Button();
			method_cancelB = new Button();
			tableLayoutPanel3 = new TableLayoutPanel();
			method_argsL = new Label();
			method_argsTB = new TextBox();
			tableLayoutPanel4 = new TableLayoutPanel();
			method_returnTypeL = new Label();
			method_returnTypeTB = new TextBox();
			tableLayoutPanel5 = new TableLayoutPanel();
			method_nameL = new Label();
			method_nameTB = new TextBox();
			tableLayoutPanel6 = new TableLayoutPanel();
			method_accessModifierL = new Label();
			method_accessModifierCB = new ComboBox();
			method_headerL = new Label();
			tableLayoutPanel1.SuspendLayout();
			tableLayoutPanel2.SuspendLayout();
			tableLayoutPanel3.SuspendLayout();
			tableLayoutPanel4.SuspendLayout();
			tableLayoutPanel5.SuspendLayout();
			tableLayoutPanel6.SuspendLayout();
			SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 1;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 5);
			tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 4);
			tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 3);
			tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 0, 2);
			tableLayoutPanel1.Controls.Add(tableLayoutPanel6, 0, 1);
			tableLayoutPanel1.Controls.Add(method_headerL, 0, 0);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(0, 0);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 6;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
			tableLayoutPanel1.Size = new Size(634, 261);
			tableLayoutPanel1.TabIndex = 0;
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.ColumnCount = 3;
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			tableLayoutPanel2.Controls.Add(method_addB, 0, 0);
			tableLayoutPanel2.Controls.Add(method_cancelB, 2, 0);
			tableLayoutPanel2.Dock = DockStyle.Fill;
			tableLayoutPanel2.Location = new Point(3, 224);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 1;
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel2.Size = new Size(628, 34);
			tableLayoutPanel2.TabIndex = 0;
			// 
			// method_addB
			// 
			method_addB.Dock = DockStyle.Fill;
			method_addB.Location = new Point(3, 3);
			method_addB.Name = "method_addB";
			method_addB.Size = new Size(151, 28);
			method_addB.TabIndex = 0;
			method_addB.Text = "Add";
			method_addB.UseVisualStyleBackColor = true;
			method_addB.Click += method_addB_Click;
			// 
			// method_cancelB
			// 
			method_cancelB.Dock = DockStyle.Fill;
			method_cancelB.Location = new Point(474, 3);
			method_cancelB.Name = "method_cancelB";
			method_cancelB.Size = new Size(151, 28);
			method_cancelB.TabIndex = 1;
			method_cancelB.Text = "Cancel";
			method_cancelB.UseVisualStyleBackColor = true;
			method_cancelB.Click += method_cancelB_Click;
			// 
			// tableLayoutPanel3
			// 
			tableLayoutPanel3.ColumnCount = 2;
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
			tableLayoutPanel3.Controls.Add(method_argsL, 0, 0);
			tableLayoutPanel3.Controls.Add(method_argsTB, 1, 0);
			tableLayoutPanel3.Dock = DockStyle.Fill;
			tableLayoutPanel3.Location = new Point(3, 172);
			tableLayoutPanel3.Name = "tableLayoutPanel3";
			tableLayoutPanel3.RowCount = 1;
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel3.Size = new Size(628, 46);
			tableLayoutPanel3.TabIndex = 1;
			// 
			// method_argsL
			// 
			method_argsL.AutoSize = true;
			method_argsL.Dock = DockStyle.Fill;
			method_argsL.Location = new Point(3, 0);
			method_argsL.Name = "method_argsL";
			method_argsL.Size = new Size(119, 46);
			method_argsL.TabIndex = 0;
			method_argsL.Text = "Arguments:";
			method_argsL.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// method_argsTB
			// 
			method_argsTB.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			method_argsTB.Location = new Point(128, 11);
			method_argsTB.Name = "method_argsTB";
			method_argsTB.Size = new Size(497, 23);
			method_argsTB.TabIndex = 1;
			// 
			// tableLayoutPanel4
			// 
			tableLayoutPanel4.ColumnCount = 2;
			tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
			tableLayoutPanel4.Controls.Add(method_returnTypeL, 0, 0);
			tableLayoutPanel4.Controls.Add(method_returnTypeTB, 1, 0);
			tableLayoutPanel4.Dock = DockStyle.Fill;
			tableLayoutPanel4.Location = new Point(3, 120);
			tableLayoutPanel4.Name = "tableLayoutPanel4";
			tableLayoutPanel4.RowCount = 1;
			tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel4.Size = new Size(628, 46);
			tableLayoutPanel4.TabIndex = 2;
			// 
			// method_returnTypeL
			// 
			method_returnTypeL.AutoSize = true;
			method_returnTypeL.Dock = DockStyle.Fill;
			method_returnTypeL.Location = new Point(3, 0);
			method_returnTypeL.Name = "method_returnTypeL";
			method_returnTypeL.Size = new Size(119, 46);
			method_returnTypeL.TabIndex = 0;
			method_returnTypeL.Text = "Return type:";
			method_returnTypeL.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// method_returnTypeTB
			// 
			method_returnTypeTB.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			method_returnTypeTB.Location = new Point(128, 11);
			method_returnTypeTB.Name = "method_returnTypeTB";
			method_returnTypeTB.Size = new Size(497, 23);
			method_returnTypeTB.TabIndex = 1;
			// 
			// tableLayoutPanel5
			// 
			tableLayoutPanel5.ColumnCount = 2;
			tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
			tableLayoutPanel5.Controls.Add(method_nameL, 0, 0);
			tableLayoutPanel5.Controls.Add(method_nameTB, 1, 0);
			tableLayoutPanel5.Dock = DockStyle.Fill;
			tableLayoutPanel5.Location = new Point(3, 68);
			tableLayoutPanel5.Name = "tableLayoutPanel5";
			tableLayoutPanel5.RowCount = 1;
			tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel5.Size = new Size(628, 46);
			tableLayoutPanel5.TabIndex = 3;
			// 
			// method_nameL
			// 
			method_nameL.AutoSize = true;
			method_nameL.Dock = DockStyle.Fill;
			method_nameL.Location = new Point(3, 0);
			method_nameL.Name = "method_nameL";
			method_nameL.Size = new Size(119, 46);
			method_nameL.TabIndex = 0;
			method_nameL.Text = "Name:";
			method_nameL.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// method_nameTB
			// 
			method_nameTB.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			method_nameTB.Location = new Point(128, 11);
			method_nameTB.Name = "method_nameTB";
			method_nameTB.Size = new Size(497, 23);
			method_nameTB.TabIndex = 1;
			// 
			// tableLayoutPanel6
			// 
			tableLayoutPanel6.ColumnCount = 2;
			tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
			tableLayoutPanel6.Controls.Add(method_accessModifierL, 0, 0);
			tableLayoutPanel6.Controls.Add(method_accessModifierCB, 1, 0);
			tableLayoutPanel6.Dock = DockStyle.Fill;
			tableLayoutPanel6.Location = new Point(3, 29);
			tableLayoutPanel6.Name = "tableLayoutPanel6";
			tableLayoutPanel6.RowCount = 1;
			tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel6.Size = new Size(628, 33);
			tableLayoutPanel6.TabIndex = 4;
			// 
			// method_accessModifierL
			// 
			method_accessModifierL.AutoSize = true;
			method_accessModifierL.Dock = DockStyle.Fill;
			method_accessModifierL.Location = new Point(3, 0);
			method_accessModifierL.Name = "method_accessModifierL";
			method_accessModifierL.Size = new Size(119, 33);
			method_accessModifierL.TabIndex = 0;
			method_accessModifierL.Text = "Access modifier:";
			method_accessModifierL.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// method_accessModifierCB
			// 
			method_accessModifierCB.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			method_accessModifierCB.FormattingEnabled = true;
			method_accessModifierCB.Items.AddRange(new object[] { "public", "protected", "private" });
			method_accessModifierCB.Location = new Point(128, 5);
			method_accessModifierCB.Name = "method_accessModifierCB";
			method_accessModifierCB.Size = new Size(497, 23);
			method_accessModifierCB.TabIndex = 1;
			// 
			// method_headerL
			// 
			method_headerL.AutoSize = true;
			method_headerL.Dock = DockStyle.Fill;
			method_headerL.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
			method_headerL.Location = new Point(3, 0);
			method_headerL.Name = "method_headerL";
			method_headerL.Size = new Size(628, 26);
			method_headerL.TabIndex = 5;
			method_headerL.Text = "Add method";
			method_headerL.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// FormMethodAdder
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(634, 261);
			Controls.Add(tableLayoutPanel1);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			Name = "FormMethodAdder";
			Text = "Add new method";
			Load += FormMethodAdder_Load;
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			tableLayoutPanel2.ResumeLayout(false);
			tableLayoutPanel3.ResumeLayout(false);
			tableLayoutPanel3.PerformLayout();
			tableLayoutPanel4.ResumeLayout(false);
			tableLayoutPanel4.PerformLayout();
			tableLayoutPanel5.ResumeLayout(false);
			tableLayoutPanel5.PerformLayout();
			tableLayoutPanel6.ResumeLayout(false);
			tableLayoutPanel6.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel tableLayoutPanel1;
		private TableLayoutPanel tableLayoutPanel2;
		private Button method_addB;
		private Button method_cancelB;
		private TableLayoutPanel tableLayoutPanel3;
		private TableLayoutPanel tableLayoutPanel4;
		private TableLayoutPanel tableLayoutPanel5;
		private Label method_nameL;
		private TextBox method_nameTB;
		private TableLayoutPanel tableLayoutPanel6;
		private Label method_headerL;
		private Label method_accessModifierL;
		private ComboBox method_accessModifierCB;
		private Label method_argsL;
		private TextBox method_argsTB;
		private Label method_returnTypeL;
		private TextBox method_returnTypeTB;
	}
}