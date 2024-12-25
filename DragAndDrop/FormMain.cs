using DragAndDrop.Boxes;

namespace DragAndDrop
{
	public partial class FormMain : Form
	{
		private Canvas _canvas;

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
			_canvas.Select(e.X, e.Y);
			pictureBox.Refresh();
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
				Point relativePosition = new Point(e.X, e.Y);
				Point screenPosition = pictureBox.PointToScreen(relativePosition);

				contextMenuStripRC.Show(screenPosition);
			}
		}

		private void FormMain_Load(object sender, EventArgs e)
		{
#if DEBUG
			Console.WriteLine("Debug Mode Active - Main Form Loaded");
#endif
		}

		private void classToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			ClassBox classBox = new ClassBox(10, 10, "Testuju!");
			_canvas.AddBoxToList(classBox);
		}

		private void newClassRC_Click(object sender, EventArgs e)
		{
			Point screenPosition = Cursor.Position;
			Point relativePosition = pictureBox.PointToClient(screenPosition);

			ClassBox classBox = new ClassBox(relativePosition.X, relativePosition.Y, "Testuju!");
			classBox.PositionX -= classBox.Width / 2;
			classBox.PositionY -= classBox.Height / 2;
			_canvas.AddBoxToList(classBox);
		}

		private void FormMain_MouseDoubleClick(object sender, MouseEventArgs e)
		{

		}

		private void abstractClassToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AbstractClassBox abstractBox = new AbstractClassBox(10, 10, "I'm abstract!");
			_canvas.AddBoxToList(abstractBox);
		}

		private void interfaceToolStripMenuItem_Click(object sender, EventArgs e)
		{
			InterfaceBox interfaceBox = new InterfaceBox(10, 10, "I'm interface!");
			_canvas.AddBoxToList(interfaceBox);
		}
	}
}
