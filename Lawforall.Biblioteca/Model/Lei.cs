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
    public class Lei
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Artigo { get; set; }
        public int Numero { get; set; }
        public string Descricao { get; set; }
        public int CategoriaId { get; set; }
    }
}