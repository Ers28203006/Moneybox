using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Moneybox.Client.Models
{
    public class CashBox
    {
        private static CashBox _box  = new CashBox();
        private CashBox() {}
        public static CashBox CashInitializer() 
        {
            if (_box == null)
            {
                _box = new CashBox();
                return _box;
            }
            else return _box;
        }
        public double Money { get; set; }
    }
}