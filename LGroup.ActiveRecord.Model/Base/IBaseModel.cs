using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//O padrao Active Record, não é um padrão GOF, foi criado por Martin Fowler
//Existe desde 2003 = Padrao de Acesso a Dados
//Os Modelos alem de armazenar dados, tambem acessam DADOS
//Teremos Conexões e CRUD dentro dos Modelos
//É o oposto do DAO, Active Record (Model + DAO)


namespace LGroup.ActiveRecord.Model.Base
{
    //Desenhamos o CRUD
    public interface IBaseModel<TModelo>
    {
        //Normalmente, tudo tem que ser Void, e não pode ter parametros de entrada
        //Os parametros de entrada são os campos da propria classe Model, são metodos Virgens

        void Cadastrar();
        void Atualizar();
        void Deletar();
        IEnumerable<TModelo> Listar();
    }
}
