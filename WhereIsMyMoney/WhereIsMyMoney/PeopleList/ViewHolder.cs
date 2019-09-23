using System;

using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;

namespace WhereIsMyMoney.PeopleList
{
    public class ViewHolder : RecyclerView.ViewHolder
    {
        public TextView TextView1 { get; private set; }

        public TextView TextView2 { get; private set; }

        public ViewHolder(View itemView) : base(itemView)
        {
            TextView1 = itemView.FindViewById<TextView>(Resource.Id.rip_txt1);
            TextView2 = itemView.FindViewById<TextView>(Resource.Id.rip_txt2);
        }
    }
}