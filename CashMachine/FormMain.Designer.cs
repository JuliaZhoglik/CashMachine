namespace CashMachine
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelState = new System.Windows.Forms.Label();
            this.radioButtonAdd = new System.Windows.Forms.RadioButton();
            this.radioButtonGet = new System.Windows.Forms.RadioButton();
            this.labelCoin = new System.Windows.Forms.Label();
            this.comboBoxMoneyType = new System.Windows.Forms.ComboBox();
            this.numCountMoney = new System.Windows.Forms.NumericUpDown();
            this.labelNum = new System.Windows.Forms.Label();
            this.buttonOperation = new System.Windows.Forms.Button();
            this.numSum = new System.Windows.Forms.NumericUpDown();
            this.labelSum = new System.Windows.Forms.Label();
            this.checkBoxSmall = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numCountMoney)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSum)).BeginInit();
            this.SuspendLayout();
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Location = new System.Drawing.Point(322, 12);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(58, 13);
            this.labelState.TabIndex = 1;
            this.labelState.Text = "LabelState";
            // 
            // radioButtonAdd
            // 
            this.radioButtonAdd.AutoSize = true;
            this.radioButtonAdd.Checked = true;
            this.radioButtonAdd.Location = new System.Drawing.Point(12, 126);
            this.radioButtonAdd.Name = "radioButtonAdd";
            this.radioButtonAdd.Size = new System.Drawing.Size(103, 17);
            this.radioButtonAdd.TabIndex = 2;
            this.radioButtonAdd.TabStop = true;
            this.radioButtonAdd.Text = "Внести купюры";
            this.radioButtonAdd.UseVisualStyleBackColor = true;
            this.radioButtonAdd.CheckedChanged += new System.EventHandler(this.radioButtonAdd_CheckedChanged);
            // 
            // radioButtonGet
            // 
            this.radioButtonGet.AutoSize = true;
            this.radioButtonGet.Location = new System.Drawing.Point(164, 126);
            this.radioButtonGet.Name = "radioButtonGet";
            this.radioButtonGet.Size = new System.Drawing.Size(114, 17);
            this.radioButtonGet.TabIndex = 3;
            this.radioButtonGet.Text = "Получить купюры";
            this.radioButtonGet.UseVisualStyleBackColor = true;
            this.radioButtonGet.CheckedChanged += new System.EventHandler(this.radioButtonGet_CheckedChanged);
            // 
            // labelCoin
            // 
            this.labelCoin.AutoSize = true;
            this.labelCoin.Location = new System.Drawing.Point(12, 12);
            this.labelCoin.Name = "labelCoin";
            this.labelCoin.Size = new System.Drawing.Size(105, 13);
            this.labelCoin.TabIndex = 5;
            this.labelCoin.Text = "Номинал банкноты";
            // 
            // comboBoxMoneyType
            // 
            this.comboBoxMoneyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMoneyType.FormattingEnabled = true;
            this.comboBoxMoneyType.Items.AddRange(new object[] {
            "10",
            "50",
            "100",
            "200",
            "500",
            "1000",
            "2000",
            "5000"});
            this.comboBoxMoneyType.Location = new System.Drawing.Point(12, 31);
            this.comboBoxMoneyType.Name = "comboBoxMoneyType";
            this.comboBoxMoneyType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMoneyType.TabIndex = 6;
            // 
            // numCountMoney
            // 
            this.numCountMoney.Location = new System.Drawing.Point(12, 86);
            this.numCountMoney.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numCountMoney.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCountMoney.Name = "numCountMoney";
            this.numCountMoney.Size = new System.Drawing.Size(120, 20);
            this.numCountMoney.TabIndex = 7;
            this.numCountMoney.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelNum
            // 
            this.labelNum.AutoSize = true;
            this.labelNum.Location = new System.Drawing.Point(12, 70);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new System.Drawing.Size(110, 13);
            this.labelNum.TabIndex = 8;
            this.labelNum.Text = "Количество банкнот";
            // 
            // buttonOperation
            // 
            this.buttonOperation.Location = new System.Drawing.Point(69, 167);
            this.buttonOperation.Name = "buttonOperation";
            this.buttonOperation.Size = new System.Drawing.Size(140, 23);
            this.buttonOperation.TabIndex = 9;
            this.buttonOperation.Text = "Выполнить операцию";
            this.buttonOperation.UseVisualStyleBackColor = true;
            this.buttonOperation.Click += new System.EventHandler(this.buttonOperation_Click);
            // 
            // numSum
            // 
            this.numSum.Enabled = false;
            this.numSum.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numSum.Location = new System.Drawing.Point(164, 32);
            this.numSum.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.numSum.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numSum.Name = "numSum";
            this.numSum.Size = new System.Drawing.Size(120, 20);
            this.numSum.TabIndex = 10;
            this.numSum.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Location = new System.Drawing.Point(161, 12);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(81, 13);
            this.labelSum.TabIndex = 11;
            this.labelSum.Text = "Сумма выдачи";
            // 
            // checkBoxSmall
            // 
            this.checkBoxSmall.AutoSize = true;
            this.checkBoxSmall.Enabled = false;
            this.checkBoxSmall.Location = new System.Drawing.Point(164, 86);
            this.checkBoxSmall.Name = "checkBoxSmall";
            this.checkBoxSmall.Size = new System.Drawing.Size(112, 17);
            this.checkBoxSmall.TabIndex = 12;
            this.checkBoxSmall.Text = "Номинал выдачи";
            this.checkBoxSmall.UseVisualStyleBackColor = true;
            this.checkBoxSmall.CheckedChanged += new System.EventHandler(this.checkBoxSmall_CheckedChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 237);
            this.Controls.Add(this.checkBoxSmall);
            this.Controls.Add(this.labelSum);
            this.Controls.Add(this.numSum);
            this.Controls.Add(this.buttonOperation);
            this.Controls.Add(this.labelNum);
            this.Controls.Add(this.numCountMoney);
            this.Controls.Add(this.comboBoxMoneyType);
            this.Controls.Add(this.labelCoin);
            this.Controls.Add(this.radioButtonGet);
            this.Controls.Add(this.radioButtonAdd);
            this.Controls.Add(this.labelState);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Банкомат";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numCountMoney)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.RadioButton radioButtonAdd;
        private System.Windows.Forms.RadioButton radioButtonGet;
        private System.Windows.Forms.Label labelCoin;
        private System.Windows.Forms.ComboBox comboBoxMoneyType;
        private System.Windows.Forms.NumericUpDown numCountMoney;
        private System.Windows.Forms.Label labelNum;
        private System.Windows.Forms.Button buttonOperation;
        private System.Windows.Forms.NumericUpDown numSum;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.CheckBox checkBoxSmall;
    }
}

