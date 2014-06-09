using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Charades.Data.Interface
{
    public interface IUnitOfWork
    {
        CharadesEntities Context { get; }
    }
}