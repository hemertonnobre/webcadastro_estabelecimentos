using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Webcad_estabelecimentos.Util
{
	public class DAL
	{
		private static string Server = "localhost";
		private static string Database = "dbcadastro";
		private static string User = "root";
		private static string Password = "";
		private MySqlConnection Connection;

		private string ConnectionString =$"Server={Server};Database={Database};Uid={User};Pwd={Password};Sslmode=none;charset=utf8;";

		public DAL() { 
			Connection =new MySqlConnection(ConnectionString);
			Connection.Open();
		}

		//Executa : INSERT, UPDATA,DELETE

		public void ExecutarComandoSQL(string sql)
		{
			MySqlCommand Command = new MySqlCommand(sql, Connection);
			Command.ExecuteNonQuery();
		}

		//Retorna Dados do banco
		public DataTable RetornaDataTable(string sql)
		{
			MySqlCommand Command = new MySqlCommand(sql, Connection);
			MySqlDataAdapter DataAdaptar = new MySqlDataAdapter(Command);
			DataTable Dados = new DataTable();
			DataAdaptar.Fill(Dados);
            return Dados;

		}


	}
}
