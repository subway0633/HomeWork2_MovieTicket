namespace MovieTicket
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbDiscountList = new System.Windows.Forms.ComboBox();
            this.btnAddList = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.RichTextBox();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblTicket = new System.Windows.Forms.Label();
            this.btnPayMoney = new System.Windows.Forms.Button();
            this.txtTicket = new System.Windows.Forms.TextBox();
            this.txtDicount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblMovieTicket = new System.Windows.Forms.Label();
            this.chb3D = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cmbDiscountList
            // 
            this.cmbDiscountList.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmbDiscountList.FormattingEnabled = true;
            this.cmbDiscountList.Items.AddRange(new object[] {
            "學生",
            "小孩",
            "VIP"});
            this.cmbDiscountList.Location = new System.Drawing.Point(36, 125);
            this.cmbDiscountList.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDiscountList.Name = "cmbDiscountList";
            this.cmbDiscountList.Size = new System.Drawing.Size(260, 29);
            this.cmbDiscountList.TabIndex = 0;
            this.cmbDiscountList.Text = "選擇折扣方式";
            this.cmbDiscountList.SelectedIndexChanged += new System.EventHandler(this.cmbDiscountList_SelectedIndexChanged);
            // 
            // btnAddList
            // 
            this.btnAddList.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddList.Location = new System.Drawing.Point(731, 210);
            this.btnAddList.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddList.Name = "btnAddList";
            this.btnAddList.Size = new System.Drawing.Size(165, 79);
            this.btnAddList.TabIndex = 4;
            this.btnAddList.Text = "加入清單";
            this.btnAddList.UseVisualStyleBackColor = true;
            this.btnAddList.Click += new System.EventHandler(this.btnAddList_Click);
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtResult.Location = new System.Drawing.Point(36, 210);
            this.txtResult.Margin = new System.Windows.Forms.Padding(4);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(670, 287);
            this.txtResult.TabIndex = 5;
            this.txtResult.Text = "";
            // 
            // txtamount
            // 
            this.txtamount.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtamount.Location = new System.Drawing.Point(799, 121);
            this.txtamount.Margin = new System.Windows.Forms.Padding(4);
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(76, 33);
            this.txtamount.TabIndex = 6;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDiscount.Location = new System.Drawing.Point(577, 86);
            this.lblDiscount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(129, 19);
            this.lblDiscount.TabIndex = 7;
            this.lblDiscount.Text = "折扣計算方式";
            // 
            // lblTicket
            // 
            this.lblTicket.AutoSize = true;
            this.lblTicket.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTicket.Location = new System.Drawing.Point(346, 86);
            this.lblTicket.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTicket.Name = "lblTicket";
            this.lblTicket.Size = new System.Drawing.Size(109, 19);
            this.lblTicket.TabIndex = 8;
            this.lblTicket.Text = "電影票種類";
            // 
            // btnPayMoney
            // 
            this.btnPayMoney.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPayMoney.Location = new System.Drawing.Point(731, 312);
            this.btnPayMoney.Margin = new System.Windows.Forms.Padding(4);
            this.btnPayMoney.Name = "btnPayMoney";
            this.btnPayMoney.Size = new System.Drawing.Size(165, 79);
            this.btnPayMoney.TabIndex = 4;
            this.btnPayMoney.Text = "結帳";
            this.btnPayMoney.UseVisualStyleBackColor = true;
            this.btnPayMoney.Click += new System.EventHandler(this.btnPayMoney_Click);
            // 
            // txtTicket
            // 
            this.txtTicket.Enabled = false;
            this.txtTicket.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtTicket.Location = new System.Drawing.Point(349, 122);
            this.txtTicket.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTicket.Name = "txtTicket";
            this.txtTicket.Size = new System.Drawing.Size(200, 33);
            this.txtTicket.TabIndex = 9;
            // 
            // txtDicount
            // 
            this.txtDicount.Enabled = false;
            this.txtDicount.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDicount.Location = new System.Drawing.Point(580, 122);
            this.txtDicount.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDicount.Name = "txtDicount";
            this.txtDicount.Size = new System.Drawing.Size(182, 33);
            this.txtDicount.TabIndex = 10;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblAmount.Location = new System.Drawing.Point(795, 86);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(49, 19);
            this.lblAmount.TabIndex = 8;
            this.lblAmount.Text = "張數";
            // 
            // lblMovieTicket
            // 
            this.lblMovieTicket.AutoSize = true;
            this.lblMovieTicket.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblMovieTicket.Location = new System.Drawing.Point(32, 86);
            this.lblMovieTicket.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMovieTicket.Name = "lblMovieTicket";
            this.lblMovieTicket.Size = new System.Drawing.Size(95, 19);
            this.lblMovieTicket.TabIndex = 8;
            this.lblMovieTicket.Text = "電影票價:";
            // 
            // chb3D
            // 
            this.chb3D.AutoSize = true;
            this.chb3D.Location = new System.Drawing.Point(41, 45);
            this.chb3D.Name = "chb3D";
            this.chb3D.Size = new System.Drawing.Size(45, 21);
            this.chb3D.TabIndex = 11;
            this.chb3D.Text = "3D";
            this.chb3D.UseVisualStyleBackColor = true;
            this.chb3D.CheckedChanged += new System.EventHandler(this.chb3D_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 531);
            this.Controls.Add(this.chb3D);
            this.Controls.Add(this.lblMovieTicket);
            this.Controls.Add(this.txtDicount);
            this.Controls.Add(this.txtTicket);
            this.Controls.Add(this.btnPayMoney);
            this.Controls.Add(this.btnAddList);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblTicket);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.txtamount);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.cmbDiscountList);
            this.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "電影訂票系統";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDiscountList;
        private System.Windows.Forms.Button btnAddList;
        private System.Windows.Forms.RichTextBox txtResult;
        private System.Windows.Forms.TextBox txtamount;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblTicket;
        private System.Windows.Forms.Button btnPayMoney;
        private System.Windows.Forms.TextBox txtTicket;
        private System.Windows.Forms.TextBox txtDicount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblMovieTicket;
        private System.Windows.Forms.CheckBox chb3D;
    }
}

