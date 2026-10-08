namespace Bài_1_Máy_tính_tính_cước_dịch_vụ___Giảm_giá
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 260);
            this.Text = "Service Charge Calculator";

            // Labels
            var lblUnitPrice = new System.Windows.Forms.Label();
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.Location = new System.Drawing.Point(20, 20);
            lblUnitPrice.Text = "Đơn giá dịch vụ:";

            var lblQuantity = new System.Windows.Forms.Label();
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new System.Drawing.Point(20, 60);
            lblQuantity.Text = "Số lượng khách:";

            var lblDiscount = new System.Windows.Forms.Label();
            lblDiscount.AutoSize = true;
            lblDiscount.Location = new System.Drawing.Point(20, 100);
            lblDiscount.Text = "Mã giảm giá (%):";

            var lblTotalText = new System.Windows.Forms.Label();
            lblTotalText.AutoSize = true;
            lblTotalText.Location = new System.Drawing.Point(20, 140);
            lblTotalText.Text = "Tổng tiền thanh toán:";

            // TextBoxes
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtUnitPrice.Location = new System.Drawing.Point(150, 17);
            this.txtUnitPrice.Width = 220;
            this.txtUnitPrice.TabIndex = 0;

            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtQuantity.Location = new System.Drawing.Point(150, 57);
            this.txtQuantity.Width = 220;
            this.txtQuantity.TabIndex = 1;

            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtDiscount.Location = new System.Drawing.Point(150, 97);
            this.txtDiscount.Width = 220;
            this.txtDiscount.TabIndex = 2;

            // Total label
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(150, 140);
            this.lblTotal.Width = 220;
            this.lblTotal.Text = "0";
            this.lblTotal.TabIndex = 5;

            // Buttons
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnCalculate.Location = new System.Drawing.Point(150, 180);
            this.btnCalculate.Size = new System.Drawing.Size(100, 30);
            this.btnCalculate.Text = "Tính tiền";
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);

            this.btnReset = new System.Windows.Forms.Button();
            this.btnReset.Location = new System.Drawing.Point(270, 180);
            this.btnReset.Size = new System.Drawing.Size(100, 30);
            this.btnReset.Text = "Làm mới";
            this.btnReset.TabIndex = 4;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);

            // Add controls to form
            this.Controls.Add(lblUnitPrice);
            this.Controls.Add(lblQuantity);
            this.Controls.Add(lblDiscount);
            this.Controls.Add(lblTotalText);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnReset);
        }

        #endregion
    }
}

