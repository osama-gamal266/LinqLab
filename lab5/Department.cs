namespace ClubExample
{
    class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Emp> Employees { get; set; } = new List<Emp>();

        public void AddEmployee(Emp emp)
        {
            if (!Employees.Contains(emp))
            {
                Employees.Add(emp);
                // Subscribe to employee event
                emp.AbsentExceeded += RemoveEmployee;
            }
        }

        private void RemoveEmployee(Emp emp)
        {
            Employees.Remove(emp);
            Console.WriteLine($"[INFO] {emp.Name} was removed from {Name} due to excessive absence.");
        }

        public override string ToString()
        {
            string list = Employees.Count == 0 ? "No Employees"
                                               : string.Join(", ", Employees);
            return $"{Id} - {Name} : [{list}]";
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            Department other = obj as Department;
            if (other == null) return false;

            return this.Id == other.Id;
        }

        public override int GetHashCode() => Id.GetHashCode();
    }
}
