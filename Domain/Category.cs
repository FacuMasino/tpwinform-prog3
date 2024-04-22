﻿using System.ComponentModel;

namespace Domain
{
    public class Category
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public override string ToString()
        {
            return Description;
        }
    }
}
