using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Charades.Infrastructure.Enum;

namespace Charades.Business.Interface.DTO
{
    public class PhraseDto
    {
        public string Name { get; set; }
        public int? Year { get; set; }
        public PhraseType Type { get; set; }
    }
}