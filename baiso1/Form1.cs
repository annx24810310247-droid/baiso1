using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;

namespace baiso1
{
    public partial class Form1 : Form
    {
        private BindingList<Device> _deviceList;
        private BindingSource _bindingSource;
        private int _autoIncrementId = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _deviceList = new BindingList<Device>();
            _bindingSource = new BindingSource { DataSource = _deviceList };

            cboCategory.Items.AddRange(new string[] { "Điện thoại", "Laptop", "Máy tính bảng", "Phụ kiện", "Màn hình" });

            SetupDataGridView();
            SetupDataBinding();
            AddSampleData();
        }

        #region Setup DataGridView & Data Binding

        private void SetupDataGridView()
        {
            dgvDevices.AutoGenerateColumns = false;
            dgvDevices.AllowUserToAddRows = false;
            dgvDevices.MultiSelect = false;
            dgvDevices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDevices.ReadOnly = true;

            dgvDevices.Columns.Clear();

            dgvDevices.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DeviceId",
                HeaderText = "Mã Thiết Bị",
                Width = 100
            });

            dgvDevices.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DeviceName",
                HeaderText = "Tên Thiết Bị",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvDevices.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Category",
                HeaderText = "Loại Thiết Bị",
                Width = 130
            });

            var priceCol = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Price",
                HeaderText = "Đơn Giá",
                Width = 130
            };
            priceCol.DefaultCellStyle.Format = "N0";
            priceCol.DefaultCellStyle.FormatProvider = new CultureInfo("vi-VN");
            priceCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDevices.Columns.Add(priceCol);

            var qtyCol = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Quantity",
                HeaderText = "Số Lượng Tồn",
                Width = 110
            };
            qtyCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDevices.Columns.Add(qtyCol);

            dgvDevices.DataSource = _bindingSource;
        }

        private void SetupDataBinding()
        {
            txtDeviceId.DataBindings.Add("Text", _bindingSource, "DeviceId", true, DataSourceUpdateMode.OnPropertyChanged);
            txtDeviceName.DataBindings.Add("Text", _bindingSource, "DeviceName", true, DataSourceUpdateMode.OnPropertyChanged);
            cboCategory.DataBindings.Add("SelectedItem", _bindingSource, "Category", true, DataSourceUpdateMode.OnPropertyChanged);

            Binding priceBinding = new Binding("Text", _bindingSource, "Price", true, DataSourceUpdateMode.OnPropertyChanged);
            priceBinding.Format += (s, e) => { if (e.Value != null) e.Value = Convert.ToDecimal(e.Value).ToString("G0"); };
            txtPrice.DataBindings.Add(priceBinding);

            numQuantity.DataBindings.Add("Value", _bindingSource, "Quantity", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void AddSampleData()
        {
            _deviceList.Add(new Device { DeviceId = GenerateDeviceId(), DeviceName = "iPhone 15 Pro Max", Category = "Điện thoại", Price = 29990000, Quantity = 15 });
            _deviceList.Add(new Device { DeviceId = GenerateDeviceId(), DeviceName = "MacBook Pro M3", Category = "Laptop", Price = 42500000, Quantity = 8 });
            _bindingSource.MoveFirst();
        }

        private string GenerateDeviceId()
        {
            return $"DEV{_autoIncrementId++:D3}";
        }

        #endregion

        #region Validation

        private bool ValidateInput()
        {
            bool isValid = true;
            errorProvider1.Clear();

            if (string.IsNullOrWhiteSpace(txtDeviceName.Text))
            {
                errorProvider1.SetError(txtDeviceName, "Tên thiết bị không được để trống!");
                isValid = false;
            }

            if (cboCategory.SelectedIndex == -1)
            {
                errorProvider1.SetError(cboCategory, "Vui lòng chọn loại thiết bị!");
                isValid = false;
            }

            if (!decimal.TryParse(txtPrice.Text.Trim(), out decimal price) || price < 0)
            {
                errorProvider1.SetError(txtPrice, "Đơn giá phải là số hợp lệ lớn hơn hoặc bằng 0!");
                isValid = false;
            }

            return isValid;
        }

        #endregion

        #region Button Events

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            _bindingSource.SuspendBinding();

            Device newDevice = new Device
            {
                DeviceId = GenerateDeviceId(),
                DeviceName = txtDeviceName.Text.Trim(),
                Category = cboCategory.SelectedItem.ToString(),
                Price = decimal.Parse(txtPrice.Text.Trim()),
                Quantity = (int)numQuantity.Value
            };

            _deviceList.Add(newDevice);
            _bindingSource.ResumeBinding();

            _bindingSource.MoveLast();
            MessageBox.Show("Thêm thiết bị mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_bindingSource.Current == null)
            {
                MessageBox.Show("Không có thiết bị nào để cập nhật!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInput()) return;

            _bindingSource.EndEdit();
            dgvDevices.Refresh();

            MessageBox.Show("Cập nhật thông tin thiết bị thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_bindingSource.Current is Device currentDevice)
            {
                DialogResult dialogResult = MessageBox.Show(
                    $"Bạn có chắc chắn muốn xóa thiết bị '{currentDevice.DeviceName}' (Mã: {currentDevice.DeviceId}) không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    _bindingSource.RemoveCurrent();
                    errorProvider1.Clear();
                    MessageBox.Show("Đã xóa thiết bị thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một thiết bị để xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            _bindingSource.CancelEdit();

            txtDeviceId.Clear();
            txtDeviceName.Clear();
            cboCategory.SelectedIndex = -1;
            txtPrice.Clear();
            numQuantity.Value = 0;

            txtDeviceName.Focus();
        }

        #endregion
    }
}