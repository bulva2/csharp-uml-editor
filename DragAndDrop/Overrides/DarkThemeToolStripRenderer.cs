namespace DragAndDrop.Overrides
{
    public class DarkThemeToolStripRenderer : ToolStripProfessionalRenderer
    {
        // Kinda useful source code of .NET Forms for this class
        // https://github.com/dotnet/winforms/blob/762a4c3961b09f37eaa5ed619700fcbb45881615/src/System.Windows.Forms/src/System/Windows/Forms/Controls/ToolStrips/ToolStripHighContrastRenderer.cs#L176
        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            if (e.ToolStrip == null)
                return;

            if (!e.ToolStrip.IsDropDown)
            {
                if (e.Item.Selected)
                {
                    SolidBrush brush = new SolidBrush(Color.FromArgb(70, 70, 70));
                    e.Graphics.FillRectangle(brush, new Rectangle(Point.Empty, e.Item.Size));
                }
                else
                {
                    SolidBrush brush = new SolidBrush(Color.FromArgb(35, 35, 35));
                    e.Graphics.FillRectangle(brush, new Rectangle(Point.Empty, e.Item.Size));
                }
            } else
            {
                base.OnRenderMenuItemBackground(e);
            }
        }
    }
}
