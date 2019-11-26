using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Webcad_estabelecimentos.Util;

namespace Webcad_estabelecimentos.Models
{
    public class EstabelecimentoModel
    {
        public int Id { get; set; }
        public int Id_Status { get; set; }
        public string Status { get; set; }
        public string Data_Cadastro { get; set; }
        public int Id_Categoria { get; set; }
        public string Categoria { get; set; }
        public string Razao_Social { get; set; }
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
        public string Banco { get; set; }
        public string Agencia { get; set; }
        public string Conta { get; set; }

        public void Cadastrar() 
        {
            DAL objDAL = new DAL();

            string sql = " insert into estabelecimento(status, data_cadastro, categoria, razao_social, nome_fantasia, cnpj, telefone, email, cep, logradouro, numero, bairro, cidade, uf,banco, agencia, conta)" +
            			 $"values('{Id_Status}','{DateTime.Parse(Data_Cadastro).ToString("yyyy/MM/dd")}',"+
                         $"'{Id_Categoria}','{Razao_Social}','{Nome_Fantasia }','{Cnpj}','{Telefone }','{Email}','{ Cep}','{Logradouro}','{Numero }','{Bairro}','{Cidade }','{UF}','{Banco }', '{Agencia }','{Conta}')";
            
            objDAL.ExecutarComandoSQL(sql);

        }
        public void Atualizar()
        {
            DAL objDAL = new DAL();

            string sql = " update estabelecimento set " +
                $"status ='{Id_Status}'," +
                $"data_cadastro ='{DateTime.Parse(Data_Cadastro).ToString("yyyy/MM/dd")}'," +
                $"categoria ='{Id_Categoria}'," +
                $"razao_social = '{Razao_Social}'," +
                $"nome_fantasia = '{Nome_Fantasia}'," +
                $"cnpj = '{Cnpj}'," +
                $"telefone = '{Telefone}'," +
                $"email = '{Email}'," +
                $"cep ='{Cep}'," +
                $"logradouro ='{Logradouro}'," +
                $"numero ='{Numero}'," +
                $"bairro ='{Bairro}'," +
                $"cidade ='{Cidade}'," +
                $"uf='{UF}'," +
                $"banco ='{Banco}'," +
                $"agencia ='{Agencia}'," +
                $"conta ='{Conta}' where id ={Id}";

            objDAL.ExecutarComandoSQL(sql);
        }
        public void StatusEstabelecimento()
        {
            DAL objDAL = new DAL();

            string sql = " update estabelecimento set " +
                $"status ='{Status}'where id ={Id}";

            objDAL.ExecutarComandoSQL(sql);
        }
        public void Excluir(int id)
        {
            DAL objDAL = new DAL();

            string sql = $"delete  from estabelecimento where id={id}";
            objDAL.ExecutarComandoSQL(sql);           

        }
        public List<EstabelecimentoModel> Listar()
        {

            List<EstabelecimentoModel> lista = new List<EstabelecimentoModel>();
            EstabelecimentoModel item;

            DAL objDAL = new DAL();

            string sql = "select * from estabelecimento order by data_cadastro asc";
            DataTable dados = objDAL.RetornaDataTable(sql);

            for (int i = 0; i < dados.Rows.Count; i++)
            {
                item = new EstabelecimentoModel()
                {
                    Id = int.Parse(dados.Rows[i]["id"].ToString()),
                    Id_Status = int.Parse(dados.Rows[i]["status"].ToString()),
                    Status = ((EnumStatus)dados.Rows[i]["status"]).ToString(),
                    Data_Cadastro = DateTime.Parse(dados.Rows[i]["data_cadastro"].ToString()).ToString("dd/MM/yyyy"),
                    Id_Categoria = int.Parse(dados.Rows[i]["categoria"].ToString()),
                    Categoria =((EnumCategoria) dados.Rows[i]["categoria"]).ToString(),
                    Razao_Social = dados.Rows[i]["razao_social"].ToString(),
                    Nome_Fantasia = dados.Rows[i]["nome_fantasia"].ToString(),
                    Cnpj = dados.Rows[i]["cnpj"].ToString(),
                    Telefone = dados.Rows[i]["telefone"].ToString(),
                    Email = dados.Rows[i]["email"].ToString(),
                    Cep = dados.Rows[i]["cep"].ToString(),
                    Logradouro = dados.Rows[i]["logradouro"].ToString(),
                    Numero = dados.Rows[i]["numero"].ToString(),
                    Bairro = dados.Rows[i]["bairro"].ToString(),
                    Cidade = dados.Rows[i]["cidade"].ToString(),
                    UF = dados.Rows[i]["uf"].ToString(),
                    Banco = dados.Rows[i]["banco"].ToString(),
                    Agencia = dados.Rows[i]["agencia"].ToString(),
                    Conta = dados.Rows[i]["conta"].ToString()
                };
               lista.Add(item);
            }
            return lista;
        }
        public EstabelecimentoModel Retornar(int id)
        {      
            EstabelecimentoModel item;
            DAL objDAL = new DAL();

            string sql =$"select * from estabelecimento where id = {id}";
            DataTable dados = objDAL.RetornaDataTable(sql);

            item = new EstabelecimentoModel()
            {
                Id = int.Parse(dados.Rows[0]["id"].ToString()),
                Id_Status = int.Parse(dados.Rows[0]["status"].ToString()),
                Status = ((EnumStatus)dados.Rows[0]["status"]).ToString(),
                Data_Cadastro = DateTime.Parse(dados.Rows[0]["data_cadastro"].ToString()).ToString("dd/MM/yyyy"),
                Id_Categoria = int.Parse(dados.Rows[0]["categoria"].ToString()),
                Categoria = ((EnumCategoria)dados.Rows[0]["categoria"]).ToString(),
                Razao_Social = dados.Rows[0]["razao_social"].ToString(),
                Nome_Fantasia = dados.Rows[0]["nome_fantasia"].ToString(),
                Cnpj = dados.Rows[0]["cnpj"].ToString(),
                Telefone = dados.Rows[0]["telefone"].ToString(),
                Email = dados.Rows[0]["email"].ToString(),
                Cep = dados.Rows[0]["cep"].ToString(),
                Logradouro = dados.Rows[0]["logradouro"].ToString(),
                Numero = dados.Rows[0]["numero"].ToString(),
                Bairro = dados.Rows[0]["bairro"].ToString(),
                Cidade = dados.Rows[0]["cidade"].ToString(),
                UF = dados.Rows[0]["uf"].ToString(),
                Banco = dados.Rows[0]["banco"].ToString(),
                Agencia = dados.Rows[0]["agencia"].ToString(),
                Conta = dados.Rows[0]["conta"].ToString()
            };
            
           return item;
        }
    }
}


