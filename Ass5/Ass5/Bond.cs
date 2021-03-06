﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//3Q1.
namespace Ass5
{
    //3Q2.
    class Bond : Product
    {
        //3Q3.
        public int Years { get; set; }
        public virtual double Rate { get; set; }

        public Bond(string iD,double price, int quantity, int years, double rate) :base(iD,price,quantity)
        {
            Years = years;
            Rate = rate;
        }

        public virtual double GetCoupon()
        {
            return Rate * 10;
        }

        public override string ToString()
        {
            return "Bond";
        }
    }
}
