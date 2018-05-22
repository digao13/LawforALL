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
using Lawforall.Biblioteca.Model;

namespace Lawforall.Biblioteca.Controller
{
    public class UsuarioControlador
    {
        static List<Usuario> ListUsuario = new List<Usuario>();

        public void AdicionarUsuario(string nome, string sobrenome, string idade, string username, string password, string email)
        {
            Usuario NovoUsuario = new Usuario();
            NovoUsuario.Nome = nome;
            NovoUsuario.Sobrenome = sobrenome;
            NovoUsuario.Idade = Convert.ToInt32(idade);
            NovoUsuario.Username = username;
            NovoUsuario.Senha = password;
            NovoUsuario.Email = email;

            ListUsuario.Add(NovoUsuario);
        }
        public bool UsuarioExiste(string username, string senha)
        {
            bool resultado = false;
            for (int i = 0; i < ListUsuario.Count; i++)
            {
                if (ListUsuario[i].Username == username && ListUsuario[i].Senha == senha)
                {
                    resultado = true;
                    break;
                }
            }


            return resultado;
        }
    }
}