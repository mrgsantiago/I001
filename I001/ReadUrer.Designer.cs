namespace I001
{
    partial class ReadUrer
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
            this.txtRole = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.labelRole = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.pbBackTo = new System.Windows.Forms.PictureBox();
            this.txtName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackTo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRole
            // 
            this.txtRole.Location = new System.Drawing.Point(480, 357);
            this.txtRole.Name = "txtRole";
            this.txtRole.ReadOnly = true;
            this.txtRole.Size = new System.Drawing.Size(233, 20);
            this.txtRole.TabIndex = 66;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(480, 282);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(233, 20);
            this.txtPassword.TabIndex = 65;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(480, 204);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.ReadOnly = true;
            this.txtLogin.Size = new System.Drawing.Size(233, 20);
            this.txtLogin.TabIndex = 64;
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.BackColor = System.Drawing.Color.Transparent;
            this.labelRole.Font = new System.Drawing.Font("Sitka Banner", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRole.Location = new System.Drawing.Point(250, 347);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(187, 30);
            this.labelRole.TabIndex = 63;
            this.labelRole.Text = "Роль пользователя";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelPassword.Font = new System.Drawing.Font("Sitka Banner", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassword.Location = new System.Drawing.Point(250, 272);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(211, 30);
            this.labelPassword.TabIndex = 62;
            this.labelPassword.Text = "Пароль пользователя";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Sitka Banner", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(250, 194);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(199, 30);
            this.labelName.TabIndex = 61;
            this.labelName.Text = "Логин пользователя";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Italic);
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(424, 423);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(175, 35);
            this.btnAdd.TabIndex = 59;
            this.btnAdd.Text = "Закончить просмотр";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Sitka Banner", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.Location = new System.Drawing.Point(250, 120);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(186, 30);
            this.lblName.TabIndex = 58;
            this.lblName.Text = "Имя пользователя";
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.BackColor = System.Drawing.Color.Transparent;
            this.lblText.Font = new System.Drawing.Font("Sitka Banner", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblText.Location = new System.Drawing.Point(290, 42);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(481, 39);
            this.lblText.TabIndex = 57;
            this.lblText.Text = "Просмотр информации о  пользователе";
            // 
            // pbBackTo
            // 
            this.pbBackTo.BackColor = System.Drawing.Color.Transparent;
            this.pbBackTo.BackgroundImage = global::I001.Properties.Resources.strelka;
            this.pbBackTo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBackTo.Location = new System.Drawing.Point(924, 12);
            this.pbBackTo.Name = "pbBackTo";
            this.pbBackTo.Size = new System.Drawing.Size(34, 37);
            this.pbBackTo.TabIndex = 56;
            this.pbBackTo.TabStop = false;
            this.pbBackTo.Click += new System.EventHandler(this.pbBackTo_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(480, 130);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(233, 20);
            this.txtName.TabIndex = 60;
            // 
            // ReadUrer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::I001.Properties.Resources.fotofon;
            this.ClientSize = new System.Drawing.Size(970, 486);
            this.Controls.Add(this.txtRole);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.pbBackTo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReadUrer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Просмотр пользователя";
            ((System.ComponentModel.ISupportInitialize)(this.pbBackTo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.PictureBox pbBackTo;
        private System.Windows.Forms.TextBox txtName;
    }
}