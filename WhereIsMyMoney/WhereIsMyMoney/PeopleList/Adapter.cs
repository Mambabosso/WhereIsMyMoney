using System;
using System.Collections.Generic;

using Android.Support.V7.Widget;
using Android.Views;

using WhereIsMyMoney.Data;

namespace WhereIsMyMoney.PeopleList
{
    public class Adapter : RecyclerView.Adapter
    {
        public override int ItemCount => people.Count;

        private List<Person> people;

        public Adapter(List<Person> people)
        {
            this.people = people;
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            ViewHolder viewHolder = holder as ViewHolder;
            viewHolder.TextView1.Text = people[position].DisplayName;
            viewHolder.TextView2.Text = people[position].Email;
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View itemView = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.rcv_item_person, parent, false);
            return new ViewHolder(itemView);
        }
    }
}