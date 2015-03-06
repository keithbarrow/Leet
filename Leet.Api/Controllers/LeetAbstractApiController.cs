using Leet.Api.Controllers.Interfaces;
using Leet.Data.Model.Interfaces;
using Leet.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;

namespace Leet.Api.Controllers
{
	public class LeetAbstractApiController<T, S> : ApiController, ILeetApiController<T, S, IRepository<T>>
		where T: IHasId
		where S: T
	{
		IRepository<T> Repository { get; set; }

		public IEnumerable<T> Get()
		{
			return Repository.GetAll();
		}

		public IHttpActionResult Get(int id)
		{
			var course = Repository.GetById(id);
			if (course == null)
			{
				return NotFound();
			}
			return Ok(course);
		}


		public IHttpActionResult Post(S value)
		{
			try
			{
				Repository.Add(value);
				return Ok();
			}
			catch (Exception ex)
			{
				return StatusCode(HttpStatusCode.InternalServerError);
			}
		}

		public IHttpActionResult Put(int id, S value)
		{
			try
			{
				Repository.Update(id, value);
				return Ok();
			}
			catch (Exception ex)
			{
				return StatusCode(HttpStatusCode.InternalServerError);
			}
		}

		public IHttpActionResult Delete(int id)
		{
			try
			{
				Repository.Delete(id);
				return Ok();
			}
			catch (Exception ex)
			{
				return StatusCode(HttpStatusCode.InternalServerError);
			}

		}


		public LeetAbstractApiController(IRepository<T> repository)
		{
			Repository = repository;
		}
	}
}