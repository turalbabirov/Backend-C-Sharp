﻿namespace FrontToBack.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<CategoryComponent> CategoryComponents { get; set; }

    }
}
