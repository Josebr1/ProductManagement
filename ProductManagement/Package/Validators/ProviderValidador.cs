using FluentValidation;
using ProductManagement.Package.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.Package.Validators
{
    class ProviderValidador : AbstractValidator<Provider>
    {
        public ProviderValidador()
        {
            RuleFor(provider => provider.SocialName).NotNull().NotEqual("").WithMessage("Razão Social Invalido. Redigite !!");
            RuleFor(provider => provider.FantasyName).NotNull().NotEqual("").WithMessage("Nome Fantasia Invalido. Redigite !!");
            RuleFor(provider => provider.CNPJ).NotNull().NotEqual("").WithMessage("CNPJ Invalido. Redigite !!");
            RuleFor(provider => provider.Address).NotNull().NotEqual("").WithMessage("Endereço Invalido. Redigite !!");
            RuleFor(provider => provider.Number).NotNull().NotEqual("").WithMessage("Número Invalido. Redigite !!");
            RuleFor(provider => provider.Neighborhood).NotNull().NotEqual("").WithMessage("Bairro Invalido. Redigite !!");
            RuleFor(provider => provider.City).NotNull().NotEqual("").WithMessage("Cidade Invalido. Redigite !!");
            RuleFor(provider => provider.Phone).NotNull().NotEqual("").WithMessage("Fone Invalido. Redigite !!");
            RuleFor(provider => provider.NameContact).NotNull().NotEqual("").WithMessage("Nome contato Invalido. Redigite !!");
            RuleFor(provider => provider.Email).NotNull().NotEqual("").EmailAddress().WithMessage("E-Mail Invalido. Redigite !!");
            RuleFor(provider => provider.Site).NotNull().NotEqual("").WithMessage("Site Invalido. Redigite !!");
        }
    }
}
