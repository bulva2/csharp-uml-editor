using System.Drawing;
using System.Text.Json.Serialization;

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

        public List<string> labelsText => _labels.Select(l => l.Text).ToList();
        public List<string> methodsText => _methods.Select(l => l.Text).ToList();
        public string colorName => _color.ToString()!;

        [JsonInclude]
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
            _name = OriginalName;
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

            _separator = h - Height + ((Height * 2) / 9) + (_labels.Count * 20) + 10;
            
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
            DrawMethods(g);

			UpdateMethodPositions();

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
			using (Pen pen = new Pen(Color.Black, 1))
			{
				g.DrawLine(pen, 0, _separator, Width, _separator);
			}

			foreach (Label label in _methods)
                g.DrawString(label.Text, new Font("Segoe UI", 12), Brushes.Black, label.Location);
        }
        private void UpdateMethodPositions()
        {
            if(_labels.Count > 0)
			{
				for (int i = 0; i < _methods.Count; i++)
				{
					_methods[i].Location = new Point(10, (_separator) + 10 + (_methods.Count + i * 20));
				}
			}
			else
			{
				for(int i = 0; i < _methods.Count; ++i)
				{
					_methods[i].Location = new Point(10, ((Height * 2) / 9) + (_labels.Count + i * 20));
				}
			}
			
        }
        public void UpdateBoxName() => _name = OriginalName;

        private void UpdateSeparator()
        {
            if (_labels.Count > 0)
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
        public override string ToString()
        {
            return $"{OriginalName}";
        }
        public void DrawLineB1RightB2(Box b1, Box b2, Graphics g, Pen p)
        {
			Point p1 = new Point(b1.PositionX/* + b1.Width*/, b1.PositionY + b1.Height / 2);
			Point p2 = new Point(b2.PositionX + b2.Width, b2.PositionY + b2.Height / 2);

			g.DrawLine(p, p1, p2);
		}

        public void DrawLineB1LeftB2(Box b1, Box b2, Graphics g, Pen p)
		{
			Point p1 = new Point(b1.PositionX + b1.Width, b1.PositionY + b1.Height / 2);
			Point p2 = new Point(b2.PositionX, b2.PositionY + b2.Height / 2);

			g.DrawLine(p, p1, p2);
		}

        public void DrawLineB1OverB2(Box b1, Box b2, Graphics g, Pen p)
		{
			Point p1 = new Point(b1.PositionX + b1.Width / 2, b1.PositionY + b1.Height);
			Point p2 = new Point(b2.PositionX + b2.Width / 2, b2.PositionY);

			g.DrawLine(p, p1, p2);
		}

        public void DrawLineB1UnderB2(Box b1, Box b2, Graphics g, Pen p)
		{
			Point p1 = new Point(b1.PositionX + b1.Width / 2, b1.PositionY );
			Point p2 = new Point(b2.PositionX + b2.Width / 2, b2.PositionY + b1.Height);

			g.DrawLine(p, p1, p2);
		}
        public void DrawAssociation(Box b1, Box b2, Graphics g, Pen p, string rel, string relOrigin)
        {

        }
        public void DrawAgregation(Box b1, Box b2, Graphics g, Pen p, string rel, string relOrigin)
        {
			if (relOrigin == "source")
			{
				//b1<>-- b2
				if (b1.PositionX < b2.PositionX && b1.PositionX + b1.Width <= b2.PositionX)
				{
					Point[] points =
					{
						new Point(b1.PositionX + b1.Width, b1.PositionY + b1.Height / 2), //left
						new Point(b1.PositionX + b1.Width + 15, b1.PositionY + b1.Height / 2 + 8), //top
                        new Point(b1.PositionX + b1.Width  + 30, b1.PositionY + b1.Height / 2), //right
                        new Point(b1.PositionX + b1.Width + 15, b1.PositionY + b1.Height / 2 -8) //bottom
					};
					Point rotatePoint = new Point(b2.PositionX, b2.PositionY + b2.Height / 2);

					double angle = Math.Atan2(rotatePoint.Y - points[0].Y, rotatePoint.X - points[0].X);

					Point rotPt1 = RotatePoint(points[1], points[0], angle);
					Point rotPt2 = RotatePoint(points[2], points[0], angle);
					Point rotPt3 = RotatePoint(points[3], points[0], angle);

					Point[] rotatedPts =
					{
						points[0],
						rotPt1,
						rotPt2,
						rotPt3
					};

					g.DrawPolygon(p, rotatedPts);
				}

				//b2--<>b1
				else if (b1.PositionX > b2.PositionX && b2.PositionX + b2.Width <= b1.PositionX)
				{
					Point[] points =
					{
						new Point(b1.PositionX, b1.PositionY + b1.Height / 2), //left
						new Point(b1.PositionX - 15, b1.PositionY + b1.Height / 2 + 8), //top
                        new Point(b1.PositionX - 30, b1.PositionY + b1.Height / 2), //right
                        new Point(b1.PositionX - 15, b1.PositionY + b1.Height / 2 -8) //bottom
					};
					Point rotatePoint = new Point(b2.PositionX + b2.Width, b2.PositionY + b2.Height / 2);

					double angle = Math.Atan2(rotatePoint.Y - points[0].Y, rotatePoint.X - points[0].X);
					angle += Math.PI;

					Point rotPt1 = RotatePoint(points[1], points[0], angle);
					Point rotPt2 = RotatePoint(points[2], points[0], angle);
					Point rotPt3 = RotatePoint(points[3], points[0], angle);

					Point[] rotatedPts =
					{
						points[0],
						rotPt1,
						rotPt2,
						rotPt3
					};

					g.DrawPolygon(p, rotatedPts);
				}

				//b1^b2
				else if (b1.PositionY < b2.PositionY)
				{
					Point[] points =
					{
						new Point(b1.PositionX + b1.Width / 2, b1.PositionY + b1.Height), //left
						new Point(b1.PositionX + b1.Width / 2 + 8, b1.PositionY + b1.Height + 15), //top
                        new Point(b1.PositionX + b1.Width / 2, b1.PositionY + b1.Height + 30), //right
                        new Point(b1.PositionX + b1.Width / 2 - 8, b1.PositionY + b1.Height +15) //bottom
					};
					Point rotatePoint = new Point(b2.PositionX + b2.Width / 2, b2.PositionY);

					double angle = Math.Atan2(rotatePoint.Y - points[0].Y, rotatePoint.X - points[0].X);
					angle += (270 * (Math.PI / 180));

					Point rotPt1 = RotatePoint(points[1], points[0], angle);
					Point rotPt2 = RotatePoint(points[2], points[0], angle);
					Point rotPt3 = RotatePoint(points[3], points[0], angle);

					Point[] rotatedPts =
					{
						points[0],
						rotPt1,
						rotPt2,
						rotPt3
					};

					g.DrawPolygon(p, rotatedPts);
				}
				//b1ˇb2
				else if (b1.PositionY > b2.PositionY)
				{
					Point[] points =
					{
						new Point(b1.PositionX + b1.Width / 2, b1.PositionY), //left
						new Point(b1.PositionX + b1.Width / 2 + 8, b1.PositionY - 15), //top
                        new Point(b1.PositionX + b1.Width / 2, b1.PositionY - 30), //right
                        new Point(b1.PositionX + b1.Width / 2 - 8, b1.PositionY -15) //bottom
					};
					Point rotatePoint = new Point(b2.PositionX + b2.Width / 2, b2.PositionY + b2.Height);

					double angle = Math.Atan2(rotatePoint.Y - points[0].Y, rotatePoint.X - points[0].X);
					angle += (90 * (Math.PI / 180));

					Point rotPt1 = RotatePoint(points[1], points[0], angle);
					Point rotPt2 = RotatePoint(points[2], points[0], angle);
					Point rotPt3 = RotatePoint(points[3], points[0], angle);

					Point[] rotatedPts =
					{
						points[0],
						rotPt1,
						rotPt2,
						rotPt3
					};

					g.DrawPolygon(p, rotatedPts);
				}

			}
			else if (relOrigin == "target")
			{
				//b2<>-- b1
				if (b2.PositionX < b1.PositionX && b2.PositionX + b2.Width <= b1.PositionX)
				{
					Point[] points =
					{
						new Point(b2.PositionX + b2.Width, b2.PositionY + b2.Height / 2), //left
						new Point(b2.PositionX + b2.Width + 15, b2.PositionY + b2.Height / 2 + 8), //top
                        new Point(b2.PositionX + b2.Width  + 30, b2.PositionY + b2.Height / 2), //right
                        new Point(b2.PositionX + b2.Width + 15, b2.PositionY + b2.Height / 2 -8) //bottom
					};
					Point rotatePoint = new Point(b1.PositionX, b1.PositionY + b1.Height / 2);

					double angle = Math.Atan2(rotatePoint.Y - points[0].Y, rotatePoint.X - points[0].X);

					Point rotPt1 = RotatePoint(points[1], points[0], angle);
					Point rotPt2 = RotatePoint(points[2], points[0], angle);
					Point rotPt3 = RotatePoint(points[3], points[0], angle);

					Point[] rotatedPts =
					{
						points[0],
						rotPt1,
						rotPt2,
						rotPt3
					};

					g.DrawPolygon(p, rotatedPts);
				}

				//b1--<>b2
				else if (b2.PositionX > b1.PositionX && b1.PositionX + b1.Width <= b2.PositionX)
				{
					Point[] points =
					{
						new Point(b2.PositionX, b2.PositionY + b2.Height / 2), //left
						new Point(b2.PositionX - 15, b2.PositionY + b2.Height / 2 + 8), //top
                        new Point(b2.PositionX - 30, b2.PositionY + b2.Height / 2), //right
                        new Point(b2.PositionX - 15, b2.PositionY + b2.Height / 2 -8) //bottom
					};
					Point rotatePoint = new Point(b1.PositionX + b1.Width, b1.PositionY + b1.Height / 2);

					double angle = Math.Atan2(rotatePoint.Y - points[0].Y, rotatePoint.X - points[0].X);
					angle += Math.PI;

					Point rotPt1 = RotatePoint(points[1], points[0], angle);
					Point rotPt2 = RotatePoint(points[2], points[0], angle);
					Point rotPt3 = RotatePoint(points[3], points[0], angle);

					Point[] rotatedPts =
					{
						points[0],
						rotPt1,
						rotPt2,
						rotPt3
					};

					g.DrawPolygon(p, rotatedPts);
				}

				//b2^b1
				else if (b2.PositionY < b1.PositionY)
				{
					Point[] points =
					{
						new Point(b2.PositionX + b2.Width / 2, b2.PositionY + b2.Height), //left
						new Point(b2.PositionX + b2.Width / 2 + 8, b2.PositionY + b2.Height + 15), //top
                        new Point(b2.PositionX + b2.Width / 2, b2.PositionY + b2.Height + 30), //right
                        new Point(b2.PositionX + b2.Width / 2 - 8, b2.PositionY + b2.Height +15) //bottom
					};
					Point rotatePoint = new Point(b1.PositionX + b1.Width / 2, b1.PositionY);

					double angle = Math.Atan2(rotatePoint.Y - points[0].Y, rotatePoint.X - points[0].X);
					angle += (270 * (Math.PI / 180));

					Point rotPt1 = RotatePoint(points[1], points[0], angle);
					Point rotPt2 = RotatePoint(points[2], points[0], angle);
					Point rotPt3 = RotatePoint(points[3], points[0], angle);

					Point[] rotatedPts =
					{
						points[0],
						rotPt1,
						rotPt2,
						rotPt3
					};

					g.DrawPolygon(p, rotatedPts);
				}
				//b2ˇb1
				else if (b2.PositionY > b1.PositionY)
				{
					Point[] points =
					{
						new Point(b2.PositionX + b2.Width / 2, b2.PositionY), //left
						new Point(b2.PositionX + b2.Width / 2 + 8, b2.PositionY - 15), //top
                        new Point(b2.PositionX + b2.Width / 2, b2.PositionY - 30), //right
                        new Point(b2.PositionX + b2.Width / 2 - 8, b2.PositionY -15) //bottom
					};
					Point rotatePoint = new Point(b1.PositionX + b1.Width / 2, b1.PositionY + b1.Height);

					double angle = Math.Atan2(rotatePoint.Y - points[0].Y, rotatePoint.X - points[0].X);
					angle += (90 * (Math.PI / 180));

					Point rotPt1 = RotatePoint(points[1], points[0], angle);
					Point rotPt2 = RotatePoint(points[2], points[0], angle);
					Point rotPt3 = RotatePoint(points[3], points[0], angle);

					Point[] rotatedPts =
					{
						points[0],
						rotPt1,
						rotPt2,
						rotPt3
					};

					g.DrawPolygon(p, rotatedPts);
				}
			}
		}
        
        public void DrawComposition(Box b1, Box b2, Graphics g, Pen p, string rel, string relOrigin)
        {
            Brush b = new SolidBrush(Color.Black);
            if (relOrigin == "source")
			{
				//b1<>-- b2
				if (b1.PositionX < b2.PositionX && b1.PositionX + b1.Width <= b2.PositionX)
				{
					Point[] points =
					{
						new Point(b1.PositionX + b1.Width, b1.PositionY + b1.Height / 2), //left
						new Point(b1.PositionX + b1.Width + 15, b1.PositionY + b1.Height / 2 + 8), //top
                        new Point(b1.PositionX + b1.Width  + 30, b1.PositionY + b1.Height / 2), //right
                        new Point(b1.PositionX + b1.Width + 15, b1.PositionY + b1.Height / 2 -8) //bottom
					};
					Point rotatePoint = new Point(b2.PositionX, b2.PositionY + b2.Height / 2);

					double angle = Math.Atan2(rotatePoint.Y - points[0].Y, rotatePoint.X - points[0].X);

					Point rotPt1 = RotatePoint(points[1], points[0], angle);
					Point rotPt2 = RotatePoint(points[2], points[0], angle);
					Point rotPt3 = RotatePoint(points[3], points[0], angle);

					Point[] rotatedPts =
					{
						points[0],
						rotPt1,
						rotPt2,
						rotPt3
					};

					g.FillPolygon(b, rotatedPts);
				}

				//b2--<>b1
				else if (b1.PositionX > b2.PositionX && b2.PositionX + b2.Width <= b1.PositionX)
				{
					Point[] points =
					{
						new Point(b1.PositionX, b1.PositionY + b1.Height / 2), //left
						new Point(b1.PositionX - 15, b1.PositionY + b1.Height / 2 + 8), //top
                        new Point(b1.PositionX - 30, b1.PositionY + b1.Height / 2), //right
                        new Point(b1.PositionX - 15, b1.PositionY + b1.Height / 2 -8) //bottom
					};
					Point rotatePoint = new Point(b2.PositionX + b2.Width, b2.PositionY + b2.Height / 2);

					double angle = Math.Atan2(rotatePoint.Y - points[0].Y, rotatePoint.X - points[0].X);
					angle += Math.PI;

					Point rotPt1 = RotatePoint(points[1], points[0], angle);
					Point rotPt2 = RotatePoint(points[2], points[0], angle);
					Point rotPt3 = RotatePoint(points[3], points[0], angle);

					Point[] rotatedPts =
					{
						points[0],
						rotPt1,
						rotPt2,
						rotPt3
					};

					g.FillPolygon(b, rotatedPts);
				}

				//b1^b2
				else if (b1.PositionY < b2.PositionY)
				{
					Point[] points =
					{
						new Point(b1.PositionX + b1.Width / 2, b1.PositionY + b1.Height), //left
						new Point(b1.PositionX + b1.Width / 2 + 8, b1.PositionY + b1.Height + 15), //top
                        new Point(b1.PositionX + b1.Width / 2, b1.PositionY + b1.Height + 30), //right
                        new Point(b1.PositionX + b1.Width / 2 - 8, b1.PositionY + b1.Height +15) //bottom
					};
					Point rotatePoint = new Point(b2.PositionX + b2.Width / 2, b2.PositionY);

					double angle = Math.Atan2(rotatePoint.Y - points[0].Y, rotatePoint.X - points[0].X);
					angle += (270 * (Math.PI / 180));

					Point rotPt1 = RotatePoint(points[1], points[0], angle);
					Point rotPt2 = RotatePoint(points[2], points[0], angle);
					Point rotPt3 = RotatePoint(points[3], points[0], angle);

					Point[] rotatedPts =
					{
						points[0],
						rotPt1,
						rotPt2,
						rotPt3
					};

					g.FillPolygon(b, rotatedPts);
				}
				//b1ˇb2
				else if (b1.PositionY > b2.PositionY)
				{
					Point[] points =
					{
						new Point(b1.PositionX + b1.Width / 2, b1.PositionY), //left
						new Point(b1.PositionX + b1.Width / 2 + 8, b1.PositionY - 15), //top
                        new Point(b1.PositionX + b1.Width / 2, b1.PositionY - 30), //right
                        new Point(b1.PositionX + b1.Width / 2 - 8, b1.PositionY -15) //bottom
					};
					Point rotatePoint = new Point(b2.PositionX + b2.Width / 2, b2.PositionY + b2.Height);

					double angle = Math.Atan2(rotatePoint.Y - points[0].Y, rotatePoint.X - points[0].X);
					angle += (90 * (Math.PI / 180));

					Point rotPt1 = RotatePoint(points[1], points[0], angle);
					Point rotPt2 = RotatePoint(points[2], points[0], angle);
					Point rotPt3 = RotatePoint(points[3], points[0], angle);

					Point[] rotatedPts =
					{
						points[0],
						rotPt1,
						rotPt2,
						rotPt3
					};

					g.FillPolygon(b, rotatedPts);
				}

			}
			else if (relOrigin == "target")
			{
				//b2<>-- b1
				if (b2.PositionX < b1.PositionX && b2.PositionX + b2.Width <= b1.PositionX)
				{
					Point[] points =
					{
						new Point(b2.PositionX + b2.Width, b2.PositionY + b2.Height / 2), //left
						new Point(b2.PositionX + b2.Width + 15, b2.PositionY + b2.Height / 2 + 8), //top
                        new Point(b2.PositionX + b2.Width  + 30, b2.PositionY + b2.Height / 2), //right
                        new Point(b2.PositionX + b2.Width + 15, b2.PositionY + b2.Height / 2 -8) //bottom
					};
					Point rotatePoint = new Point(b1.PositionX, b1.PositionY + b1.Height / 2);

					double angle = Math.Atan2(rotatePoint.Y - points[0].Y, rotatePoint.X - points[0].X);

					Point rotPt1 = RotatePoint(points[1], points[0], angle);
					Point rotPt2 = RotatePoint(points[2], points[0], angle);
					Point rotPt3 = RotatePoint(points[3], points[0], angle);

					Point[] rotatedPts =
					{
						points[0],
						rotPt1,
						rotPt2,
						rotPt3
					};

					g.FillPolygon(b, rotatedPts);
				}

				//b1--<>b2
				else if (b2.PositionX > b1.PositionX && b1.PositionX + b1.Width <= b2.PositionX)
				{
					Point[] points =
					{
						new Point(b2.PositionX, b2.PositionY + b2.Height / 2), //left
						new Point(b2.PositionX - 15, b2.PositionY + b2.Height / 2 + 8), //top
                        new Point(b2.PositionX - 30, b2.PositionY + b2.Height / 2), //right
                        new Point(b2.PositionX - 15, b2.PositionY + b2.Height / 2 -8) //bottom
					};
					Point rotatePoint = new Point(b1.PositionX + b1.Width, b1.PositionY + b1.Height / 2);

					double angle = Math.Atan2(rotatePoint.Y - points[0].Y, rotatePoint.X - points[0].X);
					angle += Math.PI;

					Point rotPt1 = RotatePoint(points[1], points[0], angle);
					Point rotPt2 = RotatePoint(points[2], points[0], angle);
					Point rotPt3 = RotatePoint(points[3], points[0], angle);

					Point[] rotatedPts =
					{
						points[0],
						rotPt1,
						rotPt2,
						rotPt3
					};

					g.FillPolygon(b, rotatedPts);
				}

				//b2^b1
				else if (b2.PositionY < b1.PositionY)
				{
					Point[] points =
					{
						new Point(b2.PositionX + b2.Width / 2, b2.PositionY + b2.Height), //left
						new Point(b2.PositionX + b2.Width / 2 + 8, b2.PositionY + b2.Height + 15), //top
                        new Point(b2.PositionX + b2.Width / 2, b2.PositionY + b2.Height + 30), //right
                        new Point(b2.PositionX + b2.Width / 2 - 8, b2.PositionY + b2.Height +15) //bottom
					};
					Point rotatePoint = new Point(b1.PositionX + b1.Width / 2, b1.PositionY);

					double angle = Math.Atan2(rotatePoint.Y - points[0].Y, rotatePoint.X - points[0].X);
					angle += (270 * (Math.PI / 180));

					Point rotPt1 = RotatePoint(points[1], points[0], angle);
					Point rotPt2 = RotatePoint(points[2], points[0], angle);
					Point rotPt3 = RotatePoint(points[3], points[0], angle);

					Point[] rotatedPts =
					{
						points[0],
						rotPt1,
						rotPt2,
						rotPt3
					};

					g.FillPolygon(b, rotatedPts);
				}
				//b2ˇb1
				else if (b2.PositionY > b1.PositionY)
				{
					Point[] points =
					{
						new Point(b2.PositionX + b2.Width / 2, b2.PositionY), //left
						new Point(b2.PositionX + b2.Width / 2 + 8, b2.PositionY - 15), //top
                        new Point(b2.PositionX + b2.Width / 2, b2.PositionY - 30), //right
                        new Point(b2.PositionX + b2.Width / 2 - 8, b2.PositionY -15) //bottom
					};
					Point rotatePoint = new Point(b1.PositionX + b1.Width / 2, b1.PositionY + b1.Height);

					double angle = Math.Atan2(rotatePoint.Y - points[0].Y, rotatePoint.X - points[0].X);
					angle += (90 * (Math.PI / 180));

					Point rotPt1 = RotatePoint(points[1], points[0], angle);
					Point rotPt2 = RotatePoint(points[2], points[0], angle);
					Point rotPt3 = RotatePoint(points[3], points[0], angle);

					Point[] rotatedPts =
					{
						points[0],
						rotPt1,
						rotPt2,
						rotPt3
					};

					g.FillPolygon(b, rotatedPts);
				}
			}
		}
        
        // ! přizpůsobit origin šipek středu stran a ne středu boxu - špatně se vykresluje úhel
		public void DrawGeneralisation(Box b1, Box b2, Graphics g, Pen p, string rel, string relOrigin)
        {
			Brush b = new SolidBrush(Color.Black);
			if (relOrigin == "source")
			{
				//b1<|-- b2
				if (b1.PositionX < b2.PositionX && b1.PositionX + b1.Width <= b2.PositionX)
				{
					Point[] points =
					{
						new Point(b1.PositionX + b1.Width, b1.PositionY + b1.Height / 2),
						new Point(b1.PositionX + b1.Width + 15, b1.PositionY + b1.Height / 2 + 8),
                        new Point(b1.PositionX + b1.Width + 15, b1.PositionY + b1.Height / 2 -8)
					};

					Point rotatePoint = new Point(b2.PositionX, b2.PositionY + b2.Height / 2);

					double angle = Math.Atan2(rotatePoint.Y - points[0].Y, rotatePoint.X - points[0].X);

					Point rotPt1 = RotatePoint(points[1], points[0], angle);
					Point rotPt2 = RotatePoint(points[2], points[0], angle);

					Point[] rotatedPts =
					{
						points[0],
						rotPt1,
						rotPt2
					};

					g.FillPolygon(b, rotatedPts);
				}

				//b2--|>b1
				else if (b1.PositionX > b2.PositionX && b2.PositionX + b2.Width <= b1.PositionX)
				{
					Point[] points =
					{
						new Point(b1.PositionX, b1.PositionY + b1.Height / 2),
						new Point(b1.PositionX - 15, b1.PositionY + b1.Height / 2 + 8), 
                        new Point(b1.PositionX - 15, b1.PositionY + b1.Height / 2 -8)
					};
					Point rotatePoint = new Point(b2.PositionX + b2.Width, b2.PositionY + b2.Height / 2);

					double angle = Math.Atan2(rotatePoint.Y - points[0].Y, rotatePoint.X - points[0].X);
					angle += Math.PI;

					Point rotPt1 = RotatePoint(points[1], points[0], angle);
					Point rotPt2 = RotatePoint(points[2], points[0], angle);

					Point[] rotatedPts =
					{
						points[0],
						rotPt1,
						rotPt2
					};

					g.FillPolygon(b, rotatedPts);
				}

				//b1^b2
				else if (b1.PositionY < b2.PositionY)
				{
					Point[] points =
					{
						new Point(b1.PositionX + b1.Width / 2, b1.PositionY + b1.Height),
						new Point(b1.PositionX + b1.Width / 2 + 8, b1.PositionY + b1.Height + 15),
                        new Point(b1.PositionX + b1.Width / 2 - 8, b1.PositionY + b1.Height +15) 
					};
					Point rotatePoint = new Point(b2.PositionX + b2.Width/2, b2.PositionY);

					double angle = Math.Atan2(rotatePoint.Y - points[0].Y, rotatePoint.X - points[0].X);
					
					angle += (270 * (Math.PI / 180));
					Point rotPt1 = RotatePoint(points[1], points[0], angle);
					Point rotPt2 = RotatePoint(points[2], points[0], angle);

					Point[] rotatedPts =
					{
						points[0],
						rotPt1,
						rotPt2
					};

					g.FillPolygon(b, rotatedPts);
				}
				//b1ˇb2
				else if (b1.PositionY > b2.PositionY)
				{					
					Point[] points =
					{
						new Point(b1.PositionX + b1.Width / 2, b1.PositionY), //left
						new Point(b1.PositionX + b1.Width / 2 + 8, b1.PositionY - 15), //top
                        new Point(b1.PositionX + b1.Width / 2 - 8, b1.PositionY -15) //bottom
					};
					Point rotatePoint = new Point(b2.PositionX + b2.Width / 2, b2.PositionY + b2.Height);

					double angle = Math.Atan2(rotatePoint.Y - points[0].Y, rotatePoint.X - points[0].X);
					angle += (90 * (Math.PI / 180));

					Point rotPt1 = RotatePoint(points[1], points[0], angle);
					Point rotPt2 = RotatePoint(points[2], points[0], angle);

					Point[] rotatedPts =
					{
						points[0],
						rotPt1,
						rotPt2
					};

					g.FillPolygon(b, rotatedPts);
				}

			}
			else if (relOrigin == "target")
			{
				//b2<>-- b1
				if (b2.PositionX < b1.PositionX && b2.PositionX + b2.Width <= b1.PositionX)
				{
					Point[] points =
					{
						new Point(b2.PositionX + b2.Width, b2.PositionY + b2.Height / 2), //left
						new Point(b2.PositionX + b2.Width + 15, b2.PositionY + b2.Height / 2 + 8), //top
                        new Point(b2.PositionX + b2.Width + 15, b2.PositionY + b2.Height / 2 -8) //bottom
					};
					Point rotatePoint = new Point(b1.PositionX, b1.PositionY + b1.Height / 2);

					double angle = Math.Atan2(rotatePoint.Y - points[0].Y, rotatePoint.X - points[0].X);

					Point rotPt1 = RotatePoint(points[1], points[0], angle);
					Point rotPt2 = RotatePoint(points[2], points[0], angle);

					Point[] rotatedPts =
					{
						points[0],
						rotPt1,
						rotPt2
					};

					g.FillPolygon(b, rotatedPts);
				}

				//b1--<>b2
				else if (b2.PositionX > b1.PositionX && b1.PositionX + b1.Width <= b2.PositionX)
				{
					Point[] points =
					{
						new Point(b2.PositionX, b2.PositionY + b2.Height / 2),
						new Point(b2.PositionX - 15, b2.PositionY + b2.Height / 2 + 8), 
                        new Point(b2.PositionX - 15, b2.PositionY + b2.Height / 2 -8) 
					};
					Point rotatePoint = new Point(b1.PositionX + b1.Width, b1.PositionY + b1.Height / 2);

					double angle = Math.Atan2(rotatePoint.Y - points[0].Y, rotatePoint.X - points[0].X);
					angle += Math.PI;

					Point rotPt1 = RotatePoint(points[1], points[0], angle);
					Point rotPt2 = RotatePoint(points[2], points[0], angle);

					Point[] rotatedPts =
					{
						points[0],
						rotPt1,
						rotPt2
					};
					g.FillPolygon(b, rotatedPts);
				}

				//b2^b1
				else if (b2.PositionY < b1.PositionY)
				{
					Point[] points =
					{
						new Point(b2.PositionX + b2.Width / 2, b2.PositionY + b2.Height),
						new Point(b2.PositionX + b2.Width / 2 + 8, b2.PositionY + b2.Height + 15), 
                        new Point(b2.PositionX + b2.Width / 2 - 8, b2.PositionY + b2.Height +15)
					};
					Point rotatePoint = new Point(b1.PositionX + b1.Width / 2, b1.PositionY);

					double angle = Math.Atan2(rotatePoint.Y - points[0].Y, rotatePoint.X - points[0].X);

					angle += (270 * (Math.PI / 180));
					Point rotPt1 = RotatePoint(points[1], points[0], angle);
					Point rotPt2 = RotatePoint(points[2], points[0], angle);

					Point[] rotatedPts =
					{
						points[0],
						rotPt1,
						rotPt2
					};

					g.FillPolygon(b, rotatedPts);
				}
				//b2ˇb1
				else if (b2.PositionY > b1.PositionY)
				{
					Point[] points =
					{
						new Point(b2.PositionX + b2.Width / 2, b2.PositionY),
						new Point(b2.PositionX + b2.Width / 2 + 8, b2.PositionY - 15),
                        new Point(b2.PositionX + b2.Width / 2 - 8, b2.PositionY -15)
					};
					Point rotatePoint = new Point(b1.PositionX + b1.Width / 2, b1.PositionY + b1.Height);

					double angle = Math.Atan2(rotatePoint.Y - points[0].Y, rotatePoint.X - points[0].X);
					angle += (90 * (Math.PI / 180));

					Point rotPt1 = RotatePoint(points[1], points[0], angle);
					Point rotPt2 = RotatePoint(points[2], points[0], angle);

					Point[] rotatedPts =
					{
						points[0],
						rotPt1,
						rotPt2
					};

					g.FillPolygon(b, rotatedPts);
				}
			}
		}
		private Point RotatePoint(Point pt, Point pivot, double angle)
		{
			int x = pivot.X + (int)((pt.X - pivot.X) * Math.Cos(angle) - (pt.Y - pivot.Y) * Math.Sin(angle));
			int y = pivot.Y + (int)((pt.X - pivot.X) * Math.Sin(angle) + (pt.Y - pivot.Y) * Math.Cos(angle));
			return new Point(x, y);
		}
	}
}
