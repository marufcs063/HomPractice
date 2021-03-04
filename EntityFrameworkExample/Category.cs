using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkExample
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<ProductCategory> Categories { get; set; }
    }
}
