﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control
{
    public class AcessoSqlServer
    {
        private readonly SqlParameterCollection sqlParameterCollection = new SqlCommand().Parameters;

        private SqlConnection CriarConexao()
        {
            return new SqlConnection("Data Source=DESKTOP-VNVBOD3\\SQLEXPRESS;Initial Catalog=HelpDesk;Integrated Security=True");
        }
        public void LimparParametros()
        {
            sqlParameterCollection.Clear();
        }
        public void AdicionarParametros(String nomeParametro, object valorParametro)
        {
            sqlParameterCollection.Add(new SqlParameter(nomeParametro, valorParametro));
        }
        public object ExecutarManipulacao(CommandType commandType, string nomeStoreProcedureOuTextoSql)
        {
            try
            {
                int codigo;

                SqlConnection sqlConnection = CriarConexao();
                sqlConnection.Open();

                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nomeStoreProcedureOuTextoSql;
                sqlCommand.CommandTimeout = 500;

                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }

                codigo = Convert.ToInt32(sqlCommand.ExecuteScalar());
                sqlConnection.Close();

                return codigo;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public DataTable ExecutarConsulta(CommandType commandType, string nomeStoreProcedureOuTextoSql)
        {
            SqlConnection sqlConnection = CriarConexao();
            
            try
            {
                
                sqlConnection.Open();

                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nomeStoreProcedureOuTextoSql;
                sqlCommand.CommandTimeout = 7200;

                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                sqlConnection.Close();

                return dataTable;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

    }
}
