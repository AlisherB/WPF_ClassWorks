using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingPractice
{
    public class Products
    {
        private long id;
        private string name;
        private int price;
        private DateTime dateTime;

        public long Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public int Price { get { return price; } set { price = value; } }
        public DateTime Date { get { return DateTime.Today; } set { dateTime = value; } }
    }
}
