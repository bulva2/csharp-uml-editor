namespace DragAndDrop
{
    public class Canvas
    {
        private List<Box> _boxes;
        private Selection? _selection;

        public Canvas()
        {
            _boxes = new List<Box>();
            _selection = null;

            for(int i = 0; i < 5; i++)
            {
                Box box = new Box(10, (i * 100) + 10);
                _boxes.Add(box);
            }
        }

        public void Draw(Graphics g)
        {
            foreach (Box box in _boxes)
                box.Draw(g);
        }

        public void Select(int x, int y)
        {
            Unselect();
            for (int i = 0; i < _boxes.Count; i++)
            {
                Box box = _boxes[i];
                if (box.IsInCollisionWithCorner(x, y))
                {
                    //MessageBox.Show("Corner selected!");

                    _selection = new ResizeSelection(box, x, y);
                    _selection.Select();
                    return;
                }
                else if (box.IsInCollision(x, y))
                {
                    _selection = new MoveSelection(box, x, y);
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
    }
}
