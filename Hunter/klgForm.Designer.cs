using n7aKeylogger;
namespace WindowsFormsApplication1
{
    partial class klgForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(klgForm));
            this.cbKeyloggerEnabled = new System.Windows.Forms.CheckBox();
            this.CleanBtn = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.AppTxt = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.resourcesTxt = new System.Windows.Forms.TextBox();
            this.showElementsTxt = new System.Windows.Forms.TextBox();
            this.keylogger1 = new n7aKeylogger.Keylogger();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbKeyloggerEnabled
            // 
            this.cbKeyloggerEnabled.AutoSize = true;
            this.cbKeyloggerEnabled.Location = new System.Drawing.Point(15, 12);
            this.cbKeyloggerEnabled.Name = "cbKeyloggerEnabled";
            this.cbKeyloggerEnabled.Size = new System.Drawing.Size(115, 17);
            this.cbKeyloggerEnabled.TabIndex = 9;
            this.cbKeyloggerEnabled.Text = "Keylogger Enabled";
            this.cbKeyloggerEnabled.UseVisualStyleBackColor = true;
            this.cbKeyloggerEnabled.CheckedChanged += new System.EventHandler(this.cbKeyloggerEnabled_CheckedChanged);
            // 
            // CleanBtn
            // 
            this.CleanBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CleanBtn.Location = new System.Drawing.Point(12, 35);
            this.CleanBtn.Name = "CleanBtn";
            this.CleanBtn.Size = new System.Drawing.Size(118, 23);
            this.CleanBtn.TabIndex = 16;
            this.CleanBtn.Text = "Clean";
            this.CleanBtn.UseVisualStyleBackColor = true;
            this.CleanBtn.Click += new System.EventHandler(this.CleanBtn_Click);
            // 
            // close
            // 
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Location = new System.Drawing.Point(12, 358);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(118, 23);
            this.close.TabIndex = 18;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(12, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "XML";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AppTxt
            // 
            this.AppTxt.Location = new System.Drawing.Point(12, 117);
            this.AppTxt.Name = "AppTxt";
            this.AppTxt.Size = new System.Drawing.Size(118, 20);
            this.AppTxt.TabIndex = 20;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(169, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.showElementsTxt);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.resourcesTxt);
            this.splitContainer1.Size = new System.Drawing.Size(678, 415);
            this.splitContainer1.SplitterDistance = 241;
            this.splitContainer1.TabIndex = 21;
            // 
            // resourcesTxt
            // 
            this.resourcesTxt.AllowDrop = true;
            this.resourcesTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resourcesTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resourcesTxt.Location = new System.Drawing.Point(17, 3);
            this.resourcesTxt.Multiline = true;
            this.resourcesTxt.Name = "resourcesTxt";
            this.resourcesTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resourcesTxt.Size = new System.Drawing.Size(411, 397);
            this.resourcesTxt.TabIndex = 14;
            // 
            // showElementsTxt
            // 
            this.showElementsTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.showElementsTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showElementsTxt.Location = new System.Drawing.Point(3, 3);
            this.showElementsTxt.Multiline = true;
            this.showElementsTxt.Name = "showElementsTxt";
            this.showElementsTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.showElementsTxt.Size = new System.Drawing.Size(220, 393);
            this.showElementsTxt.TabIndex = 22;
            // 
            // keylogger1
            // 
            this.keylogger1.Enabled = false;
            this.keylogger1.Keylogger_Mode = n7aKeylogger.Keylogger.Keylogger_Modes.Hooks;
            this.keylogger1.VKCodeAsStringDown += new n7aKeylogger.Keylogger.ValueChangedEventHandler(this.keylogger1_VKCodeAsStringDown);
            // 
            // klgForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 439);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.AppTxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.close);
            this.Controls.Add(this.CleanBtn);
            this.Controls.Add(this.cbKeyloggerEnabled);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "klgForm";
            this.Text = "Hunter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.klgForm_FormClosing);
            this.Load += new System.EventHandler(this.klgForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Keylogger keylogger1;
        private System.Windows.Forms.CheckBox cbKeyloggerEnabled;
        private System.Windows.Forms.Button CleanBtn;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox AppTxt;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox showElementsTxt;
        private System.Windows.Forms.TextBox resourcesTxt;
    }
}

