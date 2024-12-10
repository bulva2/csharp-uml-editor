namespace DragAndDrop
{
    public abstract class Selection
    {
        protected Box _selectedBox;
        protected int _relativeX;
        protected int _relativeY;

        public Selection(Box box, int x, int y)
        {
            _selectedBox = box;
            _relativeX = x - box.PositionX;
            _relativeY = y - box.PositionY;
        }

        public void Select()
        {
            _selectedBox.Select();
        }

        public void Unselect()
        {
            _selectedBox.Unselect();
        }

        public abstract void Move(int x, int y);
    }
}
