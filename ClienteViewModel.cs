﻿using PizzariaSys.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PizzariaSys.Web.ViewModels
{
    public class ClienteViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")] 
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [DataType(DataType.Text)]
        [RegularExpression(@"^[A-Za-z0-9]*\d+[A-Za-z0-9]*$",ErrorMessage = "Digite somente números")]
        public int Numero { get; set; }

        public string Bairro { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string Telefone { get; set; }

        public ClienteViewModel()
        {

        }

        public ClienteViewModel(Cliente cliente)
        {
            Id = cliente.Id;
            Nome = cliente.Nome;
            Logradouro = cliente.Logradouro;
            Numero = cliente.Numero;
            Bairro = cliente.Bairro;
            Telefone = cliente.Telefone;
        }
    }
}