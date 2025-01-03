using DragAndDrop.Boxes;
using DragAndDrop.Enums;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing.Imaging;
using System.Text;
using System.Text.Json;
using System.Xml.Linq;
using System.Xml.Serialization;

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
                // Přidat errorProvider na formMethodAdder
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

            string relationship = "";
            string relationshipPlace = "";

            string srcCardinality = "";
            string tgtCardinality = "";


            DialogResult result = formAddLine.ShowDialog();

            if (result == DialogResult.OK /*&& formAddLine._targetBox != null*/)
            {
                if (formAddLine.srcClassCardinality == null)
                    return;
                else if (formAddLine.srcClassCardinality != "none")
                    srcCardinality = formAddLine.srcClassCardinality;

                if (formAddLine.tgtClassCardinality == null)
                    return;
                else if (formAddLine.tgtClassCardinality != "none")
                    tgtCardinality = formAddLine.tgtClassCardinality;


                if (formAddLine._isNoneRelation == false)
                {
                    if (string.IsNullOrEmpty(formAddLine._relationship))
                        return;
                    relationship = formAddLine._relationship;

                    if (string.IsNullOrEmpty(formAddLine._relationshipPlace))
                        return;
                    relationshipPlace = formAddLine._relationshipPlace;
                    _canvas.AddConnection(_selectedBox, formAddLine._targetBox, relationship, relationshipPlace, srcCardinality, tgtCardinality);
                }
                else
                    _canvas.AddConnection(_selectedBox, formAddLine._targetBox, relationship, relationshipPlace, srcCardinality, tgtCardinality);
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

        private void newDiagramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _selectedBox = null;
            _canvas = new Canvas();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialogJson.ShowDialog();

            if (result == DialogResult.OK)
            {
                string path = openFileDialogJson.FileName;
                DeserializeBoxesFromJSON(path);
            }
        }

        private void DeserializeBoxesFromJSON(string path)
        {
            string json = File.ReadAllText(path);

            try
            {
                // Parsneme si JSON, tak abychom zjistili o jakej box se jedná
                JsonDocument jsonDocument = JsonDocument.Parse(json);

                foreach (JsonElement element in jsonDocument.RootElement.EnumerateArray())
                {
                    string boxType = element.GetProperty("BoxType").GetString()!;

                    JsonSerializerOptions options = new JsonSerializerOptions
                    {
                        IncludeFields = true,
                    };

                    Box? box = boxType switch
                    {
                        "Class" => JsonSerializer.Deserialize<ClassBox>(element, options),
                        "Abstract" => JsonSerializer.Deserialize<AbstractClassBox>(element, options),
                        "Interface" => JsonSerializer.Deserialize<InterfaceBox>(element, options),
                        _ => throw new JsonException($"Unknown box type: {boxType}")
                    };

                    if (box != null)
                    {
                        if (!_canvas.DoesBoxNameExist(box.OriginalName))
                        {
                            _canvas.AddBoxToList(box);
                        }
                        else
                        {
                            MessageBox.Show($"Box with name {box.OriginalName} already exists in the diagram. Skipping...", "JSON Import Progress", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error while deserializing JSON file!\n\nError message: {e.Message}", "JSON Import Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void xMLFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Box>));
            DialogResult result = saveFileDialogXml.ShowDialog();

            if (result == DialogResult.OK)
            {
                string path = saveFileDialogXml.FileName;
                FileStream fileStream = File.Create(path);

                try
                {
                    serializer.Serialize(fileStream, _canvas.GetBoxes());
                }
                catch (Exception err)
                {
                    MessageBox.Show($"An error has occured while saving the XML file!\n\n{err.Message}", "XML Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    fileStream.Close();
                }

            }
        }

        private void addConstructorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_selectedBox == null) return;

            string modifier = "";

            if (_selectedBox.BoxType == "Abstract")
                modifier = AccessModifierExt.GetAccessModifier(AccessModifier.Protected);
            else if (_selectedBox.BoxType == "Class")
                modifier = AccessModifierExt.GetAccessModifier(AccessModifier.Public);
            else if (_selectedBox.BoxType == "Interface")
            {
                MessageBox.Show("Interfaces cannot have constructor!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            List<string> properties = new List<string>();

            if (_selectedBox.LabelsText.Count == 0)
            {
                DialogResult result = MessageBox.Show("Class doesn't have any properties. Do you want to create empty constructor?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return;
                }
            }
            foreach (string property in _selectedBox.LabelsText)
            {
                string temp2;

                if (property.Contains("#"))
                {
                    temp2 = property.Replace("#", "");
                }

                else if (property.Contains("+"))
                {
                    temp2 = property.Replace("+", "");
                }

                else
                {
                    temp2 = property.Replace("-", "");
                }

                temp2.Replace(" ", "");

                string[] temp = temp2.Split(':');
                string tempStr = temp[1] + " " + temp[0];

                properties.Add(tempStr);
                properties.Add(",");
            }

            StringBuilder builder = new StringBuilder();
            foreach (string s in properties)
            {
                builder.Append(s);
            }

            if (builder.Length > 0 && builder[builder.Length - 1] == ',')
                builder.Remove(builder.Length - 1, 1);

            if (builder.Length > 0)
                builder.Remove(builder.Length - builder.Length, 1);

            string temp0 = string.Join("", properties);
            string ctor = modifier + _selectedBox.OriginalName + "(" + builder.ToString() + ")";

            _selectedBox.AddMethod(ctor);
            pictureBox.Refresh();

        }

        private void fromXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            DialogResult result = openFileDialogXml.ShowDialog();

            if (result == DialogResult.OK)
            {
                XDocument doc = XDocument.Load(openFileDialogXml.FileName);
                List<XElement>? boxes = doc.Descendants("Box").ToList();

                foreach (XElement box in boxes)
                {
                    string boxType = box.Element("BoxType")?.Value!;
                    XmlSerializer? serializer = null;

                    foreach (var elem in box.DescendantsAndSelf())
                    {
                        elem.Name = elem.Name.LocalName;
                        elem.Attributes().Where(a => a.IsNamespaceDeclaration).Remove();
                    }

                    if (boxType == "Class")
                    {
                        serializer = new XmlSerializer(typeof(ClassBox));
                        using (StringReader reader = new StringReader(box.ToString()))
                        {
                            ClassBox? classBox = (ClassBox?)serializer.Deserialize(reader);
                            if (classBox != null && !_canvas.DoesBoxNameExist(classBox.OriginalName))
                            {
                                _canvas.AddBoxToList(classBox);
                            }
                        }
                    }
                    else if (boxType == "Abstract")
                    {
                        serializer = new XmlSerializer(typeof(AbstractClassBox));
                        using (StringReader reader = new StringReader(box.ToString()))
                        {
                            AbstractClassBox? abstractBox = (AbstractClassBox?)serializer.Deserialize(reader);
                            if (abstractBox != null && !_canvas.DoesBoxNameExist(abstractBox.OriginalName))
                            {
                                _canvas.AddBoxToList(abstractBox);
                            }
                        }
                    }
                    else if (boxType == "Interface")
                    {
                        serializer = new XmlSerializer(typeof(InterfaceBox));
                        using (StringReader reader = new StringReader(box.ToString()))
                        {
                            InterfaceBox? interfaceBox = (InterfaceBox?)serializer.Deserialize(reader);
                            if (interfaceBox != null && !_canvas.DoesBoxNameExist(interfaceBox.OriginalName))
                            {
                                _canvas.AddBoxToList(interfaceBox);
                            }
                        }
                    }
                }
            }
            */
        }
    }
}
