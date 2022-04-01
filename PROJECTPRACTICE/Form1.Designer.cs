
namespace PROJECTPRACTICE
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.image_load = new System.Windows.Forms.Button();
            this.textimage = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textapply = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.Controls.Add(this.textapply);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.textimage);
            this.panel1.Controls.Add(this.image_load);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(51, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(689, 303);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.PeachPuff;
            this.pictureBox1.Location = new System.Drawing.Point(17, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.PeachPuff;
            this.pictureBox2.Location = new System.Drawing.Point(456, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(169, 164);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // image_load
            // 
            this.image_load.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.image_load.Location = new System.Drawing.Point(45, 198);
            this.image_load.Name = "image_load";
            this.image_load.Size = new System.Drawing.Size(103, 26);
            this.image_load.TabIndex = 2;
            this.image_load.Text = "Load Image";
            this.image_load.UseVisualStyleBackColor = true;
            this.image_load.Click += new System.EventHandler(this.image_load_Click);
            // 
            // textimage
            // 
            this.textimage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textimage.Location = new System.Drawing.Point(201, 241);
            this.textimage.Name = "textimage";
            this.textimage.Size = new System.Drawing.Size(149, 26);
            this.textimage.TabIndex = 3;
            this.textimage.Text = "Add text on image:";
            this.textimage.UseVisualStyleBackColor = true;
            this.textimage.Visible = false;
            this.textimage.Click += new System.EventHandler(this.textimage_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(384, 241);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(265, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Visible = false;
            // 
            // textapply
            // 
            this.textapply.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textapply.Location = new System.Drawing.Point(446, 267);
            this.textapply.Name = "textapply";
            this.textapply.Size = new System.Drawing.Size(116, 24);
            this.textapply.TabIndex = 5;
            this.textapply.Text = "Apply text";
            this.textapply.UseVisualStyleBackColor = true;
            this.textapply.Visible = false;
            this.textapply.Click += new System.EventHandler(this.textapply_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "myapp";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button image_load;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button textimage;
        private System.Windows.Forms.Button textapply;
    }
}

