using FluentValidation;
using FoxBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoxBlog.BLL.ValidationRules.FluentValidation
{
    public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Kategori adı giriniz.");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("Kategori adı en az 3 karakter içermelidir.");
        }
    }
}
