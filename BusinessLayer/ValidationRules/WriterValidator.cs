using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
   public class WriterValidator :AbstractValidator<Yazar>
    {
        public WriterValidator()
        {
            RuleFor(x => x.yazarAd).NotEmpty().WithMessage("Yazar adı soyadı kısmı boş geçilemez.");
            RuleFor(x => x.yazarMail).NotEmpty().WithMessage("Mail adresi boş geçilemez.");
            RuleFor(x => x.yazarSifre).NotEmpty().WithMessage("Şifre boş geçilemez.");
            RuleFor(x => x.yazarAd).MinimumLength(2).WithMessage("Lütfen en az 2 karakter girişi yapın.");
            RuleFor(x => x.yazarAd).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakterlik veri girişi yapın.");
        }
    }
}
