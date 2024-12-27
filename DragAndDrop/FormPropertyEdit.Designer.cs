namespace DragAndDrop
{
    partial class FormPropertyEdit
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
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            comboBox = new ComboBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            buttonCancel = new Button();
            buttonOK = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            label2 = new Label();
            textBoxName = new TextBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            label3 = new Label();
            textBoxDataType = new TextBox();
            errorProvider = new ErrorProvider(components);
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 3);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 37.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(584, 216);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(578, 27);
            label1.TabIndex = 1;
            label1.Text = "Enter the name of your new property";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tableLayoutPanel2.Controls.Add(comboBox, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 138);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(578, 75);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // comboBox
            // 
            comboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.FormattingEnabled = true;
            comboBox.Items.AddRange(new object[] { "public", "protected", "private" });
            comboBox.Location = new Point(3, 3);
            comboBox.Name = "comboBox";
            comboBox.Size = new Size(254, 23);
            comboBox.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(buttonCancel, 0, 0);
            tableLayoutPanel3.Controls.Add(buttonOK, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(320, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(255, 69);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // buttonCancel
            // 
            buttonCancel.Dock = DockStyle.Fill;
            buttonCancel.Location = new Point(3, 3);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(121, 63);
            buttonCancel.TabIndex = 0;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonOK
            // 
            buttonOK.Dock = DockStyle.Fill;
            buttonOK.Location = new Point(130, 3);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(122, 63);
            buttonOK.TabIndex = 1;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.1833916F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.81661F));
            tableLayoutPanel4.Controls.Add(label2, 0, 0);
            tableLayoutPanel4.Controls.Add(textBoxName, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 30);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 21F));
            tableLayoutPanel4.Size = new Size(578, 48);
            tableLayoutPanel4.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(128, 48);
            label2.TabIndex = 0;
            label2.Text = "Name:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBoxName
            // 
            textBoxName.Anchor = AnchorStyles.Left;
            textBoxName.Location = new Point(137, 12);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(307, 23);
            textBoxName.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.3564014F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.6436F));
            tableLayoutPanel5.Controls.Add(label3, 0, 0);
            tableLayoutPanel5.Controls.Add(textBoxDataType, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 84);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(578, 48);
            tableLayoutPanel5.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(129, 48);
            label3.TabIndex = 0;
            label3.Text = "Data type:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBoxDataType
            // 
            textBoxDataType.Anchor = AnchorStyles.Left;
            textBoxDataType.Location = new Point(138, 12);
            textBoxDataType.Name = "textBoxDataType";
            textBoxDataType.Size = new Size(307, 23);
            textBoxDataType.TabIndex = 2;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // FormPropertyEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 216);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MinimizeBox = false;
            Name = "FormPropertyEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPropertyEdit";
            Load += FormPropertyEdit_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private ComboBox comboBox;
        private TableLayoutPanel tableLayoutPanel3;
        private Button buttonCancel;
        private Button buttonOK;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label2;
        private TextBox textBoxName;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label3;
        private TextBox textBoxDataType;
        private ErrorProvider errorProvider;
    }
}