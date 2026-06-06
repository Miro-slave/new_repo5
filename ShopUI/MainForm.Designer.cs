namespace ShopUI
{
    partial class MainForm
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
            this.gbProducts = new System.Windows.Forms.GroupBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.gbServices = new System.Windows.Forms.GroupBox();
            this.dgvServices = new System.Windows.Forms.DataGridView();
            this.gbCart = new System.Windows.Forms.GroupBox();
            this.lblCartTotalValue = new System.Windows.Forms.Label();
            this.lblCartTotal = new System.Windows.Forms.Label();
            this.lstCart = new System.Windows.Forms.ListBox();
            this.gbControls = new System.Windows.Forms.GroupBox();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnWeigh = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbItems = new System.Windows.Forms.ComboBox();
            this.lblSelectItem = new System.Windows.Forms.Label();
            this.gbCustomerInfo = new System.Windows.Forms.GroupBox();
            this.lblBonusesValue = new System.Windows.Forms.Label();
            this.lblCardValue = new System.Windows.Forms.Label();
            this.lblCashValue = new System.Windows.Forms.Label();
            this.lblNameValue = new System.Windows.Forms.Label();
            this.lblBonuses = new System.Windows.Forms.Label();
            this.lblCard = new System.Windows.Forms.Label();
            this.lblCash = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.gbLog = new System.Windows.Forms.GroupBox();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.gbServices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).BeginInit();
            this.gbCart.SuspendLayout();
            this.gbControls.SuspendLayout();
            this.gbCustomerInfo.SuspendLayout();
            this.gbLog.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbProducts
            // 
            this.gbProducts.Controls.Add(this.dgvProducts);
            this.gbProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbProducts.Location = new System.Drawing.Point(14, 15);
            this.gbProducts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbProducts.Name = "gbProducts";
            this.gbProducts.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbProducts.Size = new System.Drawing.Size(506, 312);
            this.gbProducts.TabIndex = 0;
            this.gbProducts.TabStop = false;
            this.gbProducts.Text = "Товары";
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProducts.Location = new System.Drawing.Point(3, 27);
            this.dgvProducts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.RowHeadersWidth = 62;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(500, 281);
            this.dgvProducts.TabIndex = 0;
            // 
            // gbServices
            // 
            this.gbServices.Controls.Add(this.dgvServices);
            this.gbServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbServices.Location = new System.Drawing.Point(14, 335);
            this.gbServices.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbServices.Name = "gbServices";
            this.gbServices.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbServices.Size = new System.Drawing.Size(506, 250);
            this.gbServices.TabIndex = 1;
            this.gbServices.TabStop = false;
            this.gbServices.Text = "Услуги";
            // 
            // dgvServices
            // 
            this.dgvServices.AllowUserToAddRows = false;
            this.dgvServices.AllowUserToDeleteRows = false;
            this.dgvServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvServices.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvServices.Location = new System.Drawing.Point(3, 27);
            this.dgvServices.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvServices.MultiSelect = false;
            this.dgvServices.Name = "dgvServices";
            this.dgvServices.ReadOnly = true;
            this.dgvServices.RowHeadersVisible = false;
            this.dgvServices.RowHeadersWidth = 62;
            this.dgvServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServices.Size = new System.Drawing.Size(500, 219);
            this.dgvServices.TabIndex = 1;
            // 
            // gbCart
            // 
            this.gbCart.Controls.Add(this.lblCartTotalValue);
            this.gbCart.Controls.Add(this.lblCartTotal);
            this.gbCart.Controls.Add(this.lstCart);
            this.gbCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbCart.Location = new System.Drawing.Point(538, 15);
            this.gbCart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbCart.Name = "gbCart";
            this.gbCart.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbCart.Size = new System.Drawing.Size(394, 570);
            this.gbCart.TabIndex = 2;
            this.gbCart.TabStop = false;
            this.gbCart.Text = "Корзина";
            this.gbCart.Enter += new System.EventHandler(this.gbCart_Enter);
            // 
            // lblCartTotalValue
            // 
            this.lblCartTotalValue.AutoSize = true;
            this.lblCartTotalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCartTotalValue.ForeColor = System.Drawing.Color.Green;
            this.lblCartTotalValue.Location = new System.Drawing.Point(136, 531);
            this.lblCartTotalValue.Name = "lblCartTotalValue";
            this.lblCartTotalValue.Size = new System.Drawing.Size(48, 29);
            this.lblCartTotalValue.TabIndex = 2;
            this.lblCartTotalValue.Text = "0 ₽";
            // 
            // lblCartTotal
            // 
            this.lblCartTotal.AutoSize = true;
            this.lblCartTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCartTotal.Location = new System.Drawing.Point(30, 531);
            this.lblCartTotal.Name = "lblCartTotal";
            this.lblCartTotal.Size = new System.Drawing.Size(101, 29);
            this.lblCartTotal.TabIndex = 1;
            this.lblCartTotal.Text = "Итого: ";
            // 
            // lstCart
            // 
            this.lstCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstCart.FormattingEnabled = true;
            this.lstCart.ItemHeight = 22;
            this.lstCart.Location = new System.Drawing.Point(7, 31);
            this.lstCart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstCart.Name = "lstCart";
            this.lstCart.Size = new System.Drawing.Size(380, 466);
            this.lstCart.TabIndex = 0;
            // 
            // gbControls
            // 
            this.gbControls.Controls.Add(this.btnCheckout);
            this.gbControls.Controls.Add(this.btnWeigh);
            this.gbControls.Controls.Add(this.btnRemove);
            this.gbControls.Controls.Add(this.btnAdd);
            this.gbControls.Controls.Add(this.cmbItems);
            this.gbControls.Controls.Add(this.lblSelectItem);
            this.gbControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbControls.Location = new System.Drawing.Point(938, 15);
            this.gbControls.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbControls.Name = "gbControls";
            this.gbControls.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbControls.Size = new System.Drawing.Size(360, 570);
            this.gbControls.TabIndex = 3;
            this.gbControls.TabStop = false;
            this.gbControls.Text = "Управление";
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.Color.Green;
            this.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCheckout.ForeColor = System.Drawing.Color.White;
            this.btnCheckout.Location = new System.Drawing.Point(34, 475);
            this.btnCheckout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(292, 62);
            this.btnCheckout.TabIndex = 5;
            this.btnCheckout.Text = "ОПЛАТИТЬ";
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnWeigh
            // 
            this.btnWeigh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnWeigh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWeigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnWeigh.ForeColor = System.Drawing.Color.White;
            this.btnWeigh.Location = new System.Drawing.Point(34, 350);
            this.btnWeigh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnWeigh.Name = "btnWeigh";
            this.btnWeigh.Size = new System.Drawing.Size(292, 50);
            this.btnWeigh.TabIndex = 4;
            this.btnWeigh.Text = "ВЗВЕСИТЬ ТОВАР";
            this.btnWeigh.UseVisualStyleBackColor = false;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Red;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(34, 275);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(292, 50);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "УДАЛИТЬ ИЗ КОРЗИНЫ";
            this.btnRemove.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(34, 200);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(292, 50);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "ДОБАВИТЬ В КОРЗИНУ";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // cmbItems
            // 
            this.cmbItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbItems.FormattingEnabled = true;
            this.cmbItems.Location = new System.Drawing.Point(34, 100);
            this.cmbItems.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbItems.Name = "cmbItems";
            this.cmbItems.Size = new System.Drawing.Size(292, 33);
            this.cmbItems.TabIndex = 1;
            // 
            // lblSelectItem
            // 
            this.lblSelectItem.AutoSize = true;
            this.lblSelectItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSelectItem.Location = new System.Drawing.Point(29, 69);
            this.lblSelectItem.Name = "lblSelectItem";
            this.lblSelectItem.Size = new System.Drawing.Size(271, 25);
            this.lblSelectItem.TabIndex = 0;
            this.lblSelectItem.Text = "Выберите товар или услугу:";
            // 
            // gbCustomerInfo
            // 
            this.gbCustomerInfo.Controls.Add(this.lblBonusesValue);
            this.gbCustomerInfo.Controls.Add(this.lblCardValue);
            this.gbCustomerInfo.Controls.Add(this.lblCashValue);
            this.gbCustomerInfo.Controls.Add(this.lblNameValue);
            this.gbCustomerInfo.Controls.Add(this.lblBonuses);
            this.gbCustomerInfo.Controls.Add(this.lblCard);
            this.gbCustomerInfo.Controls.Add(this.lblCash);
            this.gbCustomerInfo.Controls.Add(this.lblName);
            this.gbCustomerInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbCustomerInfo.Location = new System.Drawing.Point(14, 592);
            this.gbCustomerInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbCustomerInfo.Name = "gbCustomerInfo";
            this.gbCustomerInfo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbCustomerInfo.Size = new System.Drawing.Size(1285, 125);
            this.gbCustomerInfo.TabIndex = 4;
            this.gbCustomerInfo.TabStop = false;
            this.gbCustomerInfo.Text = "Информация о покупателе";
            this.gbCustomerInfo.Enter += new System.EventHandler(this.gbCustomerInfo_Enter);
            // 
            // lblBonusesValue
            // 
            this.lblBonusesValue.AutoSize = true;
            this.lblBonusesValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBonusesValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblBonusesValue.Location = new System.Drawing.Point(925, 62);
            this.lblBonusesValue.Name = "lblBonusesValue";
            this.lblBonusesValue.Size = new System.Drawing.Size(61, 25);
            this.lblBonusesValue.TabIndex = 7;
            this.lblBonusesValue.Text = "500 б";
            // 
            // lblCardValue
            // 
            this.lblCardValue.AutoSize = true;
            this.lblCardValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCardValue.ForeColor = System.Drawing.Color.Blue;
            this.lblCardValue.Location = new System.Drawing.Point(925, 25);
            this.lblCardValue.Name = "lblCardValue";
            this.lblCardValue.Size = new System.Drawing.Size(83, 25);
            this.lblCardValue.TabIndex = 6;
            this.lblCardValue.Text = "10000 ₽";
            // 
            // lblCashValue
            // 
            this.lblCashValue.AutoSize = true;
            this.lblCashValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCashValue.ForeColor = System.Drawing.Color.Green;
            this.lblCashValue.Location = new System.Drawing.Point(428, 62);
            this.lblCashValue.Name = "lblCashValue";
            this.lblCashValue.Size = new System.Drawing.Size(72, 25);
            this.lblCashValue.TabIndex = 5;
            this.lblCashValue.Text = "5000 ₽";
            // 
            // lblNameValue
            // 
            this.lblNameValue.AutoSize = true;
            this.lblNameValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNameValue.Location = new System.Drawing.Point(428, 25);
            this.lblNameValue.Name = "lblNameValue";
            this.lblNameValue.Size = new System.Drawing.Size(131, 25);
            this.lblNameValue.TabIndex = 4;
            this.lblNameValue.Text = "Иван Петров";
            // 
            // lblBonuses
            // 
            this.lblBonuses.AutoSize = true;
            this.lblBonuses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBonuses.Location = new System.Drawing.Point(810, 62);
            this.lblBonuses.Name = "lblBonuses";
            this.lblBonuses.Size = new System.Drawing.Size(92, 25);
            this.lblBonuses.TabIndex = 3;
            this.lblBonuses.Text = "Бонусы:";
            // 
            // lblCard
            // 
            this.lblCard.AutoSize = true;
            this.lblCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCard.Location = new System.Drawing.Point(810, 25);
            this.lblCard.Name = "lblCard";
            this.lblCard.Size = new System.Drawing.Size(79, 25);
            this.lblCard.TabIndex = 2;
            this.lblCard.Text = "Карта:";
            // 
            // lblCash
            // 
            this.lblCash.AutoSize = true;
            this.lblCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCash.Location = new System.Drawing.Point(304, 62);
            this.lblCash.Name = "lblCash";
            this.lblCash.Size = new System.Drawing.Size(120, 25);
            this.lblCash.TabIndex = 1;
            this.lblCash.Text = "Наличные:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.Location = new System.Drawing.Point(304, 25);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(70, 25);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "ФИО:";
            // 
            // gbLog
            // 
            this.gbLog.Controls.Add(this.txtLog);
            this.gbLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbLog.Location = new System.Drawing.Point(14, 725);
            this.gbLog.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbLog.Name = "gbLog";
            this.gbLog.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbLog.Size = new System.Drawing.Size(1285, 188);
            this.gbLog.TabIndex = 5;
            this.gbLog.TabStop = false;
            this.gbLog.Text = "Лог событий";
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLog.ForeColor = System.Drawing.Color.LightGreen;
            this.txtLog.Location = new System.Drawing.Point(3, 27);
            this.txtLog.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(1279, 157);
            this.txtLog.TabIndex = 0;
            this.txtLog.Text = "";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 921);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1312, 35);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslStatus
            // 
            this.tsslStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsslStatus.Name = "tsslStatus";
            this.tsslStatus.Size = new System.Drawing.Size(304, 28);
            this.tsslStatus.Text = "Готов к работе. Выберите товар";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 956);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.gbLog);
            this.Controls.Add(this.gbCustomerInfo);
            this.Controls.Add(this.gbControls);
            this.Controls.Add(this.gbCart);
            this.Controls.Add(this.gbServices);
            this.Controls.Add(this.gbProducts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Магазин - Система покупок с бонусной программой";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gbProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.gbServices.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).EndInit();
            this.gbCart.ResumeLayout(false);
            this.gbCart.PerformLayout();
            this.gbControls.ResumeLayout(false);
            this.gbControls.PerformLayout();
            this.gbCustomerInfo.ResumeLayout(false);
            this.gbCustomerInfo.PerformLayout();
            this.gbLog.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbProducts;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.GroupBox gbServices;
        private System.Windows.Forms.DataGridView dgvServices;
        private System.Windows.Forms.GroupBox gbCart;
        private System.Windows.Forms.ListBox lstCart;
        private System.Windows.Forms.Label lblCartTotalValue;
        private System.Windows.Forms.Label lblCartTotal;
        private System.Windows.Forms.GroupBox gbControls;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnWeigh;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbItems;
        private System.Windows.Forms.Label lblSelectItem;
        private System.Windows.Forms.GroupBox gbCustomerInfo;
        private System.Windows.Forms.Label lblBonuses;
        private System.Windows.Forms.Label lblCard;
        private System.Windows.Forms.Label lblCash;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblBonusesValue;
        private System.Windows.Forms.Label lblCardValue;
        private System.Windows.Forms.Label lblCashValue;
        private System.Windows.Forms.Label lblNameValue;
        private System.Windows.Forms.GroupBox gbLog;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslStatus;
    }
}
