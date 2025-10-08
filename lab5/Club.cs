namespace ClubExample
{
    class Club
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Emp> Members { get; set; } = new List<Emp>();

        public override string ToString()
        {
            string list = Members.Count == 0 ? "No Members"
                                             : string.Join(", ", Members);
            return $"{Id} - {Name} : [{list}]";
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            Club other = obj as Club;
            if (other == null) return false;

            return this.Id == other.Id;
        }


        public override int GetHashCode() => Id.GetHashCode();
    }
}
