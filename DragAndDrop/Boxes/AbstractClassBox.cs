using System.Text.Json.Serialization;

namespace DragAndDrop.Boxes
{
	public class AbstractClassBox : Box
	{
		public override string BoxType { get; set; } = "Abstract";
		public AbstractClassBox(int x, int y, string name) : base(x, y, name)
		{
			PositionX = x;
			PositionY = y;

			Width = 180;
			Height = 180;
			ColorBrush = Brushes.AliceBlue;
			Name = name;

			_formatCenter = new StringFormat()
			{
				Alignment = StringAlignment.Center,
				LineAlignment = StringAlignment.Center				
			};
		}

		[JsonConstructor]
        public AbstractClassBox(int positionX, int positionY, int width, int height, string originalName, string boxType, List<string> labelsText, List<string> methodsText, string colorName, int separator) : base(positionX, positionY, width, height, originalName, boxType, labelsText, methodsText, colorName, separator)
        {
        }

        public AbstractClassBox() : base(0, 0, string.Empty)
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

        public override void Draw(Graphics g)
		{
			g.TranslateTransform(PositionX, PositionY);

			g.FillRectangle(ColorBrush, 0, 0, Width, Height);
			g.FillRectangle(Brushes.Black, Width - 10, Height - 10, 10, 10);

			// Make it bold, just like in UML CD
			g.DrawString(Name, new Font("Segoe UI", 10, FontStyle.Bold | FontStyle.Italic), Brushes.Black, Width / 2, Height * 0.1f, _formatCenter);

			g.DrawLine(Pens.Black, 0, Height * 0.2f, Width, Height * 0.2f);

            DrawProperties(g);
            DrawMethods(g);
            UpdateMethodPositions();

            g.ResetTransform();
		}

		public override void Select()
		{
			ColorBrush = Brushes.LightBlue;
			Name = "Selected Abstract!";
		}

		public override void Unselect()
		{
			ColorBrush = Brushes.AliceBlue;
			Name = OriginalName;
		}
	}
}
