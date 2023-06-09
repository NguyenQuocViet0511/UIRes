﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRes.Models.Category
{
    public class Category
    {
        private string ID;
        private string Name;
        private int Count;
        private string Status;
        private string Created_at;


        public Category()
        {

        }
        public Category(string id, string name, int count, string status,string Created_at)
        {
            this.ID = id;
            this.Name = name;
            this.Count = count;
            this.Status = status;
            this.Created_at = Created_at;


        }

        public string id { get => ID; set => ID = value; }
        public string name { get => Name; set => Name = value; }
        public int count { get => Count; set => Count = value; }
        public string status { get => Status; set => Status = value; }
        public string created_at { get => Created_at; set => Created_at = value; }
    }
}
