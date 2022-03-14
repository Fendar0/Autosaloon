namespace Autosaloon
{
    partial class FormAdmin
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
            this.bt_Add = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_Exit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_work = new System.Windows.Forms.RadioButton();
            this.rb_clients = new System.Windows.Forms.RadioButton();
            this.rb_user = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_Add
            // 
            this.bt_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_Add.Location = new System.Drawing.Point(889, 153);
            this.bt_Add.Name = "bt_Add";
            this.bt_Add.Size = new System.Drawing.Size(154, 65);
            this.bt_Add.TabIndex = 0;
            this.bt_Add.Text = "Добавить пользователя";
            this.bt_Add.UseVisualStyleBackColor = true;
            this.bt_Add.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(833, 277);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // bt_Exit
            // 
            this.bt_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_Exit.Location = new System.Drawing.Point(889, 224);
            this.bt_Exit.Name = "bt_Exit";
            this.bt_Exit.Size = new System.Drawing.Size(154, 65);
            this.bt_Exit.TabIndex = 3;
            this.bt_Exit.Text = "Выход";
            this.bt_Exit.UseVisualStyleBackColor = true;
            this.bt_Exit.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_work);
            this.groupBox1.Controls.Add(this.rb_clients);
            this.groupBox1.Controls.Add(this.rb_user);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(851, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 135);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация о работе";
            // 
            // rb_work
            // 
            this.rb_work.AutoSize = true;
            this.rb_work.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_work.Location = new System.Drawing.Point(6, 102);
            this.rb_work.Name = "rb_work";
            this.rb_work.Size = new System.Drawing.Size(168, 28);
            this.rb_work.TabIndex = 2;
            this.rb_work.Text = "Отчеты работы";
            this.rb_work.UseVisualStyleBackColor = true;
            this.rb_work.CheckedChanged += new System.EventHandler(this.rb_work_CheckedChanged);
            // 
            // rb_clients
            // 
            this.rb_clients.AutoSize = true;
            this.rb_clients.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_clients.Location = new System.Drawing.Point(6, 63);
            this.rb_clients.Name = "rb_clients";
            this.rb_clients.Size = new System.Drawing.Size(106, 28);
            this.rb_clients.TabIndex = 1;
            this.rb_clients.Text = "Клиенты";
            this.rb_clients.UseVisualStyleBackColor = true;
            this.rb_clients.CheckedChanged += new System.EventHandler(this.rb_work_CheckedChanged);
            // 
            // rb_user
            // 
            this.rb_user.AutoSize = true;
            this.rb_user.Checked = true;
            this.rb_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_user.Location = new System.Drawing.Point(6, 28);
            this.rb_user.Name = "rb_user";
            this.rb_user.Size = new System.Drawing.Size(157, 28);
            this.rb_user.TabIndex = 0;
            this.rb_user.TabStop = true;
            this.rb_user.Text = "Пользователи";
            this.rb_user.UseVisualStyleBackColor = true;
            this.rb_user.CheckedChanged += new System.EventHandler(this.rb_work_CheckedChanged);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 298);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_Exit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bt_Add);
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_Add;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_Exit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_work;
        private System.Windows.Forms.RadioButton rb_clients;
        private System.Windows.Forms.RadioButton rb_user;
    }
}