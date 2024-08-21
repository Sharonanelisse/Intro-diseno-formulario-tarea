namespace RegistroContactosApp
{
    partial class RegistroContactosApp
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
            EtiquetaNombre = new Label();
            EtiquetaTelefono = new Label();
            EtiquetaEmail = new Label();
            TextBoxNombre = new TextBox();
            TextBoxTelefono = new TextBox();
            TextBoxEmail = new TextBox();
            ButtonAgregar = new Button();
            ButtonLimpiar = new Button();
            ListBoxContactos = new ListBox();
            LabelEstado = new Label();
            SuspendLayout();
            // 
            // EtiquetaNombre
            // 
            EtiquetaNombre.AutoSize = true;
            EtiquetaNombre.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EtiquetaNombre.Location = new Point(64, 33);
            EtiquetaNombre.Name = "EtiquetaNombre";
            EtiquetaNombre.Size = new Size(60, 17);
            EtiquetaNombre.TabIndex = 0;
            EtiquetaNombre.Text = "Nombre:";
            // 
            // EtiquetaTelefono
            // 
            EtiquetaTelefono.AutoSize = true;
            EtiquetaTelefono.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EtiquetaTelefono.Location = new Point(63, 86);
            EtiquetaTelefono.Name = "EtiquetaTelefono";
            EtiquetaTelefono.Size = new Size(61, 17);
            EtiquetaTelefono.TabIndex = 1;
            EtiquetaTelefono.Text = "Teléfono:";
            // 
            // EtiquetaEmail
            // 
            EtiquetaEmail.AutoSize = true;
            EtiquetaEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EtiquetaEmail.Location = new Point(62, 133);
            EtiquetaEmail.Name = "EtiquetaEmail";
            EtiquetaEmail.Size = new Size(120, 17);
            EtiquetaEmail.TabIndex = 2;
            EtiquetaEmail.Text = "Correo Electrónico:";
            // 
            // TextBoxNombre
            // 
            TextBoxNombre.Location = new Point(188, 32);
            TextBoxNombre.Name = "TextBoxNombre";
            TextBoxNombre.Size = new Size(362, 23);
            TextBoxNombre.TabIndex = 3;
            // 
            // TextBoxTelefono
            // 
            TextBoxTelefono.Location = new Point(188, 85);
            TextBoxTelefono.Name = "TextBoxTelefono";
            TextBoxTelefono.Size = new Size(362, 23);
            TextBoxTelefono.TabIndex = 4;
            // 
            // TextBoxEmail
            // 
            TextBoxEmail.Location = new Point(188, 132);
            TextBoxEmail.Name = "TextBoxEmail";
            TextBoxEmail.Size = new Size(362, 23);
            TextBoxEmail.TabIndex = 5;
            // 
            // ButtonAgregar
            // 
            ButtonAgregar.Location = new Point(149, 193);
            ButtonAgregar.Name = "ButtonAgregar";
            ButtonAgregar.Size = new Size(136, 32);
            ButtonAgregar.TabIndex = 6;
            ButtonAgregar.Text = "Agregar Contacto";
            ButtonAgregar.UseVisualStyleBackColor = true;
            ButtonAgregar.Click += ButtonAgregar_Click;
            ButtonAgregar.MouseEnter += RegistroContactosApp_Load;
            ButtonAgregar.MouseLeave += RegistroContactosApp_Load;
            // 
            // ButtonLimpiar
            // 
            ButtonLimpiar.Location = new Point(320, 193);
            ButtonLimpiar.Name = "ButtonLimpiar";
            ButtonLimpiar.Size = new Size(136, 32);
            ButtonLimpiar.TabIndex = 7;
            ButtonLimpiar.Text = "Limpiar Campos";
            ButtonLimpiar.UseVisualStyleBackColor = true;
            ButtonLimpiar.Click += ButtonLimpiar_Click;
            ButtonLimpiar.MouseEnter += RegistroContactosApp_Load;
            ButtonLimpiar.MouseLeave += RegistroContactosApp_Load;
            // 
            // ListBoxContactos
            // 
            ListBoxContactos.BackColor = SystemColors.InactiveBorder;
            ListBoxContactos.FormattingEnabled = true;
            ListBoxContactos.ItemHeight = 15;
            ListBoxContactos.Location = new Point(64, 272);
            ListBoxContactos.Name = "ListBoxContactos";
            ListBoxContactos.RightToLeft = RightToLeft.No;
            ListBoxContactos.Size = new Size(486, 139);
            ListBoxContactos.TabIndex = 8;
            // 
            // LabelEstado
            // 
            LabelEstado.AutoSize = true;
            LabelEstado.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            LabelEstado.Location = new Point(38, 427);
            LabelEstado.Name = "LabelEstado";
            LabelEstado.Size = new Size(0, 15);
            LabelEstado.TabIndex = 9;
            // 
            // RegistroContactosApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(625, 458);
            Controls.Add(LabelEstado);
            Controls.Add(ListBoxContactos);
            Controls.Add(ButtonLimpiar);
            Controls.Add(ButtonAgregar);
            Controls.Add(TextBoxEmail);
            Controls.Add(TextBoxTelefono);
            Controls.Add(TextBoxNombre);
            Controls.Add(EtiquetaEmail);
            Controls.Add(EtiquetaTelefono);
            Controls.Add(EtiquetaNombre);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "RegistroContactosApp";
            RightToLeft = RightToLeft.No;
            Text = "RegistroContactosApp";
            TransparencyKey = Color.Black;
            Load += RegistroContactosApp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label EtiquetaNombre;
        private Label EtiquetaTelefono;
        private Label EtiquetaEmail;
        private TextBox TextBoxNombre;
        private TextBox TextBoxTelefono;
        private TextBox TextBoxEmail;
        private Button ButtonAgregar;
        private Button ButtonLimpiar;
        private ListBox ListBoxContactos;
        private Label LabelEstado;
    }
}
