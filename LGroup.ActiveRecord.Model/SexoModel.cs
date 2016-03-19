using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//subimos pra memoria a dll responsavel por fazer o mapeamento das tabelas e campos
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

//quando trabalhamos com EF utilizandoo Code First(Só Codigo), temos 2 formas de fazer o mapeamento do banco e das tabelas
//1 -> Fluent API = Arquivo de Mapeamento, Forma de Lambda x=> x
//2 -> Data Annotation = Atributos[]

//A melhor forma é sempre a Fluent Api, não tem limitações...
//Limitações dos Data Annotations:
//1-> Mapeamento de Relacionamento N pra N
//2-> Não da pra fazer Mapeamento de Campo Decimal(Dinheiro)
//3-> Não da pra mapear Stored Procedure
//4-> Não da pra configurar a Exclusão em Cascata 


namespace LGroup.ActiveRecord.Model
{
    //utilizamos a Anotação(Configurações Adicionais) - Opcionais
    [Table("TB_SEXO1")]
    public sealed class SexoModel : Base.IBaseModel<SexoModel>
    {
        [Key]
        [Column("ID_SEXO", TypeName = "INT")]
        public Int32 Codigo { get; set; }

        [Required]
        [MaxLength(09)]
        [Column("DS_SEXO", TypeName = "VARCHAR")]
        public string Descricao { get; set; }

        public void Cadastrar()
        {
            throw new NotImplementedException();
        }

        public void Atualizar()
        {
            throw new NotImplementedException();
        }

        public void Deletar()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SexoModel> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
