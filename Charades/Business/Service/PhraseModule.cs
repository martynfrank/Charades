using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Charades.Business.Interface;
using Charades.Business.Interface.DTO;
using Charades.Data.Interface;

namespace Charades.Business.Service
{
    public class PhraseModule : IPhraseModule
    {
        private readonly IPhraseRepository _phraseRepository;

        public PhraseModule(IPhraseRepository phraseRepository)
        {
            _phraseRepository = phraseRepository;
        }

        public IEnumerable<PhraseDto> GetRandomPhrase()
        {
            return _phraseRepository.Phrases.Select(x => new PhraseDto { Name = x.Name, Year = x.Year, Type = x.Type });
        }
    }
}