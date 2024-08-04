using BUS.Services;
using DAL.Models;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAn1
{
    public partial class ProductDeltailForm : Form
    {
        ProductDetailBUS productDetailBUS = new ProductDetailBUS();
        ProductBUS productBUS = new ProductBUS();
        CpuBUS cpuBUS = new CpuBUS();
        ProductColorBUS colorBUS = new ProductColorBUS();
        PromotionBUS promotionBUS = new PromotionBUS();
        AccountBUS accountBUS = new AccountBUS();
        FormMenu menu = new FormMenu();
        string idProduct;
        public ProductDeltailForm()
        {
            InitializeComponent();
        }
        public ProductDeltailForm(string currentIdProduct)
        {
            this.idProduct = currentIdProduct;
            InitializeComponent();
        }
        public void ChangeIdProductDetail()
        {
            string idProduct = cbbIdProduct.Text;
            string colorName = "";
            string storage;
            if (cbbIdColor.SelectedIndex != -1)
                colorName = txtColorName.Text;
            storage = txtStorage.Text;
            txtIdProductDetail.Text = idProduct + "-" + colorName + "-" + storage;
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
        public void ResetProductDetailForm()
        {
            ResetTexbox(txtIdProductDetail, txtColorName, txtStorage, txtPrice, txtWarrantyPeriod, txtInventory, txtPromotionName, txtDiscount);
            ResetCombobox(cbbIdProduct, cbbIdColor, cbbIdPromotion);
            txtIdAccount.Text = menu.IdAccountMenu;
        }
        public bool CheckCbb(params ComboBox[] cbbs)
        {
            foreach (ComboBox cbb in cbbs)
            {
                if (cbb.SelectedIndex == -1)
                {
                    return false;
                }
            }
            return true;
        }
        public void LoadDataGridView()
        {
            dgvProductDetail.Columns.Add("IDproduct", "ID product");
            dgvProductDetail.Columns.Add("IdproductDetails", "Id productDetails");
            dgvProductDetail.Columns.Add("Idcolor", "Id color");
            dgvProductDetail.Columns.Add("Storage", "Storage");
            dgvProductDetail.Columns.Add("Price", "Price");
            dgvProductDetail.Columns.Add("Idpromotion", "Id promotion");
            dgvProductDetail.Columns.Add("WarrantyPeriod", "Warranty period");
            dgvProductDetail.Columns.Add("Inventory", "Inventory");
            dgvProductDetail.Columns.Add("Idaccount", "Idaccount");
        }
        public void ShowOnDataGridView(List<ProductDetail> productDetails)
        {
            dgvProductDetail.Rows.Clear();
            if(productDetails!=null)
            {
                foreach (ProductDetail productDetail in productDetails)
                {
                    dgvProductDetail.Rows.Add(productDetail.Idproduct, productDetail.IdproductDetails, productDetail.Idcolor, productDetail.Storage, productDetail.Price, productDetail.Idpromotion, productDetail.WarrantyPeriod, productDetail.Inventory, productDetail.Idaccount);
                }
            }    
        }
        public bool CheckProductDetailIfExists(string idProductDetail)
        {
            if (productDetailBUS.GetProductDetailByID(idProductDetail) != null)
                return true;
            return false;
        }
        public bool CheckNull(params string[] strings)
        {
            foreach (string s in strings)
            {
                if (string.IsNullOrEmpty(s))
                    return true;
            }
            return false;
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
        public string CheckIsNumberProductDetail(TextBox storage, TextBox price, TextBox warrantyPeriod, TextBox inventory)
        {
            var check = CheckIsInt(storage, warrantyPeriod, inventory);
            var check2 = CheckIsDouble(price);
            if (check != null)
                return check;
            if (check2 != null) return check2;
            return null;
        }
        public void LoadCbbWhenDropDown(ComboBox currentCbb, List<string> originList)
        {
            currentCbb.Items.Clear();
            var text = currentCbb.Text;
            foreach (var item in originList.Where(c => c.Contains(text)))
            {
                currentCbb.Items.Add(item);
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (CheckCbb(cbbIdProduct, cbbIdColor))
            {
                var idProduct = cbbIdProduct.SelectedItem.ToString();
                var idProductDetail = txtIdProductDetail.Text;
                var idColor = cbbIdColor.SelectedItem.ToString();
                var storage = txtStorage.Text;
                var price = txtPrice.Text;
                string idPromotion;
                if (cbbIdPromotion.SelectedIndex == -1)
                    idPromotion = null;
                else
                    idPromotion = cbbIdPromotion.SelectedItem.ToString();
                var warrantyPeriod = txtWarrantyPeriod.Text;
                var inventory = txtInventory.Text;
                var idAccount = txtIdAccount.Text;
                if (!CheckNull(idProduct, idProductDetail, idColor, storage, price, warrantyPeriod, inventory, idAccount))
                {
                    if (CheckProductDetailIfExists(cbbIdProduct.SelectedItem.ToString()) == false)
                    {
                        var check = CheckIsNumberProductDetail(txtStorage, txtPrice, txtWarrantyPeriod, txtInventory);
                        if (check == null)
                        {
                            if (productDetailBUS.AddNewProductDetail(idProduct, idProductDetail, idColor, int.Parse(storage), decimal.Parse(price), idPromotion, int.Parse(warrantyPeriod), int.Parse(inventory), idAccount))
                            {
                                var productDetail = productDetailBUS.GetProductDetailByID(txtIdProductDetail.Text);
                                if (productDetail != null)
                                {
                                    FormImei formImei = new FormImei(productDetail, menu.IdAccountMenu);
                                    formImei.ShowDialog();
                                    if (formImei.Comfirm)
                                    {
                                        MessageBox.Show("Thêm thành công");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Sản phẩm này chưa có Imei nào");
                                    }
                                }
                                else
                                    MessageBox.Show("Không có id product detail này");
                            }
                            else
                                MessageBox.Show("Thêm thất bại");
                        }
                        else
                            MessageBox.Show(check);
                    }
                    else
                        MessageBox.Show("Product detail này đã tồn tại");
                }
                else
                    MessageBox.Show("Nhập đầy đủ thông tin trước khi thêm");
            }
            else
                MessageBox.Show("Chọn lại giá trị từ các combo box");
            ShowOnDataGridView(productDetailBUS.GetAllProductDetail());
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            var idProduct = cbbIdProduct.Text;
            var idProductDetail = txtIdProductDetail.Text;
            var idColor = cbbIdColor.Text;
            var storage = txtStorage.Text;
            var price = txtPrice.Text;
            string idPromotion;
            if (cbbIdPromotion.SelectedIndex == -1)
                idPromotion = null;
            else
                idPromotion = cbbIdPromotion.SelectedItem.ToString();
            var warrantyPeriod = txtWarrantyPeriod.Text;
            var inventory = txtInventory.Text;
            var idAccount = txtIdAccount.Text;
            if (!CheckNull(idProduct, idProductDetail, idColor, storage, price, warrantyPeriod, inventory, idAccount))
            {
                if (CheckProductDetailIfExists(cbbIdProduct.Text) == false)
                {
                    var check = CheckIsNumberProductDetail(txtStorage, txtPrice, txtWarrantyPeriod, txtInventory);
                    if (check == null)
                    {
                        var productDetail = productDetailBUS.GetProductDetailByID(txtIdProductDetail.Text);
                        if (productDetail != null)
                        {
                            FormImei formImei = new FormImei(productDetail, menu.IdAccountMenu);
                            formImei.ShowDialog();
                            if (formImei.Comfirm)
                            {
                                if (productDetailBUS.UpdateProductDetail(idProduct, idProductDetail, idColor, int.Parse(storage), decimal.Parse(price), idPromotion, int.Parse(warrantyPeriod), int.Parse(inventory), idAccount))
                                    MessageBox.Show("Sửa thành công");
                                else
                                    MessageBox.Show("Sửa thất bại");
                            }
                            else
                                MessageBox.Show("Chưa xác nhận imei");
                        }
                        else
                            MessageBox.Show("Không có ID product detail này");
                    }
                    else
                        MessageBox.Show(check);
                }
                else
                    MessageBox.Show("Product detail này đã tồn tại");
            }
            else
                MessageBox.Show("Nhập đầy đủ thông tin trước khi sửa");
            ShowOnDataGridView(productDetailBUS.GetAllProductDetail());
        }

        private void cbbIdProduct_DropDown(object sender, EventArgs e)
        {
            LoadCbbWhenDropDown(cbbIdProduct, productBUS.GetAllIDProduct());
        }
        private void cbbIdColor_DropDown(object sender, EventArgs e)
        {
            LoadCbbWhenDropDown(cbbIdColor, colorBUS.GetAllIdColor());
        }

        private void cbbIdPromotion_DropDown(object sender, EventArgs e)
        {
            LoadCbbWhenDropDown(cbbIdPromotion, promotionBUS.GetAllIdPromotion());
        }
        private void ProductDeltailForm_Load(object sender, EventArgs e)
        {
            txtIdAccount.Text = menu.IdAccountMenu;
            cbbIdProduct.Text = idProduct;
            LoadDataGridView();
            ShowOnDataGridView(productDetailBUS.GetAllProductDetail());
            List<string> listSearch = new List<string>() { "By id productdetail", "By id product", "By ID account", "By id color", "By color name", "By id promotion" };
            LoadCbbWhenDropDown(cbbTimKiem, listSearch);
            List<string> listFillter = new List<string>() { "Storage", "Price", "Warranty period", "Inventory" };
            LoadCbbWhenDropDown(cbbFillter, listFillter);
        }

        private void vbButton1_Click(object sender, EventArgs e)
        {
            List<ProductDetail> productDetails = new List<ProductDetail>();
            productDetails = productDetailBUS.Search(cbbTimKiem.SelectedIndex, txtTimKiem.Text);
        }
        private void cbbIdColor_Leave(object sender, EventArgs e)
        {
            if (cbbIdColor.SelectedItem != null)
            {
                ChangeIdProductDetail();
                var color = colorBUS.GetProductColorById(cbbIdColor.SelectedItem.ToString());
                if (color != null)
                {
                    txtColorName.Text = color.ColorName;
                }
            }
        }

        private void cbbIdPromotion_Leave(object sender, EventArgs e)
        {
            if (cbbIdPromotion.SelectedItem != null)
            {
                var promotion = promotionBUS.GetPromotionById(cbbIdPromotion.SelectedItem.ToString());
                if (promotion != null)
                {
                    txtPromotionName.Text = promotion.PromotionName;
                    txtDiscount.Text = promotion.Discount.ToString();
                    dtpStartDate.Value = promotion.StartTime;
                    if (promotion.EndTime == null)
                        dtpEndDate.Visible = false;
                    else
                        dtpEndDate.Value = (DateTime)promotion.EndTime;
                }
            }
        }

        private void dgvProductDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvProductDetail.RowCount - 1)
            {
                DataGridViewRow row = dgvProductDetail.Rows[e.RowIndex];
                var currentProductDetail = productDetailBUS.GetProductDetailByID(row.Cells[1].Value.ToString());
                cbbIdProduct.Text = currentProductDetail.Idproduct;
                txtIdProductDetail.Text = currentProductDetail.IdproductDetails;
                cbbIdColor.Text = currentProductDetail.Idcolor;
                txtColorName.Text = colorBUS.GetProductColorById(currentProductDetail.Idcolor).ColorName;
                txtStorage.Text = currentProductDetail.Storage.ToString();
                txtPrice.Text = currentProductDetail.Price.ToString();
                txtWarrantyPeriod.Text = currentProductDetail.WarrantyPeriod.ToString();
                txtInventory.Text = currentProductDetail.Inventory.ToString();
                txtIdAccount.Text = currentProductDetail.Idaccount;
                cbbIdPromotion.Text = currentProductDetail.Idpromotion;
                if (currentProductDetail.Idpromotion != null)
                {
                    txtPromotionName.Text = promotionBUS.GetPromotionById(currentProductDetail.Idpromotion).PromotionName;
                    txtDiscount.Text = promotionBUS.GetPromotionById(currentProductDetail.Idpromotion).Discount.ToString();
                    dtpStartDate.Value = promotionBUS.GetPromotionById(currentProductDetail.Idpromotion).StartTime;
                    var endTime = promotionBUS.GetPromotionById(currentProductDetail.Idpromotion).EndTime;
                    dtpEndDate.Value = endTime != null ? (DateTime)endTime : new DateTime(9999, 12, 31);
                }
                else
                {
                    txtPromotionName.Clear();
                    txtDiscount.Clear();
                }

            }
        }
        private void txtStorage_Leave(object sender, EventArgs e)
        {
            ChangeIdProductDetail();
        }

        private void cbbIdProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeIdProductDetail();
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
                        var result = productDetailBUS.Filter(cbbFillter.SelectedIndex, from, to);
                        ShowOnDataGridView(result);
                    }
                    else
                        MessageBox.Show("Chọn một giá trị từ combobox filter");
                }
                else
                    MessageBox.Show(check);
            }
        }

        private void vbButton2_Click(object sender, EventArgs e)
        {
            ResetProductDetailForm();
        }
    }
}
