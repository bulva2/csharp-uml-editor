namespace DragAndDrop
{
    public class Box
    {
        public int PositionX { get; private set; }
        public int PositionY { get; private set; }
        public int Width { get; private set; }
        public int Height { get; private set; }

        public int MinWidth => 80;
        public int MinHeight => 140;
        public int MaxWidth => 320;
        public int MaxHeight => 320;

        private StringFormat _formatCenter;

        private Brush _color;
        private string _text;

        public Box(int x, int y)
        {
            PositionX = x;
            PositionY = y;

            Width = 140;
            Height = 140;
            _color = Brushes.LightSkyBlue;
            _text = "Box";

            _formatCenter = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
        }

        public void Select()
        {
            _color = Brushes.LightBlue;
            _text = "Selected";
        }

        public void Unselect()
        {
            _color = Brushes.LightSkyBlue;
            _text = "Box";
        }

        public void Move(int x, int y)
        {
            PositionX = x;
            PositionY = y;
        }

        public void Resize(int w, int h)
        {
            if (w < MinWidth)
                w = MinWidth;

            if (h < MinHeight)
                h = MinHeight;

            if (w > MaxWidth)
                w = MaxWidth;

            if (h > MaxHeight)
                h = MaxHeight;

            Width = w;
            Height = h;
        }

        public void Draw(Graphics g)
        {
            g.TranslateTransform(PositionX, PositionY);
            g.FillRectangle(_color, 0, 0, Width, Height);
            g.FillRectangle(Brushes.Black, Width - 10, Height - 10, 10, 10);

            g.DrawString(Height.ToString(), new Font("Arial", 10), Brushes.Black, Width / 2, Height * 0.3f, _formatCenter);

            g.DrawString(_text, new Font("Arial", 10), Brushes.Black, Width / 2, Height * 0.1f, _formatCenter);
            g.ResetTransform();
        }

        public bool IsInCollision(int x, int y)
        {
            return x > PositionX && x <= PositionX + Width
                && y > PositionY && y <= PositionY + Height;
        }

        public bool IsInCollisionWithCorner(int x, int y)
        {
            return x > (PositionX + Width - 10) && x <= PositionX + Width
                && y > (PositionY + Height - 10) && y <= PositionY + Height;
        }
    }
}
