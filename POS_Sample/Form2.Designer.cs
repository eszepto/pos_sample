namespace POS_Sample
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.textTotal = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textCash = new System.Windows.Forms.TextBox();
            this.textBalance = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelCash = new System.Windows.Forms.Label();
            this.labelBalance = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonDone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textTotal
            // 
            this.textTotal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textTotal.Enabled = false;
            this.textTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTotal.Location = new System.Drawing.Point(241, 36);
            this.textTotal.Name = "textTotal";
            this.textTotal.ReadOnly = true;
            this.textTotal.Size = new System.Drawing.Size(226, 35);
            this.textTotal.TabIndex = 1;
            this.textTotal.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textCash
            // 
            this.textCash.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCash.Location = new System.Drawing.Point(241, 105);
            this.textCash.Name = "textCash";
            this.textCash.Size = new System.Drawing.Size(226, 35);
            this.textCash.TabIndex = 0;
            this.textCash.TextChanged += new System.EventHandler(this.TextCash_TextChanged);
            this.textCash.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextCash_KeyPress);
            // 
            // textBalance
            // 
            this.textBalance.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBalance.Location = new System.Drawing.Point(241, 196);
            this.textBalance.Name = "textBalance";
            this.textBalance.ReadOnly = true;
            this.textBalance.Size = new System.Drawing.Size(254, 62);
            this.textBalance.TabIndex = 3;
            this.textBalance.TabStop = false;
            this.textBalance.Visible = false;
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonOK.Enabled = false;
            this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOK.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonOK.Location = new System.Drawing.Point(286, 174);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(136, 75);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(184, 43);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(51, 24);
            this.labelTotal.TabIndex = 5;
            this.labelTotal.Text = "Total";
            // 
            // labelCash
            // 
            this.labelCash.AutoSize = true;
            this.labelCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCash.Location = new System.Drawing.Point(182, 112);
            this.labelCash.Name = "labelCash";
            this.labelCash.Size = new System.Drawing.Size(53, 24);
            this.labelCash.TabIndex = 6;
            this.labelCash.Text = "Cash";
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBalance.Location = new System.Drawing.Point(157, 214);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(78, 24);
            this.labelBalance.TabIndex = 7;
            this.labelBalance.Text = "Balance";
            this.labelBalance.Visible = false;
            // 
            // buttonDone
            // 
            this.buttonDone.BackColor = System.Drawing.Color.LightGreen;
            this.buttonDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDone.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonDone.Location = new System.Drawing.Point(265, 301);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(182, 67);
            this.buttonDone.TabIndex = 9;
            this.buttonDone.Text = "Done !";
            this.buttonDone.UseVisualStyleBackColor = false;
            this.buttonDone.Visible = false;
            this.buttonDone.Click += new System.EventHandler(this.ButtonDone_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 438);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.labelBalance);
            this.Controls.Add(this.labelCash);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBalance);
            this.Controls.Add(this.textCash);
            this.Controls.Add(this.textTotal);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textTotal;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textCash;
        private System.Windows.Forms.TextBox textBalance;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelCash;
        private System.Windows.Forms.Label labelBalance;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buttonDone;
    }
}