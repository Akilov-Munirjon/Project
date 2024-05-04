using FluentValidation;
using Project01.Application.Features.ServicesEquipments.Commands.CreateServiceEquipment;

namespace Project01.Application.Features.ServicesEquipments.Commands.CreateServicesEquipment
{
    public class AdditionServicesEquipmentCommandValidaton : AbstractValidator<CreateServicesEquipmentsCommand>
    {
        public AdditionServicesEquipmentCommandValidaton()
        {
            RuleFor(x => x.ServiceId)
                   .NotNull()
                   .NotEmpty()
                   .WithMessage("Идентификатор услуги не может быть пустым"); 


            RuleFor(x => x.EquipmentId)
                   .NotNull()
                   .NotEmpty()
                   .WithMessage("Идентификатор оборудования не может быть пустым");
        }
    }
}
