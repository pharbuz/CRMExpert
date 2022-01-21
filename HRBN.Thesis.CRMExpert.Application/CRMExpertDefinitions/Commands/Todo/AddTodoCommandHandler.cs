﻿using System;
using System.Threading.Tasks;
using AutoMapper;
using HRBN.Thesis.CRMExpert.Application.Core;
using HRBN.Thesis.CRMExpert.Application.Core.Command;
using HRBN.Thesis.CRMExpert.Domain.Core.Repositories;

namespace HRBN.Thesis.CRMExpert.Application.CRMExpertDefinitions.Commands.Todo
{
    public sealed class AddTodoCommandHandler : CommandHandlerBase<AddTodoCommand>
    {
        public AddTodoCommandHandler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public override async Task<Result> HandleAsync(AddTodoCommand command)
        {
            var validationResult = await new AddTodoCommandValidator().ValidateAsync(command);

            if (!validationResult.IsValid)
            {
                return Result.Fail(validationResult);
            }

            var todo = _mapper.Map<Domain.Core.Entities.Todo>(command);
            todo.Id = Guid.NewGuid();
            todo.CreDate = DateTime.Now;
            todo.ModDate = DateTime.Now;
            await _unitOfWork.TodosRepository.AddAsync(todo);
            await _unitOfWork.CommitAsync();

            return Result.Ok();
        }
    }
}
