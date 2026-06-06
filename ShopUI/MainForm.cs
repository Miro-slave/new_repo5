using ShopUI.Models.Entities;
using ShopUI.Presenters;
using ShopUI.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopUI
{
    public partial class MainForm : Form, IShopView
    {
        public event Action OnAddToCart;
        public event Action OnRemoveFromCart;
        public event Action OnWeighItem;
        public event Action OnCheckout;
        public event Action<decimal, string> OnPayment;
        public event Action OnClearFilters;

        private ShopPresenter _presenter;
        private List<IPurchasable> _availableItems;

        public MainForm()
        {
            InitializeComponent();

            // Подписка на события
            btnAdd.Click += (s, e) => OnAddToCart?.Invoke();
            btnRemove.Click += (s, e) => OnRemoveFromCart?.Invoke();
            btnWeigh.Click += (s, e) => OnWeighItem?.Invoke();
            btnCheckout.Click += (s, e) => OnCheckout?.Invoke();

            _presenter = new ShopPresenter(this);
            _availableItems = new List<IPurchasable>();
            _presenter.Start();
        }

        #region Реализация IShopView

        public void DisplayProducts(List<Product> products)
        {
            dgvProducts.DataSource = null;
            dgvProducts.DataSource = products;

            // Настройка отображения таблицы товаров
            if (dgvProducts.Columns.Count > 0)
            {
                dgvProducts.Columns["Id"].HeaderText = "Артикул";
                dgvProducts.Columns["Name"].HeaderText = "Наименование";
                dgvProducts.Columns["Price"].HeaderText = "Цена";
                dgvProducts.Columns["Stock"].HeaderText = "Остаток";
                dgvProducts.Columns["RequiresWeighing"].HeaderText = "Весовой";
                dgvProducts.Columns["RequiresWeighing"].Visible = false;
                dgvProducts.Columns["Weight"].Visible = false;
                dgvProducts.Columns["IsWeighed"].Visible = false;

                dgvProducts.Columns["Price"].DefaultCellStyle.Format = "C";
            }

            // Добавляем товары в общий список доступных позиций
            foreach (var product in products)
            {
                if (!_availableItems.Contains(product))
                    _availableItems.Add(product);
            }
            UpdateComboBox();
        }

        public void DisplayServices(List<Service> services)
        {
            dgvServices.DataSource = null;
            dgvServices.DataSource = services;

            // Настройка отображения таблицы услуг
            if (dgvServices.Columns.Count > 0)
            {
                dgvServices.Columns["Id"].HeaderText = "Артикул";
                dgvServices.Columns["Name"].HeaderText = "Наименование";
                dgvServices.Columns["Price"].HeaderText = "Цена";
                dgvServices.Columns["DurationMinutes"].HeaderText = "Длительность (мин)";
                dgvServices.Columns["RequiresWeighing"].Visible = false;
                dgvServices.Columns["Weight"].Visible = false;
                dgvServices.Columns["IsWeighed"].Visible = false;

                dgvServices.Columns["Price"].DefaultCellStyle.Format = "C";
            }

            // Добавляем услуги в общий список доступных позиций
            foreach (var service in services)
            {
                if (!_availableItems.Contains(service))
                    _availableItems.Add(service);
            }
            UpdateComboBox();
        }

        public void DisplayCart(IEnumerable<IPurchasable> cartItems)
        {
            lstCart.DataSource = null;
            lstCart.DisplayMember = "GetDisplayInfo";
            lstCart.DataSource = cartItems.ToList();

            // Обновляем статус в статусбаре
            tsslStatus.Text = $"В корзине {cartItems.Count()} товаров на сумму {GetCartTotal():C}";
        }

        public void UpdateCustomerInfo(string name, decimal cash, decimal cardBalance, int bonuses)
        {
            lblNameValue.Text = name;
            lblCashValue.Text = $"{cash:C}";
            lblCardValue.Text = $"{cardBalance:C}";
            lblBonusesValue.Text = $"{bonuses} б";
        }

        public void ShowMessage(string message, bool isError = false)
        {
            if (isError)
            {
                MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLog.AppendText($"[ОШИБКА] {DateTime.Now:HH:mm:ss} - {message}\n");
                tsslStatus.Text = $"Ошибка: {message}";
            }
            else
            {
                MessageBox.Show(message, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLog.AppendText($"[ИНФО] {DateTime.Now:HH:mm:ss} - {message}\n");
                tsslStatus.Text = message;
            }
            txtLog.ScrollToCaret();
        }

        public void UpdateCartTotal(decimal total)
        {
            lblCartTotalValue.Text = $"{total:C}";
        }

        public IPurchasable GetSelectedItem()
        {
            if (cmbItems.SelectedItem != null)
                return cmbItems.SelectedItem as IPurchasable;
            return null;
        }

        public void ShowWeighDialog(IPurchasable item, Action<decimal> callback)
        {
            var dialog = new Form
            {
                Text = $"Взвешивание: {item.Name}",
                Size = new System.Drawing.Size(350, 180),
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false
            };

            Label lblWeight = new Label
            {
                Text = $"Введите вес товара \"{item.Name}\" (кг):",
                Location = new System.Drawing.Point(20, 20),
                Size = new System.Drawing.Size(300, 25),
                Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular)
            };

            NumericUpDown nudWeight = new NumericUpDown
            {
                Location = new System.Drawing.Point(20, 55),
                Size = new System.Drawing.Size(150, 26),
                DecimalPlaces = 2,
                Minimum = 0.1m,
                Maximum = 100,
                Value = 1,
                Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular)
            };

            Label lblKg = new Label
            {
                Text = "кг",
                Location = new System.Drawing.Point(180, 58),
                Size = new System.Drawing.Size(50, 25),
                Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular)
            };

            Button btnOk = new Button
            {
                Text = "Подтвердить",
                Location = new System.Drawing.Point(20, 100),
                Size = new System.Drawing.Size(120, 35),
                BackColor = System.Drawing.Color.DodgerBlue,
                ForeColor = System.Drawing.Color.White,
                FlatStyle = FlatStyle.Flat,
                DialogResult = DialogResult.OK
            };

            Button btnCancel = new Button
            {
                Text = "Отмена",
                Location = new System.Drawing.Point(150, 100),
                Size = new System.Drawing.Size(120, 35),
                DialogResult = DialogResult.Cancel
            };

            dialog.Controls.AddRange(new Control[] { lblWeight, nudWeight, lblKg, btnOk, btnCancel });

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                callback(nudWeight.Value);
            }
        }

        public void ShowPaymentDialog(decimal total, Action<decimal, string> paymentCallback)
        {
            var dialog = new Form
            {
                Text = $"Оплата покупки на сумму {total:C}",
                Size = new System.Drawing.Size(450, 280),
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false
            };

            Label lblTotal = new Label
            {
                Text = $"Сумма к оплате: {total:C}",
                Location = new System.Drawing.Point(20, 20),
                Size = new System.Drawing.Size(400, 30),
                Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold),
                ForeColor = System.Drawing.Color.Green
            };

            Label lblMethod = new Label
            {
                Text = "Выберите способ оплаты:",
                Location = new System.Drawing.Point(20, 65),
                Size = new System.Drawing.Size(200, 25),
                Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular)
            };

            ComboBox cmbMethod = new ComboBox
            {
                Location = new System.Drawing.Point(20, 95),
                Size = new System.Drawing.Size(200, 28),
                DropDownStyle = ComboBoxStyle.DropDownList,
                Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular)
            };
            cmbMethod.Items.AddRange(new[] { "Наличные", "Карта", "Бонусы" });
            cmbMethod.SelectedIndex = 0;

            Label lblInfo = new Label
            {
                Text = "При оплате картой начисляется кэшбэк 10%",
                Location = new System.Drawing.Point(20, 130),
                Size = new System.Drawing.Size(400, 25),
                Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic),
                ForeColor = System.Drawing.Color.Gray
            };

            Button btnPay = new Button
            {
                Text = "ОПЛАТИТЬ",
                Location = new System.Drawing.Point(20, 175),
                Size = new System.Drawing.Size(180, 45),
                BackColor = System.Drawing.Color.Green,
                ForeColor = System.Drawing.Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold)
            };

            Button btnCancel = new Button
            {
                Text = "ОТМЕНА",
                Location = new System.Drawing.Point(215, 175),
                Size = new System.Drawing.Size(180, 45),
                BackColor = System.Drawing.Color.Gray,
                ForeColor = System.Drawing.Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold),
                DialogResult = DialogResult.Cancel
            };

            btnPay.Click += (s, e) =>
            {
                paymentCallback(total, cmbMethod.SelectedItem.ToString());
                dialog.Close();
            };

            dialog.Controls.AddRange(new Control[] { lblTotal, lblMethod, cmbMethod, lblInfo, btnPay, btnCancel });
            dialog.ShowDialog();
        }

        public string GetCustomerName()
        {
            return lblNameValue.Text;
        }

        #endregion

        #region Вспомогательные методы

        private void UpdateComboBox()
        {
            cmbItems.DataSource = null;
            cmbItems.DisplayMember = "Name";
            cmbItems.ValueMember = "Id";
            cmbItems.DataSource = _availableItems.ToList();

            if (cmbItems.Items.Count > 0)
                cmbItems.SelectedIndex = 0;
        }

        private decimal GetCartTotal()
        {
            if (lstCart.DataSource != null && lstCart.Items.Count > 0)
            {
                var cartItems = lstCart.Items.Cast<IPurchasable>();
                return cartItems.Sum(i => i.Price * (i.RequiresWeighing ? i.Weight : 1));
            }
            return 0;
        }

        #endregion

        #region Обработчики событий формы

        private void Form1_Load(object sender, EventArgs e)
        {
            // Дополнительная настройка при загрузке формы
            txtLog.AppendText($"[СИСТЕМА] {DateTime.Now:HH:mm:ss} - Программа запущена\n");
            txtLog.AppendText($"[СИСТЕМА] {DateTime.Now:HH:mm:ss} - Загружены товары и услуги\n");
            tsslStatus.Text = "Готов к работе. Выберите товар или услугу";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            txtLog.AppendText($"[СИСТЕМА] {DateTime.Now:HH:mm:ss} - Завершение работы программы\n");
        }

        #endregion

        public void RaisePaymentEvent(decimal amount, string method)
        {
            OnPayment?.Invoke(amount, method);
        }

        private void gbCustomerInfo_Enter(object sender, EventArgs e)
        {

        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {

        }

        private void gbCart_Enter(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
