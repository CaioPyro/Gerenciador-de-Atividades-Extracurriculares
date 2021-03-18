using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projeto
{
    class Globais
    {
        public static string versao = "1.0";
        public static Boolean logado = false;
        public static int tipoAcesso = 0;

        public static string caminho = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
        public static string nomeBanco = "banco_sistema.db";
        public static string caminhoBanco = caminho+@"\Banco\";

    }
}
