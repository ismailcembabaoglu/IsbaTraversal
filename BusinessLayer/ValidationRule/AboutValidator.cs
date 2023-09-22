using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRule
{
    public class AboutValidator:AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(c => c.Description).NotEmpty().WithMessage("Açıklama Alanı Boş Geçilemez.");
            RuleFor(c=>c.Image1).NotEmpty().WithMessage("Lütfen Görsel Seçiniz");
            RuleFor(c=>c.Description).MinimumLength(50).WithMessage("Lütfen Görsel Seçiniz");
            RuleFor(c=>c.Description).MinimumLength(1500).WithMessage("Lütfen Açılamayı Azaltın");
        }
    }
}
