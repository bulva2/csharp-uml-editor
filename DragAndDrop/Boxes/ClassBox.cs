﻿using System.Text.Json.Serialization;

namespace DragAndDrop.Boxes
{
    public class ClassBox : Box
    {
        public override string BoxType { get; set; } = "Class";

        public ClassBox(int x, int y, string name) : base(x, y, name)
        {
            PositionX = x;
            PositionY = y;

            Width = 180;
            Height = 180;
            ColorBrush = Brushes.LightSkyBlue;
            Name = name;

            _formatCenter = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
        }

        [JsonConstructor]
        public ClassBox(int positionX, int positionY, int width, int height, string originalName, string boxType, List<string> labelsText, List<string> methodsText, string colorName) : base(positionX, positionY, width, height, originalName, boxType, labelsText, methodsText, colorName)
        {
        }

        public ClassBox() : base(0, 0, 0, 0, string.Empty, "Class", new List<string>(), new List<string>(), string.Empty)
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
    }
}
