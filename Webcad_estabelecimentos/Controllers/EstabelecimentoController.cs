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
	public class EstabelecimentoController : ControllerBase
	{
		// GET api/values
		[HttpGet]
        [Route("Listar")]
		public List<EstabelecimentoModel> Listar()
		{
            return new EstabelecimentoModel().Listar();
		}

		// leitura
		[HttpGet]
        [Route("Retornar/{id}")]
		public EstabelecimentoModel Retornar(int id)
		{
            return new EstabelecimentoModel().Retornar(id);
        }

		// insere
		[HttpPost]
        [Route("Cadastrar")]
        
        public ReturnAllServices Cadastrar([FromBody]EstabelecimentoModel dados)
		{
            ReturnAllServices retorno = new ReturnAllServices();

            try
            {
                dados.Cadastrar();
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

        // atualiza
        [HttpPut]
        [Route("Atualizar")]
        public ReturnAllServices Atualizar([FromBody]EstabelecimentoModel dados)
         {
            ReturnAllServices retorno = new ReturnAllServices();

            try
            {
                dados.Atualizar();
                retorno.Result = true;
                retorno.ErrorMessege = string.Empty;
            }
            catch (Exception ex)
            {
                retorno.Result = false;
                retorno.ErrorMessege = "Erro ao tentar atualizar um Estabelecimento: " + ex.Message;

            }

            return retorno;
        }

        [HttpPut]
        [Route("Status/{id}")]
        public ReturnAllServices Status(int id)
        {
            ReturnAllServices retorno = new ReturnAllServices();

            try
            {
                EstabelecimentoModel dados = Retornar(id);
                dados.Id_Status = (dados.Id_Status == 0 ? 1 : 0);
                dados.StatusEstabelecimento();
                retorno.Result = true;
                retorno.ErrorMessege = string.Empty;
            }
            catch (Exception ex)
            {
                retorno.Result = false;
                retorno.ErrorMessege = "Erro ao tentar atualizar um Estabelecimento: " + ex.Message;

            }

            return retorno;
        }

        // excluir
        [HttpDelete]
        [Route("Excluir/{id}")]
        public void Excluir(int id)
        {
            new EstabelecimentoModel().Excluir(id);
        }
    } 
 }
