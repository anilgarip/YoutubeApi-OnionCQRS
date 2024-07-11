﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeApi.Domain.Common;

namespace YoutubeApi.Domain.Entities
{
    public class Category : EntityBase
    {
       public Category() { }
        public Category(int parentId,string name,int priority)
        {
            ParentId = parentId;
            Name = name;
            Priority = priority;
        }
        public int ParentId { get; set; }
        public string Name { get; set; }
        public int Priority { get; set; }

        public ICollection<Detail> Details { get; set; } // çoka çok ilişki için ICollection olarak birbirine(Category <=> Product) eklemek gerekiyor
        public ICollection<ProductCategory> ProductCategories { get; set; }

    }
}
