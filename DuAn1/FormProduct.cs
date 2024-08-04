using BUS;
using BUS.Services;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAn1
{
    public partial class FormProduct : Form
    {
        ProductBUS productBUS = new ProductBUS();
        ProductCompanyBUS productCompanyBUS = new ProductCompanyBUS();
        AccountBUS accountBUS = new AccountBUS();
        CpuBUS cpuBUS = new CpuBUS();
        Validate validate = new Validate();
        FormMenu menu = new FormMenu();
        public FormProduct()
        {
            InitializeComponent();
        }
        public void LoadDataGridView()
        {
            dgvListProduct.Columns.Add("IDproduct", "ID product");
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol.Name = "ProductImage";
            imgCol.HeaderText = "Product image";
            imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            imgCol.Width = 100;
            dgvListProduct.Columns.Add(imgCol);
            dgvListProduct.Columns.Add("ProductName", "Product name");
            dgvListProduct.Columns.Add("IdCompany", "ID company");
            dgvListProduct.Columns.Add("Ram", "Ram");
            dgvListProduct.Columns.Add("IdCpu", "ID CPU");
            dgvListProduct.Columns.Add("ScreenSize", "Screen size");
            dgvListProduct.Columns.Add("ScreenResolution", "Screen resolution");
            dgvListProduct.Columns.Add("RefreshRate", "Refresh rate");
            dgvListProduct.Columns.Add("CameraResolution", "Camera resolution");
            dgvListProduct.Columns.Add("Pin", "Pin");
            dgvListProduct.Columns.Add("IdAccount", "ID account");
            dgvListProduct.Columns.Add("ProductStatus", "Product status");
            dgvListProduct.RowTemplate.Height = 100;
        }
        public string OpenFile(string fillter)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn một file";
            openFileDialog.Filter = fillter;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                MessageBox.Show($"Đường dẫn file đã chọn: {filePath}");
                return filePath;
            }
            return null;
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
        public void ShowOnDataGridView(List<Product> products)
        {
            dgvListProduct.Rows.Clear();
            if (products != null)
            {
                foreach (Product product in products)
                {
                    try
                    {
                        System.Net.WebRequest request = System.Net.WebRequest.Create(product.ProductImage);
                        System.Net.WebResponse response = request.GetResponse();
                        System.IO.Stream responseStream = response.GetResponseStream();
                        Bitmap img = new Bitmap(responseStream);
                        dgvListProduct.Rows.Add(product.Idproduct, img, product.ProductName, product.Idcompany, product.Ram, product.Idcpu, product.ScreenSize, product.ScreenResolution, product.RefreshRate, product.CameraResolution, product.Pin, product.Idaccount, product.ProductStatus);
                    }
                    catch (Exception)
                    {
                        try
                        {
                            Bitmap img = new Bitmap(product.ProductImage);
                            dgvListProduct.Rows.Add(product.Idproduct, img, product.ProductName, product.Idcompany, product.Ram, product.Idcpu, product.ScreenSize, product.ScreenResolution, product.RefreshRate, product.CameraResolution, product.Pin, product.Idaccount, product.ProductStatus);
                        }
                        catch (Exception)
                        {
                            var defaultImg = "C:\\Users\\chinh\\Downloads\\fpt.jpg";
                            Bitmap img = new Bitmap(defaultImg);
                            dgvListProduct.Rows.Add(product.Idproduct, img, product.ProductName, product.Idcompany, product.Ram, product.Idcpu, product.ScreenSize, product.ScreenResolution, product.RefreshRate, product.CameraResolution, product.Pin, product.Idaccount, product.ProductStatus);
                        }
                    }
                }
            }
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
        public string CheckIsNumberInProduct(TextBox ram, TextBox pin, TextBox refreshRate, TextBox cameraResolution, TextBox screenSize)
        {
            var check = CheckIsInt(ram, pin, refreshRate);
            var check2 = CheckIsDouble(cameraResolution, screenSize);
            if (check != null)
                return check;
            else if (check2 != null)
                return check2;
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
        public void ResetFormProduct()
        {
            ResetTexbox(txtProductID, txtProductImage, txtProductName, txtRam, txtPin, txtRefreshRate, txtScreenResolution, txtCameraResolution, txtScreenSize);
            txtIdAccount.Text = menu.IdAccountMenu;
            ResetCombobox(cbbIDCompany, cbbIDCPU);
            rdoActivated.Checked = true;
            rdoUnActivated.Checked = false;
        }
        public List<Product> SearchByName(string name)
        {
            return productBUS.GetProductByName(name);
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            txtIdAccount.Text = menu.IdAccountMenu;
            rdoActivated.Checked = true;
            LoadDataGridView();
            List<Product> products = productBUS.GetAllProduct();
            ShowOnDataGridView(products);
            string[] listSearch = ["By name", "By ID", "By id company", "By company name", "By ID account", "By ID CPU", "By CPU name"];
            cbbTimKiem.Items.AddRange(listSearch);
            List<string> listFillter = new List<string>() { "Ram", "Pin", "Refresh rate", "Screen size" };
            LoadCbbWhenDropDown(cbbFillter, listFillter);
            cbbTimKiem.SelectedIndex = 0;
            cbbFillter.SelectedIndex = 0;
        }
        private Form formNow;
        private void LoadForm(Form formnew)
        {
            if (formNow != null)
            {
                formNow.Close();
            }
            formNow = formnew;
            formnew.TopLevel = false;
            formnew.FormBorderStyle = FormBorderStyle.None;
            formnew.Dock = DockStyle.Fill;

            // Thêm form mới vào Panel (giả sử bạn có Panel tên là panelContainer)


            formnew.BringToFront();
            formnew.Show();
        }
        private Button ButtonNow;
        private void btnProductDetail_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProductID.Text))
            {
                ProductDeltailForm a = new ProductDeltailForm();
                a.Show();
            }
            else
            {
                ProductDeltailForm a = new ProductDeltailForm(txtProductID.Text);
                a.Show();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (CheckCbb(cbbIDCompany, cbbIDCPU))
            {
                var productID = txtProductID.Text;
                var productImage = txtProductImage.Text;
                var productName = txtProductName.Text;
                var idCompany = cbbIDCompany.SelectedItem.ToString();
                var ram = txtRam.Text;
                var pin = txtPin.Text;
                var refreshRate = txtRefreshRate.Text;
                var idAccount = txtIdAccount.Text;
                var idCPU = cbbIDCPU.SelectedItem.ToString();
                var screenResolution = txtScreenResolution.Text;
                var cameraResolution = txtCameraResolution.Text;
                var screenSize = txtScreenSize.Text;
                var status = rdoActivated.Checked ? true : false;

                if (CheckNull(productID, productImage, productName, idCompany, ram, pin, refreshRate, idAccount, idCPU, cameraResolution, screenResolution, screenSize) == false)
                {
                    var checkNum = CheckIsNumberInProduct(txtRam, txtPin, txtRefreshRate, txtCameraResolution, txtScreenSize);
                    if (checkNum == null)
                    {
                        if (productBUS.CheckProductIfExist(productID))
                        {
                            if (productBUS.AddNewProduct(productID, productImage, productName, idCompany, int.Parse(ram), idCPU, double.Parse(screenSize), screenResolution, int.Parse(refreshRate), double.Parse(cameraResolution), int.Parse(pin), idAccount, status))
                                MessageBox.Show("Thêm thành công");
                            else
                                MessageBox.Show("Thêm thất bại");
                        }
                        else
                            MessageBox.Show("ID product này đã tồn tại");
                    }
                    else
                        MessageBox.Show(checkNum);
                }
                else
                    MessageBox.Show("Nhập đầy đủ thông tin trước khi thêm");
            }
            else
                MessageBox.Show("Chọn lại giá trị từ các combo box");
            ShowOnDataGridView(productBUS.GetAllProduct());
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var productID = txtProductID.Text;
            var productImage = txtProductImage.Text;
            var productName = txtProductName.Text;
            var idCompany = cbbIDCompany.Text;
            var ram = txtRam.Text;
            var pin = txtPin.Text;
            var refreshRate = txtRefreshRate.Text;
            var idAccount = txtIdAccount.Text;
            var idCPU = cbbIDCPU.Text;
            var screenResolution = txtScreenResolution.Text;
            var cameraResolution = txtCameraResolution.Text;
            var screenSize = txtScreenSize.Text;
            var status = rdoActivated.Checked ? true : false;
            if (CheckNull(productID, productImage, productName, idCompany, ram, pin, refreshRate, idAccount, idCPU, cameraResolution, screenResolution, screenSize) == false)
            {
                var checkNum = CheckIsNumberInProduct(txtRam, txtPin, txtRefreshRate, txtCameraResolution, txtScreenSize);
                if (checkNum == null)
                {
                    if (productBUS.UpdateProduct(productID, productImage, productName, idCompany, int.Parse(ram), idCPU, double.Parse(screenSize), screenResolution, int.Parse(refreshRate), double.Parse(cameraResolution), int.Parse(pin), idAccount, status))
                        MessageBox.Show("Sửa thành công");
                    else
                        MessageBox.Show("Sửa thất bại");
                }
                else
                    MessageBox.Show(checkNum);
            }
            else
                MessageBox.Show("Nhập đầy đủ thông tin trước khi sửa");
            ShowOnDataGridView(productBUS.GetAllProduct());
        }

        private void cbbIDCompany_DropDown(object sender, EventArgs e)
        {
            LoadCbbWhenDropDown(cbbIDCompany, productCompanyBUS.GetAllIDCompany());
        }
        private void cbbIDCPU_DropDown(object sender, EventArgs e)
        {
            LoadCbbWhenDropDown(cbbIDCPU, cpuBUS.GetAllIDCpu());
        }

        private void dgvListProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvListProduct.RowCount - 1)
            {
                DataGridViewRow row = dgvListProduct.Rows[e.RowIndex];
                var idProduct = row.Cells[0].Value.ToString();
                var product = productBUS.GetProductByID(idProduct);
                txtProductID.Text = product.Idproduct;
                txtProductImage.Text = product.ProductImage;
                txtProductName.Text = product.ProductName;
                cbbIDCompany.Text = product.Idcompany;
                txtRam.Text = product.Ram.ToString();
                txtPin.Text = product.Pin.ToString();
                txtRefreshRate.Text = product.RefreshRate.ToString();
                txtIdAccount.Text = product.Idaccount;
                cbbIDCPU.Text = product.Idcpu;
                txtScreenSize.Text = product.ScreenSize.ToString();
                txtScreenResolution.Text = product.ScreenResolution.ToString();
                txtCameraResolution.Text = product.CameraResolution.ToString();
                if (product.ProductStatus)
                {
                    rdoActivated.Checked = true;
                    rdoUnActivated.Checked = false;
                }
                else
                {
                    rdoActivated.Checked = false;
                    rdoUnActivated.Checked = true;
                }
            }
        }

        private void vbButton2_Click(object sender, EventArgs e)
        {
            ResetFormProduct();
        }

        private void vbButton1_Click(object sender, EventArgs e)
        {
            List<Product> products = new List<Product>();
            switch (cbbTimKiem.SelectedIndex)
            {
                case 0:
                    products = productBUS.GetProductByName(txtTimKiem.Text);
                    break;
                case 1:
                    products = productBUS.SearchByID(txtTimKiem.Text);
                    break;
                case 2:
                    products = productBUS.GetProductByIDProductCompany(txtTimKiem.Text);
                    break;
                case 3:
                    products = productBUS.GetProducstByCompanyName(txtTimKiem.Text);
                    break;
                case 4:
                    products = productBUS.GetProductByIdAccount(txtTimKiem.Text);
                    break;
                case 5:
                    products = productBUS.GetProductByIdCPU(txtTimKiem.Text);
                    break;
                case 6:
                    products = productBUS.GetProductByCPUName(txtTimKiem.Text);
                    break;
                default:
                    products = productBUS.GetAllProduct();
                    break;
            }
            ShowOnDataGridView(products);
        }

        private void btnImgLink_Click(object sender, EventArgs e)
        {
            txtProductImage.Text = OpenFile("Image Files|*.jpg;*.jpeg;*.png;*.bmp");
        }

        private void cbbIDCompany_Leave(object sender, EventArgs e)
        {
            if (cbbIDCompany.SelectedIndex != -1)
            {
                var listProduct = productBUS.GetProductByIDProductCompany(cbbIDCompany.SelectedItem.ToString());
                txtProductID.Text = productCompanyBUS.GetCompanyById(cbbIDCompany.SelectedItem.ToString()).CompanyName + listProduct.Count;
                txtCompanyName.Text = productCompanyBUS.GetCompanyById(cbbIDCompany.SelectedItem.ToString()).CompanyName;
            }
        }
        private void cbbIdCpu_Leave(object sender, EventArgs e)
        {
            if (cbbIDCPU.SelectedItem != null)
            {
                var id = cbbIDCPU.SelectedItem.ToString();
                var cpu = cpuBUS.GetCpuById(id);
                if (cpu != null)
                {
                    txtManufacturer.Text = cpu.Manufacturer;
                    txtNameCpu.Text = cpu.NameCpu;
                }
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
                        var result = productBUS.FilterProduct(cbbFillter.SelectedIndex, from, to);
                        ShowOnDataGridView(result);
                    }
                    else
                        MessageBox.Show("Chọn một giá trị từ combobox filter");
                }    
                else
                    MessageBox.Show(check);
            }    
                
        }
    }
}
