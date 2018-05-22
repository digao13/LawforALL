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

namespace Lawforall.Interface
{
    [Activity(Label = "Activity1")]
    public class Activity1 : Activity
    {
        ListView lstCategoria;
        List<Categoria> Categorias;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Categoria);

            lstCategoria = FindViewById<ListView>(Resource.Id.lstCategoria);

            Categorias = new List<Categoria>();
            Categoria categoria1 = new Categoria();
            categoria1.Titulo = "Hoje";
            categoria1.Descricao = "amanhã";
            Categorias.Add(categoria1);
        }
    }
}