
namespace WindowsMedicos
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.btnGuardarMedico = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.cbEspecialidad = new System.Windows.Forms.ComboBox();
            this.gridMedicos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTraerPorEspecialidad = new System.Windows.Forms.ComboBox();
            this.btnTraerUnMedico = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnEliminarMedico = new System.Windows.Forms.Button();
            this.btnModificarMedico = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridMedicos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(27, 16);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(27, 55);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(24, 92);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(53, 13);
            this.lblMatricula.TabIndex = 2;
            this.lblMatricula.Text = "Matricula:";
            // 
            // btnGuardarMedico
            // 
            this.btnGuardarMedico.Location = new System.Drawing.Point(18, 170);
            this.btnGuardarMedico.Name = "btnGuardarMedico";
            this.btnGuardarMedico.Size = new System.Drawing.Size(191, 23);
            this.btnGuardarMedico.TabIndex = 4;
            this.btnGuardarMedico.Text = "Guardar Medico";
            this.btnGuardarMedico.UseVisualStyleBackColor = true;
            this.btnGuardarMedico.Click += new System.EventHandler(this.btnGuardarMedico_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(90, 16);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(119, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(90, 55);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(119, 20);
            this.txtApellido.TabIndex = 6;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(90, 92);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(119, 20);
            this.txtMatricula.TabIndex = 7;
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Location = new System.Drawing.Point(15, 134);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(70, 13);
            this.lblEspecialidad.TabIndex = 8;
            this.lblEspecialidad.Text = "Especialidad:";
            // 
            // cbEspecialidad
            // 
            this.cbEspecialidad.FormattingEnabled = true;
            this.cbEspecialidad.Location = new System.Drawing.Point(90, 131);
            this.cbEspecialidad.Name = "cbEspecialidad";
            this.cbEspecialidad.Size = new System.Drawing.Size(119, 21);
            this.cbEspecialidad.TabIndex = 9;
            // 
            // gridMedicos
            // 
            this.gridMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMedicos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridMedicos.Location = new System.Drawing.Point(0, 212);
            this.gridMedicos.Name = "gridMedicos";
            this.gridMedicos.Size = new System.Drawing.Size(563, 238);
            this.gridMedicos.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Traer por especialidad";
            // 
            // cbTraerPorEspecialidad
            // 
            this.cbTraerPorEspecialidad.FormattingEnabled = true;
            this.cbTraerPorEspecialidad.Location = new System.Drawing.Point(434, 172);
            this.cbTraerPorEspecialidad.Name = "cbTraerPorEspecialidad";
            this.cbTraerPorEspecialidad.Size = new System.Drawing.Size(119, 21);
            this.cbTraerPorEspecialidad.TabIndex = 13;
            this.cbTraerPorEspecialidad.SelectionChangeCommitted += new System.EventHandler(this.cbTraerPorEspecialidad_SelectionChangeCommitted);
            // 
            // btnTraerUnMedico
            // 
            this.btnTraerUnMedico.Location = new System.Drawing.Point(409, 34);
            this.btnTraerUnMedico.Name = "btnTraerUnMedico";
            this.btnTraerUnMedico.Size = new System.Drawing.Size(132, 23);
            this.btnTraerUnMedico.TabIndex = 14;
            this.btnTraerUnMedico.Text = "Mostrar medico por ID";
            this.btnTraerUnMedico.UseVisualStyleBackColor = true;
            this.btnTraerUnMedico.Click += new System.EventHandler(this.btnTraerUnMedico_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(431, 11);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 13);
            this.lblId.TabIndex = 15;
            this.lblId.Text = "ID:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(474, 8);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(45, 20);
            this.txtId.TabIndex = 16;
            // 
            // btnEliminarMedico
            // 
            this.btnEliminarMedico.Location = new System.Drawing.Point(409, 63);
            this.btnEliminarMedico.Name = "btnEliminarMedico";
            this.btnEliminarMedico.Size = new System.Drawing.Size(132, 23);
            this.btnEliminarMedico.TabIndex = 17;
            this.btnEliminarMedico.Text = "Eliminar medico por ID";
            this.btnEliminarMedico.UseVisualStyleBackColor = true;
            this.btnEliminarMedico.Click += new System.EventHandler(this.btnEliminarMedico_Click);
            // 
            // btnModificarMedico
            // 
            this.btnModificarMedico.Location = new System.Drawing.Point(409, 92);
            this.btnModificarMedico.Name = "btnModificarMedico";
            this.btnModificarMedico.Size = new System.Drawing.Size(132, 23);
            this.btnModificarMedico.TabIndex = 18;
            this.btnModificarMedico.Text = "Modificar medico por ID";
            this.btnModificarMedico.UseVisualStyleBackColor = true;
            this.btnModificarMedico.Click += new System.EventHandler(this.btnModificarMedico_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 450);
            this.Controls.Add(this.btnModificarMedico);
            this.Controls.Add(this.btnEliminarMedico);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnTraerUnMedico);
            this.Controls.Add(this.cbTraerPorEspecialidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridMedicos);
            this.Controls.Add(this.cbEspecialidad);
            this.Controls.Add(this.lblEspecialidad);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnGuardarMedico);
            this.Controls.Add(this.lblMatricula);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridMedicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Button btnGuardarMedico;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.ComboBox cbEspecialidad;
        private System.Windows.Forms.DataGridView gridMedicos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTraerPorEspecialidad;
        private System.Windows.Forms.Button btnTraerUnMedico;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnEliminarMedico;
        private System.Windows.Forms.Button btnModificarMedico;
    }
}

