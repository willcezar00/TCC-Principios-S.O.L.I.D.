﻿using System;
using System.Globalization;
using System.Net.Mail;
using SOLID._4___Interface_Segregation_Principle.Violacao.Models;


namespace SOLID._4___Interface_Segregation_Principle.Violacao.Services
{
    public class NotificacaoService 
    {
        public void EnviaEmail(Carrinho carrinho)
        {
            string emailCliente = carrinho.Cliente.Email;
            if (!string.IsNullOrEmpty(emailCliente))
            {
                using (var mensagem = new MailMessage("notificação@suporte", emailCliente))
                using (var cliente = new SmtpClient("localhost"))
                {
                    mensagem.Subject = "Recebemos seu pedido feito as : " +
                                       DateTime.Now.ToString(CultureInfo.InvariantCulture);

                    mensagem.Body = "Detalhes do Pedido " + carrinho.ToString();

                    try
                    {
                        cliente.Send(mensagem);
                    }
                    catch (Exception ex)
                    {
                        throw new System.NotImplementedException();
                        //Logger.Error("Erro ao enviar email.", ex);
                    }
                }
            }
            
        }
    }
}
