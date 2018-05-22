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
using Lawforall.Biblioteca.Controller;

namespace Lawforall.Interface
{
    [Activity(Label = "Createactivity")]
    public class Createactivity : Activity
    {
        EditText edtNome;
        EditText edtSobrenome;
        EditText edtIdade;
        EditText edtUsername;
        EditText edtSenha;
        EditText edtEmail;
        Button btnSalvar;
        

        UsuarioControlador controlador = new UsuarioControlador();

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Create);

            edtNome = FindViewById<EditText>(Resource.Id.edtNome);
            edtSobrenome = FindViewById<EditText>(Resource.Id.edtSobrenome);
            edtIdade = FindViewById<EditText>(Resource.Id.edtIdade);
            edtUsername = FindViewById<EditText>(Resource.Id.edtUsername);
            edtSenha = FindViewById<EditText>(Resource.Id.edtPassword);
            edtEmail = FindViewById<EditText>(Resource.Id.edtEmail);
            btnSalvar = FindViewById<Button>(Resource.Id.btnSalvar);

            btnSalvar.Click += BtnSalvar_Click;

            // Create your application here
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            controlador.AdicionarUsuario(edtNome.Text, edtSobrenome.Text, edtIdade.Text, edtUsername.Text, edtSenha.Text, edtEmail.Text);
            
        }
    }
}