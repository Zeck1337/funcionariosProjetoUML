using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcionarios
{
    static class ConexaoBanco
    {      
        private const string servidor = "localhost";
        private const string bancoDados = "dbfuncionarios";
        private const string usuario = "root";
        private const string senha = "lol32012";

        static public string bancoServidor = $"server={servidor}; user id={usuario}; database={bancoDados};password={senha}";
    

         
    }
}
