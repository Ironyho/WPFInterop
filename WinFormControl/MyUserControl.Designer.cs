namespace WinFormControl
{
    partial class MyUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._infoLabel = new System.Windows.Forms.Label();
            this._wpfHost = new System.Windows.Forms.Integration.ElementHost();
            this._wpfControl = new WpfControl.MyControl();
            this.SuspendLayout();
            // 
            // _infoLabel
            // 
            this._infoLabel.AutoSize = true;
            this._infoLabel.Location = new System.Drawing.Point(183, 308);
            this._infoLabel.Name = "_infoLabel";
            this._infoLabel.Size = new System.Drawing.Size(122, 13);
            this._infoLabel.TabIndex = 3;
            this._infoLabel.Text = "User Control of WinForm";
            // 
            // _wpfHost
            // 
            this._wpfHost.Location = new System.Drawing.Point(22, 20);
            this._wpfHost.Name = "_wpfHost";
            this._wpfHost.Size = new System.Drawing.Size(458, 267);
            this._wpfHost.TabIndex = 2;
            this._wpfHost.Text = "WpfHost";
            this._wpfHost.Child = this._wpfControl;
            // 
            // MyUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Controls.Add(this._infoLabel);
            this.Controls.Add(this._wpfHost);
            this.Name = "MyUserControl";
            this.Size = new System.Drawing.Size(504, 338);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _infoLabel;
        private System.Windows.Forms.Integration.ElementHost _wpfHost;
        private WpfControl.MyControl _wpfControl;
    }
}
