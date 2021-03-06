using System.Linq.Expressions;

using KUSYSDemo.Business.Interfaces;
using KUSYSDemo.DataAccess.Interfaces;
using KUSYSDemo.Entities.Concrete;

namespace KUSYSDemo.Business.Concrete
{
    public class StudentManager : IStudentService
    {
        #region ctor
        private readonly IStudentDal _studentDal;
        public StudentManager(IStudentDal studentDal)
        {
            _studentDal = studentDal;
        }

        #endregion

        public void Add(Student entity)
        => _studentDal.Add(entity);

        public IEnumerable<Student> Find(Expression<Func<Student, bool>> expression)
        => _studentDal.Find(expression);

        public void Remove(Student entity)
        => _studentDal.Remove(entity);

        IEnumerable<Student> IGenericService<Student>.GetAll()
        => _studentDal.GetAll();

        Student IGenericService<Student>.GetById(int id)
        => _studentDal.GetById(id);

        public void Update(Student entity)
        => _studentDal.Update(entity);

    }
}
