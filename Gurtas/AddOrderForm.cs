using Gurtas.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gurtas
{
    public partial class AddOrderForm : Form
    {
        public AddOrderForm()
        {
            InitializeComponent();
        }

        private void AddOrderForm_Load(object sender, EventArgs e)
        {
            //btnGiveOrder.Enabled = false;

            if (this.Tag == null)
            {
                Clear();
            }
            else
            {
                FillForm();
            }

        }

        private void FillForm()
        {
            int orderId = Convert.ToInt32(this.Tag);
            var order = Helper.Helper.GetOrderById(orderId);
            txtOrderNumber.Text = order.OrderNumber;
            txtMaterial.Text = order.Material;
            txtShippingDetail.Text = order.ShippingDetail;
            txtSupplier.Text = order.Supplier;
            txtOrderDetail.Text = order.OrderDetail;
            txtDescription.Text = order.Description;
            txtBidNumber.Text = order.BidNumber;
            txtContactName.Text = order.ContactName;
            nmuQuantity.Value = Convert.ToDecimal(order.Quantity);
            nmuPrice.Value = Convert.ToDecimal(order.Price);
            nmuDiscount.Value = Convert.ToInt32(order.Discount);
            // Ödeme Türü
            if (order.PaymentMethod == "Peşin")
            {
                rbCash.Checked = true;
            }
            else if (order.PaymentMethod == "Vadeli")
            {
                rbTerm.Checked = true;
            }
            // Vade Şekli
            if (order.PaymentTerm == "Çek")
            {
                rbCek.Checked = true;
            }
            else if (order.PaymentTerm == "Açık Hesap")
            {
                rbAcikHesap.Checked = true;
            }
            else if (order.PaymentTerm == "Senet")
            {
                rbSenet.Checked = true;
            }
            else if (order.PaymentTerm == "Kredi Kartı")
            {
                rbKrediKart.Checked = true;
            }
            else if (order.PaymentTerm == "Diğer")
            {
                rbDiger.Checked = true;
            }
            txtDeliveryTime.Text = order.DeliveryTime;
            txtPackaging.Text = order.PackagingDetail;
            txtShippingDetail.Text = order.ShippingDetail;
            // Tamamlandı mı ?
            if (order.IsActive == Convert.ToBoolean(1))
            {
                rbYes.Checked = true;
            }
            else if (order.IsActive == Convert.ToBoolean(0))
            {
                rbNo.Checked = true;
            }
            // Para Birimi
            if (order.Currency == "Türk Lirası")
            {
                rbLira.Checked = true;
            }
            else if (order.Currency == "Euro")
            {
                rbEuro.Checked = true;
            }
            else if (order.Currency == "Dolar")
            {
                rbDollar.Checked = true;
            }
            txtDeliveryTime.Text = order.DeliveryTime;
            txtPackaging.Text = order.PackagingDetail;
            txtShippingDetail.Text = order.ShippingDetail;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            this.Tag = 0;
            txtOrderNumber.Text = null;
            txtBidNumber.Text = null;
            txtMaterial.Text = null;
            txtOrderDetail.Text = null;
            txtDescription.Text = null;
            nmuQuantity.Value = 0;
            nmuPrice.Value = 0;
            nmuDiscount.Value = 0;
            rbCash.Checked = true;
            rbAcikHesap.Checked = true;
            txtDeliveryTime.Text = null;
            txtPackaging.Text = null;
            txtShippingDetail.Text = null;
            rbNo.Checked = true;
            rbLira.Checked = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
            this.Close();
        }

        private void Save()
        {
            var orderId = Convert.ToInt32(this.Tag);
            var orderNumber = txtOrderNumber.Text;
            var supplier = txtSupplier.Text;
            var contactName = txtContactName.Text;
            var bidNumber = txtBidNumber.Text;
            var orderDetail = txtOrderDetail.Text;
            var quantity = nmuQuantity.Value.ToString();
            var material = txtMaterial.Text;
            var price = nmuPrice.Value;
            // Para Birimi
            var currency = "";
            if (rbLira.Checked == true)
            {
                currency = "Türk Lirası";
            }
            else if (rbEuro.Checked == true)
            {
                currency = "Euro";
            }
            else if (rbDollar.Checked == true)
            {
                currency = "Dolar";
            }
            var description = txtDescription.Text;
            var deliveryTime = txtDeliveryTime.Text;
            var discount = Convert.ToInt32(nmuDiscount.Value);
            var packagingDetail = txtPackaging.Text;
            var shippingDetail = txtShippingDetail.Text;
            // Ödeme Türü
            var paymentMethod = "";
            if (rbCash.Checked == true)
            {
                paymentMethod = "Peşin";
            }
            else if (rbTerm.Checked == true)
            {
                paymentMethod = "Vadeli";
            }
            // Vade Şekli
            var paymentTerm = "";
            if (rbAcikHesap.Checked == true)
            {
                paymentTerm = "Açık Hesap";
            }
            else if (rbCek.Checked == true)
            {
                paymentTerm = "Çek";
            }
            else if (rbSenet.Checked == true)
            {
                paymentTerm = "Senet";
            }
            else if (rbKrediKart.Checked == true)
            {
                paymentTerm = "Kredi Kartı";
            }
            else if (rbDiger.Checked == true)
            {
                paymentTerm = "Diğer";
            }
            // Tamamlandı mı ?
            var isActive = false;
            if (rbYes.Checked == true)
            {
                isActive = true;
            }
            else if (rbNo.Checked == true)
            {
                isActive = false;
            }
            var userId = 2;

            Helper.Helper.AddNewOrder(orderId, orderNumber, supplier, contactName, bidNumber, orderDetail, quantity, material, price, currency, description, deliveryTime, discount, packagingDetail, shippingDetail, paymentMethod, paymentTerm, isActive, userId);

            string supplierMail = txtSupplierMail.Text;
            Helper.Helper.Email($"Aşağıdaki ürünler siparişimizdir.\n\n {material} {quantity} Adet \n\n ***Lütfen teyit ediniz.***", supplierMail);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void Delete()
        {
            try
            {
                int orderId = Convert.ToInt32(this.Tag);
                Helper.Helper.DeleteOrder(orderId);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

        }

        private void btnGiveOrder_Click(object sender, EventArgs e)
        {
            string supplierMail = txtSupplierMail.Text;
            Helper.Helper.Email($"Aşağıdaki ürünler siparişimizdir.\n 1 - DENEME ÜRÜNÜ 2 ADET \n 2 - DENEME ÜRÜNÜ 5 ADET", supplierMail);
        }
    }
}
