using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Domain.Entities
{
    //classe anemica, ou seja, sem regras de negócio, apenas com propriedades

    public sealed class User : BaseEntity
    {
        public string? Email { get; set; }
        public string? Name { get; set; }
    }
}
