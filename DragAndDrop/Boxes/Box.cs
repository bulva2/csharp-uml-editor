namespace DragAndDrop.Boxes
{
    public abstract class Box
    {
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public string OriginalName { get; set; }

        public int MinWidth => 180;
        public int MinHeight => 180;
        public int MaxWidth => 360;
        public int MaxHeight => 360;

        protected StringFormat _formatCenter;
        protected Brush _color;
        protected string _name;

        protected List<Label> _labels;
        protected List<Label> _methods;

        private int _separator = 0;

        public Box(int x, int y, string name)
        {
            PositionX = x;
            PositionY = y;

            Width = 180;
            Height = 180;
            _color = Brushes.LightSkyBlue;

            _name = name;
            OriginalName = name;

            _labels = new List<Label>();
            _methods = new List<Label>();

            _formatCenter = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
        }

        public virtual void Select()
        {
            _color = Brushes.LightBlue;
            _name = "Selected";
        }

        public virtual void Unselect()
        {
            _color = Brushes.LightSkyBlue;
            _name =  OriginalName;
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

            UpdateLabelPositions();
            UpdateMethodPositions();
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

            DrawProperties(g);

			using (Pen pen = new Pen(Color.Black, 1))
			{
				g.DrawLine(pen, 0, _separator, Width, _separator);
			}

			DrawMethods(g);

            // Reset coords
            g.ResetTransform();
        }

        public bool IsInCollision(int x, int y)
        {
            return x > PositionX && x <= PositionX + Width
                && y > PositionY && y <= PositionY + Height;
        }

        public bool IsInCollisionWithHeader(int x, int y)
        {
            return x > PositionX && x <= PositionX + Width
                && y > PositionY && y <= PositionY + Height * 0.2f;
        }

        public bool IsInCollisionWithCorner(int x, int y)
        {
            return x > PositionX + Width - 10 && x <= PositionX + Width
                && y > PositionY + Height - 10 && y <= PositionY + Height;
        }

        public void AddProperty(string property)
        {
            Label propertyLabel = new Label()
            {
                Text = property,
                AutoSize = true,
                Location = new Point(10, ((Height * 2) / 9) + (_labels.Count * 20))
            };

            _labels.Add(propertyLabel);
            UpdateSeparator();
        }


        private void DrawProperties(Graphics g)
        {
            foreach (Label label in _labels)
                g.DrawString(label.Text, new Font("Segoe UI", 12), Brushes.Black, label.Location);
        }

        private void UpdateLabelPositions()
        {
            for (int i = 0; i < _labels.Count; i++)
            {
                _labels[i].Location = new Point(10, ((Height * 2) / 9) + (_labels.Count + i * 20));
            }
        }

        public void AddMethod(string method)
        {
            Label methodLabel = new Label()
            {
                Text = method,
                AutoSize = true,
                Location = new Point(10, _separator + 10 + (_methods.Count * 20))
			};
            _methods.Add(methodLabel);
        }
        private void DrawMethods(Graphics g)
        {
            foreach (Label label in _methods)
                g.DrawString(label.Text, new Font("Segoe UI", 12), Brushes.Black, label.Location);
        }
        private void UpdateMethodPositions()
        {
            for(int i = 0; i < _methods.Count; i++)
            {
				_methods[i].Location = new Point(10, _separator + 10 + (i * 20));
			}
        }
        public void UpdateBoxName() => _name = OriginalName;

        private void UpdateSeparator()
        {
            if(_labels.Count > 0)
            {
                Label lastProperty = _labels.Last();
                _separator = lastProperty.Location.Y + lastProperty.Height + 10;
            }
            else
            {
                _separator = (Height * 2) / 9;
            }

            UpdateMethodPositions();
        }
    }
}
