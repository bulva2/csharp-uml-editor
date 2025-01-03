using System.Text.Json.Serialization;

namespace DragAndDrop.Boxes
{
	public class InterfaceBox : Box
	{
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
        public InterfaceBox(int positionX, int positionY, int width, int height, string originalName, string boxType, List<string> labelsText, List<string> methodsText, string colorName, int separator) : base(positionX, positionY, width, height, originalName, boxType, labelsText, methodsText, colorName, separator)
        {

        }

        public InterfaceBox() : base(0, 0, string.Empty)
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
            ColorBrush = Brushes.LightCoral;
			Name = OriginalName;
        }
    }
}
