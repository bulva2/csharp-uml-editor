namespace DragAndDrop
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pictureBox = new PictureBox();
            menuStrip = new MenuStrip();
            newToolStripMenuItem = new ToolStripMenuItem();
            newDiagramToolStripMenuItem = new ToolStripMenuItem();
            loadDiagramToolStripMenuItem = new ToolStripMenuItem();
            saveDiagramAsToolStripMenuItem = new ToolStripMenuItem();
            jSONFileToolStripMenuItem = new ToolStripMenuItem();
            pNGFileToolStripMenuItem = new ToolStripMenuItem();
            boxToolStripMenuItem = new ToolStripMenuItem();
            classToolStripMenuItem = new ToolStripMenuItem();
            abstractClassToolStripMenuItem = new ToolStripMenuItem();
            interfaceToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStripRC = new ContextMenuStrip(components);
            testToolStripMenuItem = new ToolStripMenuItem();
            newAbstractClassToolStripMenuItem = new ToolStripMenuItem();
            newInterfaceToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            menuStrip.SuspendLayout();
            contextMenuStripRC.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.BackColor = Color.White;
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Location = new Point(15, 24);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(1554, 822);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            pictureBox.Paint += pictureBox_Paint;
            pictureBox.MouseClick += pictureBox_MouseClick;
            pictureBox.MouseDown += pictureBox_MouseDown;
            pictureBox.MouseMove += pictureBox_MouseMove;
            pictureBox.MouseUp += pictureBox_MouseUp;
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { newToolStripMenuItem, boxToolStripMenuItem });
            menuStrip.Location = new Point(15, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(1554, 24);
            menuStrip.TabIndex = 1;
            menuStrip.Text = "menuStrip1";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newDiagramToolStripMenuItem, loadDiagramToolStripMenuItem, saveDiagramAsToolStripMenuItem });
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(37, 20);
            newToolStripMenuItem.Text = "File";
            // 
            // newDiagramToolStripMenuItem
            // 
            newDiagramToolStripMenuItem.Name = "newDiagramToolStripMenuItem";
            newDiagramToolStripMenuItem.Size = new Size(162, 22);
            newDiagramToolStripMenuItem.Text = "New Diagram";
            // 
            // loadDiagramToolStripMenuItem
            // 
            loadDiagramToolStripMenuItem.Name = "loadDiagramToolStripMenuItem";
            loadDiagramToolStripMenuItem.Size = new Size(162, 22);
            loadDiagramToolStripMenuItem.Text = "Load Diagram";
            // 
            // saveDiagramAsToolStripMenuItem
            // 
            saveDiagramAsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { jSONFileToolStripMenuItem, pNGFileToolStripMenuItem });
            saveDiagramAsToolStripMenuItem.Name = "saveDiagramAsToolStripMenuItem";
            saveDiagramAsToolStripMenuItem.Size = new Size(162, 22);
            saveDiagramAsToolStripMenuItem.Text = "Save Diagram As";
            // 
            // jSONFileToolStripMenuItem
            // 
            jSONFileToolStripMenuItem.Name = "jSONFileToolStripMenuItem";
            jSONFileToolStripMenuItem.Size = new Size(123, 22);
            jSONFileToolStripMenuItem.Text = "JSON File";
            // 
            // pNGFileToolStripMenuItem
            // 
            pNGFileToolStripMenuItem.Name = "pNGFileToolStripMenuItem";
            pNGFileToolStripMenuItem.Size = new Size(123, 22);
            pNGFileToolStripMenuItem.Text = "PNG File";
            // 
            // boxToolStripMenuItem
            // 
            boxToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { classToolStripMenuItem, abstractClassToolStripMenuItem, interfaceToolStripMenuItem });
            boxToolStripMenuItem.Name = "boxToolStripMenuItem";
            boxToolStripMenuItem.Size = new Size(39, 20);
            boxToolStripMenuItem.Text = "Box";
            // 
            // classToolStripMenuItem
            // 
            classToolStripMenuItem.Name = "classToolStripMenuItem";
            classToolStripMenuItem.Size = new Size(148, 22);
            classToolStripMenuItem.Text = "Class";
            // 
            // abstractClassToolStripMenuItem
            // 
            abstractClassToolStripMenuItem.Name = "abstractClassToolStripMenuItem";
            abstractClassToolStripMenuItem.Size = new Size(148, 22);
            abstractClassToolStripMenuItem.Text = "Abstract Class";
            // 
            // interfaceToolStripMenuItem
            // 
            interfaceToolStripMenuItem.Name = "interfaceToolStripMenuItem";
            interfaceToolStripMenuItem.Size = new Size(148, 22);
            interfaceToolStripMenuItem.Text = "Interface";
            // 
            // contextMenuStripRC
            // 
            contextMenuStripRC.Items.AddRange(new ToolStripItem[] { testToolStripMenuItem, newAbstractClassToolStripMenuItem, newInterfaceToolStripMenuItem });
            contextMenuStripRC.Name = "contextMenuStripRC";
            contextMenuStripRC.Size = new Size(176, 70);
            // 
            // testToolStripMenuItem
            // 
            testToolStripMenuItem.Name = "testToolStripMenuItem";
            testToolStripMenuItem.Size = new Size(175, 22);
            testToolStripMenuItem.Text = "New Class";
            testToolStripMenuItem.Click += testToolStripMenuItem_Click;
            // 
            // newAbstractClassToolStripMenuItem
            // 
            newAbstractClassToolStripMenuItem.Name = "newAbstractClassToolStripMenuItem";
            newAbstractClassToolStripMenuItem.Size = new Size(175, 22);
            newAbstractClassToolStripMenuItem.Text = "New Abstract Class";
            // 
            // newInterfaceToolStripMenuItem
            // 
            newInterfaceToolStripMenuItem.Name = "newInterfaceToolStripMenuItem";
            newInterfaceToolStripMenuItem.Size = new Size(175, 22);
            newInterfaceToolStripMenuItem.Text = "New Interface";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1584, 861);
            Controls.Add(pictureBox);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            MinimumSize = new Size(720, 480);
            Name = "FormMain";
            Padding = new Padding(15, 0, 15, 15);
            Text = "UML Diagram Editor";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            contextMenuStripRC.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox;
        private MenuStrip menuStrip;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem boxToolStripMenuItem;
        private ToolStripMenuItem newDiagramToolStripMenuItem;
        private ToolStripMenuItem loadDiagramToolStripMenuItem;
        private ToolStripMenuItem saveDiagramAsToolStripMenuItem;
        private ToolStripMenuItem jSONFileToolStripMenuItem;
        private ToolStripMenuItem pNGFileToolStripMenuItem;
        private ToolStripMenuItem classToolStripMenuItem;
        private ToolStripMenuItem abstractClassToolStripMenuItem;
        private ToolStripMenuItem interfaceToolStripMenuItem;
        private ContextMenuStrip contextMenuStripRC;
        private ToolStripMenuItem testToolStripMenuItem;
        private ToolStripMenuItem newAbstractClassToolStripMenuItem;
        private ToolStripMenuItem newInterfaceToolStripMenuItem;
    }
}
