namespace AzureTableApp
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
            this.Applabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TabletextBox = new System.Windows.Forms.TextBox();
            this.IdtextBox = new System.Windows.Forms.TextBox();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.PricetextBox = new System.Windows.Forms.TextBox();
            this.AddDatabutton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Tablebutton = new System.Windows.Forms.Button();
            this.Blobbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Applabel
            // 
            this.Applabel.AutoSize = true;
            this.Applabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Applabel.Location = new System.Drawing.Point(201, 35);
            this.Applabel.Name = "Applabel";
            this.Applabel.Size = new System.Drawing.Size(168, 24);
            this.Applabel.TabIndex = 0;
            this.Applabel.Text = "Azure Table App";
            this.Applabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Azure Table Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Product ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enter Product Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Enter Product Price:";
            // 
            // TabletextBox
            // 
            this.TabletextBox.Location = new System.Drawing.Point(217, 95);
            this.TabletextBox.Name = "TabletextBox";
            this.TabletextBox.Size = new System.Drawing.Size(132, 20);
            this.TabletextBox.TabIndex = 5;
            // 
            // IdtextBox
            // 
            this.IdtextBox.Location = new System.Drawing.Point(217, 137);
            this.IdtextBox.Name = "IdtextBox";
            this.IdtextBox.Size = new System.Drawing.Size(132, 20);
            this.IdtextBox.TabIndex = 6;
            // 
            // NametextBox
            // 
            this.NametextBox.Location = new System.Drawing.Point(217, 172);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(132, 20);
            this.NametextBox.TabIndex = 7;
            // 
            // PricetextBox
            // 
            this.PricetextBox.Location = new System.Drawing.Point(217, 213);
            this.PricetextBox.Name = "PricetextBox";
            this.PricetextBox.Size = new System.Drawing.Size(132, 20);
            this.PricetextBox.TabIndex = 8;
            // 
            // AddDatabutton
            // 
            this.AddDatabutton.Location = new System.Drawing.Point(242, 254);
            this.AddDatabutton.Name = "AddDatabutton";
            this.AddDatabutton.Size = new System.Drawing.Size(75, 23);
            this.AddDatabutton.TabIndex = 9;
            this.AddDatabutton.Text = "Add Data";
            this.AddDatabutton.UseVisualStyleBackColor = true;
            this.AddDatabutton.Click += new System.EventHandler(this.AddDatabutton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(397, 138);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(200, 95);
            this.listBox1.TabIndex = 10;
            // 
            // Tablebutton
            // 
            this.Tablebutton.Location = new System.Drawing.Point(397, 92);
            this.Tablebutton.Name = "Tablebutton";
            this.Tablebutton.Size = new System.Drawing.Size(90, 23);
            this.Tablebutton.TabIndex = 11;
            this.Tablebutton.Text = "Click to Create";
            this.Tablebutton.UseVisualStyleBackColor = true;
            this.Tablebutton.Click += new System.EventHandler(this.Tablebutton_Click);
            // 
            // Blobbutton
            // 
            this.Blobbutton.Location = new System.Drawing.Point(515, 92);
            this.Blobbutton.Name = "Blobbutton";
            this.Blobbutton.Size = new System.Drawing.Size(82, 23);
            this.Blobbutton.TabIndex = 12;
            this.Blobbutton.Text = "List BLobs";
            this.Blobbutton.UseVisualStyleBackColor = true;
            this.Blobbutton.Click += new System.EventHandler(this.Blobbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 310);
            this.Controls.Add(this.Blobbutton);
            this.Controls.Add(this.Tablebutton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.AddDatabutton);
            this.Controls.Add(this.PricetextBox);
            this.Controls.Add(this.NametextBox);
            this.Controls.Add(this.IdtextBox);
            this.Controls.Add(this.TabletextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Applabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Applabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TabletextBox;
        private System.Windows.Forms.TextBox IdtextBox;
        private System.Windows.Forms.TextBox NametextBox;
        private System.Windows.Forms.TextBox PricetextBox;
        private System.Windows.Forms.Button AddDatabutton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Tablebutton;
        private System.Windows.Forms.Button Blobbutton;
    }
}

