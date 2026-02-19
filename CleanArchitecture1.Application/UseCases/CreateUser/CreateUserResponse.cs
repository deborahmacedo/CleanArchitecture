using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.UseCases.CreateUser
{
    public sealed record CreateUserResponse
    {
        public Guid Id { get; init; }
        public string? Name { get; init; }
        public string? Email { get; init; }  
    }
}
