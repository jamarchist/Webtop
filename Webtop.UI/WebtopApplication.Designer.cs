namespace Webtop.UI
{
    partial class WebtopApplication
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
            this.viewWindow = new WebKit.WebKitBrowser();
            this.SuspendLayout();
            // 
            // viewWindow
            // 
            this.viewWindow.BackColor = System.Drawing.Color.White;
            this.viewWindow.Location = new System.Drawing.Point(0, 0);
            this.viewWindow.Name = "viewWindow";
            this.viewWindow.Size = new System.Drawing.Size(713, 500);
            this.viewWindow.TabIndex = 0;
            this.viewWindow.Url = null;
            // 
            // WebtopApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 500);
            this.Controls.Add(this.viewWindow);
            this.Name = "WebtopApplication";
            this.Text = "Webtop Application";
            this.ResumeLayout(false);

        }

        #endregion

        private WebKit.WebKitBrowser viewWindow;
    }
}

