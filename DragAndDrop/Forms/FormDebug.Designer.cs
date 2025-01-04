namespace DragAndDrop
{
    partial class FormDebug
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
            debugTextBox = new TextBox();
            SuspendLayout();
            // 
            // debugTextBox
            // 
            debugTextBox.BackColor = Color.FromArgb(24, 28, 20);
            debugTextBox.Dock = DockStyle.Fill;
            debugTextBox.ForeColor = Color.White;
            debugTextBox.Location = new Point(0, 0);
            debugTextBox.Multiline = true;
            debugTextBox.Name = "debugTextBox";
            debugTextBox.Size = new Size(800, 450);
            debugTextBox.TabIndex = 0;
            debugTextBox.DoubleClick += debugTextBox_DoubleClick;
            // 
            // FormDebug
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(debugTextBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormDebug";
            Text = "Development Debug";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox debugTextBox;
    }
}