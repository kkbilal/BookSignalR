using FluentValidation;
using SignalR.DtoLayer.BookingDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BussinesLayer.ValidationRules
{
    public class CreateBookingValidation : AbstractValidator<CreateBookingDto>
    {
        public CreateBookingValidation()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim kısmı boş geçilemez.");
            RuleFor(x => x.Phone).NotEmpty().WithMessage("Telefon kısmı boş geçilemez.");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail kısmı boş geçilemez.");
            RuleFor(x => x.PersonCount).NotEmpty().WithMessage("Kişi Sayısı kısmı boş geçilemez.");

            RuleFor(x => x.Description).MaximumLength(350).WithMessage("Lütfen 350 karakterden daha az veri girin.");

            RuleFor(x => x.Mail).EmailAddress().WithMessage("Lütfen geçerli bir mail adresi girin.");
        }
    }
}
