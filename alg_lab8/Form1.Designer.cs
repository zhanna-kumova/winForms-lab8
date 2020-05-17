namespace alg_lab8
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
            this.btn_get = new System.Windows.Forms.Button();
            this.col_exists = new System.Windows.Forms.Label();
            this.column = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(164, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(451, 229);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_get
            // 
            this.btn_get.Location = new System.Drawing.Point(164, 305);
            this.btn_get.Name = "btn_get";
            this.btn_get.Size = new System.Drawing.Size(451, 36);
            this.btn_get.TabIndex = 1;
            this.btn_get.Text = "get column with even numbers";
            this.btn_get.UseVisualStyleBackColor = true;
            this.btn_get.Click += new System.EventHandler(this.btn_get_Click);
            // 
            // col_exists
            // 
            this.col_exists.AutoSize = true;
            this.col_exists.Location = new System.Drawing.Point(301, 370);
            this.col_exists.Name = "col_exists";
            this.col_exists.Size = new System.Drawing.Size(166, 17);
            this.col_exists.TabIndex = 2;
            this.col_exists.Text = "tag of column\'s existence";
            this.col_exists.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // column
            // 
            this.column.AutoSize = true;
            this.column.Location = new System.Drawing.Point(330, 407);
            this.column.Name = "column";
            this.column.Size = new System.Drawing.Size(105, 17);
            this.column.TabIndex = 3;
            this.column.Text = "column number";
            this.column.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.column);
            this.Controls.Add(this.col_exists);
            this.Controls.Add(this.btn_get);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "lab №8";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_get;
        private System.Windows.Forms.Label col_exists;
        private System.Windows.Forms.Label column;
    }
}

