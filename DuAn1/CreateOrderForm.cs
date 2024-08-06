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
        public decimal FinalAmount(string idOrder)
        {
            var listOrderDetail = orderDetailBUS.GetOrderDetailsByOrderId(idOrder);
            if(listOrderDetail != null)
            {
                decimal totalAmount = 0;
                foreach(var item in listOrderDetail)
                {
                    totalAmount += (item.Amount-item.ReducedAmount);
                }
                return totalAmount;
            }
            return 0;
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
            dgvOrderDetails.Columns.Add("idProduct", "ID product");
            dgvOrderDetails.Columns.Add("productName", "Product name");
            dgvOrderDetails.Columns.Add("idProductDetail", "ID product detail");
            dgvOrderDetails.Columns.Add("Color", "Color");
            dgvOrderDetails.Columns.Add("Storage", "Storage");
            dgvOrderDetails.Columns.Add("Price", "Price");
            dgvOrderDetails.Columns.Add("Promotion", "Promotion");
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
        public void ShowOnDgvOrderDetail(string idOrder)
        {
            var listOrderDetails = orderDetailBUS.GetOrderDetailsByOrderId(idOrder);
            if (listOrderDetails != null)
            {
                foreach (var item in listOrderDetails)
                {
                    var productDetail = productDetailBUS.GetProductDetailByID(item.IdproductDetails);
                    var productName = productDetail.IdproductNavigation.ProductName;
                    dgvOrderDetails.Rows.Add(productDetail.Idproduct, productName, productDetail.IdproductDetails, productDetail.IdcolorNavigation.ColorName, productDetail.Storage, productDetail.Price, productDetail.IdpromotionNavigation==null?0: productDetail.IdpromotionNavigation.Discount, item.Quantity);
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
            LoadCbbWhenDropDown(cbbOrderQueue, orderBUS.GetAllIDWaitingOrder());
        }

        private void cbbIdCustomer_DropDown(object sender, EventArgs e)
        {
            var customers = customerBUS.SearchCustomerByIdCustomer(cbbIdCustomer.Text);
            if (customers != null)
            {
                List<string> list = new List<string>();
                foreach (Customer customer in customers)
                {
                    list.Add(customer.Idcustomer);
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
                cbbStorage.Items.Clear();
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
                {
                    MessageBox.Show("Không có id khách hàng này");
                    ResetTexbox(txtIdOrder, txtphone, txtName, txtaddres);
                }
            }
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
                            if (int.Parse(txtQuantity.Text) <= int.Parse(txtInventory.Text))
                            {
                                var idColor = colorBUS.GetProductColorByName(cbbColor.Text).Idcolor;
                                var productDetail = productDetailBUS.GetProductDetailForOrder(txtIdProduct.Text, idColor, int.Parse(cbbStorage.Text));
                                var orderDetail = orderDetailBUS.GetOrderDetailByKey(txtIdOrder.Text, productDetail.IdproductDetails);
                                if (orderDetail == null)
                                {
                                    if (orderDetailBUS.AddNewOrderDetail(txtIdOrder.Text, productDetail.IdproductDetails, int.Parse(txtQuantity.Text), productDetail.Price, productDetail.IdpromotionNavigation==null?0:productDetail.IdpromotionNavigation.Discount))
                                    {
                                        ShowOnDgvOrderDetail(txtIdOrder.Text);
                                        ResetCombobox(cbbColor, cbbStorage);
                                        ResetTexbox(txtIdProduct, txtBrandName, txtInventory, txtProductName, txtQuantity);
                                        txtFinalAmount.Text=FinalAmount(txtIdOrder.Text).ToString();
                                    }
                                    else
                                        MessageBox.Show("Thêm sản phẩm thất bại");
                                }
                                else
                                {
                                    if (int.Parse(txtQuantity.Text) + orderDetail.Quantity <= int.Parse(txtInventory.Text))
                                    {
                                        if (!orderDetailBUS.UpdateOrderDetail(orderDetail.Idorder, orderDetail.IdproductDetails, orderDetail.Quantity + int.Parse(txtQuantity.Text), orderDetail.Amount, orderDetail.ReducedAmount))
                                            MessageBox.Show("Thêm sản phẩm thất bại");
                                        else
                                        {
                                            ShowOnDgvOrderDetail(txtIdOrder.Text);
                                        }
                                    }
                                    else
                                        MessageBox.Show("Quantity vượt quá inventory");
                                }
                            }
                            else
                                MessageBox.Show("Quantity phải nhỏ hơn inventory");
                        }
                        else
                        {
                            var idColor = colorBUS.GetProductColorByName(cbbColor.Text).Idcolor;
                            var productDetail = productDetailBUS.GetProductDetailForOrder(txtIdProduct.Text, idColor, int.Parse(cbbStorage.Text));
                            if (orderBUS.AddNewOrder(txtIdOrder.Text, IdAccount, cbbIdCustomer.Text, DateTime.Now, productDetail.Price - productDetail.IdpromotionNavigation.Discount, null, 0))
                            {
                                if (orderDetailBUS.AddNewOrderDetail(txtIdOrder.Text, productDetail.IdproductDetails, int.Parse(txtQuantity.Text), productDetail.Price, productDetail.IdpromotionNavigation.Discount))
                                {
                                    ShowOnDgvOrderDetail(txtIdOrder.Text);
                                    ResetCombobox(cbbColor, cbbStorage);
                                    ResetTexbox(txtIdProduct, txtBrandName, txtInventory, txtProductName, txtQuantity);
                                }
                                else
                                    MessageBox.Show("Thêm sản phẩm thất bại");
                            }
                            else
                                MessageBox.Show("Thêm order thất bại");
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
            LoadCbbWhenDropDown(cbbOrderQueue, orderBUS.GetAllIDWaitingOrder());
        }

        private void cbbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbColor.SelectedIndex > -1)
            {

                if (string.IsNullOrEmpty(cbbStorage.Text))
                {
                    cbbStorage.Items.Clear();
                    List<int> storages = ProductBUS.GetStorageWithColor(txtIdProduct.Text, cbbColor.SelectedItem.ToString());
                    foreach (int storage in storages)
                    {
                        cbbStorage.Items.Add(storage);
                    }
                }
                else
                {
                    var productDetail = productDetailBUS.GetProductDetailForOrder(txtIdProduct.Text, colorBUS.GetProductColorByName(cbbColor.SelectedItem.ToString()).Idcolor, int.Parse(cbbStorage.Text));
                    if (productDetail != null)
                        txtInventory.Text = productDetail.Inventory.ToString();
                    else
                    {
                        cbbStorage.Text= string.Empty;
                        cbbStorage.Items.Clear();
                        List<int> storages = ProductBUS.GetStorageWithColor(txtIdProduct.Text, cbbColor.SelectedItem.ToString());
                        foreach (int storage in storages)
                        {
                            cbbStorage.Items.Add(storage);
                        }
                    }
                }
            }
        }

        private void cbbStorage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbStorage.SelectedIndex > -1)
            {
                if (string.IsNullOrEmpty(cbbColor.Text))
                {
                    cbbColor.Items.Clear();
                    List<string> colors = ProductBUS.GetColorWithStorage(txtIdProduct.Text, int.Parse(cbbStorage.Text));
                    foreach (string color in colors)
                    {
                        cbbColor.Items.Add(color);
                    }
                }
                else
                {
                    var productDetail = productDetailBUS.GetProductDetailForOrder(txtIdProduct.Text, colorBUS.GetProductColorByName(cbbColor.SelectedItem.ToString()).Idcolor, int.Parse(cbbStorage.Text));
                    if(productDetail!=null)
                        txtInventory.Text = productDetail.Inventory.ToString();
                    else
                    {
                        cbbColor.Text = string.Empty;
                        cbbColor.Items.Clear();
                        List<string> colors = ProductBUS.GetColorWithStorage(txtIdProduct.Text, int.Parse(cbbStorage.Text));
                        foreach (string color in colors)
                        {
                            cbbColor.Items.Add(color);
                        }
                    }    
                }
            }
        }
        private void btnTaoDon_Click(object sender, EventArgs e)
        {
            ResetTexbox(txtIdProductDetaiOrderDetail, txtIdOrder, txtphone, txtName, txtaddres, txtIdProduct, txtProductName, txtBrandName, txtInventory, txtQuantity, txtFrom, txtTo, txtSearch, txtIdCustomerQueue, txtTotalAmountQuese, txtVoucherName, txtFinalAmount);
            ResetCombobox();
            LoadCbbWhenDropDown(cbbOrderQueue, orderBUS.GetAllIDWaitingOrder());
        }

        private void dgvOrderDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.RowIndex < dgvOrderDetails.RowCount - 1)
            {
                var row = dgvOrderDetails.Rows[e.RowIndex];
                txtIdProductOrderDetail.Text = row.Cells[0].Value.ToString();
                txtProductNameOrderDetail.Text = row.Cells[1].Value.ToString();
                txtIdProductDetaiOrderDetail.Text = row.Cells[2].Value.ToString();
                txtColorOrderDetail.Text = row.Cells[3].Value.ToString();
                txtStorageOrderDetail.Text = row.Cells[4].Value.ToString();
                txtQuantityOrderDetail.Text = row.Cells[7].Value.ToString();
                var productDetail = productDetailBUS.GetProductDetailByID(txtIdProductDetaiOrderDetail.Text);
                txtInvetoryOrderDetail.Text = productDetail.Inventory.ToString();
            }
        }

        private void btnUpdateOrderDetail_Click(object sender, EventArgs e)
        {
            if (!CheckNull(txtIdProductOrderDetail.Text, txtQuantityOrderDetail.Text))
            {
                var check = CheckIsInt(txtQuantity);
                if (check == null)
                {
                    var orderDetail = orderDetailBUS.GetOrderDetailByKey(txtIdOrder.Text, txtIdProductDetaiOrderDetail.Text);
                    if (orderDetail != null)
                    {
                        if (int.Parse(txtQuantityOrderDetail.Text) <= int.Parse(txtInvetoryOrderDetail.Text))
                        {
                            if (orderDetailBUS.UpdateOrderDetail(txtIdOrder.Text, txtIdProductDetaiOrderDetail.Text, orderDetail.Quantity, orderDetail.Amount, orderDetail.ReducedAmount))
                            {
                                MessageBox.Show("Sửa thành công");
                            }
                            else
                                MessageBox.Show("Sửa thất bại");
                        }
                        else
                            MessageBox.Show("Quantity không vượt quá inventory");
                    }
                    else
                        MessageBox.Show("Không tìm được order detail này");
                }
                else
                    MessageBox.Show(check);
            }
            else
                MessageBox.Show("Chọn một sản phảm và nhập quantity");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var orderDetail = orderDetailBUS.GetOrderDetailByKey(txtIdOrder.Text, txtIdProductDetaiOrderDetail.Text);
            if (orderDetail != null)
            {
                if (orderDetailBUS.DeleteOrderDetail(orderDetail.Idorder, orderDetail.IdproductDetails))
                {
                    MessageBox.Show("Xóa thành công");
                }
                else
                    MessageBox.Show("Xóa thất bại");
            }
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbbOrderQueue.Text))
            {
                var order = orderBUS.GetOrderById(cbbOrderQueue.Text);
                if (order != null)
                {
                    if (orderBUS.UpdateOrder(order.Idorder, order.Idaccount, order.Idcustomer, order.EstablishedDate, order.TotalAmount, order.Idvoucher, 2))
                        MessageBox.Show("Hủy thành công");
                    else
                        MessageBox.Show("Hủy thất bại");
                }
                else
                    MessageBox.Show("Hủy thất bại");
            }
            else
                MessageBox.Show("Chọn một order từ combo box");
            LoadCbbWhenDropDown(cbbOrderQueue, orderBUS.GetAllIDWaitingOrder());
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbbOrderQueue.Text))
            {
                var order = orderBUS.GetOrderById(cbbOrderQueue.Text);
                if (order != null)
                {
                    txtIdOrder.Text = order.Idorder.ToString();
                    cbbIdCustomer.Text = order.Idcustomer.ToString();
                    var customer= customerBUS.GetCustomerByID(cbbIdCustomer.Text);
                    txtphone.Text=customer.PhoneNumber;
                    txtName.Text=customer.CustomerName;
                    txtaddres.Text=customer.CustomerAddress;
                    ShowOnDgvOrderDetail(txtIdOrder.Text);
                }
                else
                    MessageBox.Show("Không tìm thấy order này");
            }
            else
                MessageBox.Show("Chọn một order từ combo box");
        }
    }
}
