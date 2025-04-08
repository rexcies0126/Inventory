using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp9.Model;
using WindowsFormsApp9.View;

namespace WindowsFormsApp9
{
    public partial class ProductView : Form, IProductView
    {
        public ProductView()
        {
            InitializeComponent();

            RaiseEvent();
        }

        public int ProductID
        {
            get { return int.Parse(txtProductID.Text); }
            set { txtProductID.Text = value.ToString(); }
        }
        public string ProductName
        {
            get { return txtProductName.Text; }
            set { txtProductName.Text = value; }
        }
        public int Quantity
        {
            get { return int.Parse(txtQuantity.Text); }
            set { txtQuantity.Text = value.ToString(); }
        }

        public double Price
        {
            get { return double.Parse(txtPrice.Text); }
            set { txtPrice.Text = value.ToString(); }
        }

        private void RaiseEvent()
        {
            btnSave.Click += (sender, e) =>
            {
                AddProductClicked?.Invoke(this, EventArgs.Empty);
            }; 
        }

        public void LoadProducts(List<Product> products)
        {
            dgvProductList.DataSource = null;
            dgvProductList.DataSource = products;
        }

        public void ClearFields()
        {
            txtProductID.Clear();
            txtProductName.Clear();
            txtQuantity.Clear();
            txtPrice.Clear();
        }

        public event EventHandler AddProductClicked;


    }
}
