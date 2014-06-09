using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Charades.Data.Interface;

namespace Charades.Data.Service
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork()
        {
            Context = new CharadesEntities();
            Context.Configuration.LazyLoadingEnabled = false;
        }

        public CharadesEntities Context { get; private set; }
    }
}