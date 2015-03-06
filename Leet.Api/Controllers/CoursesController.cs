
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Leet.Data.Model.Interfaces;
using Leet.Data.Model;
using Leet.Data.Repositories.Interfaces;

namespace Leet.Api.Controllers
{
    public class CoursesController : LeetAbstractApiController<ICourse, Course>
    {
		public CoursesController(IRepository<ICourse> repository): 
			base(repository)
		{

		}
		
    }
}
