namespace DragAndDrop
{
    public class ResizeSelection : Selection
    {
        public ResizeSelection(Box box, int x, int y) 
            : base(box, x, y)
        { }

        public override void Move(int x, int y)
        {
            int dx = _selectedBox.Width - _relativeX;
            int dy = _selectedBox.Height - _relativeY;

            _selectedBox.Resize(x - _selectedBox.PositionX + dx, y - _selectedBox.PositionY + dy);

            _relativeX = _selectedBox.Width - dx;
            _relativeY = _selectedBox.Height - dy;
        }
    }
}
