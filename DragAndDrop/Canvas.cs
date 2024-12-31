﻿using DragAndDrop.Boxes;
using System.Reflection.Metadata.Ecma335;

namespace DragAndDrop
{
    public class Canvas
    {
        public List<Box> _boxes;
        private Selection? _selection;
        private ListManipulator<Box> _manipulator;
        private List<(Box, Box)> _connections = new List<(Box, Box)>();

        public Canvas()
        {
            _boxes = new List<Box>();
            _selection = null;
            _manipulator = new ListManipulator<Box>(_boxes);

            for(int i = 0; i < 2; i++)
            {
                Box box = new ClassBox(10, (i * 300) + 10, i.ToString());
                _boxes.Add(box);
            }
        }

        public void Draw(Graphics g)
        {
            foreach (Box box in _boxes)
            {
                box.Draw(g);
				using(Pen p = new Pen(Color.Black, 2))
                foreach (var (b1, b2) in _connections)
				{
                        CheckLines(b1, b2, g, p);
				}
			}
        }

        public Box? SelectRC(int x, int y)
        {
            Unselect();

            for (int i = _boxes.Count - 1; i >= 0; i--)
            {
                Box box = _boxes[i];
                if (box.IsInCollision(x, y))
                {
                    return box;
                }
            }

            return null;
        }

        public Box? SelectHeader(int x, int y)
        {
            Unselect();

            for (int i = _boxes.Count - 1; i >= 0; i--)
            {
                Box box = _boxes[i];
                if (box.IsInCollisionWithHeader(x, y))
                {
                    return box;
                }
            }

            return null;
        }

        public void Select(int x, int y)
        {
            Unselect();

            for (int i = _boxes.Count - 1; i >= 0; i--)
            {
                Box box = _boxes[i];
                if (box.IsInCollisionWithCorner(x, y))
                {
                    _selection = new ResizeSelection(box, x, y);

                    _manipulator.MoveToLast(i);
                    _selection.Select();
                    return;
                }
                else if (box.IsInCollision(x, y))
                {
                    _selection = new MoveSelection(box, x, y);

                    _manipulator.MoveToLast(i);
                    _selection.Select();
                    return;
                }
            }
        }

        public void Unselect()
        {
            if (_selection == null)
                return;

            _selection.Unselect();
            _selection = null;
        }

        public void Move(int x, int y)
        {
            if (_selection == null)
                return;

            _selection.Move(x, y);
        }

        public void AddBoxToList(Box box) => _boxes.Add(box);

        public void RemoveBoxFromList(Box box) => _boxes.Remove(box);

        public bool DoesBoxNameExist(string name)
        {
            return _boxes.Exists(box => box.OriginalName == name);
        }
        public void AddConnection(Box b1, Box b2)
        {
            _connections.Add((b1, b2));
        }
        public void CheckLines(Box b1, Box b2, Graphics g, Pen p)
        {
			foreach (Box box in _boxes)
            {
                if (b1.PositionX < b2.PositionX && b1.PositionX + b1.Width <=  b2.PositionX)
                {
                    box.DrawLineB1LeftB2(b1, b2, g, p);
                    return;
                }
                else if (b1.PositionX > b2.PositionX && b2.PositionX + b2.Width <= b1.PositionX)
                {
                    box.DrawLineB1RightB2(b1, b2, g, p);
                    return;
                }
                else if (b1.PositionY < b2.PositionY)
                {
                    box.DrawLineB1OverB2(b1, b2, g, p);
                    return;
                }
                else if (b1.PositionY > b2.PositionY)
                {
                    box.DrawLineB1UnderB2(b1, b2, g, p);
                    return;
                }
                return;
			}
		}
    }
}
