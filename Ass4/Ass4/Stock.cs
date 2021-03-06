﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ass4
{
    //3Q2.
    class Stock : Product
    {
        public Stock(string iD, double price, int quantity) : base(iD,price,quantity)
        {
            
        }

        public void SplitStocks()
        {
            Price /= 2;
            Quantity *= 2;
        }

        public override string ToString()
        {
            return "Stock";
        }

        //4Q3
        public override bool Equals(object obj)
        {
            return obj.GetHashCode()==this.GetHashCode();
        }

        public override int GetHashCode()
        {
            string s = ID;
            return s.GetHashCode();
        }

    }
}
