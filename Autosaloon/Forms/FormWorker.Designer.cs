namespace Autosaloon
{
    partial class FormWorker
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
            this.bt_Back = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_OpenOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_Back
            // 
            this.bt_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_Back.Location = new System.Drawing.Point(558, 316);
            this.bt_Back.Name = "bt_Back";
            this.bt_Back.Size = new System.Drawing.Size(142, 65);
            this.bt_Back.TabIndex = 5;
            this.bt_Back.Text = "Назад";
            this.bt_Back.UseVisualStyleBackColor = true;
            this.bt_Back.Click += new System.EventHandler(this.bt_Back_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(688, 298);
            this.dataGridView1.TabIndex = 4;
            // 
            // bt_OpenOrder
            // 
            this.bt_OpenOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_OpenOrder.Location = new System.Drawing.Point(410, 316);
            this.bt_OpenOrder.Name = "bt_OpenOrder";
            this.bt_OpenOrder.Size = new System.Drawing.Size(142, 65);
            this.bt_OpenOrder.TabIndex = 3;
            this.bt_OpenOrder.Text = "Принять обращение";
            this.bt_OpenOrder.UseVisualStyleBackColor = true;
            this.bt_OpenOrder.Click += new System.EventHandler(this.bt_OpenOrder_Click);
            // 
            // FormWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 394);
            this.Controls.Add(this.bt_Back);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bt_OpenOrder);
            this.Name = "FormWorker";
            this.Text = "FormWorker";
            this.Load += new System.EventHandler(this.FormWorker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_Back;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_OpenOrder;
    }
}