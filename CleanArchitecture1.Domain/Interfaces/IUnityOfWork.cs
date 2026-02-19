using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Domain.Interfaces
{
    public interface IUnityOfWork //interface para salvar as alterações
    {
        Task Commit(CancellationToken cancellationToken);
    }
}
