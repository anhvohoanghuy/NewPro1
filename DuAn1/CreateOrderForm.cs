using BUS.Services;
using DAL.Models;
using System.Drawing;
using static DuAn1.DangNhapForm;

namespace DuAn1
{

    public partial class CreateOrderForm : Form
    {
        string IdAccount;
        ProductBUS ProductBUS = new ProductBUS();
        ProductDetailBUS productDetailBUS = new ProductDetailBUS();
        CustomerBUS customerBUS = new CustomerBUS();
        OrderBUS orderBUS = new OrderBUS();
        OrderDetailBUS orderDetailBUS = new OrderDetailBUS();
        ProductColorBUS colorBUS = new ProductColorBUS();
        public CreateOrderForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
        }
        public CreateOrderForm(string idAccount)
        {
            IdAccount = idAccount;
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
        }
        public void LoadCbbWhenDropDown(ComboBox currentCbb, List<string> originList)
        {
            currentCbb.Items.Clear();
            foreach (var item in originList.Where(c => c.Contains(currentCbb.Text)))
            {
                currentCbb.Items.Add(item);
            }
        }
        public bool CheckNull(params string[] strings)
        {
            foreach (var item in strings)
            {
                if (string.IsNullOrEmpty(item))
                    return true;
            }
            return false;
        }
        public bool CheckCbb(params ComboBox[] cbbs)
        {
            foreach (ComboBox cbb in cbbs)
            {
                if (cbb.SelectedIndex == -1)
                    return false;
            }
            return true;
        }
        public string CheckIsInt(params TextBox[] textBoxs)
        {
            foreach (var textBox in textBoxs)
            {
                if (string.IsNullOrEmpty(textBox.Text))
                    return null;
                else if (!int.TryParse(textBox.Text, out _))
                    return $"{textBox.Name} phải là số nguyên";
                else if (int.Parse(textBox.Text) < 0)
                    return $"{textBox.Name} phải lớn hơn 0";
                else if (int.Parse(textBox.Text) != float.Parse(textBox.Text))
                    return $"{textBox.Name} phải là số nguyên";
            }
            return null;
        }

        public void ResetTexbox(params TextBox[] textBoxes)
        {
            foreach (var textBox in textBoxes)
            {
                textBox.Clear();
            }
        }
        public void ResetCombobox(params ComboBox[] comboBoxes)
        {
            foreach (var comboBox in comboBoxes)
            {
                comboBox.Items.Clear();
                comboBox.Text = string.Empty;
            }
        }
        public void LoadDataGridView()
        {
            dgvProduct.Columns.Add("IdProDuct", "ID product");
            dgvProduct.Columns.Add("ProductName", "Product name");
            dgvProduct.Columns.Add("Company Name", "Brand");
            dgvProduct.Columns.Add("Ram", "Ram");
            dgvProduct.Columns.Add("CPUName", "CPU name");
            dgvProduct.Columns.Add("ScreenSize", "ScreenSize");
            dgvProduct.Columns.Add("CameraResolution", "Camera resolution");
            dgvProduct.Columns.Add("Pin", "Pin");
            //
            dgvOrderDetails.Columns.Add("productName","Product name");
            dgvOrderDetails.Columns.Add("idProductDetail","ID product detail");
            dgvOrderDetails.Columns.Add("Color", "Color");
            dgvOrderDetails.Columns.Add("Storage", "Storage");
            dgvOrderDetails.Columns.Add("Quantity", "Quantity");
        }
        public void ShowOnDgvProduct(List<Product> products)
        {
            if (products != null)
            {
                foreach (var product in products)
                {
                    dgvProduct.Rows.Add(product.Idproduct, product.ProductName, product.IdcompanyNavigation.CompanyName, product.Ram, product.IdcpuNavigation.NameCpu, product.ScreenSize, product.CameraResolution, product.Pin);
                }
            }
        }
        private void CreateOrderForm_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            ShowOnDgvProduct(ProductBUS.GetAllProduct());
            string[] listSearch = ["By name", "By ID", "By id company", "By company name", "By ID account", "By ID CPU", "By CPU name"];
            cbbTimKiem.Items.AddRange(listSearch);
            List<string> listFillter = new List<string>() { "Ram", "Pin", "Refresh rate", "Screen size" };
            LoadCbbWhenDropDown(cbbFillter, listFillter);
            LoadCbbWhenDropDown(cbbIdCustomer, customerBUS.GetAllIdCustomer());
        }

        private void cbbIdCustomer_DropDown(object sender, EventArgs e)
        {
            var customers = customerBUS.SearchCustomerByIdCustomer(cbbIdCustomer.Text);
            if (customers!=null)
            {
                List<string> list = new List<string>();
                foreach(Customer customer in customers)
                {
                    list.Add(customer.Idaccount);
                }
                LoadCbbWhenDropDown(cbbIdCustomer, list);
            }
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.RowIndex < dgvProduct.RowCount - 1)
            {
                var row = dgvProduct.Rows[e.RowIndex];
                txtIdProduct.Text = row.Cells[0].Value.ToString();
                txtProductName.Text = row.Cells[1].Value.ToString();
                txtBrandName.Text = row.Cells[2].Value.ToString();
                var product = ProductBUS.GetProductByID(txtIdProduct.Text);
                LoadCbbWhenDropDown(cbbColor, ProductBUS.GetAllColorNameOfProduct(product));
                var storages = ProductBUS.GetAllStorageOfProduct(product);
                foreach (var storage in storages)
                {
                    cbbStorage.Items.Add(storage);
                }
            }
        }

        private void cbbIdCustomer_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbbIdCustomer.Text))
            {
                var customer = customerBUS.GetCustomerByID(cbbIdCustomer.Text);
                if (customer != null)
                {
                    txtphone.Text = customer.PhoneNumber;
                    txtaddres.Text = customer.CustomerAddress;
                    txtName.Text = customer.CustomerName;
                    var listOrder = orderBUS.GetAllOrderByIdCustomer(cbbIdCustomer.Text);
                    txtIdOrder.Text = $"{cbbIdCustomer.Text.Substring(cbbIdCustomer.Text.Length - 4)}Ord{listOrder.Count()}";
                }
                else
                    MessageBox.Show("Không có id khách hàng này");
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (!CheckNull(txtIdProduct.Text, cbbColor.Text, cbbStorage.Text))
            {
                var idColor = colorBUS.GetProductColorByName(cbbColor.Text).Idcolor;
                var productDetail = productDetailBUS.GetProductDetailForOrder(txtIdProduct.Text, idColor, int.Parse(cbbStorage.Text));
                txtInventoty.Text = productDetail.Inventory.ToString();
            }
            else
                MessageBox.Show("Chọn một sản phẩm và chọn tiếp color và storage");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!CheckNull(txtQuantity.Text))
            {
                if (!string.IsNullOrEmpty(txtIdOrder.Text))
                {
                    var check = CheckIsInt(txtQuantity);
                    if (check == null)
                    {
                        var checkOrder = orderBUS.GetOrderById(txtIdOrder.Text);
                        if (checkOrder != null)
                        {
                            if(int.Parse(txtQuantity.Text)<=int.Parse(txtInventoty.Text))
                            {
                                var idColor = colorBUS.GetProductColorByName(cbbColor.Text).Idcolor;
                                var productDetail = productDetailBUS.GetProductDetailForOrder(txtIdProduct.Text, idColor, int.Parse(cbbStorage.Text));
                                orderDetailBUS.AddNewOrderDetail(txtIdOrder.Text, productDetail.IdproductDetails, int.Parse(txtQuantity.Text), productDetail.Price, productDetail.IdpromotionNavigation.Discount);
                            }
                            else
                                MessageBox.Show("Quantity phải nhỏ hơn inventory");
                        }
                        else
                        {

                        }
                    }
                    else
                        MessageBox.Show(check);
                }
                else
                    MessageBox.Show("Chọn id customer");
            }
            else
                MessageBox.Show("Nhập quantity");
        }
    }
}
