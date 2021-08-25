using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projeto
{
    class Globais
    {
        public static Boolean logado = false;

        public static string caminho = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
        public static string nomeBanco = "banco_sistema.db";
        public static string caminhoBanco = caminho+@"\Banco\";

    }
}
