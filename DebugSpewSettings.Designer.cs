
namespace LiveSplit.DebugSpew
{
    partial class DebugSpewSettings
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
            this.butOpenView = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butOpenView
            // 
            this.butOpenView.Location = new System.Drawing.Point(7, 3);
            this.butOpenView.Name = "butOpenView";
            this.butOpenView.Size = new System.Drawing.Size(463, 23);
            this.butOpenView.TabIndex = 0;
            this.butOpenView.Text = "Open Debug View";
            this.butOpenView.UseVisualStyleBackColor = true;
            this.butOpenView.Click += new System.EventHandler(this.butOpenView_Click);
            // 
            // DebugSpewSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.butOpenView);
            this.Name = "DebugSpewSettings";
            this.Size = new System.Drawing.Size(470, 449);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butOpenView;
    }
}
