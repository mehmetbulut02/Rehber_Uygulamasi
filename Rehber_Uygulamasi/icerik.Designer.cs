﻿namespace Rehber_Uygulamasi
{
    partial class icerik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(icerik));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.veriEklemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veriSilmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veriDüzenlemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(54, 227);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(691, 211);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.BackgroundImage = global::Rehber_Uygulamasi.Properties.Resources.kişi_sorgu_Photoroom;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(585, 28);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 144);
            this.button3.TabIndex = 3;
            this.toolTip1.SetToolTip(this.button3, "Düzenleme İşlemi");
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.BackgroundImage = global::Rehber_Uygulamasi.Properties.Resources.output__1_;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(321, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 144);
            this.button2.TabIndex = 2;
            this.toolTip1.SetToolTip(this.button2, "Silme İşlemi");
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.BackgroundImage = global::Rehber_Uygulamasi.Properties.Resources.output;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(54, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 144);
            this.button1.TabIndex = 1;
            this.toolTip1.SetToolTip(this.button1, "Kayıt İşlemi");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.veriEklemeToolStripMenuItem,
            this.veriSilmeToolStripMenuItem,
            this.veriDüzenlemeToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(183, 100);
            // 
            // veriEklemeToolStripMenuItem
            // 
            this.veriEklemeToolStripMenuItem.Name = "veriEklemeToolStripMenuItem";
            this.veriEklemeToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.veriEklemeToolStripMenuItem.Text = "Veri Ekleme";
            // 
            // veriSilmeToolStripMenuItem
            // 
            this.veriSilmeToolStripMenuItem.Name = "veriSilmeToolStripMenuItem";
            this.veriSilmeToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.veriSilmeToolStripMenuItem.Text = "Veri Silme";
            // 
            // veriDüzenlemeToolStripMenuItem
            // 
            this.veriDüzenlemeToolStripMenuItem.Name = "veriDüzenlemeToolStripMenuItem";
            this.veriDüzenlemeToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.veriDüzenlemeToolStripMenuItem.Text = "Veri Düzenleme";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(586, 190);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 22);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(527, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Arama :";
            // 
            // icerik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "icerik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rehber Uygulaması";
            this.Load += new System.EventHandler(this.icerik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem veriEklemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veriSilmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veriDüzenlemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}