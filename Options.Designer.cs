namespace BrowSharp1
{
    partial class Options
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.engineTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lightRadio = new System.Windows.Forms.RadioButton();
            this.darkRadio = new System.Windows.Forms.RadioButton();
            this.blackRadio = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBtn.Location = new System.Drawing.Point(222, 103);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(98, 28);
            this.saveBtn.TabIndex = 0;
            this.saveBtn.Text = "OK";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.Location = new System.Drawing.Point(118, 103);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(98, 28);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search engine";
            // 
            // engineTextbox
            // 
            this.engineTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.engineTextbox.Location = new System.Drawing.Point(118, 6);
            this.engineTextbox.Name = "engineTextbox";
            this.engineTextbox.Size = new System.Drawing.Size(202, 20);
            this.engineTextbox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Theme";
            // 
            // lightRadio
            // 
            this.lightRadio.AutoSize = true;
            this.lightRadio.Location = new System.Drawing.Point(118, 33);
            this.lightRadio.Name = "lightRadio";
            this.lightRadio.Size = new System.Drawing.Size(48, 17);
            this.lightRadio.TabIndex = 5;
            this.lightRadio.TabStop = true;
            this.lightRadio.Text = "Light";
            this.lightRadio.UseVisualStyleBackColor = true;
            // 
            // darkRadio
            // 
            this.darkRadio.AutoSize = true;
            this.darkRadio.Location = new System.Drawing.Point(172, 33);
            this.darkRadio.Name = "darkRadio";
            this.darkRadio.Size = new System.Drawing.Size(48, 17);
            this.darkRadio.TabIndex = 6;
            this.darkRadio.TabStop = true;
            this.darkRadio.Text = "Dark";
            this.darkRadio.UseVisualStyleBackColor = true;
            // 
            // blackRadio
            // 
            this.blackRadio.AutoSize = true;
            this.blackRadio.Location = new System.Drawing.Point(226, 33);
            this.blackRadio.Name = "blackRadio";
            this.blackRadio.Size = new System.Drawing.Size(52, 17);
            this.blackRadio.TabIndex = 7;
            this.blackRadio.TabStop = true;
            this.blackRadio.Text = "Black";
            this.blackRadio.UseVisualStyleBackColor = true;
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 143);
            this.Controls.Add(this.blackRadio);
            this.Controls.Add(this.darkRadio);
            this.Controls.Add(this.lightRadio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.engineTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Options";
            this.Text = "Options";
            this.Load += new System.EventHandler(this.Options_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox engineTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton lightRadio;
        private System.Windows.Forms.RadioButton darkRadio;
        private System.Windows.Forms.RadioButton blackRadio;
    }
}