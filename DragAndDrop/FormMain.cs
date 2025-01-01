using DragAndDrop.Boxes;
using DragAndDrop.Enums;
using System.Drawing.Imaging;
using System.Text.Json;

namespace DragAndDrop
{
    public partial class FormMain : Form
    {
        private Canvas _canvas;
        private Box? _selectedBox;

        public FormMain()
        {
            _canvas = new Canvas();

            InitializeComponent();
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            _canvas.Unselect();
            pictureBox.Refresh();
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _canvas.Select(e.X, e.Y);
                pictureBox.Refresh();
            }
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            _canvas.Move(e.X, e.Y);
            pictureBox.Refresh();
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            _canvas.Draw(e.Graphics);
        }

        private void pictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Point point = new Point(e.X, e.Y);
                Box? clickedBox = _canvas.SelectRC(point.X, point.Y);

                Console.WriteLine(clickedBox);

                if (clickedBox == null)
                {
                    DisplayDefaultRC(point);
                }
                else
                {
                    _selectedBox = clickedBox;
                    contextMenuStripBox.Show(GetRelativeCursorPos());
                }

            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
#if DEBUG
            Console.WriteLine("Debug Mode Active - Main Form Loaded");
#endif
        }

        private void newClassRC_Click(object sender, EventArgs e)
        {
            Point relativePosition = GetRelativeCursorPos();

            FormRename formRename = new FormRename(_canvas, "Create new class", "Enter the name of your new class");
            formRename.ShowDialog();

            if (formRename.DialogResult == DialogResult.OK)
            {
                Box box = new ClassBox(relativePosition.X, relativePosition.Y, formRename.ObjName!);
                box.PositionX -= box.Width / 2;
                box.PositionY -= box.Height / 2;
                _canvas.AddBoxToList(box);

#if DEBUG
                Console.WriteLine($"Successfully created ClassBox \"{box.OriginalName}\"");
#endif
            }

        }

        private void newAbstractRC_Click(object sender, EventArgs e)
        {
            Point relativePosition = GetRelativeCursorPos();

            FormRename formRename = new FormRename(_canvas, "Create new abstract class", "Enter the name of your new abstract class");
            formRename.ShowDialog();

            if (formRename.DialogResult == DialogResult.OK)
            {
                Box box = new AbstractClassBox(relativePosition.X, relativePosition.Y, formRename.ObjName!);
                box.PositionX -= box.Width / 2;
                box.PositionY -= box.Height / 2;
                _canvas.AddBoxToList(box);
            }
        }

        private void newInterfaceRC_Click(object sender, EventArgs e)
        {
            Point relativePosition = GetRelativeCursorPos();

            FormRename formRename = new FormRename(_canvas, "Create new interface", "Enter the name of your new interface");
            formRename.ShowDialog();

            if (formRename.DialogResult == DialogResult.OK)
            {
                Box box = new InterfaceBox(relativePosition.X, relativePosition.Y, formRename.ObjName!);
                box.PositionX -= box.Width / 2;
                box.PositionY -= box.Height / 2;
                _canvas.AddBoxToList(box);
            }
        }

        private void FormMain_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void classToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormRename formRename = new FormRename(_canvas, "Create new class", "Enter the name of your new class");
            formRename.ShowDialog();

            if (formRename.DialogResult == DialogResult.OK)
            {
                Box classBox = new ClassBox(10, 10, formRename.ObjName!);
                _canvas.AddBoxToList(classBox);
            }
        }

        private void abstractClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRename formRename = new FormRename(_canvas, "Create new abstract class", "Enter the name of your new abstract class");
            formRename.ShowDialog();

            if (formRename.DialogResult == DialogResult.OK)
            {
                Box abstractBox = new AbstractClassBox(10, 10, formRename.ObjName!);
                _canvas.AddBoxToList(abstractBox);
            }
        }

        private void interfaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRename formRename = new FormRename(_canvas, "Create new interface", "Enter the name of your new interface");
            formRename.ShowDialog();

            if (formRename.DialogResult == DialogResult.OK)
            {
                Box interfaceBox = new InterfaceBox(10, 10, formRename.ObjName!);
                _canvas.AddBoxToList(interfaceBox);
            }
        }

        private Point GetRelativeCursorPos()
        {
            Point screenPosition = Cursor.Position;
            Point relativePosition = pictureBox.PointToClient(screenPosition);
            return relativePosition;
        }

        private void DisplayDefaultRC(Point point)
        {
            Point screenPosition = pictureBox.PointToScreen(point);
            contextMenuStripRC.Show(screenPosition);
        }

        private void addPropertyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_selectedBox == null)
            {
                MessageBox.Show("No box selected.");
                return;
            }

            FormPropertyEdit formRename = new FormPropertyEdit();
            DialogResult result = formRename.ShowDialog();

            if (result == DialogResult.OK)
            {
                string modifier = AccessModifierExt.GetAccessModifier(formRename.Modifier);
                string name = formRename.PropertyName!;
                string dataType = formRename.DataType!;

                string property = $"{modifier}{name}: {dataType}";
                Console.WriteLine(property);
                _selectedBox.AddProperty(property);
                pictureBox.Refresh();
            }
        }

        private void pNGFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image image = new Bitmap(pictureBox.Width, pictureBox.Height);
            Graphics g = Graphics.FromImage(image);

            DialogResult result = saveFileDialogPng.ShowDialog();

            if (result == DialogResult.OK)
            {
                string path = saveFileDialogPng.FileName;
                _canvas.Draw(g);

                image.Save(path, ImageFormat.Png);
                MessageBox.Show($"Image saved successfully!\nLocation: {path}");
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Image image = new Bitmap(pictureBox.Width, pictureBox.Height);
            Graphics g = Graphics.FromImage(image);
            g.Clear(Color.White);

            DialogResult result = saveFileDialogJpg.ShowDialog();

            if (result == DialogResult.OK)
            {
                string path = saveFileDialogJpg.FileName;
                _canvas.Draw(g);

                image.Save(path, ImageFormat.Jpeg);
                MessageBox.Show($"Image saved successfully!\nLocation: {path}");
            }
        }

        private void pictureBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point relativePosition = GetRelativeCursorPos();
                Box? box = _canvas.SelectHeader(relativePosition.X, relativePosition.Y);

                if (box == null)
                    return;

                FormRename form = new FormRename(_canvas, $"Rename object {box.OriginalName}", "Enter the new name of the object");
                DialogResult result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    box.OriginalName = form.ObjName!;
                    box.UpdateBoxName();
                }
            }
        }

        private void deleteBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Do you really wish to delete {_selectedBox!.OriginalName}?", "Delete Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                _canvas.RemoveBoxFromList(_selectedBox!);
                pictureBox.Refresh();
            }
        }

        private void addMethodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_selectedBox == null)
                return;

            FormMethodAdder formMethodAdder = new FormMethodAdder();
            DialogResult result = formMethodAdder.ShowDialog();

            if (result == DialogResult.OK)
            {
                // Pøidat errorProvider na formMethodAdder
                string name = formMethodAdder.methodName!;
                string returnType = formMethodAdder.returnType!;
                string args = formMethodAdder.arguments!;
                string modifier = AccessModifierExt.GetAccessModifier(formMethodAdder.modifier);

                string method = $"{modifier}{name}({args}): {returnType}";
                _selectedBox.AddMethod(method);
                pictureBox.Refresh();
            }
        }

        private void addLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_selectedBox == null) return;
            FormAddLine formAddLine = new FormAddLine(_selectedBox, _canvas.GetBoxes());

            if (formAddLine.ShowDialog() == DialogResult.OK && formAddLine._targetBox != null)
            {
                _canvas.AddConnection(_selectedBox, formAddLine._targetBox);
            }
        }

        private void jSONFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialogJson.ShowDialog();
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };

            if (result == DialogResult.OK)
            {
                string path = saveFileDialogJson.FileName;
                string json = JsonSerializer.Serialize(_canvas.GetBoxes(), options);
                File.WriteAllText(path, json);
                MessageBox.Show($"JSON file saved successfully!\nLocation: {path}");
            }
        }
    }
}
