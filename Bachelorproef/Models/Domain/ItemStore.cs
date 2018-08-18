using DataGatherer.Models.DAL;
using DataGatherer.Models.Domain;
using System;
using System.Collections.Generic;

namespace DataGatherer.Models.Domain
{
    public class ItemStore
    {
        public Dictionary<int, MyItem> Items { get; private set; }

        private DataGathererContext context;

        public ItemStore()
        {
            Items = new Dictionary<int, MyItem>();
        }

        public ItemStore(DataGathererContext context)
        {
            this.context = context;
            Items = new Dictionary<int, MyItem>();
            foreach (MyItem item in context.Items)
            {
                this.Items.Add(item.ItemId, item);
            }
        }

        public void Add(MyItem item)
        {
            if (!Items.ContainsKey(item.ItemId))
            {
                Items.Add(item.ItemId, item);
                context.Items.Add(item);
                context.SaveChanges();
            }   
        }
    }
}