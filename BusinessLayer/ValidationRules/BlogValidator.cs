using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
   public class BlogValidator : AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogBaslik).NotEmpty().WithMessage("Blog başlığını boş geçemezsiniz.");
            RuleFor(x => x.Blogicerik).NotEmpty().WithMessage("Blog içeriği boş geçemezsiniz.");
            RuleFor(x => x.BlogImg).NotEmpty().WithMessage("Blog görselini boş geçemezsiniz.");
            RuleFor(x => x.BlogBaslik).MaximumLength(150).WithMessage("Lütfen 150 karakterden daha az veri ğirişi yapın.");
            RuleFor(x => x.BlogBaslik).MinimumLength(2).WithMessage("Lütfen 2 karakterden fazla veri girişi yapın.");
            
        }
    }
}
