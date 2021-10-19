
namespace UgadayMelodiyu
{
    partial class fPr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fPr));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.cbAllDirectoty = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(10, 10);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(666, 224);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnSelect.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSelect.Location = new System.Drawing.Point(79, 259);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(255, 52);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "Загрузить композиции";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnClean.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClean.Location = new System.Drawing.Point(349, 259);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(255, 52);
            this.btnClean.TabIndex = 2;
            this.btnClean.Text = "Очистить";
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbAllDirectoty
            // 
            this.cbAllDirectoty.AutoSize = true;
            this.cbAllDirectoty.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cbAllDirectoty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cbAllDirectoty.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbAllDirectoty.Location = new System.Drawing.Point(79, 316);
            this.cbAllDirectoty.Name = "cbAllDirectoty";
            this.cbAllDirectoty.Size = new System.Drawing.Size(189, 28);
            this.cbAllDirectoty.TabIndex = 3;
            this.cbAllDirectoty.Text = "вложенные папки";
            this.cbAllDirectoty.UseVisualStyleBackColor = false;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnOK.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOK.Location = new System.Drawing.Point(349, 316);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(123, 39);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "Принять";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Location = new System.Drawing.Point(480, 316);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(123, 39);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Отменить";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // fPr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cbAllDirectoty);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.listBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fPr";
            this.Text = "Настройки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.CheckBox cbAllDirectoty;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}