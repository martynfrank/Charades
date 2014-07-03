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

        public PhraseDto GetRandomPhrase()
        {
            var numberofPhrases = _phraseRepository.Phrases.Count();
            var random = new Random();
            var randomNumber = random.Next(0, numberofPhrases);
            var phrase = _phraseRepository.Phrases.OrderBy(x=> x.Id).Skip(randomNumber).First();
            return new PhraseDto { Name = phrase.Name, Year = phrase.Year, Type = phrase.Type };
        }
    }
}