namespace Lab5Solution
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public void MovePlayer(Object sender , PositionChancgedEvent e)
        {
            Ball b1 = sender as Ball;
            Console.WriteLine($"Player:: ball Position Changed {this} , {b1.Position}");
        }

        public override string ToString()
        {
            return $"{Id} - {Name}";
        }
    }
}
