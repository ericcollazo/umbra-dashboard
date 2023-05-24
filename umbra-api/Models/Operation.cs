using System;
using System.Collections.Generic;

namespace react_learn.Models
{
	public class Operation
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public DateTime Begin { get; set; }
		public DateTime End { get; set; }
		public string Notes { get; set; }
		public List<Operator> Operators {get;set;}
	}
}

