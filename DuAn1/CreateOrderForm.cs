using BUS.Services;
using DAL.Models;
using DAL.ModelViews;
using static DuAn1.DangNhapForm;

namespace DuAn1
{

    public partial class CreateOrderForm : Form
    {

        private OrderModelView selectedOrder;
        private List<OrderModelView> orderQueue = new List<OrderModelView>();

        private List<ProductModelView> products;
        private List<OrderDetailModelView> addOrderDetails;
        private List<ProductColor> productColors;
        private List<Imei> imeis;
        private List<Cpu> cpus;
        private List<Voucher> vouchers;
        private List<QueueModelView> queues;

        private ProductBUS productBus;
        private ProductColorBUS productColorBus;
        private ImeiBUS imeiBus;
        private CpuBUS cpuBus;
        private OrderBUS orderBus;
        private CustomerBUS customerBus;
        private VoucherBUS voucherBus;
        private OrderDetailBUS orderDetailBus;

        int row = -1;
        decimal totalCost = 0;
        int rowDetail = -1;
        public CreateOrderForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        public void LoadForm()
        {
            products = new List<ProductModelView>();
            productColors = new List<ProductColor>();
            imeis = new List<Imei>();
            cpus = new List<Cpu>();
            addOrderDetails = new List<OrderDetailModelView>();
            vouchers = new List<Voucher>();
            queues = new List<QueueModelView>();

            productBus = new ProductBUS();
            productColorBus = new ProductColorBUS();
            imeiBus = new ImeiBUS();
            cpuBus = new CpuBUS();
            orderBus = new OrderBUS();
            customerBus = new CustomerBUS();
            voucherBus = new VoucherBUS();
            orderDetailBus = new OrderDetailBUS();


            dgvProducts.ColumnCount = 7;
            dgvProducts.Columns[0].HeaderText = "Id Prod";
            dgvProducts.Columns[0].Width = 60;
            dgvProducts.Columns[1].HeaderText = "Name";
            dgvProducts.Columns[1].Width = 80;
            dgvProducts.Columns[2].HeaderText = "Brand";
            dgvProducts.Columns[2].Width = 120;
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol.HeaderText = "Image";
            imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            imgCol.Width = 100;
            imgCol.DisplayIndex = 4;
            dgvProducts.Columns.Add(imgCol);
            dgvProducts.Columns[4].HeaderText = "Ram";
            dgvProducts.Columns[4].Width = 70;
            dgvProducts.Columns[5].HeaderText = "Storage";
            dgvProducts.Columns[5].Width = 60;
            dgvProducts.Columns[6].HeaderText = "Color";
            LoadVoucher();
            LoadProductsFirst();
            LoadHeaderOrderDetail();
        }

        public void LoadCbbWhenDropDown(ComboBox currentCbb, List<string> originList)
        {
            currentCbb.Items.Clear();
            foreach (var item in originList)
            {
                currentCbb.Items.Add(item);
            }
            currentCbb.SelectedIndex = 0;
        }

        public void LoadCombobox(ComboBox currentCbb, List<KeyValuePair<string, string>> items)
        {
            currentCbb.DataSource = items;
            currentCbb.DisplayMember = "Value";
            currentCbb.ValueMember = "Key";
        }

        private void LoadVoucher()
        {
            vouchers = voucherBus.GetAll();
            LoadCombobox(cbbVoucher, vouchers.Select(x => new KeyValuePair<string, string>(x.Idvoucher, x.Idvoucher + "|" + x.VoucherName + "|" + x.Discount)).ToList());
        }

        private void LoadProductsFirst()
        {
            products = productBus.GetAllIncludeDetail();
            LoadProducts(products);
        }

        private void LoadProducts(List<ProductModelView> list)
        {
            dgvProducts.Rows.Clear();
            foreach (var item in list)
            {

                try
                {
                    System.Net.WebRequest request = System.Net.WebRequest.Create(item.ProductImage);
                    System.Net.WebResponse response = request.GetResponse();
                    System.IO.Stream responseStream = response.GetResponseStream();
                    Bitmap img = new Bitmap(responseStream);
                    dgvProducts.Rows.Add(item.Idproduct, item.ProductName, item.CompanyName, img, item.Ram, item.Storage, item.ColorName);
                }
                catch (Exception)
                {
                    try
                    {
                        Bitmap img = new Bitmap(item.ProductImage);
                        dgvProducts.Rows.Add(item.Idproduct, item.ProductName, item.CompanyName, img, item.Ram, item.Storage, item.ColorName);
                    }
                    catch (Exception)
                    {
                        //var defaultImg = "D:\\MYDRIVE\\job\\LamTheAnh_C#Winform_QuanLyBanDienThoai\\source\\NewPro1\\DuAn1\\Resources\\95caafffcef21dbd98aa11d0a8850a03.jpg";
                        //Bitmap img = new Bitmap(defaultImg);
                        dgvProducts.Rows.Add(item.Idproduct, item.ProductName, item.CompanyName, item.Ram, item.Storage, item.ColorName);
                    }
                }
            }
        }

        public OrderModelView GetDataOrder()
        {
            OrderModelView order = new OrderModelView();
            order.OrderId = txtId.Text;
            order.CustomerId = txtIdcus.Text;
            order.CustomerName = txtName.Text;
            order.PhoneNumber = txtphone.Text;
            order.Address = txtaddres.Text;
            order.Idaccount = GetDataUser.idaccount;
            order.Idvoucher = vouchers.Count == 0 ? null : vouchers[cbbVoucher.SelectedIndex].Idvoucher;
            return order;
        }

        public void SetDataOrder(OrderModelView? order = null)
        {
            if (order == null)
            {
                txtId.Text = "";
                txtIdcus.Text = "";
                txtName.Text = "";
                txtphone.Text = "";
                txtaddres.Text = "";
            }
            else
            {
                txtId.Text = order.OrderId;
                txtIdcus.Text = order.CustomerId;
                txtName.Text = order.CustomerName;
                txtphone.Text = order.PhoneNumber;
                txtaddres.Text = order.Address;
            }
        }


        public OrderDetailModelView GetDataOrderDetail()
        {
            OrderDetailModelView detail = new OrderDetailModelView();
            detail.IdProduct = products[row].Idproduct;
            detail.IdproductDetails = products[row].IdproductDetails;
            detail.ProductName = products[row].ProductName;
            detail.ProductImage = products[row].ProductName;
            detail.Ram = products[row].Ram;
            detail.Storage = products[row].Storage;
            detail.Price = products[row].Price;
            detail.Discount = products[row].Discount;
            detail.Idcpu = products[row].Idcpu;
            detail.NameCpu = products[row].NameCpu;
            detail.Manufacturer = products[row].Manufacturer;
            detail.Idcolor = products[row].Idcolor;
            detail.ColorName = products[row].ColorName;
            detail.Idcompany = products[row].Idcompany;
            detail.CompanyName = products[row].CompanyName;

            detail.Quantity = int.Parse(txtQuantity.Text);
            detail.Amount = products[row].Price;
            detail.ReducedAmount = detail.Quantity * products[row].Price * (products[row].Discount ?? 0);
            detail.TotalCost = detail.Quantity * products[row].Price - detail.ReducedAmount;
            return detail;
        }

        private void SetOrderDetail(ProductModelView product)
        {
            txtProductId.Text = product.Idproduct + "|" + product.ProductName + "|" + product.Ram;
            txtCPU.Text = product.NameCpu + "|" + product.Manufacturer;
            txtColor.Text = product.ColorName;
        }

        private void SetOrderDetail_Data(OrderDetailModelView? order = null)
        {
            if (order != null)
            {
                txtProductId.Text = order.IdProduct + "|" + order.ProductName + "|" + order.Ram;
                txtCPU.Text = order.NameCpu + "|" + order.Manufacturer;
                txtColor.Text = order.ColorName;
                txtQuantity.Text = order.Quantity.ToString();
            }
            else
            {
                txtProductId.Text = "";
                txtCPU.Text = "";
                txtColor.Text = "";
                txtQuantity.Text = "";
            }
        }

        private void AddOrderDetail()
        {
            if (string.IsNullOrEmpty(txtProductId.Text) || (row == -1 || row > products.Count - 1))
            {
                ShowMessage("Thông tin sản phẩm không được để trống! Vui lòng chọn sản phẩm");
                return;
            }
            if (string.IsNullOrEmpty(txtQuantity.Text))
            {
                ShowMessage("Số lượng mua không được để trống");
                return;
            }

            OrderDetailModelView detail = GetDataOrderDetail();
            AddListOrderDetail(detail);

            LoadOrderDetail();
            txtQuantity.Text = "";
        }

        private void AddListOrderDetail(OrderDetailModelView detail)
        {
            if (!addOrderDetails.Any(x => x.IdproductDetails.Equals(detail.IdproductDetails)))
            {
                addOrderDetails.Add(detail);

            }
            else
            {
                foreach (OrderDetailModelView item in addOrderDetails)
                {
                    if (item.IdproductDetails.Equals(detail.IdproductDetails))
                    {
                        item.Quantity += detail.Quantity;
                        item.ReducedAmount += item.Quantity * products[row].Price * (products[row].Discount ?? 0);
                        item.TotalCost += item.Quantity * products[row].Price - item.ReducedAmount;
                    }
                }
            }

        }

        public void ShowMessage(string message, string? caption = null)
        {
            if (caption != null)
            {
                MessageBox.Show(message, caption);
            }
            else
            {
                MessageBox.Show(message);
            }
        }

        private void LoadHeaderOrderDetail()
        {
            dgvOrderDetails.ColumnCount = 11;
            dgvOrderDetails.Columns[0].HeaderText = "Id Prod";
            dgvOrderDetails.Columns[0].Width = 60;
            dgvOrderDetails.Columns[1].HeaderText = "Name";
            dgvOrderDetails.Columns[1].Width = 80;
            dgvOrderDetails.Columns[2].HeaderText = "Brand";
            dgvOrderDetails.Columns[2].Width = 120;
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol.HeaderText = "Image";
            imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            imgCol.Width = 100;
            imgCol.DisplayIndex = 4;
            dgvOrderDetails.Columns.Add(imgCol);
            dgvOrderDetails.Columns[4].HeaderText = "Ram";
            dgvOrderDetails.Columns[4].Width = 70;
            dgvOrderDetails.Columns[5].HeaderText = "Storage";
            dgvOrderDetails.Columns[5].Width = 60;
            dgvOrderDetails.Columns[6].HeaderText = "Quantity";
            dgvOrderDetails.Columns[6].Width = 60;
            dgvOrderDetails.Columns[7].HeaderText = "Price";
            dgvOrderDetails.Columns[7].Width = 60;
            dgvOrderDetails.Columns[8].HeaderText = "Prodmotional Price";
            dgvOrderDetails.Columns[8].Width = 60;
            dgvOrderDetails.Columns[9].HeaderText = "Total Discount";
            dgvOrderDetails.Columns[9].Width = 60;
            dgvOrderDetails.Columns[10].HeaderText = "Total Cost";
            dgvOrderDetails.Columns[10].Width = 60;
        }

        private void LoadOrderDetail()
        {
            dgvOrderDetails.Rows.Clear();
            foreach (var item in addOrderDetails)
            {
                try
                {
                    System.Net.WebRequest request = System.Net.WebRequest.Create(item.ProductImage);
                    System.Net.WebResponse response = request.GetResponse();
                    System.IO.Stream responseStream = response.GetResponseStream();
                    Bitmap img = new Bitmap(responseStream);
                    dgvOrderDetails.Rows.Add(item.IdProduct, item.ProductName, item.CompanyName, img, item.Ram, item.Storage, item.Quantity, item.Price, item.Discount, item.ReducedAmount, item.TotalCost);
                }
                catch (Exception)
                {
                    try
                    {
                        Bitmap img = new Bitmap(item.ProductImage);
                        dgvOrderDetails.Rows.Add(item.IdProduct, item.ProductName, item.CompanyName, img, item.Ram, item.Storage, item.Quantity, item.Price, item.Discount, item.ReducedAmount, item.TotalCost);
                    }
                    catch (Exception)
                    {
                        //var defaultImg = "D:\\MYDRIVE\\job\\LamTheAnh_C#Winform_QuanLyBanDienThoai\\source\\NewPro1\\DuAn1\\Resources\\95caafffcef21dbd98aa11d0a8850a03.jpg";
                        //Bitmap img = new Bitmap(defaultImg);
                        dgvOrderDetails.Rows.Add(item.IdProduct, item.ProductName, item.CompanyName, item.Ram, item.Storage, item.Quantity, item.Price, item.Discount, item.ReducedAmount, item.TotalCost);
                    }
                }
                totalCost += item.TotalCost ?? 0;
            }
            txtTotalCost.Text = totalCost.ToString();
        }

        private bool ValidDataOrder()
        {
            if (string.IsNullOrEmpty(txtId.Text) || string.IsNullOrEmpty(txtIdcus.Text) || string.IsNullOrEmpty(txtaddres.Text) || string.IsNullOrEmpty(txtphone.Text) || string.IsNullOrEmpty(txtName.Text))
            {
                ShowMessage("Thông tin order khong được bỏ trống. Vui lòng điền đầy đủ thông tin");
                return false;
            }
            return true;
        }

        private void CreateOrder()
        {
            if (!ValidDataOrder())
            {
                return;
            }
            if (addOrderDetails.Count == 0)
            {
                ShowMessage("Chưa có sản phẩm nào trong đơn hàng, vui lòng thêm sản phẩm");
                return;
            }
            AddOrder();

        }

        private void AddOrder()
        {
            OrderModelView order = GetDataOrder();
            if (orderBus.GetById(order.OrderId) != null)
            {
                ShowMessage("Mã hóa đơn đã tồn tại. Vui lòng nhập mã khác");
                return;
            }
            if (customerBus.GetCustomerByID(order.CustomerId) != null)
            {
                ShowMessage("Mã khách hàng đã tồn tại. Vui lòng nhập mã khác");
                return;
            }

            decimal totalCost = 0;
            foreach (OrderDetailModelView detail in addOrderDetails)
            {
                detail.Idorder = order.OrderId;
                totalCost += detail.TotalCost ?? 0;
            }

            if (order.Idvoucher != null)
            {
                var voucher = voucherBus.GetById(order.Idvoucher);

                if (voucher != null)
                {
                    totalCost *= 1 - voucher.Discount;
                }
            }
            order.TotalAmount = totalCost;
            order.Paid = true;
            orderBus.AddOrder(order);


            foreach (OrderDetailModelView detail in addOrderDetails)
            {
                orderDetailBus.AddOrder(detail);
            }

            ShowMessage("Đơn hàng được tạo thành công!");
            ResetForm();
        }

        private void ResetForm()
        {
            SetDataOrder(null);
            SetOrderDetail_Data(null);
            addOrderDetails.Clear();
            dgvOrderDetails.Rows.Clear();
            totalCost = 0;
            row = -1;
            rowDetail = -1;
        }

        private void DeleteOrderDetail()
        {
            if ((rowDetail == -1 || rowDetail > addOrderDetails.Count - 1) || string.IsNullOrEmpty(txtProductId.Text))
            {
                ShowMessage("Không thể xóa sản phẩm");
                return;
            }
            if (addOrderDetails.Count >= 1)
            {
                totalCost -= addOrderDetails[rowDetail].TotalCost ?? 0;
                addOrderDetails.RemoveAt(rowDetail);
            }
        }

        #region Events
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btninfoOrder_Click(object sender, EventArgs e)
        {
            ChiTietDonHangForm a = new ChiTietDonHangForm();
            a.ShowDialog();
        }

        private void btnAddToOrderQueue_Click(object sender, EventArgs e)
        {
            if (!ValidDataOrder())
            {
                return;
            }
            if (addOrderDetails.Count == 0)
            {
                ShowMessage("Chưa có sản phẩm nào trong đơn hàng, vui lòng thêm sản phẩm");
                return;
            }
            QueueModelView queue = new QueueModelView()
            {
                Order = GetDataOrder(),
            };
            queue.OrderDetails = new List<OrderDetailModelView>();
            queue.OrderDetails.AddRange(addOrderDetails);
            queues.Add(queue);
            ResetForm();

            LoadCombobox(cmbOrderQueue, queues.Select(x => new KeyValuePair<string, string>(x.Order.OrderId, x.Order.OrderId + "|" + x.Order.CustomerName)).ToList());
            MessageBox.Show("Đơn hàng đã được vào hàng đợi.");
        }

        private void cmbOrderQueue_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có muốn chọn hóa đơn chờ này không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (cmbOrderQueue.Items.Count < 0)
                {
                    ShowMessage("Không thể chọn hóa đơn chờ");
                    return;
                }
                ResetForm();
                var queue = queues[cmbOrderQueue.SelectedIndex];
                SetDataOrder(queue.Order);
                addOrderDetails.AddRange(queue.OrderDetails);
                LoadOrderDetail();
                queues.RemoveAt(cmbOrderQueue.SelectedIndex);
                LoadCombobox(cmbOrderQueue, queues.Select(x => new KeyValuePair<string, string>(x.Order.OrderId, x.Order.OrderId + "|" + x.Order.CustomerName)).ToList());

                if (queues.Count == 0)
                {
                    cmbOrderQueue.SelectedIndex = -1;
                }
            }
        }

        private void btnTaoDon_Click(object sender, EventArgs e)
        {
            //if (cmbOrderQueue.SelectedIndex != -1)
            //{
            //    // Lấy chỉ mục được chọn
            //    int selectedIndex = cmbOrderQueue.SelectedIndex;

            //    // Xóa mục được chọn khỏi ComboBox
            //    cmbOrderQueue.Items.RemoveAt(selectedIndex);

            //    // Xóa đơn hàng tương ứng khỏi danh sách orderQueue
            //    orderQueue.RemoveAt(selectedIndex);



            //    // Hiển thị thông báo
            //    MessageBox.Show("Đơn hàng được chọn đã được tạo.");
            //}
            //else
            //{
            //    // Nếu không có mục nào được chọn, hiển thị thông báo
            //    MessageBox.Show("Không có đơn hàng nào được chọn để xóa.");
            //}
            CreateOrder();
        }



        private void CreateOrderForm_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void vbButton4_Click(object sender, EventArgs e)
        {

        }

        private void cbbIdprod_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            if (row == -1 || row > products.Count - 1)
            {
                return;
            }
            SetOrderDetail(products[row]);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            AddOrderDetail();
        }

        private void vbButton3_Click(object sender, EventArgs e)
        {

        }
        private void vbtnSearch_Click(object sender, EventArgs e)
        {
            string key = txtSearch.Text;
            if (string.IsNullOrEmpty(key))
                LoadProductsFirst();
            else
            {
                products = productBus.SearchProduct(key);
                LoadProducts(products);
            }
        }

        private void cbbVoucher_SelectedIndexChanged(object sender, EventArgs e)
        {
            string voucherId = cbbVoucher.SelectedValue.ToString();
            var voucher = vouchers.FirstOrDefault(m => m.Idvoucher.Equals(voucherId));
            decimal total = totalCost;
            if (voucher != null && totalCost != 0)
            {
                total *= (1 - voucher.Discount);
            }
            txtTotalCost.Text = total.ToString();
        }

        private void dgvOrderDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowDetail = e.RowIndex;
            if (rowDetail == -1 || rowDetail > addOrderDetails.Count - 1)
            {
                return;
            }
            SetOrderDetail_Data(addOrderDetails[rowDetail]);
        }

        private void btnHuyDon_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn hủy đơn hàng không?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ResetForm();
            }
        }

        private void vbtnDeletePro_Click(object sender, EventArgs e)
        {
            DeleteOrderDetail();
            LoadOrderDetail();
        }
        #endregion
    }
}
