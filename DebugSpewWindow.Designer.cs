
namespace LiveSplit.DebugSpew
{
    partial class DebugSpewWindow
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
            this.boxDebugSpew = new System.Windows.Forms.TextBox();
            this.butClear = new System.Windows.Forms.Button();
            this.butExport = new System.Windows.Forms.Button();
            this.chkOnTop = new System.Windows.Forms.CheckBox();
            this.chkAutoScroll = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // boxDebugSpew
            // 
            this.boxDebugSpew.Location = new System.Drawing.Point(12, 12);
            this.boxDebugSpew.Multiline = true;
            this.boxDebugSpew.Name = "boxDebugSpew";
            this.boxDebugSpew.ReadOnly = true;
            this.boxDebugSpew.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.boxDebugSpew.Size = new System.Drawing.Size(542, 397);
            this.boxDebugSpew.TabIndex = 0;
            // 
            // butClear
            // 
            this.butClear.Location = new System.Drawing.Point(479, 415);
            this.butClear.Name = "butClear";
            this.butClear.Size = new System.Drawing.Size(75, 23);
            this.butClear.TabIndex = 1;
            this.butClear.Text = "Clear";
            this.butClear.UseVisualStyleBackColor = true;
            this.butClear.Click += new System.EventHandler(this.butClear_Click);
            // 
            // butExport
            // 
            this.butExport.Location = new System.Drawing.Point(398, 415);
            this.butExport.Name = "butExport";
            this.butExport.Size = new System.Drawing.Size(75, 23);
            this.butExport.TabIndex = 2;
            this.butExport.Text = "Export";
            this.butExport.UseVisualStyleBackColor = true;
            this.butExport.Click += new System.EventHandler(this.butExport_Click);
            // 
            // chkOnTop
            // 
            this.chkOnTop.AutoSize = true;
            this.chkOnTop.Location = new System.Drawing.Point(12, 419);
            this.chkOnTop.Name = "chkOnTop";
            this.chkOnTop.Size = new System.Drawing.Size(98, 17);
            this.chkOnTop.TabIndex = 3;
            this.chkOnTop.Text = "Always On Top";
            this.chkOnTop.UseVisualStyleBackColor = true;
            this.chkOnTop.CheckedChanged += new System.EventHandler(this.chkOnTop_CheckedChanged);
            // 
            // chkAutoScroll
            // 
            this.chkAutoScroll.AutoSize = true;
            this.chkAutoScroll.Location = new System.Drawing.Point(116, 419);
            this.chkAutoScroll.Name = "chkAutoScroll";
            this.chkAutoScroll.Size = new System.Drawing.Size(77, 17);
            this.chkAutoScroll.TabIndex = 4;
            this.chkAutoScroll.Text = "Auto Scroll";
            this.chkAutoScroll.UseVisualStyleBackColor = true;
            this.chkAutoScroll.CheckedChanged += new System.EventHandler(this.chkAutoScroll_CheckedChanged);
            // 
            // DebugSpewWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 450);
            this.Controls.Add(this.chkAutoScroll);
            this.Controls.Add(this.chkOnTop);
            this.Controls.Add(this.butExport);
            this.Controls.Add(this.butClear);
            this.Controls.Add(this.boxDebugSpew);
            this.MinimumSize = new System.Drawing.Size(300, 125);
            this.Name = "DebugSpewWindow";
            this.Text = "Debug Spew Viewer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DoClosing);
            this.Resize += new System.EventHandler(this.OnResize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox boxDebugSpew;
        private System.Windows.Forms.Button butClear;
        private System.Windows.Forms.Button butExport;
        private System.Windows.Forms.CheckBox chkOnTop;
        private System.Windows.Forms.CheckBox chkAutoScroll;
    }
}