using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Lawforall.Biblioteca.Model
{
    public class Usuario
    {
        //Usuário id, nome, sobrenome, idade, username, senha, email,Categoria
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public int Idade { get; set; }
        public string Username { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }

    }
}