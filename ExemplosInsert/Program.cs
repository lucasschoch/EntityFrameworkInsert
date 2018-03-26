using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemplosInsert
{
    class Program
    {
        static void Main(string[] args)
        {
            //InsertSimples();
            //InsertGrupo();
            //InsertDependentes();

        }

        private static void InsertDependentes()
        {
            using (ClarifyDBEntities ctx = new ClarifyDBEntities())
            {
                var pessoa = new Pessoas()
                {
                    PrimeiroNome = "Luis",
                    UltimoNome = "Geraldo",
                    DtNascimento = DateTime.Now.AddYears(-18),
                    Endereco = "Rua Xpto 12345566543"
                };
                ctx.Pessoas.Add(pessoa);

                var professor = new Professores()
                {
                    Pessoas = pessoa,
                    TempoMercado = 3,
                    TempoSalaDeAula = 2
                };
                ctx.Professores.Add(professor);

                for (int i = 0; i < 3; i++)
                {
                    var cert = new Certificacoes()
                    {
                        Descricao = "Game Boy Expert Nível " + i.ToString(),
                        EmpresaEmissora = "Nintendo",
                        Professores = professor
                    };
                    ctx.Certificacoes.Add(cert);
                }

                ctx.SaveChanges();
            }
        }

        private static void InsertGrupo()
        {
            using (ClarifyDBEntities ctx = new ClarifyDBEntities())
            {
                var pessoa = new Pessoas()
                {
                    PrimeiroNome = "Fernando",
                    UltimoNome = "Pessoa",
                    DtNascimento = DateTime.Now.AddYears(-25),
                    Endereco = "Rua Zpto 133"
                };
                ctx.Pessoas.Add(pessoa);
                var pessoa2 = new Pessoas()
                {
                    PrimeiroNome = "Alberto",
                    UltimoNome = "Garcia",
                    DtNascimento = DateTime.Now.AddYears(-23),
                    Endereco = "Rua Xpto dd 2"
                };
                ctx.Pessoas.Add(pessoa2);

                ctx.SaveChanges();
            }
        }

        private static void InsertSimples()
        {
            using (ClarifyDBEntities ctx = new ClarifyDBEntities())
            {
                var pessoa = new Pessoas()
                {
                    PrimeiroNome = "Luis",
                    UltimoNome = "Geraldo",
                    DtNascimento = DateTime.Now.AddYears(-18),
                    Endereco = "Rua Xpto 12345566543"
                };

                ctx.Pessoas.Add(pessoa);
                ctx.SaveChanges();
            }
        }
    }
}
