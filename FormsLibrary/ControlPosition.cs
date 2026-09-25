namespace FormsLibrary
{
    public class ControlPosition
    {
        public Point calcMiddle(Control control)
        {
            return new Point(control.Width/2, control.Height/2);
        }
    }
}
