namespace DragAndDrop
{
    public class MoveSelection : Selection
    {
        public MoveSelection(Box box, int x, int y) 
            : base(box, x, y)
        { }

        public override void Move(int x, int y)
        {
            _selectedBox.Move(x - _relativeX, y - _relativeY);
        }
    }
}
