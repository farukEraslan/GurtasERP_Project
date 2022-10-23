using Gurtas.DAL.Context;
using Gurtas.DAL.Entities;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Gurtas.Helper
{
    public class Helper
    {
        public static DataGridViewColumn GenerateTextColumn(string name, string headerText)
        {
            var column = new DataGridViewTextBoxColumn();
            column.Name = name;
            column.DataPropertyName = name;
            column.HeaderText = headerText;
            return column;
        }

        public static DataGridViewColumn GenerateCheckBoxColumn(string name, string headerText)
        {
            var column = new DataGridViewCheckBoxColumn();
            column.Name = name;
            column.DataPropertyName = name;
            column.HeaderText = headerText;
            return column;
        }

        public static void GenerateMeasureToolsTable(DataGridView dataGridView)
        {
            dataGridView.Columns.Clear();
            dataGridView.Columns.Add(GenerateTextColumn("ToolName", "Makine / Cihaz"));
            dataGridView.Columns.Add(GenerateTextColumn("Manufacturer", "Üretici"));
            dataGridView.Columns.Add(GenerateTextColumn("Model", "Model"));
            dataGridView.Columns.Add(GenerateTextColumn("Type", "Tip"));
            dataGridView.Columns.Add(GenerateTextColumn("MeasureRange", "Ölçüm Aralığı"));
            dataGridView.Columns.Add(GenerateTextColumn("Accuracy", "Ölçüm Belirsizliği"));
            dataGridView.Columns.Add(GenerateTextColumn("SerialNumber", "Seri Numarası"));
            dataGridView.Columns.Add(GenerateTextColumn("CertificateNumber", "Sertifika Numarası"));
            dataGridView.Columns.Add(GenerateTextColumn("CalibrationDate", "Son Kalibrasyon Tarihi"));
            dataGridView.Columns.Add(GenerateTextColumn("NextCalibrationDate", "Bir Sonraki Kalibrasyon Tarihi"));
            dataGridView.Columns.Add(GenerateTextColumn("RecordDate", "Kayıt Tarihi"));
            dataGridView.Columns.Add(GenerateTextColumn("ModifiedDate", "Güncelleme Tarihi"));
            dataGridView.Columns.Add(GenerateTextColumn("UserId", "Ekleyen Kullanıcı"));
        }

        public static void GenerateUsersTable(DataGridView dataGridView)
        {
            dataGridView.Columns.Clear();
            dataGridView.Columns.Add(GenerateTextColumn("UserId", "Kullanıcı Id"));
            dataGridView.Columns.Add(GenerateTextColumn("Username", "Kullanıcı Adı"));
            dataGridView.Columns.Add(GenerateTextColumn("Name", "Ad"));
            dataGridView.Columns.Add(GenerateTextColumn("Surname", "Soyad"));
            dataGridView.Columns.Add(GenerateTextColumn("Gender", "Cinsiyet"));
            dataGridView.Columns.Add(GenerateTextColumn("Password", "Şifre"));
            dataGridView.Columns.Add(GenerateTextColumn("RecordDate", "Kayıt Tarihi"));
            dataGridView.Columns.Add(GenerateTextColumn("modifiedDate", "Güncelleme Tarihi"));
        }

        public static void GenerateCustomersTable(DataGridView dataGridView)
        {
            dataGridView.Columns.Clear();
            dataGridView.Columns.Add(GenerateTextColumn("CustomerName", "Müşteri Adı"));
            dataGridView.Columns.Add(GenerateTextColumn("ContactTitle", "Yetkili Kişi"));
            dataGridView.Columns.Add(GenerateTextColumn("Phone", "Telefon"));
            dataGridView.Columns.Add(GenerateTextColumn("Email", "Email"));
            dataGridView.Columns.Add(GenerateTextColumn("Address", "Adres"));
            dataGridView.Columns.Add(GenerateTextColumn("City", "Şehir"));
            dataGridView.Columns.Add(GenerateTextColumn("Country", "Ülke"));
            dataGridView.Columns.Add(GenerateTextColumn("PostalCode", "Posta Kodu"));
            dataGridView.Columns.Add(GenerateTextColumn("RecordDate", "Kayıt Tarihi"));
            dataGridView.Columns.Add(GenerateTextColumn("ModifiedDate", "Güncelleme Tarihi"));
            dataGridView.Columns.Add(GenerateTextColumn("UserId", "Ekleyen Kullanıcı"));
        }

        public static void GenerateSuppliersTable(DataGridView dataGridView)
        {
            dataGridView.Columns.Clear();
            dataGridView.Columns.Add(GenerateTextColumn("CompanyName", "Firma Adı"));
            dataGridView.Columns.Add(GenerateTextColumn("ContactName", "Yetkili Kişi"));
            dataGridView.Columns.Add(GenerateTextColumn("Address", "Adres"));
            dataGridView.Columns.Add(GenerateTextColumn("TaxOfficeAndNumber", "Vergi Numarası ve Adresi"));
            dataGridView.Columns.Add(GenerateTextColumn("Phone", "Telefon"));
            dataGridView.Columns.Add(GenerateTextColumn("CompanyRating", "Firma Puanı"));
            dataGridView.Columns.Add(GenerateCheckBoxColumn("IsApproved", "Onaylı Tedarikçi Mi?"));
            dataGridView.Columns.Add(GenerateTextColumn("RecordDate", "Kayıt Tarihi"));
            dataGridView.Columns.Add(GenerateTextColumn("ModifiedDate", "Güncelleme Tarihi"));
            dataGridView.Columns.Add(GenerateTextColumn("UserId", "Ekleyen Kullanıcı"));
        }

        public static void GenerateProjectsTable(DataGridView dataGridView)
        {
            dataGridView.Columns.Clear();
            dataGridView.Columns.Add(GenerateTextColumn("ProjectNumber", "Proje Sipariş Numarası"));
            dataGridView.Columns.Add(GenerateTextColumn("ProjectName", "Proje Adı"));
            dataGridView.Columns.Add(GenerateCheckBoxColumn("IsFinished", "Bitti mi ?"));
            dataGridView.Columns.Add(GenerateTextColumn("CustomerId", "Müşteri"));
            dataGridView.Columns.Add(GenerateTextColumn("RecordDate", "Kayıt Tarihi"));
            dataGridView.Columns.Add(GenerateTextColumn("ModifiedDate", "Güncelleme Tarihi"));
            dataGridView.Columns.Add(GenerateTextColumn("UserId", "Ekleyen Kullanıcı"));
        }

        public static void GenerateOrdersTable(DataGridView dataGridView)
        {
            dataGridView.Columns.Clear();
            dataGridView.Columns.Add(GenerateTextColumn("OrderNumber", "Sipariş Numarası"));
            dataGridView.Columns.Add(GenerateTextColumn("Supplier", "Tedarikçi"));
            dataGridView.Columns.Add(GenerateTextColumn("ContactName", "Yetkili Kişi"));
            dataGridView.Columns.Add(GenerateTextColumn("BidNumber", "Teklif Numarası"));
            dataGridView.Columns.Add(GenerateTextColumn("OrderDetail", "Sipariş Detayı"));
            dataGridView.Columns.Add(GenerateTextColumn("Quantity", "Adet"));
            dataGridView.Columns.Add(GenerateTextColumn("Material", "Malzeme"));
            dataGridView.Columns.Add(GenerateTextColumn("Price", "Fiyat"));
            dataGridView.Columns.Add(GenerateTextColumn("Currency", "Para Birimi"));
            dataGridView.Columns.Add(GenerateTextColumn("Description", "Açıklama"));
            dataGridView.Columns.Add(GenerateTextColumn("DeliveryTime", "Teslim Süresi"));
            dataGridView.Columns.Add(GenerateTextColumn("Discount", "İskonto"));
            dataGridView.Columns.Add(GenerateTextColumn("PackagingDetail", "Ambalajlama"));
            dataGridView.Columns.Add(GenerateTextColumn("PaymentMethod", "Ödeme Şekli"));
            dataGridView.Columns.Add(GenerateTextColumn("PaymentTerm", "Ödeme Vadeliyse Ödeme Şekli"));
            dataGridView.Columns.Add(GenerateCheckBoxColumn("IsActive", "Tamamlandı mı ?"));
            dataGridView.Columns.Add(GenerateTextColumn("RecordDate", "Kayıt Tarihi"));
            dataGridView.Columns.Add(GenerateTextColumn("ModifiedDate", "Güncelleme Tarihi"));
            dataGridView.Columns.Add(GenerateTextColumn("UserId", "Ekleyen Kullanıcı"));
        }

        public static int UsernameControl(string username)
        {
            try
            {
                using (GurtasContext context = new GurtasContext())
                {
                    var userList = context.Users.ToList();
                    foreach(Users user in userList)
                    {
                        if (user.Username == username)
                        {
                            return user.UserId;
                        }
                    }
                    return 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        public static bool PasswordControl(int userId, string password)
        {
			try
			{
				using (GurtasContext context = new GurtasContext())
				{                    
                    var user = context.Users.FirstOrDefault(e => e.UserId == userId);
                    if (user.Password == password)
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Şifreyi Yanlış Girdiniz. Lütfen Tekrar Deneyiniz.");
                        return false;
                    }
                }
			}
			catch (Exception ex)
			{
                MessageBox.Show(ex.Message);
                throw;
			}
        }

        public static Users GetUserById(int userId)
        {
            try
            {
                using (var context = new GurtasContext())
                {
                    var user = context.Users.FirstOrDefault(e => e.UserId == userId);
                    return user;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        public static Orders GetOrderById(int orderId)
        {
            try
            {
                using (var context = new GurtasContext())
                {
                    var order = context.Orders.FirstOrDefault(e => e.OrderId == orderId);
                    return order;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        public static List<Orders> GetOrders()
        {
            try
            {
                using (var context = new GurtasContext())
                {
                    var ordersList = context.Orders.ToList();
                    return ordersList;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            
        }

        public static void AddNewOrder(int orderId, string orderNumber, string supplier, string contactName, string bidNumber, string orderDetail, string quantity, string material, decimal price, string currency, string description, string deliveryTime, int discount, string packagingDetail, string shippingDetail, string paymentMethod, string paymentTerm, bool IsActive, int userId)
        {
            try
            {
                using (GurtasContext context = new GurtasContext())
                {
                    if (orderId == 0)
                    {
                        var order = new Orders();
                        context.Orders.Add(order);
                        order.OrderNumber = orderNumber;
                        order.Supplier = supplier;
                        order.ContactName = contactName;
                        order.BidNumber = bidNumber;
                        order.OrderDetail = orderDetail;
                        order.Quantity = quantity;
                        order.Material = material;
                        order.Price = price;
                        order.Currency = currency;
                        order.DeliveryTime = deliveryTime;
                        order.Discount = discount;
                        order.PackagingDetail = packagingDetail;
                        order.ShippingDetail = shippingDetail;
                        order.PaymentMethod = paymentMethod;
                        order.PaymentTerm = paymentTerm;
                        order.Description = description;
                        order.IsActive = IsActive;
                        order.RecordDate = DateTime.Now;
                        order.ModifiedDate = DateTime.Now;
                        order.UserId = userId;
                    }
                    else if (orderId != 0)
                    {
                        var order = context.Orders.FirstOrDefault(e => e.OrderId == orderId);
                        order.OrderNumber = orderNumber;
                        order.Supplier = supplier;
                        order.ContactName = contactName;
                        order.BidNumber = bidNumber;
                        order.OrderDetail = orderDetail;
                        order.Quantity = quantity;
                        order.Material = material;
                        order.Price = price;
                        order.Currency = currency;
                        order.DeliveryTime = deliveryTime;
                        order.Discount = discount;
                        order.PackagingDetail = packagingDetail;
                        order.ShippingDetail = shippingDetail;
                        order.PaymentMethod = paymentMethod;
                        order.PaymentTerm = paymentTerm;
                        order.Description = description;
                        order.IsActive = IsActive;
                        order.RecordDate = DateTime.Now;
                        order.ModifiedDate = DateTime.Now;
                        order.UserId = userId;
                    }                   
                    
                    context.SaveChanges();
                    MessageBox.Show("Kayıt İşlemi Başarılı Şekilde Tamamlandı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            
        }

        public static void DeleteOrder(int orderId)
        {
            try
            {
                using (GurtasContext context = new GurtasContext())
                {
                    var order = context.Orders.FirstOrDefault(e=>e.OrderId == orderId);
                    context.Orders.Remove(order);
                    context.SaveChanges();
                    MessageBox.Show("Kayıt Başarılı Bir Şekilde Silindi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}
