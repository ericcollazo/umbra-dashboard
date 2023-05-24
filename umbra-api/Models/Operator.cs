namespace react_learn.Models
{
    public class Operator
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = "n/a";
        public string LastName { get; set; } = "n/a";
        public Status CurrentStatus { get; set; }

        public enum Status
        {
            Active,
            Disavowed,
            Terminated,
            MIA
        }
    }
}