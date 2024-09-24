﻿using BuildingBlocks.CQRS;
using Catalog.API.Models;
using MediatR;
using System.Windows.Input;

namespace Catalog.API.Products.CreateProduct
{
	public record CreateProductCommand(string Name, List<string> Category, string Description, string ImageFile, decimal Price): ICommand<CreateProductResult>;
	public record CreateProductResult(Guid id);
	public class CreateProductCommandHandler : ICommandHandler<CreateProductCommand, CreateProductResult>
	{
		public Task<CreateProductResult> Handle(CreateProductCommand command, CancellationToken cancellationToken)
		{
			var product = new Product
			{
				Name = command.Name,
				Category = command.Category,
				Description = command.Description,
				ImageFile = command.ImageFile,
				Price = command.Price,
			};
			throw new NotImplementedException();
		}
	}
}
