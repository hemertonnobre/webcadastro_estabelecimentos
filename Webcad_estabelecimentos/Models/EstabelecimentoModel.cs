using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webcad_estabelecimentos.Util;

namespace Webcad_estabelecimentos.Models
{
    public class EstabelecimentoModel
    {
        public int Id { get; set; }
        public string Situação { get; set; }
        public string Data_Cadastro { get; set; }
        public string Categoria { get; set; }
        public string Razão_Social { get; set; }
        public string Nome_Fantasia { get; set; }
        public string Cnpj { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string Agencia { get; set; }
        public string Conta { get; set; }

        public void CadastroEstabelecimento() 
        {
            DAL objDAL = new DAL();

            string sql = " insert into estabelesimento(situação, data_cadastro, categoria, razão_social, nome_fantasia, cnpj, telefone, email, cep, logradouro, numero, bairro, cidade, uf, agencia, conta)" +
            			 $"values('{Situação}','{DateTime.Parse(Data_Cadastro).ToString("yyyy/MM/dd")}',"+
                         $"'{Categoria}','{Razão_Social}','{Nome_Fantasia }','{Cnpj}','{Telefone }','{Email}','{ Cep}','{Logradouro}','{Numero }','{Bairro}','{Cidade }','{UF}','{Agencia }','{Conta}')";
            objDAL.ExecutarComandoSQL(sql);


        }
    }
}


