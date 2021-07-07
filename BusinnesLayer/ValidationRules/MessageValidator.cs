using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnesLayer.ValidationRules
{
    public class MessageValidator : AbstractValidator<Message>
    {
        public MessageValidator()
        {
            RuleFor(x => x.ReceiverMail).NotEmpty().WithMessage("Alıcı Adresini boş geçemezsiniz..");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konuyu boş geçemezsiniz..");
            RuleFor(x => x.MessageContent).NotEmpty().WithMessage("Mesajı boş geçemezsiniz..");

            RuleFor(x => x.MessageContent).MinimumLength(5).WithMessage("Lütfen en az 5 karakter giriniz..");
            RuleFor(x => x.MessageContent).MaximumLength(200).WithMessage("Lütfen en fazla 200 karakter giriniz..");


        }
    }
}
