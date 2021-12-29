
namespace Project_2110083
{
    partial class IPvalidator
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
            this.lbDate = new System.Windows.Forms.Label();
            this.lbipaddres = new System.Windows.Forms.Label();
            this.btnExittemp = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.txBxIp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.Location = new System.Drawing.Point(148, 57);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(78, 17);
            this.lbDate.TabIndex = 0;
            this.lbDate.Text = "Today is  : ";
            // 
            // lbipaddres
            // 
            this.lbipaddres.AutoSize = true;
            this.lbipaddres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbipaddres.Location = new System.Drawing.Point(42, 136);
            this.lbipaddres.Name = "lbipaddres";
            this.lbipaddres.Size = new System.Drawing.Size(122, 17);
            this.lbipaddres.TabIndex = 1;
            this.lbipaddres.Text = "Enter IP Address :";
            // 
            // btnExittemp
            // 
            this.btnExittemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExittemp.Location = new System.Drawing.Point(287, 249);
            this.btnExittemp.Name = "btnExittemp";
            this.btnExittemp.Size = new System.Drawing.Size(98, 31);
            this.btnExittemp.TabIndex = 16;
            this.btnExittemp.Text = "E&xit";
            this.btnExittemp.UseVisualStyleBackColor = true;
            this.btnExittemp.Click += new System.EventHandler(this.btnExittemp_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(172, 249);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(98, 31);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.Location = new System.Drawing.Point(59, 249);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(98, 31);
            this.btnConvert.TabIndex = 14;
            this.btnConvert.Text = "Validate IP";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // txBxIp
            // 
            this.txBxIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBxIp.Location = new System.Drawing.Point(176, 136);
            this.txBxIp.Name = "txBxIp";
            this.txBxIp.Size = new System.Drawing.Size(209, 23);
            this.txBxIp.TabIndex = 17;
            // 
            // IPvalidator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 357);
            this.Controls.Add(this.txBxIp);
            this.Controls.Add(this.btnExittemp);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.lbipaddres);
            this.Controls.Add(this.lbDate);
            this.Name = "IPvalidator";
            this.Text = "IPV4 Validator -  Albelis";
            this.Load += new System.EventHandler(this.IPvalidator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbipaddres;
        private System.Windows.Forms.Button btnExittemp;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox txBxIp;
    }
}