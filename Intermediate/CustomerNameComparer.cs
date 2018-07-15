using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate
{
    public class CustomerNameComparer:IEqualityComparer<Customer>
    {
        public bool Equals(Customer x, Customer y)
        {
            //Form1.textBox1.Text = x.Name;
            if (x == null)return (y==null);
            if (y == null) return false;
            //return (x.Name == y.Name);
            return (x.Address == y.Address);
        }

        public int GetHashCode(Customer obj)
        {
            return obj.Name.GetHashCode();
        }
    }
}
