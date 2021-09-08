namespace WinFormsProj
{
    partial class FormBonus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBonus));
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonCloseBonus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Скидка 15% на первый заказ. Промокод: FIRSTORDER\r\n_______________________________" +
    "___________________";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(307, 52);
            this.label4.TabIndex = 3;
            this.label4.Text = "Закажите маленькую пиццу с курицей и Pepsi\r\nи получите скидку 10%.\r\nПромокод: CHI" +
    "CKENPEPSI\r\n__________________________________________________\r\n";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonCloseBonus
            // 
            this.buttonCloseBonus.Location = new System.Drawing.Point(104, 124);
            this.buttonCloseBonus.Name = "buttonCloseBonus";
            this.buttonCloseBonus.Size = new System.Drawing.Size(122, 23);
            this.buttonCloseBonus.TabIndex = 4;
            this.buttonCloseBonus.Text = "Закрыть";
            this.buttonCloseBonus.UseVisualStyleBackColor = true;
            this.buttonCloseBonus.Click += new System.EventHandler(this.buttonCloseBonus_Click);
            // 
            // FormBonus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 162);
            this.ControlBox = false;
            this.Controls.Add(this.buttonCloseBonus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBonus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Бонусные предложения";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonCloseBonus;
    }
}