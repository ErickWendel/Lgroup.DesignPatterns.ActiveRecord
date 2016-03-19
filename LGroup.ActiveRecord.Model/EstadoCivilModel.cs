using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LGroup.ActiveRecord.Model
{
    [Table("TB_ESTADO_CIVL")]
    public sealed class  EstadoCivilModel:Base.IBaseModel<EstadoCivilModel>
    {

        [Key]
        [Column("ID_ESTADO_CIVIL", TypeName = "INT")]
        public Int32 Codigo { get; set; }

        [Required]
        [MaxLength(20)]
        [Column("DS_ESTADO_CIVIL", TypeName = "VARCHAR")]
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

        public IEnumerable<EstadoCivilModel> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
