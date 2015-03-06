using Leet.Data.Model.Interfaces;
using Leet.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Leet.Api.Controllers.Interfaces
{
	public interface ILeetApiController<T, S, U>
		where T: IHasId
		where S: T
		where U : IRepository<T>
	{
		IEnumerable<T> Get();
		IHttpActionResult Get(int id);
		IHttpActionResult Post(S value);
		IHttpActionResult Put(int id, S value);
		IHttpActionResult Delete(int id);
	}
}