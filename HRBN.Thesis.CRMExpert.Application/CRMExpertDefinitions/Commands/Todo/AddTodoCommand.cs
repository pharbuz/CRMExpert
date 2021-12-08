﻿using System;
using HRBN.Thesis.CRMExpert.Application.Core.Command;

namespace HRBN.Thesis.CRMExpert.Application.CRMExpertDefinitions.Commands.Todo
{
    public sealed class AddTodoCommand : ICommand
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public Guid ContactId { get; set; }
        public Guid CommandKey { get; }
    }
}