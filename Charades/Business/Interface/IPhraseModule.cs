using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Charades.Business.Interface.DTO;

namespace Charades.Business.Interface
{
    public interface IPhraseModule
    {
        PhraseDto GetRandomPhrase();
    }
}
