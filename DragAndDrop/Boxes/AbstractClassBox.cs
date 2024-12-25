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
	}
}
