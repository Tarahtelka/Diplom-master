namespace CreateFile
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.create = new System.Windows.Forms.Button();
            this.deletecolumn = new System.Windows.Forms.Button();
            this.addcolumn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(331, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(263, 17);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(103, 23);
            this.create.TabIndex = 1;
            this.create.Text = "Создать таблицу";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // deletecolumn
            // 
            this.deletecolumn.Location = new System.Drawing.Point(251, 3);
            this.deletecolumn.Name = "deletecolumn";
            this.deletecolumn.Size = new System.Drawing.Size(115, 23);
            this.deletecolumn.TabIndex = 2;
            this.deletecolumn.Text = "Удалить столбец";
            this.deletecolumn.UseVisualStyleBackColor = true;
            this.deletecolumn.Click += new System.EventHandler(this.deletecolumn_Click);
            // 
            // addcolumn
            // 
            this.addcolumn.Location = new System.Drawing.Point(26, 3);
            this.addcolumn.Name = "addcolumn";
            this.addcolumn.Size = new System.Drawing.Size(113, 23);
            this.addcolumn.TabIndex = 3;
            this.addcolumn.Text = "Добавить столбец";
            this.addcolumn.UseVisualStyleBackColor = true;
            this.addcolumn.Click += new System.EventHandler(this.addcolumn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addcolumn);
            this.panel1.Controls.Add(this.deletecolumn);
            this.panel1.Location = new System.Drawing.Point(386, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 280);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.create);
            this.panel2.Location = new System.Drawing.Point(386, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(402, 62);
            this.panel2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Button deletecolumn;
        private System.Windows.Forms.Button addcolumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}