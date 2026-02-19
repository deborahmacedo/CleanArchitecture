using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Domain.Entities
{
    public abstract class BaseEntity 
    {
        public Guid Id { get; set; }
        public DateTimeOffset DateCreated { get; set; }
        public DateTimeOffset? DateUpdated { get; set; } //a ? reprenta que a propriedade é opcional, ou seja, pode ser nula
        public DateTimeOffset? DateDeleted { get; set; }

    }
}
