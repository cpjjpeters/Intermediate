using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intermediate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Make some Customer objects.
            Customer[] customers =
            {
                new Customer("art", "100 Ash ave"),
                new Customer("betty", "200 Beech blv"),
                new Customer("art","300 Cedar street"),
                new Customer("Chuck", "100 Ash ave"),
            };

            CustomerNameComparer comparer = new CustomerNameComparer();

            List<Customer> list = new List<Customer>();
            //foreach (Customer cust in customers)
                
            foreach (Customer cust in customers)
            {
                listView1.Items.Add(cust.Name);
                if (!list.Contains(cust, comparer))
                    list.Add(cust);
            }
            
            
            Dictionary<Customer, Customer> dict = new Dictionary<Customer, Customer>(comparer);
            foreach (Customer cust in customers)
            {
                if (!dict.ContainsKey(cust))
                    dict.Add(cust,cust);
            }
        }

        
    }
}
