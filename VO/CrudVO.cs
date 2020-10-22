using Cadastro.Dao;
using Cadastro.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastroPessoas.VO
{
    class CrudVO
    {
        private int _id;
        private String _nome;
        private int _cpf;
        private Endereco _endereco;
        private Telefone _telefone;
       private Cadastro.Dao.PessoaDao dao;

        public CrudVO()
        {

        }

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        public String nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public int cpf
        {
            get { return _cpf; }
            set { _cpf = value; }
        }

        public Endereco endereco
        {
            get { return _endereco; }
            set { _endereco = value; }
        }

        public Telefone telefone
        {
            get { return _telefone; }
            set { _telefone = value; }
        }

        public void Inserir()
        {
            dao = new PessoaDao();
            dao.Insira(nome, cpf, endereco,telefone);
        }

        public void Atualizar()
        {
            dao = new PessoaDao();
            dao.Altera(nome, cpf, endereco, telefone);
        }

        public void Excluir()
        {
            dao = new PessoaDao();
            dao.Exclua (cpf);
        }

        public void Consulta()
        {
            dao = new PessoaDao();
            dao.Consulte(cpf);
        }

    }
}
