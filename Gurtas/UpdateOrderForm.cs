using Gurtas.DAL.Context;
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
    public partial class UpdateOrderForm : Form
    {
        public UpdateOrderForm()
        {
            InitializeComponent();
        }

        private void UpdateOrderForm_Load(object sender, EventArgs e)
        {
            grdUpdateOrder.AutoGenerateColumns = false;
            grdUpdateOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Helper.Helper.GenerateOrdersTable(grdUpdateOrder);
            try
            {
                using (var context = new GurtasContext())
                {
                    var ordersList = context.Orders.ToList();
                    grdUpdateOrder.DataSource = ordersList;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void grdUpdateOrder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                    return;

                int orderId = ((grdUpdateOrder.DataSource as List<Orders>)[e.RowIndex]).OrderId;
                var addForm = new AddOrderForm();
                addForm.Tag = orderId;
                addForm.ShowDialog();
                var ordersList = Helper.Helper.GetOrders();
                grdUpdateOrder.DataSource = ordersList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}
