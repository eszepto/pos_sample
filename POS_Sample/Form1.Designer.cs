namespace POS_Sample
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sQliteDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonDel = new System.Windows.Forms.Button();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.textID = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.textQty = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonPay = new System.Windows.Forms.Button();
            this.buttonApple = new System.Windows.Forms.Button();
            this.buttonOrange = new System.Windows.Forms.Button();
            this.buttonGrape = new System.Windows.Forms.Button();
            this.buttonCola = new System.Windows.Forms.Button();
            this.buttonWater = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQliteDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColName,
            this.ColPrice,
            this.ColQty,
            this.ColTotal});
            this.dataGridView1.Location = new System.Drawing.Point(12, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(505, 256);
            this.dataGridView1.TabIndex = 16;
            // 
            // ColID
            // 
            this.ColID.DataPropertyName = "id";
            this.ColID.HeaderText = "ID";
            this.ColID.MinimumWidth = 6;
            this.ColID.Name = "ColID";
            this.ColID.ReadOnly = true;
            // 
            // ColName
            // 
            this.ColName.DataPropertyName = "name";
            this.ColName.HeaderText = "Item Name";
            this.ColName.MinimumWidth = 6;
            this.ColName.Name = "ColName";
            this.ColName.ReadOnly = true;
            // 
            // ColPrice
            // 
            this.ColPrice.DataPropertyName = "price";
            this.ColPrice.HeaderText = "Price/Unit";
            this.ColPrice.MinimumWidth = 6;
            this.ColPrice.Name = "ColPrice";
            this.ColPrice.ReadOnly = true;
            // 
            // ColQty
            // 
            this.ColQty.DataPropertyName = "qty";
            this.ColQty.HeaderText = "Quantity";
            this.ColQty.MinimumWidth = 6;
            this.ColQty.Name = "ColQty";
            this.ColQty.ReadOnly = true;
            // 
            // ColTotal
            // 
            this.ColTotal.DataPropertyName = "total";
            this.ColTotal.HeaderText = "Total";
            this.ColTotal.MinimumWidth = 6;
            this.ColTotal.Name = "ColTotal";
            this.ColTotal.ReadOnly = true;
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonDel.Location = new System.Drawing.Point(533, 161);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(123, 51);
            this.buttonDel.TabIndex = 6;
            this.buttonDel.Text = "DEL";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.ButtonDel_Click);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ButtonAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonAdd.Location = new System.Drawing.Point(545, 12);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(68, 56);
            this.ButtonAdd.TabIndex = 7;
            this.ButtonAdd.Text = "ADD";
            this.ButtonAdd.UseVisualStyleBackColor = false;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // textID
            // 
            this.textID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textID.Location = new System.Drawing.Point(47, 27);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(107, 26);
            this.textID.TabIndex = 8;
            // 
            // textName
            // 
            this.textName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textName.Location = new System.Drawing.Point(201, 24);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(155, 30);
            this.textName.TabIndex = 9;
            // 
            // textQty
            // 
            this.textQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textQty.Location = new System.Drawing.Point(426, 20);
            this.textQty.MaxLength = 3;
            this.textQty.Name = "textQty";
            this.textQty.Size = new System.Drawing.Size(70, 36);
            this.textQty.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(374, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Quantity";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonClear.Location = new System.Drawing.Point(533, 218);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(123, 27);
            this.buttonClear.TabIndex = 14;
            this.buttonClear.Text = "CLEAR";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // buttonPay
            // 
            this.buttonPay.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonPay.Location = new System.Drawing.Point(533, 275);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(132, 133);
            this.buttonPay.TabIndex = 15;
            this.buttonPay.Text = "PAY";
            this.buttonPay.UseVisualStyleBackColor = false;
            this.buttonPay.Click += new System.EventHandler(this.ButtonPay_Click);
            // 
            // buttonApple
            // 
            this.buttonApple.Location = new System.Drawing.Point(26, 76);
            this.buttonApple.Name = "buttonApple";
            this.buttonApple.Size = new System.Drawing.Size(83, 50);
            this.buttonApple.TabIndex = 17;
            this.buttonApple.Text = "Apple";
            this.buttonApple.UseVisualStyleBackColor = true;
            this.buttonApple.Click += new System.EventHandler(this.ButtonApple_Click);
            // 
            // buttonOrange
            // 
            this.buttonOrange.Location = new System.Drawing.Point(131, 76);
            this.buttonOrange.Name = "buttonOrange";
            this.buttonOrange.Size = new System.Drawing.Size(83, 50);
            this.buttonOrange.TabIndex = 18;
            this.buttonOrange.Text = "Orange";
            this.buttonOrange.UseVisualStyleBackColor = true;
            this.buttonOrange.Click += new System.EventHandler(this.ButtonOrange_Click);
            // 
            // buttonGrape
            // 
            this.buttonGrape.Location = new System.Drawing.Point(238, 76);
            this.buttonGrape.Name = "buttonGrape";
            this.buttonGrape.Size = new System.Drawing.Size(83, 50);
            this.buttonGrape.TabIndex = 19;
            this.buttonGrape.Text = "Grape";
            this.buttonGrape.UseVisualStyleBackColor = true;
            this.buttonGrape.Click += new System.EventHandler(this.ButtonGrape_Click);
            // 
            // buttonCola
            // 
            this.buttonCola.Location = new System.Drawing.Point(346, 76);
            this.buttonCola.Name = "buttonCola";
            this.buttonCola.Size = new System.Drawing.Size(83, 50);
            this.buttonCola.TabIndex = 20;
            this.buttonCola.Text = "Cola";
            this.buttonCola.UseVisualStyleBackColor = true;
            this.buttonCola.Click += new System.EventHandler(this.ButtonCola_Click);
            // 
            // buttonWater
            // 
            this.buttonWater.Location = new System.Drawing.Point(450, 76);
            this.buttonWater.Name = "buttonWater";
            this.buttonWater.Size = new System.Drawing.Size(108, 50);
            this.buttonWater.TabIndex = 21;
            this.buttonWater.Text = "Water";
            this.buttonWater.UseVisualStyleBackColor = true;
            this.buttonWater.Click += new System.EventHandler(this.ButtonWater_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(447, 416);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Total :";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(482, 416);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(0, 13);
            this.labelTotal.TabIndex = 23;
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(POS_Sample.Form1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 438);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonWater);
            this.Controls.Add(this.buttonCola);
            this.Controls.Add(this.buttonGrape);
            this.Controls.Add(this.buttonOrange);
            this.Controls.Add(this.buttonApple);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonPay);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textQty);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.buttonDel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQliteDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textQty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonPay;
        private System.Windows.Forms.BindingSource sQliteDBBindingSource;
        private System.Windows.Forms.Button buttonApple;
        private System.Windows.Forms.Button buttonOrange;
        private System.Windows.Forms.Button buttonGrape;
        private System.Windows.Forms.Button buttonCola;
        private System.Windows.Forms.Button buttonWater;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTotal;
    }
}

