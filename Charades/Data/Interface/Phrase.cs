//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Charades.Data.Interface
{
    using System;
    using System.Collections.Generic;
    
    public partial class Phrase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> Year { get; set; }
        public Charades.Infrastructure.Enum.PhraseType Type { get; set; }
    }
}
