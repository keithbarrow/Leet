using Leet.Data.Model.Interfaces;
using Leet.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Leet.Data.Model
{
	public class Course : ICourse
	{
		public int    Id { get; set; }
		public string Description { get; set; }
	}
}