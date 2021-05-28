namespace CookieClicker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Koekje = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.KpsValue = new System.Windows.Forms.Label();
            this.KoekjesValue = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BT_deegroller = new System.Windows.Forms.Button();
            this.BT_Oven = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BT_Bakker = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Koekje)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Koekje
            // 
            this.Koekje.Image = ((System.Drawing.Image)(resources.GetObject("Koekje.Image")));
            this.Koekje.Location = new System.Drawing.Point(38, 110);
            this.Koekje.Name = "Koekje";
            this.Koekje.Size = new System.Drawing.Size(265, 190);
            this.Koekje.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Koekje.TabIndex = 0;
            this.Koekje.TabStop = false;
            this.Koekje.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Koekje_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(354, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kps:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(354, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Koekjes: ";
            // 
            // KpsValue
            // 
            this.KpsValue.AutoSize = true;
            this.KpsValue.Location = new System.Drawing.Point(396, 32);
            this.KpsValue.Name = "KpsValue";
            this.KpsValue.Size = new System.Drawing.Size(17, 20);
            this.KpsValue.TabIndex = 3;
            this.KpsValue.Text = "0";
            // 
            // KoekjesValue
            // 
            this.KoekjesValue.AutoSize = true;
            this.KoekjesValue.Location = new System.Drawing.Point(428, 56);
            this.KoekjesValue.Name = "KoekjesValue";
            this.KoekjesValue.Size = new System.Drawing.Size(17, 20);
            this.KoekjesValue.TabIndex = 4;
            this.KoekjesValue.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.BT_deegroller);
            this.groupBox1.Controls.Add(this.BT_Oven);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.BT_Bakker);
            this.groupBox1.Location = new System.Drawing.Point(354, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 289);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Upgrades";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(278, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "+ 10 per Klik";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(278, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "+ 50 Kps";
            // 
            // BT_deegroller
            // 
            this.BT_deegroller.Location = new System.Drawing.Point(20, 158);
            this.BT_deegroller.Name = "BT_deegroller";
            this.BT_deegroller.Size = new System.Drawing.Size(252, 58);
            this.BT_deegroller.TabIndex = 0;
            this.BT_deegroller.Text = "Deegroller (3500) : 0";
            this.BT_deegroller.UseVisualStyleBackColor = true;
            this.BT_deegroller.Click += new System.EventHandler(this.BT_deegroller_Click);
            // 
            // BT_Oven
            // 
            this.BT_Oven.Location = new System.Drawing.Point(20, 94);
            this.BT_Oven.Name = "BT_Oven";
            this.BT_Oven.Size = new System.Drawing.Size(252, 58);
            this.BT_Oven.TabIndex = 0;
            this.BT_Oven.Text = "Oven (2000) : 0";
            this.BT_Oven.UseVisualStyleBackColor = true;
            this.BT_Oven.Click += new System.EventHandler(this.BT_Oven_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "+ 10 Kps";
            // 
            // BT_bakker
            // 
            this.BT_Bakker.Location = new System.Drawing.Point(20, 30);
            this.BT_Bakker.Name = "BT_bakker";
            this.BT_Bakker.Size = new System.Drawing.Size(252, 58);
            this.BT_Bakker.TabIndex = 0;
            this.BT_Bakker.Text = "Bakker (100) : 0";
            this.BT_Bakker.UseVisualStyleBackColor = true;
            this.BT_Bakker.Click += new System.EventHandler(this.BT_bakker_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.KoekjesValue);
            this.Controls.Add(this.KpsValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Koekje);
            this.Name = "Form1";
            this.Text = "CookieClicker";
            ((System.ComponentModel.ISupportInitialize)(this.Koekje)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Koekje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label KpsValue;
        private System.Windows.Forms.Label KoekjesValue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BT_deegroller;
        private System.Windows.Forms.Button BT_Oven;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BT_Bakker;
        private System.Windows.Forms.Timer timer1;
    }
}

