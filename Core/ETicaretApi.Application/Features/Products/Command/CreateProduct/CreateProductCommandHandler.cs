using ETicaret.Domain.Entities;
using ETicaretApi.Application.Features.Products.Rules;
using ETicaretApi.Application.Interfaces.UnitOfWorks;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApi.Application.Features.Products.Command.CreateProduct
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommandRequest, Unit>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly ProductRules productRules;

        public CreateProductCommandHandler(IUnitOfWork unitOfWork, ProductRules productRules)
        {
            this.unitOfWork = unitOfWork;
            this.productRules = productRules;
        }
        public async Task<Unit> Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
        {
            IList<Product> products = await unitOfWork.GetReadRepository<Product>().GetAllAsync();

            //if (products.Any(x => x.Title == request.Title))
            //    throw new Exception("aynı başlıkta ürün olamaz."); This could be also but it is not available for Single Responsibility and CleanCode

            await productRules.ProductTitleMustNotBeSame(products, request.Title); 

            Product product = new(request.Title, request.Description, request.Price, request.Discount, request.BrandId);

            await unitOfWork.GetWriteRepository<Product>().AddAsync(product);

            if (await unitOfWork.SaveAsync() > 0) //controls the product save or not
            {
                foreach (var categoryId in request.CategoryIds) // if the product saved, it creates the categories (many to many) 
                    await unitOfWork.GetWriteRepository<ProductCategory>().AddAsync(new()
                    {
                        ProductId = product.Id,
                        CategoryId = categoryId
                    });
                await unitOfWork.SaveAsync();
            }
            return Unit.Value;
        }
    }
}
