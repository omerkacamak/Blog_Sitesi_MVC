using Datam.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Services.ValidationRules
{
    public class WriterValidator:AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(i => i.WriterName).NotEmpty().WithMessage("Yazar adı boş olamaz");
            RuleFor(i => i.WriterName).MinimumLength(4).WithMessage("Yazar adınız 4 karakterden az olamaz");
            RuleFor(i => i.WriterName).MaximumLength(20).WithMessage("Yazar adı 20 karakterden fazla olamaz");
            RuleFor(i => i.WriterPassword).NotEmpty().WithMessage("Şifre boş geçilemez.");
            
            

        }
    }
}
