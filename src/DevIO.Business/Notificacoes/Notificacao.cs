﻿using System;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Business.Notificacoes
{
    public class Notificacao
    {
        public string Mensagem { get; }

        public Notificacao(string mensagem)
        {
            Mensagem = mensagem;
        }
    }
}
