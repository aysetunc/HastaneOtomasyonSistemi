using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hastane.DAL;

namespace Hastane.BLL
{
    public class RepositoryBase<T, ID> where T : class
    {
        protected internal static MyContext dbContext;

        public List<T> GetALL()
        {
            dbContext = new MyContext();
            return dbContext.Set<T>().ToList();
        }
        public T GetByID(ID id)
        {
            dbContext = new MyContext();
            return dbContext.Set<T>().Find(id);
        }
        public virtual void Insert(T entity)
        {
            try
            {
                dbContext = dbContext ?? new MyContext();
                dbContext.Set<T>().Add(entity);
                dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                dbContext = new MyContext();
                throw new Exception(ex.Message);
            }
        }
        public virtual void Delete(T entity)
        {
            try
            {
                dbContext = dbContext ?? new MyContext();
                dbContext.Set<T>().Remove(entity);
                dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual void Update()
        {
            try
            {
                dbContext.SaveChanges();
                dbContext = new MyContext();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
