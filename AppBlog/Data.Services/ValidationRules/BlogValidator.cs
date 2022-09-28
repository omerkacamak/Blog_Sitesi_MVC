using Datam.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Services.ValidationRules
{
    public class BlogValidator:AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(i => i.BlogTitle).MinimumLength(3).WithMessage("Başlık 3 karakterden küçük olamaz");
            RuleFor(i => i.BlogContent).MinimumLength(400).WithMessage("İçerik 400 karakterden küçük olamaz");
            RuleFor(i => i.BlogContent).NotEmpty().WithMessage("Boş Bırakamazsınız");
            RuleFor(i => i.BlogTitle).NotEmpty().WithMessage("Boş Bırakamazsınız");
            RuleFor(i => i.CategoryID).NotEmpty().WithMessage("Boş Bırakamazsınız");
            
        }
    }
}
