using System;

using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;

namespace WhereIsMyMoney.PeopleList
{
    public class PLViewHolder : RecyclerView.ViewHolder
    {
        public TextView TextView1 { get; private set; }

        public TextView TextView2 { get; private set; }

        public PLViewHolder(View itemView, Action<int> clickListener, Action<int> longClickListener) : base(itemView)
        {
            TextView1 = itemView.FindViewById<TextView>(Resource.Id.rip_txt1);
            TextView2 = itemView.FindViewById<TextView>(Resource.Id.rip_txt2);
            SetEvents(itemView, clickListener, longClickListener);
        }

        private void SetEvents(View itemView, Action<int> clickListener, Action<int> longClickListener)
        {
            itemView.Click += (s, e) => clickListener.Invoke(base.AdapterPosition);
            itemView.LongClick += (s, e) => longClickListener.Invoke(base.AdapterPosition);
        }
    }
}