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

namespace Lawforall.Adapter
{
    class CategoriaAdapter : BaseAdapter<Categoria>
    {

        Context context;
        List<Categoria> ListaCategoria;   

        public CategoriaAdapter(Context context,List<Categoria> listacategoria)
        {
            this.context = context;
            ListaCategoria = listacategoria;
        }


        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = convertView;
            CategoriaAdapterViewHolder holder = null;

            if (view != null)
                holder = view.Tag as CategoriaAdapterViewHolder;

            if (holder == null)
            {
                holder = new CategoriaAdapterViewHolder();
                var inflater = context.GetSystemService(Context.LayoutInflaterService).JavaCast<LayoutInflater>();
                //replace with your item and your holder items
                //comment back in
                view = inflater.Inflate(Resource.Layout.CategoriaItem, parent, false);
                holder.txtTitulo = view.FindViewById<TextView>(Resource.Id.txtTitulo);
                holder.txtDescricao = view.FindViewById<TextView>(Resource.Id.txtdescricao);
                view.Tag = holder;
            }


            //fill in your items
            //holder.Title.Text = "new text here";

            return view;
        }

        //Fill in cound here, currently 0
        public override int Count
        {
            get
            {
                return 0;
            }
        }

        public override Categoria this[int position] => ListaCategoria[position];
    }

    class CategoriaAdapterViewHolder : Java.Lang.Object
    {
        public TextView txtTitulo { get; set; }
        public TextView txtDescricao { get; set; }
    }
}