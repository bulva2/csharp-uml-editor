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

        private void classToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
