using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragAndDrop.Boxes
{
	public class AbstractClassBox : Box
	{
		public AbstractClassBox(int x, int y, string name) : base(x, y, name)
		{
			PositionX = x;
			PositionY = y;

			Width = 140;
			Height = 140;
			_color = Brushes.AliceBlue;
			_name = name;

			_formatCenter = new StringFormat()
			{
				Alignment = StringAlignment.Center,
				LineAlignment = StringAlignment.Center				
			};
		}
		public override void Draw(Graphics g)
		{
			g.TranslateTransform(PositionX, PositionY);

			g.FillRectangle(_color, 0, 0, Width, Height);
			g.FillRectangle(Brushes.Black, Width - 10, Height - 10, 10, 10);

			// Make it bold, just like in UML CD
			g.DrawString(_name, new Font("Segoe UI", 10, FontStyle.Bold | FontStyle.Italic), Brushes.Black, Width / 2, Height * 0.1f, _formatCenter);

			g.DrawLine(Pens.Black, 0, Height * 0.2f, Width, Height * 0.2f);

			g.ResetTransform();
		}

		public override void Select()
		{
			_color = Brushes.LightBlue;
			_name = "Selected Abstract!";
		}

		public override void Unselect()
		{
			_color = Brushes.AliceBlue;
			_name = OriginalName;
		}
	}
}
