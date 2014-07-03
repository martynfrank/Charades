using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Charades.Data.Interface;

namespace Charades.Data.Service
{
    public class PhraseRepository : IPhraseRepository
    {
        private CharadesEntities _context;

        public PhraseRepository()
        {
            _context = new CharadesEntities();
            _context.Configuration.LazyLoadingEnabled = false;
        }

        public IQueryable<Phrase> Phrases
        {
            get
            {
                return _context.Phrases;
            }
        }
    }
}