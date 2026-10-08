using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_1_Máy_tính_tính_cước_dịch_vụ___Giảm_giá
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Set default AcceptButton for Enter key
            this.AcceptButton = this.btnCalculate;
        }

        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(txtUnitPrice.Text) || string.IsNullOrWhiteSpace(txtQuantity.Text))
            {
                MessageBox.Show("Vui lòng nhập Đơn giá và Số lượng.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Parse values
            if (!decimal.TryParse(txtUnitPrice.Text.Trim(), out decimal unitPrice))
            {
                MessageBox.Show("Đơn giá phải là số hợp lệ.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUnitPrice.Focus();
                return;
            }

            if (!decimal.TryParse(txtQuantity.Text.Trim(), out decimal quantity))
            {
                MessageBox.Show("Số lượng phải là số hợp lệ.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantity.Focus();
                return;
            }

            decimal discount = 0m;
            if (!string.IsNullOrWhiteSpace(txtDiscount.Text))
            {
                if (!decimal.TryParse(txtDiscount.Text.Trim(), out discount))
                {
                    MessageBox.Show("Mã giảm giá phải là số (%).", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDiscount.Focus();
                    return;
                }
            }

            // Constrain discount between 0 and 100
            if (discount < 0m) discount = 0m;
            if (discount > 100m) discount = 100m;

            // Calculation: (Đơn giá × Số lượng) × (100 - %Giảm) / 100
            decimal total = (unitPrice * quantity) * (100m - discount) / 100m;

            lblTotal.Text = total.ToString("C2");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUnitPrice.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            txtDiscount.Text = string.Empty;
            lblTotal.Text = "0";
            txtUnitPrice.Focus();
        }
    }
}
