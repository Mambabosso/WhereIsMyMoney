using System;
using System.Collections.Generic;

using Android.Support.V7.Widget;
using Android.Views;

using WhereIsMyMoney.Data;

namespace WhereIsMyMoney.PeopleList
{
    public class PLAdapter : RecyclerView.Adapter
    {
        public event EventHandler<int> ItemClick;

        public event EventHandler<int> ItemLongClick;

        public override int ItemCount => people.Count;

        private List<WIMMPerson> people;

        public PLAdapter(List<WIMMPerson> people)
        {
            this.people = people;
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            PLViewHolder viewHolder = holder as PLViewHolder;
            viewHolder.TextView1.Text = people[position].DisplayName;
            viewHolder.TextView2.Text = people[position].Email;
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View itemView = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.rcv_item_wimmperson, parent, false);
            return new PLViewHolder(itemView, OnItemClick, OnItemLongClick);
        }

        private void OnItemClick(int position)
        {
            ItemClick?.Invoke(this, position);
        }

        private void OnItemLongClick(int position)
        {
            ItemLongClick?.Invoke(this, position);
        }
    }
}