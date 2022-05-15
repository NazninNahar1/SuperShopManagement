
namespace SuperShopManagement
{
    partial class Item
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ItemDGV = new System.Windows.Forms.DataGridView();
            this.CatCb = new System.Windows.Forms.ComboBox();
            this.ItSaveBtn = new System.Windows.Forms.Button();
            this.ItEditBtn = new System.Windows.Forms.Button();
            this.iDeleteBtn = new System.Windows.Forms.Button();
            this.ItClearBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.ItemPriceTb = new System.Windows.Forms.TextBox();
            this.ItemQtyTb = new System.Windows.Forms.TextBox();
            this.ItemNameTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BacktoEmp = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel1.Controls.Add(this.ItemDGV);
            this.panel1.Controls.Add(this.CatCb);
            this.panel1.Controls.Add(this.ItSaveBtn);
            this.panel1.Controls.Add(this.ItEditBtn);
            this.panel1.Controls.Add(this.iDeleteBtn);
            this.panel1.Controls.Add(this.ItClearBtn);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.ItemPriceTb);
            this.panel1.Controls.Add(this.ItemQtyTb);
            this.panel1.Controls.Add(this.ItemNameTb);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.BacktoEmp);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(3, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 485);
            this.panel1.TabIndex = 8;
            // 
            // ItemDGV
            // 
            this.ItemDGV.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.ItemDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemDGV.Location = new System.Drawing.Point(109, 282);
            this.ItemDGV.Name = "ItemDGV";
            this.ItemDGV.RowTemplate.Height = 25;
            this.ItemDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ItemDGV.Size = new System.Drawing.Size(537, 163);
            this.ItemDGV.TabIndex = 28;
            this.ItemDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemDGV_CellContentClick);
            // 
            // CatCb
            // 
            this.CatCb.FormattingEnabled = true;
            this.CatCb.Items.AddRange(new object[] {
            "FISH",
            "FRUIT",
            "MEAT",
            "VEGITABLES"});
            this.CatCb.Location = new System.Drawing.Point(601, 152);
            this.CatCb.Name = "CatCb";
            this.CatCb.Size = new System.Drawing.Size(141, 23);
            this.CatCb.TabIndex = 27;
            this.CatCb.Text = "Select Catagory";
            // 
            // ItSaveBtn
            // 
            this.ItSaveBtn.BackColor = System.Drawing.Color.Orchid;
            this.ItSaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ItSaveBtn.Location = new System.Drawing.Point(109, 222);
            this.ItSaveBtn.Name = "ItSaveBtn";
            this.ItSaveBtn.Size = new System.Drawing.Size(89, 31);
            this.ItSaveBtn.TabIndex = 25;
            this.ItSaveBtn.Text = "Save";
            this.ItSaveBtn.UseVisualStyleBackColor = false;
            this.ItSaveBtn.Click += new System.EventHandler(this.ItSaveBtn_Click);
            // 
            // ItEditBtn
            // 
            this.ItEditBtn.BackColor = System.Drawing.Color.Orchid;
            this.ItEditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ItEditBtn.Location = new System.Drawing.Point(257, 222);
            this.ItEditBtn.Name = "ItEditBtn";
            this.ItEditBtn.Size = new System.Drawing.Size(89, 31);
            this.ItEditBtn.TabIndex = 24;
            this.ItEditBtn.Text = "Edit";
            this.ItEditBtn.UseVisualStyleBackColor = false;
            this.ItEditBtn.Click += new System.EventHandler(this.ItEditBtn_Click);
            // 
            // iDeleteBtn
            // 
            this.iDeleteBtn.BackColor = System.Drawing.Color.Orchid;
            this.iDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iDeleteBtn.Location = new System.Drawing.Point(398, 222);
            this.iDeleteBtn.Name = "iDeleteBtn";
            this.iDeleteBtn.Size = new System.Drawing.Size(89, 31);
            this.iDeleteBtn.TabIndex = 23;
            this.iDeleteBtn.Text = "Delete";
            this.iDeleteBtn.UseVisualStyleBackColor = false;
            this.iDeleteBtn.Click += new System.EventHandler(this.iDeleteBtn_Click);
            // 
            // ItClearBtn
            // 
            this.ItClearBtn.BackColor = System.Drawing.Color.Orchid;
            this.ItClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ItClearBtn.Location = new System.Drawing.Point(537, 222);
            this.ItClearBtn.Name = "ItClearBtn";
            this.ItClearBtn.Size = new System.Drawing.Size(89, 31);
            this.ItClearBtn.TabIndex = 22;
            this.ItClearBtn.Text = "Clear";
            this.ItClearBtn.UseVisualStyleBackColor = false;
            this.ItClearBtn.Click += new System.EventHandler(this.ItClearBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(586, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 23);
            this.label7.TabIndex = 20;
            this.label7.Text = "Category";
            // 
            // ItemPriceTb
            // 
            this.ItemPriceTb.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ItemPriceTb.Location = new System.Drawing.Point(398, 151);
            this.ItemPriceTb.Name = "ItemPriceTb";
            this.ItemPriceTb.Size = new System.Drawing.Size(178, 31);
            this.ItemPriceTb.TabIndex = 19;
            // 
            // ItemQtyTb
            // 
            this.ItemQtyTb.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ItemQtyTb.Location = new System.Drawing.Point(204, 151);
            this.ItemQtyTb.Name = "ItemQtyTb";
            this.ItemQtyTb.Size = new System.Drawing.Size(178, 31);
            this.ItemQtyTb.TabIndex = 18;
            // 
            // ItemNameTb
            // 
            this.ItemNameTb.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ItemNameTb.Location = new System.Drawing.Point(13, 152);
            this.ItemNameTb.Name = "ItemNameTb";
            this.ItemNameTb.Size = new System.Drawing.Size(178, 31);
            this.ItemNameTb.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(398, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 23);
            this.label6.TabIndex = 16;
            this.label6.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(204, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 23);
            this.label5.TabIndex = 15;
            this.label5.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(13, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(398, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Items";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orchid;
            this.panel2.Location = new System.Drawing.Point(380, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(124, 10);
            this.panel2.TabIndex = 12;
            // 
            // BacktoEmp
            // 
            this.BacktoEmp.AutoSize = true;
            this.BacktoEmp.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BacktoEmp.ForeColor = System.Drawing.Color.Black;
            this.BacktoEmp.Location = new System.Drawing.Point(221, 37);
            this.BacktoEmp.Name = "BacktoEmp";
            this.BacktoEmp.Size = new System.Drawing.Size(103, 23);
            this.BacktoEmp.TabIndex = 11;
            this.BacktoEmp.Text = "Employee";
            this.BacktoEmp.Click += new System.EventHandler(this.BacktoEmp_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orchid;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(365, 451);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 31);
            this.button1.TabIndex = 7;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(352, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "SUPER SHOP";
            // 
            // Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orchid;
            this.ClientSize = new System.Drawing.Size(831, 525);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Item";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item";
            this.Load += new System.EventHandler(this.Item_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox CatCb;
        private System.Windows.Forms.Button ItSaveBtn;
        private System.Windows.Forms.Button ItEditBtn;
        private System.Windows.Forms.Button iDeleteBtn;
        private System.Windows.Forms.Button ItClearBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ItemPriceTb;
        private System.Windows.Forms.TextBox ItemQtyTb;
        private System.Windows.Forms.TextBox ItemNameTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label BacktoEmp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView ItemDGV;
    }
}