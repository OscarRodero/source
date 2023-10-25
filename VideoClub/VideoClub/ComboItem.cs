using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoClub
{
    public class ComboItem
    {
        public int Id { get; set; }
        public string Value { get; set; }

        public ComboItem(int id, string value)
        {
            Id = id;
            Value = value;
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
