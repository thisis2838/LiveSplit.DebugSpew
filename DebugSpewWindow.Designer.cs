
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // boxDebugSpew
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.boxDebugSpew, 5);
            this.boxDebugSpew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boxDebugSpew.Location = new System.Drawing.Point(12, 12);
            this.boxDebugSpew.Multiline = true;
            this.boxDebugSpew.Name = "boxDebugSpew";
            this.boxDebugSpew.ReadOnly = true;
            this.boxDebugSpew.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.boxDebugSpew.Size = new System.Drawing.Size(542, 396);
            this.boxDebugSpew.TabIndex = 0;
            // 
            // butClear
            // 
            this.butClear.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.butClear.Location = new System.Drawing.Point(479, 414);
            this.butClear.Name = "butClear";
            this.butClear.Size = new System.Drawing.Size(75, 23);
            this.butClear.TabIndex = 1;
            this.butClear.Text = "Clear";
            this.butClear.UseVisualStyleBackColor = true;
            this.butClear.Click += new System.EventHandler(this.butClear_Click);
            // 
            // butExport
            // 
            this.butExport.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.butExport.Location = new System.Drawing.Point(393, 414);
            this.butExport.Name = "butExport";
            this.butExport.Size = new System.Drawing.Size(75, 23);
            this.butExport.TabIndex = 2;
            this.butExport.Text = "Export";
            this.butExport.UseVisualStyleBackColor = true;
            this.butExport.Click += new System.EventHandler(this.butExport_Click);
            // 
            // chkOnTop
            // 
            this.chkOnTop.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkOnTop.AutoSize = true;
            this.chkOnTop.Location = new System.Drawing.Point(12, 417);
            this.chkOnTop.Name = "chkOnTop";
            this.chkOnTop.Size = new System.Drawing.Size(98, 17);
            this.chkOnTop.TabIndex = 3;
            this.chkOnTop.Text = "Always On Top";
            this.chkOnTop.UseVisualStyleBackColor = true;
            this.chkOnTop.CheckedChanged += new System.EventHandler(this.chkOnTop_CheckedChanged);
            // 
            // chkAutoScroll
            // 
            this.chkAutoScroll.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkAutoScroll.AutoSize = true;
            this.chkAutoScroll.Location = new System.Drawing.Point(117, 417);
            this.chkAutoScroll.Name = "chkAutoScroll";
            this.chkAutoScroll.Size = new System.Drawing.Size(77, 17);
            this.chkAutoScroll.TabIndex = 4;
            this.chkAutoScroll.Text = "Auto Scroll";
            this.chkAutoScroll.UseVisualStyleBackColor = true;
            this.chkAutoScroll.CheckedChanged += new System.EventHandler(this.chkAutoScroll_CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 195F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 214F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel1.Controls.Add(this.boxDebugSpew, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.chkAutoScroll, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.chkOnTop, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.butClear, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.butExport, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(9);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(566, 450);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // DebugSpewWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(300, 350);
            this.Name = "DebugSpewWindow";
            this.ShowIcon = false;
            this.Text = "Debug Spew Viewer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DoClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TextBox boxDebugSpew;
        private System.Windows.Forms.Button butClear;
        private System.Windows.Forms.Button butExport;
        private System.Windows.Forms.CheckBox chkOnTop;
        private System.Windows.Forms.CheckBox chkAutoScroll;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}