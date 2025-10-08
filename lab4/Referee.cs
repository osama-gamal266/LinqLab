namespace Lab5Solution
{
    public class Referee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public void MoveReferee(Object sender, PositionChancgedEvent e)
        {
            Ball b1 = sender as Ball;
            Console.WriteLine($"Referee:: ball Position Changed {this} , {b1.Position}");
        }

        public override string ToString()
        {
            return $"{Id} - {Name}";
        }
    }
}
