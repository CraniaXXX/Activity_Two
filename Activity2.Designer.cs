namespace WindowsFormsApplication4
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
            this.WishList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fill = new System.Windows.Forms.Button();
            this.sort = new System.Windows.Forms.Button();
            this.count = new System.Windows.Forms.Button();
            this.sectionBox = new System.Windows.Forms.TextBox();
            this.countBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WishList
            // 
            this.WishList.FormattingEnabled = true;
            this.WishList.Location = new System.Drawing.Point(64, 105);
            this.WishList.Name = "WishList";
            this.WishList.Size = new System.Drawing.Size(191, 186);
            this.WishList.TabIndex = 0;
            this.WishList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "WishList";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // fill
            // 
            this.fill.Location = new System.Drawing.Point(320, 115);
            this.fill.Name = "fill";
            this.fill.Size = new System.Drawing.Size(75, 23);
            this.fill.TabIndex = 2;
            this.fill.Text = "fill";
            this.fill.UseVisualStyleBackColor = true;
            this.fill.Click += new System.EventHandler(this.button1_Click);
            // 
            // sort
            // 
            this.sort.Location = new System.Drawing.Point(320, 154);
            this.sort.Name = "sort";
            this.sort.Size = new System.Drawing.Size(75, 23);
            this.sort.TabIndex = 3;
            this.sort.Text = "sort";
            this.sort.UseVisualStyleBackColor = true;
            this.sort.Click += new System.EventHandler(this.button2_Click);
            // 
            // count
            // 
            this.count.Location = new System.Drawing.Point(320, 237);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(75, 23);
            this.count.TabIndex = 4;
            this.count.Text = "count";
            this.count.UseVisualStyleBackColor = true;
            this.count.Click += new System.EventHandler(this.button3_Click);
            // 
            // sectionBox
            // 
            this.sectionBox.Location = new System.Drawing.Point(155, 338);
            this.sectionBox.Name = "sectionBox";
            this.sectionBox.Size = new System.Drawing.Size(100, 20);
            this.sectionBox.TabIndex = 5;
            this.sectionBox.TextChanged += new System.EventHandler(this.sectionBox_TextChanged);
            // 
            // countBox
            // 
            this.countBox.Location = new System.Drawing.Point(155, 413);
            this.countBox.Name = "countBox";
            this.countBox.Size = new System.Drawing.Size(100, 20);
            this.countBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Section";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 413);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "selection";
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(320, 196);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 15;
            this.clear.Text = "clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(320, 276);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 16;
            this.close.Text = "close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 530);
            this.Controls.Add(this.close);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.countBox);
            this.Controls.Add(this.sectionBox);
            this.Controls.Add(this.count);
            this.Controls.Add(this.sort);
            this.Controls.Add(this.fill);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WishList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox WishList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button fill;
        private System.Windows.Forms.Button sort;
        private System.Windows.Forms.Button count;
        private System.Windows.Forms.TextBox sectionBox;
        private System.Windows.Forms.TextBox countBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button close;
    }
}

