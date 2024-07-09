﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeApi.Application.UnitOfWorks;
using YoutubeApi.Domain.Entities;

namespace YoutubeApi.Application.Features.Products.Queries.GetAllProducts
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQueryRequest, IList<GetAllProductsQueryResponse>>
    {
        private readonly IUnitOfWork unitOfWork;

        public GetAllProductsQueryHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public async Task<IList<GetAllProductsQueryResponse>> Handle(GetAllProductsQueryRequest request, CancellationToken cancellationToken)
        {
            var products = await unitOfWork.GetReadRepository<Product>().GetAllAsync();

            List<GetAllProductsQueryResponse> response = new();

            foreach (var product in products)
            {
                response.Add(new GetAllProductsQueryResponse
                {
                    Description = product.Description,
                    Title = product.Title,
                    Price = product.Price -(product.Price*product.Discount / 100),
                    Discount = product.Discount,
                });

            }
            return response;
        }
    }
}