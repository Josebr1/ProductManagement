using FluentValidation;
using ProductManagement.Package.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.Package.Validators
{
    class ProductValidador : AbstractValidator<Product>
    {
        public ProductValidador()
        {
            RuleFor(product => product.Description).NotNull().NotEqual("").WithMessage("Descrição Invalido. Redigite !!");
            RuleFor(product => product.Unit).NotNull().WithMessage("Unidade Invalido. Redigite !!");
            RuleFor(product => product.StockQuantity).NotNull().WithMessage("Quantidade no estoque Invalido. Redigite !!");
            RuleFor(product => product.Characteristics).NotNull().NotEqual("").WithMessage("Características Invalido. Redigite !!");
            RuleFor(product => product.CodProvider).NotNull().WithMessage("Fornecedor Invalido. Redigite !!");
        }
    }
}
