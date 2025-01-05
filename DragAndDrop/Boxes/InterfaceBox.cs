using System.Text.Json.Serialization;

namespace DragAndDrop.Boxes
{
	public class InterfaceBox : Box
	{
		public override string BoxType { get; set; } = "Interface";
		public InterfaceBox(int x, int y, string name) : base(x, y, name)
		{
			PositionX = x;
			PositionY = y;

			Width = 180;
			Height = 180;
			ColorBrush = Brushes.LightCoral;
			Name = name;

			_formatCenter = new StringFormat()
			{
				Alignment = StringAlignment.Center,
				LineAlignment = StringAlignment.Center
			};
		}

		[JsonConstructor]
        public InterfaceBox(int positionX, int positionY, int width, int height, string originalName, string boxType, List<string> labelsText, List<string> methodsText, string colorName) : base(positionX, positionY, width, height, originalName, boxType, labelsText, methodsText, colorName)
        {

        }
        
        public InterfaceBox() : base(0, 0, 0, 0, string.Empty, "Interface", new List<string>(), new List<string>(), string.Empty)
        {
            PositionX = 0;
            PositionY = 0;

            Width = 180;
            Height = 180;
            ColorBrush = Brushes.LightSkyBlue;
            Name = string.Empty;

            _formatCenter = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
        }

        public override void Unselect()
        {
            ColorBrush = Brushes.Coral;
			Name = OriginalName;
        }

        public override void Select()
        {
            ColorBrush = Brushes.LightCoral;
        }

        public override void Draw(Graphics g)
        {
            // Set coords to begin in top-left corner of the box
            g.TranslateTransform(PositionX, PositionY);

            // Draw Box
            g.FillRectangle(ColorBrush, 0, 0, Width, Height);
            g.FillRectangle(Brushes.Black, Width - 10, Height - 10, 10, 10);

            // Name of the box (Class/Interface Name)
            g.DrawString($"<<Interface>>\n{Name}", new Font("Segoe UI", 10, FontStyle.Bold), Brushes.Black, Width / 2, Height * 0.1f, _formatCenter);

            // Line under the name
            g.DrawLine(Pens.Black, 0, Height * 0.2f, Width, Height * 0.2f);

            DrawProperties(g);
            DrawMethods(g);

            UpdateMethodPositions();

            // Reset coords
            g.ResetTransform();
        }
    }
}
