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
    public class Categoria
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
    }
}