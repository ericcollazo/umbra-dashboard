namespace react_learn.Models
{
    public class Operator
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
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