using Leet.Data.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leet.Data.Repositories.Interfaces
{
	public interface IRepository<T>
		where T : IHasId
	{
		IQueryable<T> GetAll();
		T GetById(int id);
		void Add(T newValue);
		void Update(int id, T newValue);
		void Delete(int id);
	}
}
