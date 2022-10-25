
namespace ElectroShop.Formularios
{
    partial class Inicio
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2txtUsuario = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2txtContraseña = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2btnAceptar = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(386, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Inicie Sesion Aqui";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::ElectroShop.Properties.Resources._1;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::ElectroShop.Properties.Resources._1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(312, 317);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // guna2txtUsuario
            // 
            this.guna2txtUsuario.Animated = true;
            this.guna2txtUsuario.AutoRoundedCorners = true;
            this.guna2txtUsuario.BorderRadius = 17;
            this.guna2txtUsuario.BorderThickness = 2;
            this.guna2txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2txtUsuario.DefaultText = "Usuario";
            this.guna2txtUsuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2txtUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2txtUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2txtUsuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2txtUsuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2txtUsuario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2txtUsuario.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2txtUsuario.Location = new System.Drawing.Point(362, 107);
            this.guna2txtUsuario.Name = "guna2txtUsuario";
            this.guna2txtUsuario.PasswordChar = '\0';
            this.guna2txtUsuario.PlaceholderText = "";
            this.guna2txtUsuario.SelectedText = "";
            this.guna2txtUsuario.Size = new System.Drawing.Size(200, 36);
            this.guna2txtUsuario.TabIndex = 9;
            // 
            // guna2txtContraseña
            // 
            this.guna2txtContraseña.Animated = true;
            this.guna2txtContraseña.AutoRoundedCorners = true;
            this.guna2txtContraseña.BorderRadius = 17;
            this.guna2txtContraseña.BorderThickness = 2;
            this.guna2txtContraseña.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2txtContraseña.DefaultText = "Contraseña";
            this.guna2txtContraseña.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2txtContraseña.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2txtContraseña.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2txtContraseña.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2txtContraseña.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2txtContraseña.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2txtContraseña.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2txtContraseña.Location = new System.Drawing.Point(362, 167);
            this.guna2txtContraseña.Name = "guna2txtContraseña";
            this.guna2txtContraseña.PasswordChar = '\0';
            this.guna2txtContraseña.PlaceholderText = "";
            this.guna2txtContraseña.SelectedText = "";
            this.guna2txtContraseña.Size = new System.Drawing.Size(200, 36);
            this.guna2txtContraseña.TabIndex = 10;
            // 
            // guna2btnAceptar
            // 
            this.guna2btnAceptar.Animated = true;
            this.guna2btnAceptar.AutoRoundedCorners = true;
            this.guna2btnAceptar.BorderRadius = 12;
            this.guna2btnAceptar.DefaultAutoSize = true;
            this.guna2btnAceptar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2btnAceptar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2btnAceptar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2btnAceptar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2btnAceptar.FillColor = System.Drawing.Color.Blue;
            this.guna2btnAceptar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2btnAceptar.ForeColor = System.Drawing.Color.White;
            this.guna2btnAceptar.Location = new System.Drawing.Point(427, 240);
            this.guna2btnAceptar.Name = "guna2btnAceptar";
            this.guna2btnAceptar.Size = new System.Drawing.Size(72, 27);
            this.guna2btnAceptar.TabIndex = 11;
            this.guna2btnAceptar.Text = "Aceptar";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(633, 317);
            this.Controls.Add(this.guna2btnAceptar);
            this.Controls.Add(this.guna2txtContraseña);
            this.Controls.Add(this.guna2txtUsuario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Inicio";
            this.Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox guna2txtUsuario;
        private Guna.UI2.WinForms.Guna2TextBox guna2txtContraseña;
        private Guna.UI2.WinForms.Guna2Button guna2btnAceptar;
    }
}