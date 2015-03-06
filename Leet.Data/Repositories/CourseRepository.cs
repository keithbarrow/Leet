using Leet.Data.Model;
using Leet.Data.Model.Interfaces;
using Leet.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leet.Data.Repositories
{
	public class CourseRepository : IRepository<ICourse>
	{
		private List<ICourse> Courses = new List<ICourse>() { new Course() { Id = 0, Description = "Course 0" }, new Course(){ Id =1, Description ="Course 1"} };

		public IQueryable<ICourse> GetAll()
		{
			return Courses.AsQueryable();
		}

		public ICourse GetById(int id)
		{
			return Courses.SingleOrDefault(x => x.Id == id);

		}

		public void Update(int id, ICourse newValue)
		{
			var course = GetById(id);
			course.Description = newValue.Description;
		}

		public void Add(ICourse newValue)
		{
			Courses.Add(newValue);
		}

		public void Delete(int id)
		{
			var course = GetById(id);
			Courses.Remove(course);
		}
	}
}
