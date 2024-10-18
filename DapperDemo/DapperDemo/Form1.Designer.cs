namespace DapperDemo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.btnObtenerTodos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxObtenerID = new System.Windows.Forms.TextBox();
            this.btnObtenerId = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbCustomerId = new System.Windows.Forms.TextBox();
            this.txbCompanyName = new System.Windows.Forms.TextBox();
            this.txbContactName = new System.Windows.Forms.TextBox();
            this.txbContactTitle = new System.Windows.Forms.TextBox();
            this.txbAddress = new System.Windows.Forms.TextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(12, 12);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.RowHeadersWidth = 51;
            this.dgvCustomers.RowTemplate.Height = 24;
            this.dgvCustomers.Size = new System.Drawing.Size(1125, 185);
            this.dgvCustomers.TabIndex = 0;
            // 
            // btnObtenerTodos
            // 
            this.btnObtenerTodos.Location = new System.Drawing.Point(1036, 204);
            this.btnObtenerTodos.Name = "btnObtenerTodos";
            this.btnObtenerTodos.Size = new System.Drawing.Size(102, 42);
            this.btnObtenerTodos.TabIndex = 1;
            this.btnObtenerTodos.Text = "Obtener Todos";
            this.btnObtenerTodos.UseVisualStyleBackColor = true;
            this.btnObtenerTodos.Click += new System.EventHandler(this.btnObtenerTodos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(927, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "ContactName";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Id Cliente";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tboxObtenerID
            // 
            this.tboxObtenerID.Location = new System.Drawing.Point(109, 335);
            this.tboxObtenerID.Name = "tboxObtenerID";
            this.tboxObtenerID.Size = new System.Drawing.Size(100, 22);
            this.tboxObtenerID.TabIndex = 4;
            // 
            // btnObtenerId
            // 
            this.btnObtenerId.Location = new System.Drawing.Point(252, 333);
            this.btnObtenerId.Name = "btnObtenerId";
            this.btnObtenerId.Size = new System.Drawing.Size(75, 23);
            this.btnObtenerId.TabIndex = 5;
            this.btnObtenerId.Text = "Buscar";
            this.btnObtenerId.UseVisualStyleBackColor = true;
            this.btnObtenerId.Click += new System.EventHandler(this.btnObtenerId_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(927, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "CompanyName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(927, 397);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Contact title";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(927, 437);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(927, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "CustomersID";
            // 
            // txbCustomerId
            // 
            this.txbCustomerId.Location = new System.Drawing.Point(1036, 276);
            this.txbCustomerId.Name = "txbCustomerId";
            this.txbCustomerId.Size = new System.Drawing.Size(100, 22);
            this.txbCustomerId.TabIndex = 10;
            this.txbCustomerId.TextChanged += new System.EventHandler(this.txbCustomerId_TextChanged);
            // 
            // txbCompanyName
            // 
            this.txbCompanyName.Location = new System.Drawing.Point(1036, 314);
            this.txbCompanyName.Name = "txbCompanyName";
            this.txbCompanyName.Size = new System.Drawing.Size(100, 22);
            this.txbCompanyName.TabIndex = 11;
            // 
            // txbContactName
            // 
            this.txbContactName.Location = new System.Drawing.Point(1036, 350);
            this.txbContactName.Name = "txbContactName";
            this.txbContactName.Size = new System.Drawing.Size(100, 22);
            this.txbContactName.TabIndex = 12;
            // 
            // txbContactTitle
            // 
            this.txbContactTitle.Location = new System.Drawing.Point(1036, 391);
            this.txbContactTitle.Name = "txbContactTitle";
            this.txbContactTitle.Size = new System.Drawing.Size(100, 22);
            this.txbContactTitle.TabIndex = 13;
            // 
            // txbAddress
            // 
            this.txbAddress.Location = new System.Drawing.Point(1036, 431);
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.Size = new System.Drawing.Size(100, 22);
            this.txbAddress.TabIndex = 14;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(740, 301);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(113, 49);
            this.btnInsertar.TabIndex = 15;
            this.btnInsertar.Text = "Insertar cliente";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(740, 378);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(113, 49);
            this.btnActualizar.TabIndex = 16;
            this.btnActualizar.Text = "Actualizar.";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 542);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.txbAddress);
            this.Controls.Add(this.txbContactTitle);
            this.Controls.Add(this.txbContactName);
            this.Controls.Add(this.txbCompanyName);
            this.Controls.Add(this.txbCustomerId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnObtenerId);
            this.Controls.Add(this.tboxObtenerID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnObtenerTodos);
            this.Controls.Add(this.dgvCustomers);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Button btnObtenerTodos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboxObtenerID;
        private System.Windows.Forms.Button btnObtenerId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbCustomerId;
        private System.Windows.Forms.TextBox txbCompanyName;
        private System.Windows.Forms.TextBox txbContactName;
        private System.Windows.Forms.TextBox txbContactTitle;
        private System.Windows.Forms.TextBox txbAddress;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnActualizar;
    }
}

