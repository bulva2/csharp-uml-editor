﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
			_color = Brushes.LightCoral;
			_name = name;

			_formatCenter = new StringFormat()
			{
				Alignment = StringAlignment.Center,
				LineAlignment = StringAlignment.Center
			};
		}

        public override void Unselect()
        {
            _color = Brushes.LightCoral;
			_name = OriginalName;
        }
    }
}
