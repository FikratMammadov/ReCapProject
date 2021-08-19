using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFColorDal : IColorDal
    {
        public void Add(Color entity)
        {
            using (ReCapContext context = new ReCapContext())
            {
                context.Set<Color>().Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(Color entity)
        {
            using (ReCapContext context = new ReCapContext())
            {
                context.Set<Color>().Remove(entity);
                context.SaveChanges();
            }
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> filter)
        {
            using (ReCapContext context = new ReCapContext())
            {
                return filter == null ? context.Set<Color>().ToList()
                     : context.Set<Color>().Where(filter).ToList();
            }
        }

        public Color GetById(Expression<Func<Color, bool>> filter)
        {
            using (ReCapContext context = new ReCapContext())
            {
                return context.Set<Color>().SingleOrDefault(filter);
            }
            
        }

        public void Update(Color entity)
        {
            using (ReCapContext context = new ReCapContext())
            {
                context.Set<Color>().Update(entity);
                context.SaveChanges();
            }
        }
    }
}
