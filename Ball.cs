namespace Lab5Solution
{
    public class Ball
    {
        Point position;
        public event EventHandler<PositionChancgedEvent> OnPositionChancged;

        public Point Position
        {
            get => position;
        }

        public void SetPosition(int x , int y)
        {
            PositionChancgedEvent e = new PositionChancgedEvent();
            e.DeltaX = this.position.X - x;
            e.DeltaY = this.position.Y - y;
            position.X = x;
            position.Y = y;
            OnPositionChancged.Invoke(this,e);

        }

        public override string ToString()
        {
            return $"Ball Position:{position}";
        }
    }
}
