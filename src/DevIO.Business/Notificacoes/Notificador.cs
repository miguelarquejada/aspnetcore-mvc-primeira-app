using DevIO.Business.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DevIO.Business.Notificacoes
{
    public class Notificador : INotificador
    {
        private List<Notificacao> _notificacoes;

        // cria uma lista de noticações vazia
        public Notificador()
        {
            _notificacoes = new List<Notificacao>();
        }

        // acrescenca a notificação à lista
        public void Handle(Notificacao notificacao)
        {
            _notificacoes.Add(notificacao);
        }

        // pega a lista de notificações
        public List<Notificacao> ObterNotificacoes()
        {
            return _notificacoes;
        }

        // verifica se a lista tem alguma notificação
        public bool TemNotificacao()
        {
            return _notificacoes.Any();
        }
    }
}
