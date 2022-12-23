
namespace Monkey_Fox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.urlbox = new System.Windows.Forms.TextBox();
            this.back = new System.Windows.Forms.Button();
            this.web = new System.Windows.Forms.WebBrowser();
            this.next = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.yt = new System.Windows.Forms.Button();
            this.fb = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.fb);
            this.panel1.Controls.Add(this.yt);
            this.panel1.Controls.Add(this.search);
            this.panel1.Controls.Add(this.refresh);
            this.panel1.Controls.Add(this.next);
            this.panel1.Controls.Add(this.back);
            this.panel1.Controls.Add(this.urlbox);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1445, 64);
            this.panel1.TabIndex = 0;
            // 
            // urlbox
            // 
            this.urlbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.urlbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlbox.Location = new System.Drawing.Point(204, 11);
            this.urlbox.Name = "urlbox";
            this.urlbox.Size = new System.Drawing.Size(938, 41);
            this.urlbox.TabIndex = 0;
            this.urlbox.Text = "www.google.com";
            this.urlbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back.BackgroundImage")));
            this.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.back.Location = new System.Drawing.Point(10, 5);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(50, 50);
            this.back.TabIndex = 1;
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // web
            // 
            this.web.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.web.Location = new System.Drawing.Point(2, 70);
            this.web.MinimumSize = new System.Drawing.Size(20, 20);
            this.web.Name = "web";
            this.web.Size = new System.Drawing.Size(1442, 544);
            this.web.TabIndex = 1;
            this.web.Url = new System.Uri("http://www.google.com", System.UriKind.Absolute);
            this.web.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.web_Navigated);
            this.web.ProgressChanged += new System.Windows.Forms.WebBrowserProgressChangedEventHandler(this.web_ProgressChanged);
            // 
            // next
            // 
            this.next.BackColor = System.Drawing.Color.Transparent;
            this.next.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("next.BackgroundImage")));
            this.next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.next.Location = new System.Drawing.Point(76, 5);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(50, 50);
            this.next.TabIndex = 2;
            this.next.UseVisualStyleBackColor = false;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.Color.Transparent;
            this.refresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("refresh.BackgroundImage")));
            this.refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.refresh.Location = new System.Drawing.Point(140, 5);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(50, 50);
            this.refresh.TabIndex = 3;
            this.refresh.UseVisualStyleBackColor = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // search
            // 
            this.search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search.BackColor = System.Drawing.Color.Transparent;
            this.search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("search.BackgroundImage")));
            this.search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.search.Location = new System.Drawing.Point(1148, 7);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(79, 50);
            this.search.TabIndex = 4;
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // yt
            // 
            this.yt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.yt.BackColor = System.Drawing.Color.Transparent;
            this.yt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("yt.BackgroundImage")));
            this.yt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.yt.Location = new System.Drawing.Point(1242, 7);
            this.yt.Name = "yt";
            this.yt.Size = new System.Drawing.Size(87, 50);
            this.yt.TabIndex = 5;
            this.yt.UseVisualStyleBackColor = false;
            this.yt.Click += new System.EventHandler(this.yt_Click);
            // 
            // fb
            // 
            this.fb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fb.BackColor = System.Drawing.Color.Transparent;
            this.fb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fb.BackgroundImage")));
            this.fb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.fb.Location = new System.Drawing.Point(1340, 7);
            this.fb.Name = "fb";
            this.fb.Size = new System.Drawing.Size(88, 50);
            this.fb.TabIndex = 6;
            this.fb.UseVisualStyleBackColor = false;
            this.fb.Click += new System.EventHandler(this.fb_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1448, 617);
            this.Controls.Add(this.web);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Water Fox";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.TextBox urlbox;
        private System.Windows.Forms.WebBrowser web;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button fb;
        private System.Windows.Forms.Button yt;
        private System.Windows.Forms.Button search;
    }
}

