namespace baiso1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.lblDeviceId = new System.Windows.Forms.Label();
            this.txtDeviceId = new System.Windows.Forms.TextBox();
            this.lblDeviceName = new System.Windows.Forms.Label();
            this.txtDeviceName = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvDevices = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);

            this.grpInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();

            // grpInput
            this.grpInput.Controls.Add(this.lblDeviceId);
            this.grpInput.Controls.Add(this.txtDeviceId);
            this.grpInput.Controls.Add(this.lblDeviceName);
            this.grpInput.Controls.Add(this.txtDeviceName);
            this.grpInput.Controls.Add(this.lblCategory);
            this.grpInput.Controls.Add(this.cboCategory);
            this.grpInput.Controls.Add(this.lblPrice);
            this.grpInput.Controls.Add(this.txtPrice);
            this.grpInput.Controls.Add(this.lblQuantity);
            this.grpInput.Controls.Add(this.numQuantity);
            this.grpInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpInput.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInput.Location = new System.Drawing.Point(10, 10);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(764, 190);
            this.grpInput.TabIndex = 0;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "THÔNG TIN THIẾT BỊ";

            // lblDeviceId
            this.lblDeviceId.AutoSize = true;
            this.lblDeviceId.Location = new System.Drawing.Point(30, 35);
            this.lblDeviceId.Text = "Mã thiết bị:";

            // txtDeviceId
            this.txtDeviceId.Location = new System.Drawing.Point(140, 32);
            this.txtDeviceId.Name = "txtDeviceId";
            this.txtDeviceId.ReadOnly = true;
            this.txtDeviceId.Size = new System.Drawing.Size(200, 25);

            // lblDeviceName
            this.lblDeviceName.AutoSize = true;
            this.lblDeviceName.Location = new System.Drawing.Point(30, 70);
            this.lblDeviceName.Text = "Tên thiết bị:";

            // txtDeviceName
            this.txtDeviceName.Location = new System.Drawing.Point(140, 67);
            this.txtDeviceName.Name = "txtDeviceName";
            this.txtDeviceName.Size = new System.Drawing.Size(580, 25);

            // lblCategory
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(30, 105);
            this.lblCategory.Text = "Loại thiết bị:";

            // cboCategory
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(140, 102);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(200, 25);

            // lblPrice
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(30, 140);
            this.lblPrice.Text = "Đơn giá (VNĐ):";

            // txtPrice
            this.txtPrice.Location = new System.Drawing.Point(140, 137);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(200, 25);

            // lblQuantity
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(400, 140);
            this.lblQuantity.Text = "Số lượng tồn:";

            // numQuantity
            this.numQuantity.Location = new System.Drawing.Point(520, 137);
            this.numQuantity.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(200, 25);

            // pnlButtons
            this.pnlButtons.Controls.Add(this.btnAdd);
            this.pnlButtons.Controls.Add(this.btnUpdate);
            this.pnlButtons.Controls.Add(this.btnDelete);
            this.pnlButtons.Controls.Add(this.btnClear);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlButtons.Location = new System.Drawing.Point(10, 200);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(764, 50);
            this.pnlButtons.TabIndex = 1;

            // btnAdd
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Location = new System.Drawing.Point(30, 8);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 35);
            this.btnAdd.Text = "+ Thêm mới";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // btnUpdate
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.Location = new System.Drawing.Point(170, 8);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 35);
            this.btnUpdate.Text = "* Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            // btnDelete
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Location = new System.Drawing.Point(310, 8);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 35);
            this.btnDelete.Text = "x Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // btnClear
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular);
            this.btnClear.Location = new System.Drawing.Point(450, 8);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(140, 35);
            this.btnClear.Text = "o Làm mới / Hủy";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // dgvDevices
            this.dgvDevices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDevices.Location = new System.Drawing.Point(10, 250);
            this.dgvDevices.Name = "dgvDevices";
            this.dgvDevices.Size = new System.Drawing.Size(764, 301);
            this.dgvDevices.TabIndex = 2;

            // errorProvider1
            this.errorProvider1.ContainerControl = this;

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.dgvDevices);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.grpInput);
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ DANH MỤC THIẾT BỊ ĐIỆN TỬ";
            this.Load += new System.EventHandler(this.Form1_Load);

            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.pnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.Label lblDeviceId;
        private System.Windows.Forms.TextBox txtDeviceId;
        private System.Windows.Forms.Label lblDeviceName;
        private System.Windows.Forms.TextBox txtDeviceName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.NumericUpDown numQuantity;

        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;

        private System.Windows.Forms.DataGridView dgvDevices;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}