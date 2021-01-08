namespace iResell.UI
{
    partial class frmInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventory));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCategory = new Guna.UI.WinForms.GunaLabel();
            this.btnAll = new Guna.UI.WinForms.GunaAdvenceButton();
            this.cmbCategories = new Guna.UI.WinForms.GunaComboBox();
            this.dgvProducts = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel20 = new System.Windows.Forms.Panel();
            this.label90 = new System.Windows.Forms.Label();
            this.label89 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.gunaCirclePictureBox8 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.label50 = new System.Windows.Forms.Label();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse3 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse4 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.panel20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.panel2.Controls.Add(this.lblCategory);
            this.panel2.Controls.Add(this.btnAll);
            this.panel2.Controls.Add(this.cmbCategories);
            this.panel2.Controls.Add(this.dgvProducts);
            this.panel2.Controls.Add(this.panel17);
            this.panel2.Location = new System.Drawing.Point(29, 173);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1193, 549);
            this.panel2.TabIndex = 23;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(176)))), ((int)(((byte)(207)))));
            this.lblCategory.Location = new System.Drawing.Point(27, 53);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(66, 19);
            this.lblCategory.TabIndex = 56;
            this.lblCategory.Text = "Category";
            // 
            // btnAll
            // 
            this.btnAll.Animated = true;
            this.btnAll.AnimationHoverSpeed = 0.07F;
            this.btnAll.AnimationSpeed = 0.03F;
            this.btnAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(110)))), ((int)(((byte)(230)))));
            this.btnAll.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(110)))), ((int)(((byte)(230)))));
            this.btnAll.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(110)))), ((int)(((byte)(230)))));
            this.btnAll.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(128)))), ((int)(((byte)(232)))));
            this.btnAll.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnAll.CheckedForeColor = System.Drawing.Color.White;
            this.btnAll.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnAll.CheckedImage")));
            this.btnAll.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(113)))), ((int)(((byte)(231)))));
            this.btnAll.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAll.FocusedColor = System.Drawing.Color.Empty;
            this.btnAll.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnAll.ForeColor = System.Drawing.Color.White;
            this.btnAll.Image = null;
            this.btnAll.ImageSize = new System.Drawing.Size(19, 19);
            this.btnAll.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(110)))), ((int)(((byte)(230)))));
            this.btnAll.Location = new System.Drawing.Point(989, 53);
            this.btnAll.Margin = new System.Windows.Forms.Padding(0);
            this.btnAll.Name = "btnAll";
            this.btnAll.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(110)))), ((int)(((byte)(230)))));
            this.btnAll.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnAll.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAll.OnHoverImage = null;
            this.btnAll.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.btnAll.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(128)))), ((int)(((byte)(232)))));
            this.btnAll.Size = new System.Drawing.Size(173, 38);
            this.btnAll.TabIndex = 54;
            this.btnAll.Tag = "Dashboard";
            this.btnAll.Text = "Show All";
            this.btnAll.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // cmbCategories
            // 
            this.cmbCategories.BackColor = System.Drawing.Color.Transparent;
            this.cmbCategories.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(53)))), ((int)(((byte)(72)))));
            this.cmbCategories.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(57)))), ((int)(((byte)(78)))));
            this.cmbCategories.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCategories.FocusedColor = System.Drawing.Color.Empty;
            this.cmbCategories.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCategories.ForeColor = System.Drawing.Color.White;
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.ItemHeight = 29;
            this.cmbCategories.Location = new System.Drawing.Point(116, 47);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.cmbCategories.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbCategories.Size = new System.Drawing.Size(425, 35);
            this.cmbCategories.TabIndex = 55;
            this.cmbCategories.SelectedIndexChanged += new System.EventHandler(this.cmbCategories_SelectedIndexChanged);
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(200)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(200)))), ((int)(((byte)(226)))));
            this.dgvProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProducts.ColumnHeadersHeight = 45;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(200)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProducts.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProducts.DoubleBuffered = true;
            this.dgvProducts.EnableHeadersVisualStyles = false;
            this.dgvProducts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(57)))), ((int)(((byte)(78)))));
            this.dgvProducts.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(75)))));
            this.dgvProducts.HeaderForeColor = System.Drawing.Color.White;
            this.dgvProducts.Location = new System.Drawing.Point(51, 127);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(200)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(200)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.RowHeadersWidth = 45;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(200)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(200)))), ((int)(((byte)(226)))));
            this.dgvProducts.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProducts.RowTemplate.Height = 40;
            this.dgvProducts.RowTemplate.ReadOnly = true;
            this.dgvProducts.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProducts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(1111, 391);
            this.dgvProducts.TabIndex = 24;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(75)))));
            this.panel17.Location = new System.Drawing.Point(28, 127);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(25, 45);
            this.panel17.TabIndex = 22;
            // 
            // panel20
            // 
            this.panel20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.panel20.Controls.Add(this.label90);
            this.panel20.Controls.Add(this.label89);
            this.panel20.Controls.Add(this.label61);
            this.panel20.Controls.Add(this.gunaCirclePictureBox8);
            this.panel20.Location = new System.Drawing.Point(29, 62);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(1193, 100);
            this.panel20.TabIndex = 57;
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.BackColor = System.Drawing.Color.Transparent;
            this.label90.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label90.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(176)))), ((int)(((byte)(202)))));
            this.label90.Location = new System.Drawing.Point(111, 66);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(94, 17);
            this.label90.TabIndex = 27;
            this.label90.Text = "Rank/Member";
            // 
            // label89
            // 
            this.label89.AutoSize = true;
            this.label89.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label89.ForeColor = System.Drawing.Color.White;
            this.label89.Location = new System.Drawing.Point(112, 40);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(53, 19);
            this.label89.TabIndex = 26;
            this.label89.Text = "Admin";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.BackColor = System.Drawing.Color.Transparent;
            this.label61.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label61.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(176)))), ((int)(((byte)(202)))));
            this.label61.Location = new System.Drawing.Point(111, 18);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(180, 17);
            this.label61.TabIndex = 24;
            this.label61.Text = "General settings for scanner.";
            // 
            // gunaCirclePictureBox8
            // 
            this.gunaCirclePictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.gunaCirclePictureBox8.BaseColor = System.Drawing.Color.Transparent;
            this.gunaCirclePictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("gunaCirclePictureBox8.Image")));
            this.gunaCirclePictureBox8.Location = new System.Drawing.Point(21, 14);
            this.gunaCirclePictureBox8.Name = "gunaCirclePictureBox8";
            this.gunaCirclePictureBox8.Size = new System.Drawing.Size(73, 70);
            this.gunaCirclePictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaCirclePictureBox8.TabIndex = 15;
            this.gunaCirclePictureBox8.TabStop = false;
            this.gunaCirclePictureBox8.UseTransfarantBackground = true;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label50.ForeColor = System.Drawing.Color.White;
            this.label50.Location = new System.Drawing.Point(25, 20);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(85, 21);
            this.label50.TabIndex = 58;
            this.label50.Text = "Inventory";
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this.panel2;
            // 
            // gunaElipse2
            // 
            this.gunaElipse2.TargetControl = this.cmbCategories;
            // 
            // gunaElipse3
            // 
            this.gunaElipse3.TargetControl = this.panel20;
            // 
            // gunaElipse4
            // 
            this.gunaElipse4.TargetControl = this.btnAll;
            // 
            // frmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1262, 772);
            this.Controls.Add(this.label50);
            this.Controls.Add(this.panel20);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInventory";
            this.Load += new System.EventHandler(this.frmInventory_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.panel20.ResumeLayout(false);
            this.panel20.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvProducts;
        private System.Windows.Forms.Panel panel17;
        private Guna.UI.WinForms.GunaLabel lblCategory;
        private Guna.UI.WinForms.GunaAdvenceButton btnAll;
        private Guna.UI.WinForms.GunaComboBox cmbCategories;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Label label90;
        private System.Windows.Forms.Label label89;
        private System.Windows.Forms.Label label61;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox8;
        private System.Windows.Forms.Label label50;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaElipse gunaElipse2;
        private Guna.UI.WinForms.GunaElipse gunaElipse3;
        private Guna.UI.WinForms.GunaElipse gunaElipse4;
    }
}