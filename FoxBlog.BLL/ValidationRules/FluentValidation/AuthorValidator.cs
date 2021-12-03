using FluentValidation;
using FoxBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoxBlog.BLL.ValidationRules.FluentValidation
{
   public class AuthorValidator : AbstractValidator<Author>
    {
        public AuthorValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Adınızı giriniz.");
            RuleFor(x => x.Name).MinimumLength(2).WithMessage("Adınız en az 2 karakter içermelidir.");

            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyadınızı giriniz.");
            RuleFor(x => x.Surname).MinimumLength(2).WithMessage("Soyadınız en az 2 karakter içermelidir.");

            RuleFor(x => x.Email).NotEmpty().WithMessage("Email adresinizi giriniz.");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Geçerli bir email adresi giriniz.");

            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifrenizi giriniz.");
            RuleFor(x => x.Password).MinimumLength(8).WithMessage("Şifreniz en az 8 karakter içermelidir.");


        }
    }
}
