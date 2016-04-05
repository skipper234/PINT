using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface2_Teste
{
    class Utilizador
    {
        int id;
        string nome;
        string password;
        double posicaoX;
        double posicaoY;
        double posicaoPartidaX;
        double posicaoPartidaY;
        int tipoUtilizador;

        public Utilizador()
        {

        }

        /* set individual data */

        public void setId(int id)
        {
            this.id = id;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public void setPassword(string password)
        {
            this.password = password;
        }

        public void setPosicaoPartidaX(double posicaoPartidaX)
        {
            this.posicaoPartidaX = posicaoPartidaX;
        }

        public void setPosicaoPartidaY(double posicaoPartidaY)
        {
            this.posicaoPartidaY = posicaoPartidaY;
        }

        public void setPosicaoX(double posicaoX)
        {
            this.posicaoX = posicaoX;
        }

        public void setPosicaoY(double posicaoY)
        {
            this.posicaoY = posicaoY;
        }

        public void setTipoUtilizador(int tipoUtilizador)
        {
            this.tipoUtilizador = tipoUtilizador;
        }

        /* get individual data */

        public int getId()
        {
            return id;
        }

        public string getNome()
        {
            return this.nome;
        }

        public string getPassword()
        {
            return this.password;
        }

        public double getPosicaoPartidaX()
        {
            return this.posicaoPartidaX;
        }

        public double getPosicaoPartidaY()
        {
            return this.posicaoPartidaY;
        }

        public double getPosicaoX()
        {
            return this.posicaoX;
        }

        public double getPosicaoY()
        {
            return this.posicaoY;
        }

        public int getTipoUtilizador()
        {
            return this.tipoUtilizador;
        }

        /* get multiple data */

        public string list()
        {
            return "Nome [" + this.nome + "] /t Longitude = " + this.posicaoX + "/t Altitude = " + this.posicaoY;
        }

    }
}
