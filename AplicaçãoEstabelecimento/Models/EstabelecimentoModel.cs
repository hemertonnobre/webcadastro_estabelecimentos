using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace AplicacaoEstabelecimento.Models
{
    public class EstabelecimentoModel
    {
        public string Id { get; set; }
        
        public int Id_Status { get; set; }
        public string Status { get; set; }
        [DisplayName("Data Cadastro")]
        public string Data_Cadastro { get; set; }
        public int Id_Categoria { get; set; }
        public string Categoria { get; set; }
        [DisplayName("Razão Social")]
        public string Razao_Social { get; set; }
        [DisplayName("Nome Fantasia")]
        public string Nome_Fantasia { get; set; }
        public string Cnpj { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        [DisplayName("Número")]
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        [DisplayName("Estado")]
        public string UF { get; set; }
        public string Banco { get; set; }
        public string Agencia { get; set; }
        public string Conta { get; set; }

    }
}


