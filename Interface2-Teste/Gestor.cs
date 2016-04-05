using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Interface2_Teste
{
    public delegate void Activar_Mapa();

    public class Gestor
    {
        string SQL_CON = "Data Source=Database.sqlite;Version=3;";

        GestorDataBase GesBD;

        Utilizador loginUser;

        public Gestor()
        {
            loginUser = new Utilizador();
            GesBD = new GestorDataBase(SQL_CON);
        }

        public string Obeter_Nome_Utilizador_Login()
        {
            return loginUser.getNome();
        }

        public bool validarLogin(string username, string password)
        {
            GesBD.openConnection();

            string sql = "SELECT id, nome, posicaoPartidaX, posicaoPartidaY  FROM utilizador WHERE nome = '" + username + "' AND password = '" + password + "'";
            DataTable dt = GesBD.getData(sql);

            if (dt.Rows.Count == 0)
            {
                GesBD.closeConnection();
                return false;
            }
            else
            {
                loginUser.setId(dt.Rows[0].Field<int>(0)); // campo 0 (id) do resultado do sql
                loginUser.setNome(dt.Rows[0].Field<string>(1)); // ...
                loginUser.setPosicaoPartidaX(dt.Rows[0].Field<double>(2));
                loginUser.setPosicaoPartidaY(dt.Rows[0].Field<double>(3));
                GesBD.closeConnection();
                return true;
            }
        }

        public bool validarConnecaoBD()
        {
            try { GesBD.openConnection(); GesBD.closeConnection(); }
            catch (Exception) { return false; }
            return true;
        }

        public void adicionarUtilizador(string nome, string password, string longitude, string latitude, string tipo)
        {
            GesBD.openConnection();

            string sql = "INSERT INTO utilizador (nome, password, tipoUtilizador) VALUES (";
            sql += "'" + nome + "','" + password + "', 0)";
            GesBD.execute(sql);

            GesBD.closeConnection();
        }

    }
}
