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
    [Activity(Label = "Activity1",MainLauncher = true)]
    public class LoginActivity : Activity
    {
        EditText edtUsername, edtPassword;
        Button btnLogin;
        TextView txtCreate;

        UsuarioControlador controlador = new UsuarioControlador();

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Login);
            // Componentes da tela ou Interface
            edtUsername = FindViewById<EditText>(Resource.Id.edtUsername);
            edtPassword = FindViewById<EditText>(Resource.Id.edtPassword);
            btnLogin = FindViewById<Button>(Resource.Id.btnLogin);
            txtCreate = FindViewById<TextView>(Resource.Id.txtCreate);

            //Eventos
            btnLogin.Click += BtnLogin_Click;
            txtCreate.Click += TxtCreate_Click;
            // Create your application here
        }

        private void TxtCreate_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(Createactivity));
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if(edtUsername.Text == "")
            {
                Toast Meutoast;
                Meutoast = Toast.MakeText(this, "Preencha campo Usuario", ToastLength.Short);
                Meutoast.Show();
            }
            if(edtPassword.Text == string.Empty)
            {
                Toast Meutoast;
                Meutoast = Toast.MakeText(this, "Preencha campo Senha", ToastLength.Long);
                Meutoast.Show();
                return;
            }
            bool existe = controlador.UsuarioExiste(edtUsername.Text, edtPassword.Text);
            if (existe)
            {
                Toast Meutoast;
                Meutoast = Toast.MakeText(this, "Bem Vindo", ToastLength.Short);
                Meutoast.Show();
            }
            else
            {
                Toast MeuToast;
                MeuToast = Toast.MakeText(this, "Usuario ou senha invalido", ToastLength.Short);
                MeuToast.Show();
            }
        }
    }
}