﻿
namespace CLIENTE
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.signin_groupBox = new System.Windows.Forms.GroupBox();
            this.sign_in_button = new System.Windows.Forms.Button();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.password_lbl = new System.Windows.Forms.Label();
            this.usuario_txt = new System.Windows.Forms.TextBox();
            this.user_label = new System.Windows.Forms.Label();
            this.peticiones_groupBox = new System.Windows.Forms.GroupBox();
            this.enviar_button = new System.Windows.Forms.Button();
            this.nivelMasAlto_radiobtn = new System.Windows.Forms.RadioButton();
            this.partidas_ganadas_radiobtn = new System.Windows.Forms.RadioButton();
            this.nivel_radiobtn = new System.Windows.Forms.RadioButton();
            this.user_txt = new System.Windows.Forms.TextBox();
            this.user_lbl = new System.Windows.Forms.Label();
            this.conectar_button = new System.Windows.Forms.Button();
            this.desconectar_button = new System.Windows.Forms.Button();
            this.servicios_btn = new System.Windows.Forms.Button();
            this.cont_lbl = new System.Windows.Forms.Label();
            this.juga_btn = new System.Windows.Forms.Button();
            this.ListaConectados_btn = new System.Windows.Forms.Button();
            this.ListaConectados_lbl = new System.Windows.Forms.Label();
            this.signin_groupBox.SuspendLayout();
            this.peticiones_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // signin_groupBox
            // 
            this.signin_groupBox.Controls.Add(this.sign_in_button);
            this.signin_groupBox.Controls.Add(this.password_txt);
            this.signin_groupBox.Controls.Add(this.password_lbl);
            this.signin_groupBox.Controls.Add(this.usuario_txt);
            this.signin_groupBox.Controls.Add(this.user_label);
            this.signin_groupBox.Location = new System.Drawing.Point(26, 132);
            this.signin_groupBox.Name = "signin_groupBox";
            this.signin_groupBox.Size = new System.Drawing.Size(256, 214);
            this.signin_groupBox.TabIndex = 0;
            this.signin_groupBox.TabStop = false;
            this.signin_groupBox.Text = "INICIAR SESION";
            // 
            // sign_in_button
            // 
            this.sign_in_button.Location = new System.Drawing.Point(48, 145);
            this.sign_in_button.Name = "sign_in_button";
            this.sign_in_button.Size = new System.Drawing.Size(151, 40);
            this.sign_in_button.TabIndex = 1;
            this.sign_in_button.Text = "SIGN IN";
            this.sign_in_button.UseVisualStyleBackColor = true;
            this.sign_in_button.Click += new System.EventHandler(this.sign_in_button_Click);
            // 
            // password_txt
            // 
            this.password_txt.Location = new System.Drawing.Point(134, 84);
            this.password_txt.Name = "password_txt";
            this.password_txt.PasswordChar = '*';
            this.password_txt.Size = new System.Drawing.Size(100, 26);
            this.password_txt.TabIndex = 1;
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.Location = new System.Drawing.Point(23, 90);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(92, 20);
            this.password_lbl.TabIndex = 1;
            this.password_lbl.Text = "Contraseña";
            // 
            // usuario_txt
            // 
            this.usuario_txt.Location = new System.Drawing.Point(134, 43);
            this.usuario_txt.Name = "usuario_txt";
            this.usuario_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.usuario_txt.Size = new System.Drawing.Size(100, 26);
            this.usuario_txt.TabIndex = 1;
            this.usuario_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // user_label
            // 
            this.user_label.AutoSize = true;
            this.user_label.Location = new System.Drawing.Point(23, 46);
            this.user_label.Name = "user_label";
            this.user_label.Size = new System.Drawing.Size(64, 20);
            this.user_label.TabIndex = 1;
            this.user_label.Text = "Usuario";
            // 
            // peticiones_groupBox
            // 
            this.peticiones_groupBox.Controls.Add(this.enviar_button);
            this.peticiones_groupBox.Controls.Add(this.nivelMasAlto_radiobtn);
            this.peticiones_groupBox.Controls.Add(this.partidas_ganadas_radiobtn);
            this.peticiones_groupBox.Controls.Add(this.nivel_radiobtn);
            this.peticiones_groupBox.Controls.Add(this.user_txt);
            this.peticiones_groupBox.Controls.Add(this.user_lbl);
            this.peticiones_groupBox.Location = new System.Drawing.Point(288, 132);
            this.peticiones_groupBox.Name = "peticiones_groupBox";
            this.peticiones_groupBox.Size = new System.Drawing.Size(241, 275);
            this.peticiones_groupBox.TabIndex = 1;
            this.peticiones_groupBox.TabStop = false;
            this.peticiones_groupBox.Text = "PETICIONES";
            // 
            // enviar_button
            // 
            this.enviar_button.Location = new System.Drawing.Point(65, 208);
            this.enviar_button.Name = "enviar_button";
            this.enviar_button.Size = new System.Drawing.Size(116, 33);
            this.enviar_button.TabIndex = 5;
            this.enviar_button.Text = "ENVIAR";
            this.enviar_button.UseVisualStyleBackColor = true;
            this.enviar_button.Click += new System.EventHandler(this.enviar_button_Click);
            // 
            // nivelMasAlto_radiobtn
            // 
            this.nivelMasAlto_radiobtn.AutoSize = true;
            this.nivelMasAlto_radiobtn.Location = new System.Drawing.Point(36, 150);
            this.nivelMasAlto_radiobtn.Name = "nivelMasAlto_radiobtn";
            this.nivelMasAlto_radiobtn.Size = new System.Drawing.Size(131, 24);
            this.nivelMasAlto_radiobtn.TabIndex = 4;
            this.nivelMasAlto_radiobtn.TabStop = true;
            this.nivelMasAlto_radiobtn.Text = "Nivel mas alto";
            this.nivelMasAlto_radiobtn.UseVisualStyleBackColor = true;
            // 
            // partidas_ganadas_radiobtn
            // 
            this.partidas_ganadas_radiobtn.AutoSize = true;
            this.partidas_ganadas_radiobtn.Location = new System.Drawing.Point(36, 120);
            this.partidas_ganadas_radiobtn.Name = "partidas_ganadas_radiobtn";
            this.partidas_ganadas_radiobtn.Size = new System.Drawing.Size(162, 24);
            this.partidas_ganadas_radiobtn.TabIndex = 3;
            this.partidas_ganadas_radiobtn.TabStop = true;
            this.partidas_ganadas_radiobtn.Text = "Partidas Ganadas";
            this.partidas_ganadas_radiobtn.UseVisualStyleBackColor = true;
            // 
            // nivel_radiobtn
            // 
            this.nivel_radiobtn.AutoSize = true;
            this.nivel_radiobtn.Location = new System.Drawing.Point(36, 90);
            this.nivel_radiobtn.Name = "nivel_radiobtn";
            this.nivel_radiobtn.Size = new System.Drawing.Size(67, 24);
            this.nivel_radiobtn.TabIndex = 2;
            this.nivel_radiobtn.TabStop = true;
            this.nivel_radiobtn.Text = "Nivel";
            this.nivel_radiobtn.UseVisualStyleBackColor = true;
            // 
            // user_txt
            // 
            this.user_txt.Location = new System.Drawing.Point(108, 40);
            this.user_txt.Name = "user_txt";
            this.user_txt.Size = new System.Drawing.Size(100, 26);
            this.user_txt.TabIndex = 1;
            // 
            // user_lbl
            // 
            this.user_lbl.AutoSize = true;
            this.user_lbl.Location = new System.Drawing.Point(32, 43);
            this.user_lbl.Name = "user_lbl";
            this.user_lbl.Size = new System.Drawing.Size(55, 20);
            this.user_lbl.TabIndex = 0;
            this.user_lbl.Text = "USER";
            // 
            // conectar_button
            // 
            this.conectar_button.Location = new System.Drawing.Point(53, 42);
            this.conectar_button.Name = "conectar_button";
            this.conectar_button.Size = new System.Drawing.Size(146, 45);
            this.conectar_button.TabIndex = 2;
            this.conectar_button.Text = "CONECTAR";
            this.conectar_button.UseVisualStyleBackColor = true;
            this.conectar_button.Click += new System.EventHandler(this.conectar_button_Click);
            // 
            // desconectar_button
            // 
            this.desconectar_button.Location = new System.Drawing.Point(53, 372);
            this.desconectar_button.Name = "desconectar_button";
            this.desconectar_button.Size = new System.Drawing.Size(156, 52);
            this.desconectar_button.TabIndex = 3;
            this.desconectar_button.Text = "DESCONECTAR";
            this.desconectar_button.UseVisualStyleBackColor = true;
            this.desconectar_button.Click += new System.EventHandler(this.desconectar_button_Click);
            // 
            // servicios_btn
            // 
            this.servicios_btn.Location = new System.Drawing.Point(592, 132);
            this.servicios_btn.Name = "servicios_btn";
            this.servicios_btn.Size = new System.Drawing.Size(129, 69);
            this.servicios_btn.TabIndex = 5;
            this.servicios_btn.Text = "¿Cuantos servicios?";
            this.servicios_btn.UseVisualStyleBackColor = true;
            this.servicios_btn.Click += new System.EventHandler(this.servicios_btn_Click);
            // 
            // cont_lbl
            // 
            this.cont_lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cont_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cont_lbl.Location = new System.Drawing.Point(561, 222);
            this.cont_lbl.Name = "cont_lbl";
            this.cont_lbl.Size = new System.Drawing.Size(196, 184);
            this.cont_lbl.TabIndex = 6;
            // 
            // juga_btn
            // 
            this.juga_btn.Location = new System.Drawing.Point(362, 438);
            this.juga_btn.Name = "juga_btn";
            this.juga_btn.Size = new System.Drawing.Size(107, 41);
            this.juga_btn.TabIndex = 6;
            this.juga_btn.Text = "jugar";
            this.juga_btn.UseVisualStyleBackColor = true;
            this.juga_btn.Click += new System.EventHandler(this.juga_btn_Click);
            // 
            // ListaConectados_btn
            // 
            this.ListaConectados_btn.Location = new System.Drawing.Point(864, 132);
            this.ListaConectados_btn.Name = "ListaConectados_btn";
            this.ListaConectados_btn.Size = new System.Drawing.Size(172, 69);
            this.ListaConectados_btn.TabIndex = 7;
            this.ListaConectados_btn.Text = "¿Quien esta conectado?";
            this.ListaConectados_btn.UseVisualStyleBackColor = true;
            this.ListaConectados_btn.Click += new System.EventHandler(this.ListaConectados_btn_Click);
            // 
            // ListaConectados_lbl
            // 
            this.ListaConectados_lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListaConectados_lbl.Location = new System.Drawing.Point(857, 225);
            this.ListaConectados_lbl.Name = "ListaConectados_lbl";
            this.ListaConectados_lbl.Size = new System.Drawing.Size(195, 198);
            this.ListaConectados_lbl.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 612);
            this.Controls.Add(this.ListaConectados_lbl);
            this.Controls.Add(this.ListaConectados_btn);
            this.Controls.Add(this.juga_btn);
            this.Controls.Add(this.cont_lbl);
            this.Controls.Add(this.servicios_btn);
            this.Controls.Add(this.desconectar_button);
            this.Controls.Add(this.conectar_button);
            this.Controls.Add(this.peticiones_groupBox);
            this.Controls.Add(this.signin_groupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.signin_groupBox.ResumeLayout(false);
            this.signin_groupBox.PerformLayout();
            this.peticiones_groupBox.ResumeLayout(false);
            this.peticiones_groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox signin_groupBox;
        private System.Windows.Forms.Button sign_in_button;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.Label password_lbl;
        private System.Windows.Forms.TextBox usuario_txt;
        private System.Windows.Forms.Label user_label;
        private System.Windows.Forms.GroupBox peticiones_groupBox;
        private System.Windows.Forms.TextBox user_txt;
        private System.Windows.Forms.Label user_lbl;
        private System.Windows.Forms.Button conectar_button;
        private System.Windows.Forms.Button desconectar_button;
        private System.Windows.Forms.Button enviar_button;
        private System.Windows.Forms.RadioButton nivelMasAlto_radiobtn;
        private System.Windows.Forms.RadioButton partidas_ganadas_radiobtn;
        private System.Windows.Forms.RadioButton nivel_radiobtn;
        private System.Windows.Forms.Button servicios_btn;
        private System.Windows.Forms.Label cont_lbl;
        private System.Windows.Forms.Button juga_btn;
        private System.Windows.Forms.Button ListaConectados_btn;
        private System.Windows.Forms.Label ListaConectados_lbl;
    }
}

