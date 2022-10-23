using Gurtas.DAL.Context;
using Gurtas.DAL.Entities;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            Login login = new Login();
            login.ShowDialog();

            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            grdMainPage.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdMainPage.AutoGenerateColumns = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = $"{DateTime.Now}\n{DateTime.Now.DayOfWeek}";
        }

        private void btnMeasureTools_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yapım Aşamasında...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Helper.Helper.GenerateMeasureToolsTable(grdMainPage);

            //using (GurtasContext context = new GurtasContext())
            //{
            //    var measureToolList = context.MeasureTools.ToList();
            //    grdMainPage.DataSource = measureToolList;
            //}
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yapım Aşamasında...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Helper.Helper.GenerateUsersTable(grdMainPage);

            //try
            //{
            //    using (GurtasContext context = new GurtasContext())
            //    {
            //        var userList = context.Users.ToList();
            //        grdMainPage.DataSource = userList;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    throw;
            //}
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yapım Aşamasında...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Helper.Helper.GenerateCustomersTable(grdMainPage);

            //try
            //{
            //    using (var context = new GurtasContext())
            //    {
            //        var customersList = context.Customers.ToList();
            //        grdMainPage.DataSource = customersList;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    throw;
            //}
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yapım Aşamasında...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Helper.Helper.GenerateSuppliersTable(grdMainPage);

            //try
            //{
            //    using (var context = new GurtasContext())
            //    {
            //        var suppliersList = context.Suppliers.ToList();
            //        grdMainPage.DataSource = suppliersList;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    throw;
            //}
        }

        private void btnProjects_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yapım Aşamasında...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Helper.Helper.GenerateProjectsTable(grdMainPage);

            //try
            //{
            //    using (var context = new GurtasContext())
            //    {
            //        var projectsList = context.Projects.ToList();
            //        grdMainPage.DataSource = projectsList;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    throw;
            //}
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            Helper.Helper.GenerateOrdersTable(grdMainPage);
            var ordersList = Helper.Helper.GetOrders();
            grdMainPage.DataSource = ordersList;
        }

        private void yeniSiparişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddOrderForm addOrderForm = new AddOrderForm();
            addOrderForm.ShowDialog();

            Helper.Helper.GenerateOrdersTable(grdMainPage);
            var ordersList = Helper.Helper.GetOrders();
            grdMainPage.DataSource = ordersList;
        }

        private void aktifSiparişlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (GurtasContext context = new GurtasContext())
                {
                    Helper.Helper.GenerateOrdersTable(grdMainPage);
                    var activeOrders = context.Orders.Where(e => e.IsActive == true).ToList();
                    grdMainPage.DataSource = activeOrders;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void geçmişSiparişlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (GurtasContext context = new GurtasContext())
                {
                    Helper.Helper.GenerateOrdersTable(grdMainPage);
                    var activeOrders = context.Orders.Where(e => e.IsActive == false).ToList();
                    grdMainPage.DataSource = activeOrders;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void siparişGüncelleSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var updateOrderForm = new UpdateOrderForm();
            updateOrderForm.ShowDialog();
            var ordersList = Helper.Helper.GetOrders();
            grdMainPage.DataSource = ordersList;
        }
    }
}
