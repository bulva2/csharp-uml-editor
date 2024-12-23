namespace DragAndDrop.Boxes
{
    public abstract class Box
    {
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public int MinWidth => 80;
        public int MinHeight => 140;
        public int MaxWidth => 320;
        public int MaxHeight => 320;

        protected StringFormat _formatCenter;

        protected Brush _color;

        protected string _name;
        protected string _originalName;

        public Box(int x, int y, string name)
        {
            PositionX = x;
            PositionY = y;

            Width = 140;
            Height = 140;
            _color = Brushes.LightSkyBlue;

            _name = name;
            _originalName = name;

            _formatCenter = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
        }

        public void Select()
        {
            _color = Brushes.LightBlue;
            _name = "Selected";
        }

        public void Unselect()
        {
            _color = Brushes.LightSkyBlue;
            _name =  _originalName;
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

        public virtual void Draw(Graphics g)
        {
            // Set coords to begin in top-left corner of the box
            g.TranslateTransform(PositionX, PositionY);

            // Draw Box
            g.FillRectangle(_color, 0, 0, Width, Height);
            g.FillRectangle(Brushes.Black, Width - 10, Height - 10, 10, 10);

            // Name of the box (Class/Interface Name)
            g.DrawString(_name, new Font("Segoe UI", 10, FontStyle.Bold), Brushes.Black, Width / 2, Height * 0.1f, _formatCenter);

            // Line under the name
            g.DrawLine(Pens.Black, 0, Height * 0.2f, Width, Height * 0.2f);

            // Reset coords
            g.ResetTransform();
        }

        public bool IsInCollision(int x, int y)
        {
            return x > PositionX && x <= PositionX + Width
                && y > PositionY && y <= PositionY + Height;
        }

        public bool IsInCollisionWithCorner(int x, int y)
        {
            return x > PositionX + Width - 10 && x <= PositionX + Width
                && y > PositionY + Height - 10 && y <= PositionY + Height;
        }
    }
}
