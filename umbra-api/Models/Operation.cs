namespace react_learn.Models
{
    public class Operation
	{
		public int Id { get; set; }
		public string Name { get; set; } = "n/a";
		public DateTime Begin { get; set; }
		public DateTime End { get; set; }
		public string Notes { get; set; } = "(none)";
		public List<Operator>? Operators {get;set;}
	}
}

