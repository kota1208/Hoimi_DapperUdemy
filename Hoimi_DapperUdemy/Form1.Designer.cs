namespace Hoimi_DapperUdemy
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.DataTableReadButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ReaderReadButton = new System.Windows.Forms.Button();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.productPriceTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.DapperReadButton = new System.Windows.Forms.Button();
            this.DapperInsertButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTableReadButton
            // 
            this.DataTableReadButton.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DataTableReadButton.Location = new System.Drawing.Point(12, 21);
            this.DataTableReadButton.Name = "DataTableReadButton";
            this.DataTableReadButton.Size = new System.Drawing.Size(389, 83);
            this.DataTableReadButton.TabIndex = 0;
            this.DataTableReadButton.Text = "DataTableRead";
            this.DataTableReadButton.UseVisualStyleBackColor = true;
            this.DataTableReadButton.Click += new System.EventHandler(this.DataTableReadButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(417, 441);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1018, 253);
            this.dataGridView1.TabIndex = 1;
            // 
            // ReaderReadButton
            // 
            this.ReaderReadButton.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ReaderReadButton.Location = new System.Drawing.Point(13, 124);
            this.ReaderReadButton.Name = "ReaderReadButton";
            this.ReaderReadButton.Size = new System.Drawing.Size(389, 83);
            this.ReaderReadButton.TabIndex = 2;
            this.ReaderReadButton.Text = "ReaderRead";
            this.ReaderReadButton.UseVisualStyleBackColor = true;
            this.ReaderReadButton.Click += new System.EventHandler(this.ReaderReadButton_Click);
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.productNameTextBox.Location = new System.Drawing.Point(736, 129);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(378, 47);
            this.productNameTextBox.TabIndex = 4;
            this.productNameTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // productPriceTextBox
            // 
            this.productPriceTextBox.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.productPriceTextBox.Location = new System.Drawing.Point(1132, 129);
            this.productPriceTextBox.Name = "productPriceTextBox";
            this.productPriceTextBox.Size = new System.Drawing.Size(378, 47);
            this.productPriceTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(741, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(557, 52);
            this.label1.TabIndex = 6;
            this.label1.Text = "商品名、価格の順で入力";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(12, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(389, 83);
            this.button1.TabIndex = 7;
            this.button1.Text = "InsertCommand";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DapperReadButton
            // 
            this.DapperReadButton.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DapperReadButton.Location = new System.Drawing.Point(12, 359);
            this.DapperReadButton.Name = "DapperReadButton";
            this.DapperReadButton.Size = new System.Drawing.Size(389, 83);
            this.DapperReadButton.TabIndex = 8;
            this.DapperReadButton.Text = "DapperRead";
            this.DapperReadButton.UseVisualStyleBackColor = true;
            this.DapperReadButton.Click += new System.EventHandler(this.DapperReadButton_Click);
            // 
            // DapperInsertButton
            // 
            this.DapperInsertButton.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DapperInsertButton.Location = new System.Drawing.Point(12, 475);
            this.DapperInsertButton.Name = "DapperInsertButton";
            this.DapperInsertButton.Size = new System.Drawing.Size(389, 83);
            this.DapperInsertButton.TabIndex = 9;
            this.DapperInsertButton.Text = "DapperInsert";
            this.DapperInsertButton.UseVisualStyleBackColor = true;
            this.DapperInsertButton.Click += new System.EventHandler(this.DapperInsertButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1481, 737);
            this.Controls.Add(this.DapperInsertButton);
            this.Controls.Add(this.DapperReadButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productPriceTextBox);
            this.Controls.Add(this.productNameTextBox);
            this.Controls.Add(this.ReaderReadButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DataTableReadButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DataTableReadButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ReaderReadButton;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.TextBox productPriceTextBox;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button DapperReadButton;
        private System.Windows.Forms.Button DapperInsertButton;
    }
}

