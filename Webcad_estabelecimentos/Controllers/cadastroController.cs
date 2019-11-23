using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Webcad_estabelecimentos.Models;
using Webcad_estabelecimentos.Util;

namespace Webcad_estabelecimentos.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class cadastroController : ControllerBase
	{
		// GET api/values
		[HttpGet]
		public ActionResult<IEnumerable<string>> Get()
		{
			DAL objDAL = new DAL();

			//string sql = " insert into estabelesimento(situação, data_cadastro, categoria, razão_social, nome_fantasia, cnpj, telefone, email, cep, logradouro, numero, bairro, cidade, uf, agencia, conta)" +
			//			 "values('1','2019/11/21', 'Restaurante', 'ServeBemretaurante.ltda', 'Casa do Sabor', '0567.000/0001.38', '38656524', 'servebem@yahoo.com', '13186-987', 'Rua Amaral', '503', 'Santa Gertrudes', 'Hortolandia', 'SP', '23455-0', '1318865')";
			//objDAL.ExecutarComandoSQL(sql);

			return new string[] { "value1", "value2" };
		}

		// GET api/values/5
		[HttpGet("{id}")]
		public ActionResult<string> Get(int id)
		{
			DAL objDAL = new DAL();
			string sql = $"SELECT * from estabelesimento where id ={id}";
			DataTable dados = objDAL.RetornaDataTable(sql);

			return  dados.Rows[0]["situação"].ToString();
        }

		// POST api/values
		[HttpPost]
        [Route("cadastroestabelecimento")]
        
        public ReturnAllServices CadastroEstabelecimento([FromBody]EstabelecimentoModel dados)
		{
            ReturnAllServices retorno = new ReturnAllServices();

            try
            {
                dados.CadastroEstabelecimento();
                retorno.Result = true;
                retorno.ErrorMessege = string.Empty;
            }
            catch (Exception ex)
            {
               retorno.Result = false;
               retorno.ErrorMessege = "Erro ao tentar registrar um Estabelecimento: " + ex.Message;

            }

            return retorno;
        }

		// PUT api/values/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/values/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
