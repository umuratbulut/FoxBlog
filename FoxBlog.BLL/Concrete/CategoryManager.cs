using Core.Aspects.Autofac.Validation;
using FoxBlog.BLL.Abstract;
using FoxBlog.BLL.ValidationRules.FluentValidation;
using FoxBlog.DAL.Abstract;
using FoxBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoxBlog.BLL.Concrete
{
   public class CategoryManager:ICategoryService
    {
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        private ICategoryDal _categoryDal;

        [ValidationAspect(typeof(CategoryValidator))]
        public void Add(Category category)
        {
            _categoryDal.Add(category);
        }

        public Category Find(int id)
        {
            return _categoryDal.Find(x => x.ID.Equals(id) && x.isActive.Equals(true));
        }

        public List<Category> GetList()
        {
            return _categoryDal.GetList().Where(x=>x.isActive.Equals(true)).ToList();
        }

        public void Remove(Category category)
        {
            _categoryDal.Remove(category);
        }

        public void Update(Category category)
        {
            _categoryDal.Update(category);
        }

    }
}
