using System;
using System.Collections.Generic;
using System.Text;

namespace Mdc.Data
{
    public class Owner
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Dog> Dogs { get; set; }
    }
}
