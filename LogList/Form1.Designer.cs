
namespace LogList
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
            this.ListLog = new System.Windows.Forms.ListBox();
            this.GetList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListLog
            // 
            this.ListLog.AccessibleName = "";
            this.ListLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ListLog.FormattingEnabled = true;
            this.ListLog.ItemHeight = 31;
            this.ListLog.Location = new System.Drawing.Point(12, 12);
            this.ListLog.Name = "ListLog";
            this.ListLog.Size = new System.Drawing.Size(1103, 345);
            this.ListLog.TabIndex = 0;
            this.ListLog.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // GetList
            // 
            this.GetList.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GetList.Location = new System.Drawing.Point(289, 381);
            this.GetList.Name = "GetList";
            this.GetList.Size = new System.Drawing.Size(579, 86);
            this.GetList.TabIndex = 1;
            this.GetList.Text = "GetLists";
            this.GetList.UseVisualStyleBackColor = true;
            this.GetList.Click += new System.EventHandler(this.GetList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 493);
            this.Controls.Add(this.GetList);
            this.Controls.Add(this.ListLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListLog;
        private System.Windows.Forms.Button GetList;
    }
}

