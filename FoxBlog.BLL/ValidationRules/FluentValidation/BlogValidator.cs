using FluentValidation;
using FoxBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoxBlog.BLL.ValidationRules.FluentValidation
{
    public class BlogValidator:AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.Image).NotEmpty().WithMessage("Resim yükleyiniz.");

            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık giriniz.");
            RuleFor(x => x.Title).MinimumLength(10).WithMessage("Başlık en az 10 karakter içermelidir.");

            RuleFor(x => x.Content).NotEmpty().WithMessage("İçerik giriniz.");
            RuleFor(x => x.Content).MinimumLength(150).WithMessage("İçerik en az 150 karakter içermelidir.");

            RuleFor(x => x.Description).NotEmpty().WithMessage("Sayfa açıklaması giriniz.");
            RuleFor(x => x.Description).MinimumLength(10).WithMessage("Sayfa açıklaması en az 10 karakter içermelidir.");

            RuleFor(x => x.Keyword).NotEmpty().WithMessage("Sayfa anahtar kelimesi giriniz.");
            RuleFor(x => x.Keyword).MinimumLength(10).WithMessage("Sayfa anahtar kelimesi en az 10 karakter içermelidir.");

            RuleFor(x => x.SeoUrl).NotEmpty().WithMessage("Sayfa Urlini giriniz.");
            RuleFor(x => x.SeoUrl).MinimumLength(10).WithMessage("Sayfa urli en az 10 karakter içermelidir.");
        }
    }
}
