
namespace UgadayMelodiyu
{
    partial class fMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnParam = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlay.Font = new System.Drawing.Font("Minecraft 1.1", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPlay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPlay.Location = new System.Drawing.Point(166, 146);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(475, 60);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Играть";
            this.btnPlay.UseVisualStyleBackColor = false;
            // 
            // btnParam
            // 
            this.btnParam.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnParam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnParam.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnParam.Font = new System.Drawing.Font("Minecraft 1.1", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnParam.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnParam.Location = new System.Drawing.Point(166, 293);
            this.btnParam.Name = "btnParam";
            this.btnParam.Size = new System.Drawing.Size(237, 60);
            this.btnParam.TabIndex = 1;
            this.btnParam.Text = "Настройки";
            this.btnParam.UseVisualStyleBackColor = false;
            this.btnParam.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Minecraft 1.1", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(404, 293);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(237, 60);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Выйти из игры";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnParam);
            this.Controls.Add(this.btnPlay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fMain";
            this.Text = "Угадай мелодию";
            this.Load += new System.EventHandler(this.fMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnParam;
        private System.Windows.Forms.Button btnExit;
    }
}

