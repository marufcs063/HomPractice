using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkExample
{
    public class ProductImage
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string AlternativeText { get; set; }
        public Product Product { get; set; }
    }
}
