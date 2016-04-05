using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace Interface2_Teste
{
    class GestorDataBase
    {
        SQLiteConnection Connection;

        /* inicializar a coneção */

        public GestorDataBase(string con)
        {
            Connection = new SQLiteConnection(con);
        }

        /* abrir e fechar coneção */

        public void openConnection()
        {
            Connection.Close();
            Connection.Open();
        }

        public void closeConnection()
        {
            Connection.Close();
        }

        /* executar comandos */

        public void execute(string sql)
        {
            /* [TODO] returnar o numero de dados afectados com a execusão */
            SQLiteCommand command = new SQLiteCommand(sql, Connection);
            command.ExecuteNonQuery();
        }

        public DataTable getData(string sql)
        {
            SQLiteCommand command = new SQLiteCommand(sql, Connection);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

















        /* Inicialização [SO PARA TESTES] */

        public void createDataBase(string file, string con)
        {
            string sql = "CREATE TABLE utilizador (id INT,nome VARCHAR(60), password VARCHAR(60), posicaoX FLOAT, posicaoY FLOAT, posicaoPartidaX FLOAT, posicaoPartidaY FLOAT, tipoUtilizador INT); ";
            sql += "INSERT INTO utilizador VALUES (0,'demo', 'demo', 5.262482, 8.21654458, 1.6462548, 2.36954124, 0);";
            SQLiteCommand command = new SQLiteCommand(sql, Connection);
            command.ExecuteNonQuery();
        }

        public void dropDataBase()
        {
            string sql = "DROP TABLE IF EXISTS utilizador";
            SQLiteCommand command = new SQLiteCommand(sql, Connection);
            command.ExecuteNonQuery();
        }

    }
}
