namespace Take_Home_Ass_MOVIE
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listposter = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // listposter
            // 
            this.listposter.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("listposter.ImageStream")));
            this.listposter.TransparentColor = System.Drawing.Color.Transparent;
            this.listposter.Images.SetKeyName(0, "Hulk poster.jpg");
            this.listposter.Images.SetKeyName(1, "monsterinc poster.jpg");
            this.listposter.Images.SetKeyName(2, "TheAvengers2012Poster.jpg");
            this.listposter.Images.SetKeyName(3, "Toystory poster.jpg");
            this.listposter.Images.SetKeyName(4, "Gooddinosaur poster.jpg");
            this.listposter.Images.SetKeyName(5, "Bullet_Train_(poster).jpeg");
            this.listposter.Images.SetKeyName(6, "Dilan Poster.jpg");
            this.listposter.Images.SetKeyName(7, "Minion2poster.jpeg");
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(74, 353);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1197, 1034);
            this.panel1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1436, 669);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList listposter;
        private System.Windows.Forms.Panel panel1;
    }
}

