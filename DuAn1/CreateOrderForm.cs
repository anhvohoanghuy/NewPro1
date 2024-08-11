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
        VoucherBUS voucherBUS = new VoucherBUS();
        ImeiBUS imeiBUS = new ImeiBUS();
        ProductCompanyBUS productCompanyBUS = new ProductCompanyBUS();
        PromotionBUS promotionBUS = new PromotionBUS();
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
        public void CreateBill(string idOrder,string idVoucher, decimal get)
        {
            var order= orderBUS.GetOrderById(idOrder);
            if (order != null)
            {
                string currentDirectory = "D:\\KhongPhaiWin\\Pro1\\New folder\\WinFormsApp1\\order";
                string fileName = $"{idOrder}.txt";
                string filePath = Path.Combine(currentDirectory, fileName);
                if (!File.Exists(filePath))
                {
                    File.WriteAllText(filePath, $"Hóa đơn {idOrder}\nID customer: {order.Idcustomer}\nHóa đơn chi tiết\n");
                    var listOrderDetail = orderDetailBUS.GetOrderDetailsByOrderId(idOrder);
                    foreach ( var item in listOrderDetail )
                    {
                        var productDetail = productDetailBUS.GetProductDetailByID(item.IdproductDetails);
                        File.AppendAllText(filePath, $"Tên: {productDetail.IdproductNavigation.ProductName}\nSố lượng: {item.Quantity}\nSố tiền: {item.Amount}\nKhuyến mãi: {item.ReducedAmount}\n");
                    }
                    File.AppendAllText(filePath, $"Tổng tiền: {order.TotalAmount}\n");
                    if (!string.IsNullOrEmpty(idVoucher))
                    {
                        var voucher= voucherBUS.GetVoucherById(idVoucher);
                        if(voucher!=null)
                            File.AppendAllText(filePath, $"Voucher: {voucher.Discount}\n");
                    }
                    File.AppendAllText(filePath, $"Tiền nhận: {get}\n");
                    File.AppendAllText(filePath, $"Tiền trả: {get - order.TotalAmount}\n");
                }
                else
                {
                    MessageBox.Show("File đã tồn tại");
                }
            }
            else
                MessageBox.Show("ID order không tồn tại");
        }
        public decimal GetDiscount(ProductDetail productDetail)
        {
            decimal discount = 0;
            if (productDetail.Idpromotion != null)
            {
                var promotion = promotionBUS.GetPromotionById(productDetail.Idpromotion);
                if (promotion != null)
                {
                    if (promotion.EndTime > DateTime.Now)
                        discount = promotion.Discount;
                }
            }
            return discount;
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
            if (listOrderDetail != null)
            {
                decimal totalAmount = 0;
                foreach (var item in listOrderDetail)
                {
                    totalAmount += (item.Amount - item.ReducedAmount);
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
            dgvProduct.Rows.Clear();
            if (products != null)
            {
                foreach (var product in products)
                {
                    dgvProduct.Rows.Add(product.Idproduct, product.ProductName, product.IdcompanyNavigation.CompanyName, product.Ram, product.IdcpuNavigation.NameCpu, product.ScreenSize, product.CameraResolution, product.Pin);
                }
            }
        }
        public void UpdateProductDetail(Imei imei, int x)
        {
            var productDetail = productDetailBUS.GetProductDetailByID(imei.IdproductDetails);
            productDetailBUS.UpdateProductDetail(productDetail.Idproduct, productDetail.IdproductDetails, productDetail.Idcolor, productDetail.Storage, productDetail.Price, productDetail.Idpromotion, productDetail.WarrantyPeriod, productDetail.Inventory + x, productDetail.Idaccount);
        }
        public void ShowOnDgvOrderDetail(string idOrder)
        {
            dgvOrderDetails.Rows.Clear();
            var listOrderDetails = orderDetailBUS.GetOrderDetailsByOrderId(idOrder);
            if (listOrderDetails != null)
            {
                foreach (var item in listOrderDetails)
                {
                    var productDetail = productDetailBUS.GetProductDetailByID(item.IdproductDetails);
                    var productName = productDetail.IdproductNavigation.ProductName;
                    decimal discount = 0;
                    dgvOrderDetails.Rows.Add(productDetail.Idproduct, productName, productDetail.IdproductDetails, productDetail.IdcolorNavigation.ColorName, productDetail.Storage, productDetail.Price, item.ReducedAmount, item.Quantity);
                }
            }
        }
        public string CheckIsDouble(params TextBox[] textBoxs)
        {
            foreach (var textBox in textBoxs)
            {
                if (string.IsNullOrEmpty(textBox.Text))
                    return null;
                else if (!double.TryParse(textBox.Text, out _))
                    return $"{textBox.Name} phải là số";
                else if (double.Parse(textBox.Text) < 0)
                    return $"{textBox.Name} phải lớn hơn 0";
            }
            return null;
        }
        public void AddImeiToOrderDetail(OrderDetail orderDetail)
        {

            var imei = imeiBUS.GetImeiByID(cbbImei.Text);
            if (imei != null)
            {
                if (imei.Selled == false)
                {
                    if (imeiBUS.UpdateImei(imei.IdproductDetails, imei.ImeiNumber, imei.Idaccount, true))
                    {
                        UpdateProductDetail(imei, -1);
                        orderDetailBUS.AddImeiToOrderDetail(orderDetail, imei);
                        ShowOnDgvOrderDetail(txtIdOrder.Text);
                        ResetCombobox(cbbColor, cbbStorage, cbbImei);
                        ResetTexbox(txtIdProduct, txtBrandName, txtInventory, txtProductName);
                        txtFinalAmount.Text = FinalAmount(txtIdOrder.Text).ToString();
                    }
                    else
                        MessageBox.Show("Thêm imei thất bại");
                }
                else
                    MessageBox.Show("Imei này đã bán");
            }
            else
                MessageBox.Show("Không có imei này");
        }
        private void CreateOrderForm_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            ShowOnDgvProduct(ProductBUS.GetProductForSale(ProductBUS.GetAllProduct()));
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
                ResetCombobox(cbbStorage, cbbImei, cbbColor);
                cbbColor.Text = string.Empty;
                cbbStorage.Text = string.Empty;
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
            if (!CheckNull(cbbImei.Text, cbbColor.Text, cbbStorage.Text))
            {
                if (!string.IsNullOrEmpty(txtIdOrder.Text))
                {
                    var checkOrder = orderBUS.GetOrderById(txtIdOrder.Text);
                    if (checkOrder != null)
                    {
                        var idColor = colorBUS.GetProductColorByName(cbbColor.Text).Idcolor;
                        var productDetail = productDetailBUS.GetProductDetailForOrder(txtIdProduct.Text, idColor, int.Parse(cbbStorage.Text));
                        if (productDetail != null)
                        {
                            var orderDetail = orderDetailBUS.GetOrderDetailByKey(txtIdOrder.Text, productDetail.IdproductDetails);
                            if (orderDetail == null)
                            {
                                decimal discount = GetDiscount(productDetail);
                                if (orderDetailBUS.AddNewOrderDetail(txtIdOrder.Text, productDetail.IdproductDetails, 1, productDetail.Price, discount))
                                {
                                    orderDetail = orderDetailBUS.GetOrderDetailByKey(txtIdOrder.Text, productDetail.IdproductDetails);
                                    AddImeiToOrderDetail(orderDetail);
                                }
                                else
                                    MessageBox.Show("Thêm sản phẩm thất bại");
                            }
                            else
                            {
                                decimal discount = GetDiscount(productDetail);
                                if (orderDetailBUS.UpdateOrderDetail(orderDetail.Idorder, orderDetail.IdproductDetails, orderDetail.Quantity + 1, orderDetail.Amount + productDetail.Price, orderDetail.ReducedAmount + discount))
                                {
                                    orderDetail = orderDetailBUS.GetOrderDetailByKey(txtIdOrder.Text, productDetail.IdproductDetails);
                                    AddImeiToOrderDetail(orderDetail);
                                }
                                else
                                {
                                    MessageBox.Show("Thêm sản phẩm thất bại");
                                }
                            }
                        }
                        else
                            MessageBox.Show("Không có sản phẩm này");
                    }
                    else
                    {
                        var idColor = colorBUS.GetProductColorByName(cbbColor.Text).Idcolor;
                        var productDetail = productDetailBUS.GetProductDetailForOrder(txtIdProduct.Text, idColor, int.Parse(cbbStorage.Text));
                        if (productDetail != null)
                        {
                            if (orderBUS.AddNewOrder(txtIdOrder.Text, IdAccount, cbbIdCustomer.Text, DateTime.Now, 0, null, 0))
                            {
                                decimal discount = GetDiscount(productDetail);
                                if (orderDetailBUS.AddNewOrderDetail(txtIdOrder.Text, productDetail.IdproductDetails, 1, productDetail.Price, discount))
                                {
                                    var orderDetail = orderDetailBUS.GetOrderDetailByKey(txtIdOrder.Text, productDetail.IdproductDetails);
                                    AddImeiToOrderDetail(orderDetail);
                                }
                                else
                                    MessageBox.Show("Thêm sản phẩm thất bại");
                            }
                            else
                                MessageBox.Show("Thêm order thất bại");
                        }
                        else
                            MessageBox.Show("Không có productDetail này");
                    }
                }
                else
                    MessageBox.Show("Chọn id customer");
            }
            else
                MessageBox.Show("Nhập quantity");
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
                    {
                        txtInventory.Text = productDetail.Inventory.ToString();
                        var imeis = imeiBUS.GetImeiByIdProductDetailForSale(productDetail.IdproductDetails);
                        if (imeis != null)
                        {
                            cbbImei.Items.Clear();
                            foreach (var item in imeis)
                            {
                                cbbImei.Items.Add(item.ImeiNumber);
                            }
                        }
                    }
                    else
                    {
                        cbbStorage.Text = string.Empty;
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
                    if (productDetail != null)
                    {
                        txtInventory.Text = productDetail.Inventory.ToString();
                        var imeis = imeiBUS.GetImeiByIdProductDetailForSale(productDetail.IdproductDetails);
                        if (imeis != null)
                        {
                            cbbImei.Items.Clear();
                            foreach (var item in imeis)
                            {
                                cbbImei.Items.Add(item.ImeiNumber);
                            }
                        }
                    }
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
            ResetTexbox(txtIdProductDetaiOrderDetail, txtIdOrder, txtphone, txtName, txtaddres, txtIdProduct, txtProductName, txtBrandName, txtInventory, txtFrom, txtTo, txtSearch, txtIdCustomerQueue, txtTotalAmountQuese, txtVoucherDiscount, txtFinalAmount);
            ResetCombobox(cbbColor, cbbStorage, cbbImei);
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
                var orderDetail = orderDetailBUS.GetOrderDetailByKey(txtIdOrder.Text, txtIdProductDetaiOrderDetail.Text);
                cbbImeiOrderDetail.Items.Clear();
                if (orderDetail != null)
                {
                    foreach (var item in orderDetail.ImeiNumbers)
                    {
                        cbbImeiOrderDetail.Items.Add(item.ImeiNumber);
                    }
                }
            }
        }

        private void btnUpdateOrderDetail_Click(object sender, EventArgs e)
        {
            if (!CheckNull(txtIdProductDetaiOrderDetail.Text, txtIdOrder.Text))
            {
                var orderDetail = orderDetailBUS.GetOrderDetailByKey(txtIdOrder.Text, txtIdProductDetaiOrderDetail.Text);
                if (orderDetail != null)
                {
                    var listImei = orderDetail.ImeiNumbers;
                    List<Imei> copy = new List<Imei>();
                    copy.AddRange(listImei);
                    foreach (var imei in copy)
                    {
                        if (imeiBUS.UpdateImei(imei.IdproductDetails, imei.ImeiNumber, imei.Idaccount, false))
                        {
                            UpdateProductDetail(imei, +1);
                            orderDetailBUS.RemoveImeiToOrderDetail(orderDetail, imei);
                            ResetTexbox(txtIdProductOrderDetail, txtIdProductDetaiOrderDetail, txtProductNameOrderDetail, txtColorOrderDetail, txtStorageOrderDetail, txtQuantityOrderDetail, txtInvetoryOrderDetail);
                            ResetCombobox(cbbImeiOrderDetail);
                        }
                        else
                        {
                            MessageBox.Show("Sửa imei thất bại");
                            break;
                        }
                    }
                    if (orderDetailBUS.DeleteOrderDetail(orderDetail.Idorder, orderDetail.IdproductDetails))
                    {
                        MessageBox.Show("Xóa thành công");
                    }
                    else
                        MessageBox.Show("Xóa thất bại");
                }
                else
                    MessageBox.Show("Không có order detail này");
            }
            ShowOnDgvOrderDetail(txtIdOrder.Text);
            txtFinalAmount.Text = FinalAmount(txtIdOrder.Text).ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var orderDetail = orderDetailBUS.GetOrderDetailByKey(txtIdOrder.Text, txtIdProductDetaiOrderDetail.Text);
            if (orderDetail != null)
            {
                if (!string.IsNullOrEmpty(cbbImeiOrderDetail.Text))
                {
                    if (orderDetail.Quantity > 1)
                    {
                        var imei = imeiBUS.GetImeiByID(cbbImeiOrderDetail.Text);
                        if (imei != null)
                        {
                            if (imeiBUS.UpdateImei(imei.IdproductDetails, imei.ImeiNumber, imei.Idaccount, false))
                            {
                                orderDetailBUS.RemoveImeiToOrderDetail(orderDetail, imei);
                                UpdateProductDetail(imei, +1);
                                decimal amount = orderDetail.Amount * (orderDetail.Quantity - 1) / orderDetail.Quantity;
                                decimal reduce = orderDetail.ReducedAmount * (orderDetail.Quantity - 1) / orderDetail.Quantity;
                                if (orderDetailBUS.UpdateOrderDetail(orderDetail.Idorder, orderDetail.IdproductDetails, orderDetail.Quantity - 1, amount, reduce))
                                {
                                    ResetTexbox(txtIdProductOrderDetail, txtIdProductDetaiOrderDetail, txtProductNameOrderDetail, txtColorOrderDetail, txtStorageOrderDetail, txtQuantityOrderDetail, txtInvetoryOrderDetail);
                                    ResetCombobox(cbbImeiOrderDetail);
                                    MessageBox.Show("Xóa thành công");
                                }
                                else
                                    MessageBox.Show("Xóa thất bại");
                            }
                            else
                                MessageBox.Show("Update Imei thất bại");
                        }
                        else
                            MessageBox.Show("Không có imei này");
                    }
                    else
                    {
                        var imei = imeiBUS.GetImeiByID(cbbImeiOrderDetail.Text);
                        if (imeiBUS.UpdateImei(imei.IdproductDetails, imei.ImeiNumber, imei.Idaccount, false))
                        {
                            UpdateProductDetail(imei, +1);
                            orderDetailBUS.RemoveImeiToOrderDetail(orderDetail, imei);
                            if (orderDetailBUS.DeleteOrderDetail(orderDetail.Idorder, orderDetail.IdproductDetails))
                            {
                                ResetTexbox(txtIdProductOrderDetail, txtIdProductDetaiOrderDetail, txtProductNameOrderDetail, txtColorOrderDetail, txtStorageOrderDetail, txtQuantityOrderDetail, txtInvetoryOrderDetail);
                                ResetCombobox(cbbImeiOrderDetail);
                                MessageBox.Show("Xóa thành công");
                            }
                            else
                                MessageBox.Show("Xóa thất bại");
                        }
                        else
                            MessageBox.Show("Sửa imei thất bại");
                    }
                }
                else
                    MessageBox.Show("Chọn một imei");
            }
            else
                MessageBox.Show("Không có orderDetail này");
            ShowOnDgvOrderDetail(txtIdOrder.Text);
            txtFinalAmount.Text = FinalAmount(txtIdOrder.Text).ToString();
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbbOrderQueue.Text))
            {
                var order = orderBUS.GetOrderById(cbbOrderQueue.Text);
                if (order != null)
                {
                    if (orderBUS.UpdateOrder(order.Idorder, order.Idaccount, order.Idcustomer, order.EstablishedDate, order.TotalAmount, order.Idvoucher, 2))
                    {
                        var orderDetails = orderDetailBUS.GetOrderDetailsByOrderId(order.Idorder);
                        foreach (var item in orderDetails)
                        {
                            var listImei = item.ImeiNumbers;
                            foreach (var imei in listImei)
                            {
                                if (imeiBUS.UpdateImei(imei.IdproductDetails, imei.ImeiNumber, imei.Idaccount, false))
                                {
                                    UpdateProductDetail(imei, +1);
                                }
                                else
                                {
                                    MessageBox.Show("Sửa imei thất bại");
                                    break;
                                }
                            }
                        }
                        MessageBox.Show("Hủy thành công");
                    }
                    else
                        MessageBox.Show("Hủy thất bại");
                }
                else
                    MessageBox.Show("Không có order này");
            }
            else
                MessageBox.Show("Chọn một order từ combo box");
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
                    var customer = customerBUS.GetCustomerByID(cbbIdCustomer.Text);
                    txtphone.Text = customer.PhoneNumber;
                    txtName.Text = customer.CustomerName;
                    txtaddres.Text = customer.CustomerAddress;
                    ShowOnDgvOrderDetail(txtIdOrder.Text);
                    txtFinalAmount.Text = FinalAmount(txtIdOrder.Text).ToString();
                }
                else
                    MessageBox.Show("Không tìm thấy order này");
            }
            else
                MessageBox.Show("Chọn một order từ combo box");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetTexbox(txtIdProductDetaiOrderDetail, txtIdOrder, txtphone, txtName, txtaddres, txtIdProduct, txtProductName, txtBrandName, txtInventory, txtFrom, txtTo, txtSearch, txtIdCustomerQueue, txtTotalAmountQuese, txtVoucherDiscount, txtFinalAmount);
            ResetCombobox(cbbColor, cbbStorage, cbbVoucher, cbbImei);
            dgvOrderDetails.Rows.Clear();
            ShowOnDgvProduct(ProductBUS.GetProductForSale(ProductBUS.GetAllProduct()));
        }

        private void cbbOrderQueue_DropDown(object sender, EventArgs e)
        {
            LoadCbbWhenDropDown(cbbOrderQueue, orderBUS.GetAllIDWaitingOrder(cbbOrderQueue.Text));
        }

        private void cbbVoucher_DropDown(object sender, EventArgs e)
        {
            LoadCbbWhenDropDown(cbbVoucher, voucherBUS.GetAllIdVoucherForSale(cbbVoucher.Text));
        }

        private void cbbVoucher_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbVoucher.SelectedIndex > -1)
            {
                var voucher = voucherBUS.GetVoucherById(cbbVoucher.Text);
                txtVoucherDiscount.Text = voucher.Discount.ToString();
            }
        }

        private void btnThanhToans_Click(object sender, EventArgs e)
        {
            Order order = orderBUS.GetOrderById(txtIdOrder.Text);
            if (order != null)
            {
                if (!string.IsNullOrEmpty(cbbVoucher.Text))
                {
                    decimal total = 0;
                    var voucher = voucherBUS.GetVoucherById(cbbVoucher.Text);
                    if (voucher != null)
                    {
                        total = decimal.Parse(txtFinalAmount.Text) - voucher.Discount;
                    }
                    FormThanhToan formThanhToan = new FormThanhToan(total);
                    formThanhToan.ShowDialog();
                    if (formThanhToan.XacNhan)
                    {
                        if (orderBUS.UpdateOrder(order.Idorder, order.Idaccount, order.Idcustomer, DateTime.Now, total, voucher == null ? null : voucher.Idvoucher, 1))
                        {
                            if (voucherBUS.UpdateVoucher(voucher.Idvoucher, voucher.VoucherName, voucher.Discount, voucher.StartTime, (DateTime)voucher.EndTime, voucher.UsageCount - 1, voucher.Idaccount))
                            {
                                MessageBox.Show("Thanh toán thành công");
                                CreateBill(txtIdOrder.Text, cbbVoucher.Text, formThanhToan.Get);
                                ResetTexbox(txtIdProductDetaiOrderDetail, txtIdOrder, txtphone, txtName, txtaddres, txtIdProduct, txtProductName, txtBrandName, txtInventory, txtFrom, txtTo, txtSearch, txtIdCustomerQueue, txtTotalAmountQuese, txtVoucherDiscount, txtFinalAmount);
                                ResetCombobox(cbbColor, cbbStorage, cbbVoucher, cbbVoucher);
                                dgvOrderDetails.Rows.Clear();
                                
                            }
                            else
                                MessageBox.Show("Update Voucher thất bại");
                        }
                        else
                            MessageBox.Show("Thanh toán thất bại");
                    }
                    else
                        MessageBox.Show("Chưa thanh toán");
                }
                else
                {
                    decimal total = decimal.Parse(txtFinalAmount.Text);
                    FormThanhToan formThanhToan = new FormThanhToan(total);
                    formThanhToan.ShowDialog();
                    if (formThanhToan.XacNhan)
                    {
                        if (orderBUS.UpdateOrder(order.Idorder, order.Idaccount, order.Idcustomer, DateTime.Now, total, null, 1))
                        {
                            MessageBox.Show("Thanh toán thành công");
                            ResetTexbox(txtIdProductDetaiOrderDetail, txtIdOrder, txtphone, txtName, txtaddres, txtIdProduct, txtProductName, txtBrandName, txtInventory, txtFrom, txtTo, txtSearch, txtIdCustomerQueue, txtTotalAmountQuese, txtVoucherDiscount, txtFinalAmount);
                            ResetCombobox(cbbColor, cbbStorage, cbbVoucher, cbbImei);
                            dgvOrderDetails.Rows.Clear();
                        }
                        else
                            MessageBox.Show("Thanh toán thất bại");
                    }
                    else
                        MessageBox.Show("Chưa thanh toán");
                }
            }
            else
                MessageBox.Show("Không có id order này");
        }
        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbbVoucher_Leave(object sender, EventArgs e)
        {
            var voucher = voucherBUS.GetVoucherById(cbbVoucher.Text);
            if (voucher != null)
            {
                txtVoucherDiscount.Text = voucher.VoucherName;
            }
            else
            {
                txtVoucherDiscount.Clear();
                MessageBox.Show("Không có id voucher này");
            }
        }

        private void btnFillter_Click(object sender, EventArgs e)
        {
            double from = -1;
            double to = int.MaxValue;
            if (CheckNull(txtFrom.Text) && CheckNull(txtTo.Text))
            {
                MessageBox.Show("Nhập ít nhất một trong hai giá trị");
            }
            else
            {
                var check = CheckIsDouble(txtFrom, txtTo);
                if (check == null)
                {
                    if (!CheckNull(txtFrom.Text))
                        from = double.Parse(txtFrom.Text);
                    if (!CheckNull(txtTo.Text))
                        to = double.Parse(txtTo.Text);
                    if (cbbFillter.SelectedIndex > -1)
                    {
                        var result = ProductBUS.FilterProduct(cbbFillter.SelectedIndex, from, to);
                        ShowOnDgvProduct(result);
                    }
                    else
                        MessageBox.Show("Chọn một giá trị từ combobox filter");
                }
                else
                    MessageBox.Show(check);
            }
        }
        private void vbtnSearch_Click(object sender, EventArgs e)
        {
            if (cbbTimKiem.SelectedIndex > -1)
            {
                List<Product> products = ProductBUS.SearchProduct(cbbTimKiem.SelectedIndex, txtSearch.Text);
                ShowOnDgvProduct(products);
            }
            else
                MessageBox.Show("Chọn danh mục tìm kiếm");
        }

        private void btninfoOrder_Click(object sender, EventArgs e)
        {

        }

        private void btnOkScan_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtScan.Text))
            {
                var imei = imeiBUS.GetImeiByID(txtScan.Text);
                if (imei != null)
                {
                    cbbImei.Text = imei.ImeiNumber;
                    var productDetail = productDetailBUS.GetProductDetailByID(imei.IdproductDetails);
                    if (productDetail != null)
                    {
                        var company = productCompanyBUS.GetCompanyById(productDetail.IdproductNavigation.Idcompany);
                        txtIdProduct.Text = productDetail.Idproduct;
                        txtProductName.Text = productDetail.IdproductNavigation.ProductName;
                        txtBrandName.Text = company.CompanyName;
                        cbbColor.Text = productDetail.IdcolorNavigation.ColorName;
                        cbbStorage.Text = productDetail.Storage.ToString();
                    }
                    else
                        MessageBox.Show("Không tìm thầy product detail");
                }
            }
            else
                MessageBox.Show("Không để trống scan");
        }

        private void btninfoOrder_Click_1(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(cbbVoucher.Text))
            {
                ChiTietDonHangForm a = new ChiTietDonHangForm(txtIdOrder.Text);
                a.ShowDialog();
            }
            else
            {
                ChiTietDonHangForm a = new ChiTietDonHangForm(txtIdOrder.Text,cbbVoucher.Text);
                a.ShowDialog();
            }
        }
    }
}
