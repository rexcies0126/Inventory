using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp9.Model;

namespace WindowsFormsApp9.View
{
    public interface IProductView
    {
        int ProductID { get; set; }
        string ProductName { get; set; }
        int Quantity { get; set; }
        double Price { get; set; }

        void LoadProducts(List<Product> products);

        void ClearFields();

        event EventHandler AddProductClicked;


    }
}
