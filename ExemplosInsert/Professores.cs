//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExemplosInsert
{
    using System;
    using System.Collections.Generic;
    
    public partial class Professores
    {
        public Professores()
        {
            this.Certificacoes = new HashSet<Certificacoes>();
            this.CursosAgendados = new HashSet<CursosAgendados>();
            this.CursosClarify = new HashSet<CursosClarify>();
        }
    
        public int ID { get; set; }
        public int IdPessoa { get; set; }
        public Nullable<decimal> TempoMercado { get; set; }
        public Nullable<decimal> TempoSalaDeAula { get; set; }
    
        public virtual ICollection<Certificacoes> Certificacoes { get; set; }
        public virtual ICollection<CursosAgendados> CursosAgendados { get; set; }
        public virtual ICollection<CursosClarify> CursosClarify { get; set; }
        public virtual Pessoas Pessoas { get; set; }
    }
}
