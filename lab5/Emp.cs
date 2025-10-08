namespace ClubExample
{
    class Emp
    {
        public event Action<Emp> AbsentExceeded;   // Event fired when absence > 3

        public int Id { get; set; }
        public string Name { get; set; }

        private int absentDays = 0;
        public int AbsentDays => absentDays;

        public void IncreaseAbsentDays()
        {
            absentDays++;
            if (absentDays > 3)
            {
                // Trigger the event if there are subscribers
                AbsentExceeded?.Invoke(this);
            }
        }

        public override string ToString()
        {
            return $"{Id} - {Name} - Absent:{absentDays}";
        }

        public override bool Equals(object obj)
        {
            return obj is Emp other && this.Id == other.Id;
        }

        public override int GetHashCode() => Id.GetHashCode();
    }
}
