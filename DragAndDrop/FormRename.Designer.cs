namespace DragAndDrop
{
    partial class FormRename
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
            labelTitle = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            label2 = new Label();
            textBoxName = new TextBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            buttonCancel = new Button();
            buttonOK = new Button();
            errorProvider = new ErrorProvider(components);
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(labelTitle, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.Size = new Size(384, 111);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Dock = DockStyle.Fill;
            labelTitle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelTitle.Location = new Point(3, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(378, 22);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Name your new class";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.7566137F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 86.2433853F));
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Controls.Add(textBoxName, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 25);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(378, 38);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(3, 11);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 0;
            label2.Text = "Name:";
            // 
            // textBoxName
            // 
            textBoxName.Anchor = AnchorStyles.Left;
            textBoxName.Location = new Point(55, 7);
            textBoxName.Name = "textBoxName";
            textBoxName.PlaceholderText = "Student";
            textBoxName.Size = new Size(295, 23);
            textBoxName.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Controls.Add(buttonCancel, 0, 0);
            tableLayoutPanel3.Controls.Add(buttonOK, 2, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 69);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(378, 39);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // buttonCancel
            // 
            buttonCancel.Dock = DockStyle.Fill;
            buttonCancel.Location = new Point(3, 3);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(120, 33);
            buttonCancel.TabIndex = 0;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonOK
            // 
            buttonOK.Dock = DockStyle.Fill;
            buttonOK.Location = new Point(255, 3);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(120, 33);
            buttonOK.TabIndex = 1;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // FormRename
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(384, 111);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormRename";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New Object Creation";
            Load += FormRename_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label labelTitle;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private TextBox textBoxName;
        private TableLayoutPanel tableLayoutPanel3;
        private Button buttonCancel;
        private Button buttonOK;
        private ErrorProvider errorProvider;
    }
}