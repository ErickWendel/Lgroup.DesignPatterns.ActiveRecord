using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using LGroup.ActiveRecord.Model.Database;

namespace LGroup.ActiveRecord.Model
{
    [Table("TB_CONTATO")]
    public sealed class ContatoModel : Base.IBaseModel<ContatoModel>
    {
        //inicializamos a conexao
        private readonly Conexao _conexao = new Conexao();

        [Key]
        [Column("ID_CONTATO", TypeName = "INT")]
        public Int32 Codigo { get; set; }

        [Required]
        [Column("ID_SEXO", TypeName = "INT")]
        public Int32 CodigoSexo { get; set; }


        [Required]
        [Column("ID_ESTADO_CIVIL", TypeName = "INT")]
        public Int32 CodigoEstadoCivil { get; set; }

        [Required]
        [MaxLength(50)]
        [Column("NM_CONTATO", TypeName = "VARCHAR")]
        public String Nome { get; set; }

        [Required]
        [MaxLength(30)]
        [Column("DS_EMAIL", TypeName = "VARCHAR")]
        public String Email { get; set; }

        [Required]
        [Column("DT_NASCIMENTO", TypeName = "DATETIME")]
        public DateTime DataNascimento { get; set; }

        [Required]
        [MaxLength(15)]
        [Column("NR_TELEFONE", TypeName = "VARCHAR")]
        public String Telefone { get; set; }

        //RELACIONAMENTOS
        [ForeignKey("CodigoSexo")]
        public SexoModel Sexo { get; set; }

        [ForeignKey("CodigoEstadoCivil")]
        public EstadoCivilModel EstadoCivil { get; set; }


        public void Cadastrar()
        {
            //graças aos Data Annotations conseguimos fazer validações sem IFs, sem Data Annotations, tem que fazer If(Braçal)

            //A classe ValidationContext dispara as anotações de 1 determinada classe (this)
            var contexto = new ValidationContext(this);

            //cada campo que nao foi devidamente preenchido, ele retorna 1 erro = ValidationResult
            var erros = new List<ValidationResult>();

            //Disparamos as validacoes
            Validator.TryValidateObject(this, contexto, erros);

            if (erros.Count() == 0)
            {

                //o this é a palavra de Contexto para pegar a classe corrente
                //this -> filha = classe corrente
                //base -> classe pai

                _conexao.Contato.Add(this);
                _conexao.SaveChanges();
            }
        }

        public void Atualizar()
        {
            //buscamos o registro pelo codigo
            var registro = _conexao.Contato.Find(Codigo);

            //atualizamos o registro encontrado
            registro.Nome = Nome;
            registro.Email = Email;
            registro.Telefone = Telefone;
            registro.DataNascimento = DataNascimento;

            _conexao.SaveChanges();
        }

        public void Deletar()
        {
            //buscamos o registro pelo codigo
            var registro = _conexao.Contato.Find(Codigo);
            _conexao.Contato.Remove(registro);
            _conexao.SaveChanges();

        }

        public IEnumerable<ContatoModel> Listar()
        {
            return _conexao.Contato.ToList();
        }
    }
}
