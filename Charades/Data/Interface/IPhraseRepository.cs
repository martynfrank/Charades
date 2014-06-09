using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charades.Data.Interface
{
    public interface IPhraseRepository
    {
        IQueryable<Phrase> Phrases { get; }
    }
}
