﻿using DevIO.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevIO.App.Extensions
{
    public class SummaryViewComponent : ViewComponent
    {
        private readonly INotificador _notificador;

        public SummaryViewComponent(INotificador notificador)
        {
            _notificador = notificador;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            // recebe FromResult pois ObterNotificacoes não é assíncrono
            var notificacoes = await Task.FromResult(_notificador.ObterNotificacoes());

            // percorre todas as notificações e adiciona as mensagens das notificações no ModelState
            notificacoes.ForEach(c => ViewData.ModelState.AddModelError(string.Empty, c.Mensagem));
            
            return View();
        }
    }
}
