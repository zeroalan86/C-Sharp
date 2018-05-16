namespace WinterHomework008
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Person = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pencil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eraser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ruler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Liwhite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Goods = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.One = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salesvolume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Totalsales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Person,
            this.Pen,
            this.Pencil,
            this.Eraser,
            this.Ruler,
            this.Liwhite,
            this.Sale});
            this.dataGridView1.Location = new System.Drawing.Point(12, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(652, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "業務員銷售";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "產品銷售總額";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "最佳銷售業務員:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "銷售量最多的產品:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(434, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "label5";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(434, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "label6";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Goods,
            this.One,
            this.Salesvolume,
            this.Totalsales});
            this.dataGridView2.Location = new System.Drawing.Point(12, 318);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(652, 150);
            this.dataGridView2.TabIndex = 7;
            // 
            // Person
            // 
            this.Person.DataPropertyName = "Person";
            this.Person.HeaderText = "銷售員";
            this.Person.Name = "Person";
            this.Person.ReadOnly = true;
            // 
            // Pen
            // 
            this.Pen.DataPropertyName = "Pen";
            this.Pen.HeaderText = "原子筆";
            this.Pen.Name = "Pen";
            this.Pen.ReadOnly = true;
            // 
            // Pencil
            // 
            this.Pencil.DataPropertyName = "Pencil";
            this.Pencil.HeaderText = "鉛筆";
            this.Pencil.Name = "Pencil";
            this.Pencil.ReadOnly = true;
            // 
            // Eraser
            // 
            this.Eraser.DataPropertyName = "Eraser";
            this.Eraser.HeaderText = "橡皮擦";
            this.Eraser.Name = "Eraser";
            this.Eraser.ReadOnly = true;
            // 
            // Ruler
            // 
            this.Ruler.DataPropertyName = "Ruler";
            this.Ruler.HeaderText = "直尺";
            this.Ruler.Name = "Ruler";
            this.Ruler.ReadOnly = true;
            // 
            // Liwhite
            // 
            this.Liwhite.DataPropertyName = "Liwhite";
            this.Liwhite.HeaderText = "立可白";
            this.Liwhite.Name = "Liwhite";
            this.Liwhite.ReadOnly = true;
            // 
            // Sale
            // 
            this.Sale.DataPropertyName = "Sale";
            this.Sale.HeaderText = "銷售總金額";
            this.Sale.Name = "Sale";
            this.Sale.ReadOnly = true;
            // 
            // Goods
            // 
            this.Goods.DataPropertyName = "Goods";
            this.Goods.HeaderText = "產品";
            this.Goods.Name = "Goods";
            this.Goods.ReadOnly = true;
            // 
            // One
            // 
            this.One.DataPropertyName = "One";
            this.One.HeaderText = "單價";
            this.One.Name = "One";
            this.One.ReadOnly = true;
            // 
            // Salesvolume
            // 
            this.Salesvolume.DataPropertyName = "Salesvolume";
            this.Salesvolume.HeaderText = "銷售量";
            this.Salesvolume.Name = "Salesvolume";
            this.Salesvolume.ReadOnly = true;
            // 
            // Totalsales
            // 
            this.Totalsales.DataPropertyName = "Totalsales";
            this.Totalsales.HeaderText = "銷售總量";
            this.Totalsales.Name = "Totalsales";
            this.Totalsales.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 480);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Person;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pencil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Eraser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ruler;
        private System.Windows.Forms.DataGridViewTextBoxColumn Liwhite;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sale;
        private System.Windows.Forms.DataGridViewTextBoxColumn Goods;
        private System.Windows.Forms.DataGridViewTextBoxColumn One;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salesvolume;
        private System.Windows.Forms.DataGridViewTextBoxColumn Totalsales;
    }
}

