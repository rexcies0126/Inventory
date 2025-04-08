using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp9.Model;
using WindowsFormsApp9.View;

namespace WindowsFormsApp9.Presenter
{
    public class ProductPresenter
    {
        private readonly IProductView _view;
        private List<Product> _products;

        public ProductPresenter(IProductView view)
        {
            _view = view;
            _products = new List<Product>();

            _view.AddProductClicked += OnAddProductClicked;

            _view.LoadProducts(_products);
        }

        private void OnAddProductClicked(object sender, EventArgs e)
        {
            Product product = new Product
            {
                ProductID = _view.ProductID,
                ProductName = _view.ProductName,
                Quantity = _view.Quantity,
                Price = _view.Price
            };

            _products.Add(product);
            _view.LoadProducts(_products);
            _view.ClearFields();
        }
    }
}
