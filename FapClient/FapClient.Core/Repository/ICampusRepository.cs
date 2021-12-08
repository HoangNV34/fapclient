using FapClient.Core.Models;
using System.Collections.Generic;

namespace FapClient.Core.Repository
{
    public interface ICampusRepository:ICoreRepository<Campus>
    {
        List<Campus> GetAll();
    }
}
