﻿namespace DragAndDrop
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
            toolStripMenuItem2 = new ToolStripMenuItem();
            fromXMLToolStripMenuItem = new ToolStripMenuItem();
            saveDiagramAsToolStripMenuItem = new ToolStripMenuItem();
            jSONFileToolStripMenuItem = new ToolStripMenuItem();
            xMLFileToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripMenuItem1 = new ToolStripMenuItem();
            pNGFileToolStripMenuItem = new ToolStripMenuItem();
            boxToolStripMenuItem = new ToolStripMenuItem();
            classToolStripMenuItem = new ToolStripMenuItem();
            abstractClassToolStripMenuItem = new ToolStripMenuItem();
            interfaceToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStripRC = new ContextMenuStrip(components);
            newClassRC = new ToolStripMenuItem();
            newAbstractRC = new ToolStripMenuItem();
            newInterfaceRC = new ToolStripMenuItem();
            contextMenuStripBox = new ContextMenuStrip(components);
            addPropertyToolStripMenuItem = new ToolStripMenuItem();
            addMethodToolStripMenuItem = new ToolStripMenuItem();
            addConstructorToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            deleteBoxToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            addLineToolStripMenuItem = new ToolStripMenuItem();
            saveFileDialogPng = new SaveFileDialog();
            saveFileDialogJpg = new SaveFileDialog();
            saveFileDialogJson = new SaveFileDialog();
            openFileDialogJson = new OpenFileDialog();
            saveFileDialogXml = new SaveFileDialog();
            openFileDialogXml = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            menuStrip.SuspendLayout();
            contextMenuStripRC.SuspendLayout();
            contextMenuStripBox.SuspendLayout();
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
            pictureBox.MouseDoubleClick += pictureBox_MouseDoubleClick;
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
            newDiagramToolStripMenuItem.Size = new Size(180, 22);
            newDiagramToolStripMenuItem.Text = "New Diagram";
            newDiagramToolStripMenuItem.Click += newDiagramToolStripMenuItem_Click;
            // 
            // loadDiagramToolStripMenuItem
            // 
            loadDiagramToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem2, fromXMLToolStripMenuItem });
            loadDiagramToolStripMenuItem.Name = "loadDiagramToolStripMenuItem";
            loadDiagramToolStripMenuItem.Size = new Size(180, 22);
            loadDiagramToolStripMenuItem.Text = "Load Diagram";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(180, 22);
            toolStripMenuItem2.Text = "From JSON";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // fromXMLToolStripMenuItem
            // 
            fromXMLToolStripMenuItem.Name = "fromXMLToolStripMenuItem";
            fromXMLToolStripMenuItem.Size = new Size(180, 22);
            fromXMLToolStripMenuItem.Text = "From XML";
            fromXMLToolStripMenuItem.Click += fromXMLToolStripMenuItem_Click;
            // 
            // saveDiagramAsToolStripMenuItem
            // 
            saveDiagramAsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { jSONFileToolStripMenuItem, xMLFileToolStripMenuItem, toolStripSeparator3, toolStripMenuItem1, pNGFileToolStripMenuItem });
            saveDiagramAsToolStripMenuItem.Name = "saveDiagramAsToolStripMenuItem";
            saveDiagramAsToolStripMenuItem.Size = new Size(180, 22);
            saveDiagramAsToolStripMenuItem.Text = "Save Diagram As";
            // 
            // jSONFileToolStripMenuItem
            // 
            jSONFileToolStripMenuItem.Name = "jSONFileToolStripMenuItem";
            jSONFileToolStripMenuItem.Size = new Size(123, 22);
            jSONFileToolStripMenuItem.Text = "JSON File";
            jSONFileToolStripMenuItem.Click += jSONFileToolStripMenuItem_Click;
            // 
            // xMLFileToolStripMenuItem
            // 
            xMLFileToolStripMenuItem.Name = "xMLFileToolStripMenuItem";
            xMLFileToolStripMenuItem.Size = new Size(123, 22);
            xMLFileToolStripMenuItem.Text = "XML File";
            xMLFileToolStripMenuItem.Click += xMLFileToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(120, 6);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(123, 22);
            toolStripMenuItem1.Text = "JPG File";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // pNGFileToolStripMenuItem
            // 
            pNGFileToolStripMenuItem.Name = "pNGFileToolStripMenuItem";
            pNGFileToolStripMenuItem.Size = new Size(123, 22);
            pNGFileToolStripMenuItem.Text = "PNG File";
            pNGFileToolStripMenuItem.Click += pNGFileToolStripMenuItem_Click;
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
            classToolStripMenuItem.Size = new Size(173, 22);
            classToolStripMenuItem.Text = "Add Class";
            classToolStripMenuItem.Click += classToolStripMenuItem_Click_1;
            // 
            // abstractClassToolStripMenuItem
            // 
            abstractClassToolStripMenuItem.Name = "abstractClassToolStripMenuItem";
            abstractClassToolStripMenuItem.Size = new Size(173, 22);
            abstractClassToolStripMenuItem.Text = "Add Abstract Class";
            abstractClassToolStripMenuItem.Click += abstractClassToolStripMenuItem_Click;
            // 
            // interfaceToolStripMenuItem
            // 
            interfaceToolStripMenuItem.Name = "interfaceToolStripMenuItem";
            interfaceToolStripMenuItem.Size = new Size(173, 22);
            interfaceToolStripMenuItem.Text = "Add Interface";
            interfaceToolStripMenuItem.Click += interfaceToolStripMenuItem_Click;
            // 
            // contextMenuStripRC
            // 
            contextMenuStripRC.Items.AddRange(new ToolStripItem[] { newClassRC, newAbstractRC, newInterfaceRC });
            contextMenuStripRC.Name = "contextMenuStripRC";
            contextMenuStripRC.Size = new Size(176, 70);
            // 
            // newClassRC
            // 
            newClassRC.Name = "newClassRC";
            newClassRC.Size = new Size(175, 22);
            newClassRC.Text = "New Class";
            newClassRC.Click += newClassRC_Click;
            // 
            // newAbstractRC
            // 
            newAbstractRC.Name = "newAbstractRC";
            newAbstractRC.Size = new Size(175, 22);
            newAbstractRC.Text = "New Abstract Class";
            newAbstractRC.Click += newAbstractRC_Click;
            // 
            // newInterfaceRC
            // 
            newInterfaceRC.Name = "newInterfaceRC";
            newInterfaceRC.Size = new Size(175, 22);
            newInterfaceRC.Text = "New Interface";
            newInterfaceRC.Click += newInterfaceRC_Click;
            // 
            // contextMenuStripBox
            // 
            contextMenuStripBox.Items.AddRange(new ToolStripItem[] { addPropertyToolStripMenuItem, addMethodToolStripMenuItem, addConstructorToolStripMenuItem, toolStripSeparator2, deleteBoxToolStripMenuItem, toolStripSeparator1, addLineToolStripMenuItem });
            contextMenuStripBox.Name = "contextMenuStripBox";
            contextMenuStripBox.Size = new Size(163, 126);
            // 
            // addPropertyToolStripMenuItem
            // 
            addPropertyToolStripMenuItem.Name = "addPropertyToolStripMenuItem";
            addPropertyToolStripMenuItem.Size = new Size(162, 22);
            addPropertyToolStripMenuItem.Text = "Add Property";
            addPropertyToolStripMenuItem.Click += addPropertyToolStripMenuItem_Click;
            // 
            // addMethodToolStripMenuItem
            // 
            addMethodToolStripMenuItem.Name = "addMethodToolStripMenuItem";
            addMethodToolStripMenuItem.Size = new Size(162, 22);
            addMethodToolStripMenuItem.Text = "Add Method";
            addMethodToolStripMenuItem.Click += addMethodToolStripMenuItem_Click;
            // 
            // addConstructorToolStripMenuItem
            // 
            addConstructorToolStripMenuItem.Name = "addConstructorToolStripMenuItem";
            addConstructorToolStripMenuItem.Size = new Size(162, 22);
            addConstructorToolStripMenuItem.Text = "Add Constructor";
            addConstructorToolStripMenuItem.Click += addConstructorToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(159, 6);
            // 
            // deleteBoxToolStripMenuItem
            // 
            deleteBoxToolStripMenuItem.Name = "deleteBoxToolStripMenuItem";
            deleteBoxToolStripMenuItem.Size = new Size(162, 22);
            deleteBoxToolStripMenuItem.Text = "Delete Box";
            deleteBoxToolStripMenuItem.Click += deleteBoxToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(159, 6);
            // 
            // addLineToolStripMenuItem
            // 
            addLineToolStripMenuItem.Name = "addLineToolStripMenuItem";
            addLineToolStripMenuItem.Size = new Size(162, 22);
            addLineToolStripMenuItem.Text = "Add Line";
            addLineToolStripMenuItem.Click += addLineToolStripMenuItem_Click;
            // 
            // saveFileDialogPng
            // 
            saveFileDialogPng.FileName = "export.png";
            saveFileDialogPng.Filter = "PNG File (*.png)|*.png";
            // 
            // saveFileDialogJpg
            // 
            saveFileDialogJpg.FileName = "export.jpg";
            saveFileDialogJpg.Filter = "JPG File (*.jpg)|*.jpg";
            // 
            // saveFileDialogJson
            // 
            saveFileDialogJson.Filter = "JSON File (*.json)|*.json";
            // 
            // openFileDialogJson
            // 
            openFileDialogJson.FileName = "openFileDialogJson";
            openFileDialogJson.Filter = "JSON File (*.json)|*.json";
            // 
            // saveFileDialogXml
            // 
            saveFileDialogXml.Filter = "XML File (*.xml)|*.xml";
            // 
            // openFileDialogXml
            // 
            openFileDialogXml.FileName = "openFileDialogXml";
            openFileDialogXml.Filter = "XML File (*.xml)|*.xml";
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
            Load += FormMain_Load;
            MouseDoubleClick += FormMain_MouseDoubleClick;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            contextMenuStripRC.ResumeLayout(false);
            contextMenuStripBox.ResumeLayout(false);
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
        private ToolStripMenuItem newClassRC;
        private ToolStripMenuItem newAbstractRC;
        private ToolStripMenuItem newInterfaceRC;
        private ContextMenuStrip contextMenuStripBox;
        private ToolStripMenuItem addPropertyToolStripMenuItem;
        private ToolStripMenuItem addMethodToolStripMenuItem;
        private SaveFileDialog saveFileDialogPng;
        private ToolStripMenuItem toolStripMenuItem1;
        private SaveFileDialog saveFileDialogJpg;
        private ToolStripMenuItem addConstructorToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem deleteBoxToolStripMenuItem;
		private ToolStripSeparator toolStripSeparator2;
		private ToolStripMenuItem addLineToolStripMenuItem;
        private SaveFileDialog saveFileDialogJson;
        private ToolStripMenuItem toolStripMenuItem2;
        private OpenFileDialog openFileDialogJson;
        private ToolStripMenuItem xMLFileToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private SaveFileDialog saveFileDialogXml;
        private ToolStripMenuItem fromXMLToolStripMenuItem;
        private OpenFileDialog openFileDialogXml;
    }
}
