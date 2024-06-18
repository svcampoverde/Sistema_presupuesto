namespace Presentacion
{
    partial class FRMPrincipal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbtipEmpresa = new MaterialSkin.Controls.MaterialComboBox();
            this.cbUsuario = new MaterialSkin.Controls.MaterialComboBox();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.btnUsuario = new FontAwesome.Sharp.IconButton();
            this.btHome = new FontAwesome.Sharp.IconButton();
            this.PanelContent = new System.Windows.Forms.Panel();
            this.cbProvincia = new MaterialSkin.Controls.MaterialComboBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1247, 38);
            this.panel1.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(14)))), ((int)(((byte)(15)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 593);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1247, 54);
            this.panel3.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbtipEmpresa);
            this.panel2.Controls.Add(this.cbUsuario);
            this.panel2.Controls.Add(this.iconButton3);
            this.panel2.Controls.Add(this.btnUsuario);
            this.panel2.Controls.Add(this.btHome);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(3, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(185, 491);
            this.panel2.TabIndex = 15;
            // 
            // cbtipEmpresa
            // 
            this.cbtipEmpresa.AutoResize = false;
            this.cbtipEmpresa.BackColor = System.Drawing.Color.White;
            this.cbtipEmpresa.CausesValidation = false;
            this.cbtipEmpresa.Depth = 0;
            this.cbtipEmpresa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbtipEmpresa.DropDownHeight = 174;
            this.cbtipEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtipEmpresa.DropDownWidth = 121;
            this.cbtipEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbtipEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbtipEmpresa.ForeColor = System.Drawing.Color.White;
            this.cbtipEmpresa.FormattingEnabled = true;
            this.cbtipEmpresa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbtipEmpresa.IntegralHeight = false;
            this.cbtipEmpresa.ItemHeight = 43;
            this.cbtipEmpresa.Items.AddRange(new object[] {
            "Tipo de empresa",
            "Registrar ",
            "Eliminar "});
            this.cbtipEmpresa.Location = new System.Drawing.Point(3, 152);
            this.cbtipEmpresa.MaxDropDownItems = 4;
            this.cbtipEmpresa.MouseState = MaterialSkin.MouseState.OUT;
            this.cbtipEmpresa.Name = "cbtipEmpresa";
            this.cbtipEmpresa.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbtipEmpresa.Size = new System.Drawing.Size(178, 49);
            this.cbtipEmpresa.StartIndex = 0;
            this.cbtipEmpresa.TabIndex = 14;
            // 
            // cbUsuario
            // 
            this.cbUsuario.AutoResize = false;
            this.cbUsuario.BackColor = System.Drawing.Color.White;
            this.cbUsuario.CausesValidation = false;
            this.cbUsuario.Depth = 0;
            this.cbUsuario.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbUsuario.DropDownHeight = 174;
            this.cbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUsuario.DropDownWidth = 121;
            this.cbUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUsuario.ForeColor = System.Drawing.Color.White;
            this.cbUsuario.FormattingEnabled = true;
            this.cbUsuario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbUsuario.IntegralHeight = false;
            this.cbUsuario.ItemHeight = 43;
            this.cbUsuario.Items.AddRange(new object[] {
            "Usuario",
            "Registrar Usuario",
            "Eliminar Usuario"});
            this.cbUsuario.Location = new System.Drawing.Point(3, 106);
            this.cbUsuario.MaxDropDownItems = 4;
            this.cbUsuario.MouseState = MaterialSkin.MouseState.OUT;
            this.cbUsuario.Name = "cbUsuario";
            this.cbUsuario.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbUsuario.Size = new System.Drawing.Size(178, 49);
            this.cbUsuario.StartIndex = 0;
            this.cbUsuario.TabIndex = 11;
            this.cbUsuario.SelectedIndexChanged += new System.EventHandler(this.cbUsuario_SelectedIndexChanged);
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.SlateGray;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.ForeColor = System.Drawing.Color.Black;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.Location = new System.Drawing.Point(4, 311);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(178, 57);
            this.iconButton3.TabIndex = 13;
            this.iconButton3.Text = "Usuario";
            this.iconButton3.UseVisualStyleBackColor = false;
            // 
            // btnUsuario
            // 
            this.btnUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.btnUsuario.FlatAppearance.BorderSize = 0;
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuario.ForeColor = System.Drawing.Color.Black;
            this.btnUsuario.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnUsuario.IconColor = System.Drawing.Color.Black;
            this.btnUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUsuario.Location = new System.Drawing.Point(2, 53);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(178, 56);
            this.btnUsuario.TabIndex = 12;
            this.btnUsuario.Text = "Rol de Usuario";
            this.btnUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuario.UseVisualStyleBackColor = false;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // btHome
            // 
            this.btHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.btHome.FlatAppearance.BorderSize = 0;
            this.btHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btHome.ForeColor = System.Drawing.Color.Black;
            this.btHome.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btHome.IconColor = System.Drawing.Color.Black;
            this.btHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btHome.Location = new System.Drawing.Point(3, 0);
            this.btHome.Name = "btHome";
            this.btHome.Size = new System.Drawing.Size(178, 56);
            this.btHome.TabIndex = 11;
            this.btHome.Text = "Home";
            this.btHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHome.UseVisualStyleBackColor = false;
            this.btHome.Click += new System.EventHandler(this.btHome_Click);
            // 
            // PanelContent
            // 
            this.PanelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContent.Location = new System.Drawing.Point(188, 102);
            this.PanelContent.Name = "PanelContent";
            this.PanelContent.Size = new System.Drawing.Size(1062, 491);
            this.PanelContent.TabIndex = 16;
            // 
            // cbProvincia
            // 
            this.cbProvincia.AutoResize = false;
            this.cbProvincia.BackColor = System.Drawing.Color.White;
            this.cbProvincia.CausesValidation = false;
            this.cbProvincia.Depth = 0;
            this.cbProvincia.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbProvincia.DropDownHeight = 174;
            this.cbProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProvincia.DropDownWidth = 121;
            this.cbProvincia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProvincia.ForeColor = System.Drawing.Color.White;
            this.cbProvincia.FormattingEnabled = true;
            this.cbProvincia.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbProvincia.IntegralHeight = false;
            this.cbProvincia.ItemHeight = 43;
            this.cbProvincia.Items.AddRange(new object[] {
            "Provincia",
            "Registrar ",
            "Eliminar "});
            this.cbProvincia.Location = new System.Drawing.Point(7, 300);
            this.cbProvincia.MaxDropDownItems = 4;
            this.cbProvincia.MouseState = MaterialSkin.MouseState.OUT;
            this.cbProvincia.Name = "cbProvincia";
            this.cbProvincia.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbProvincia.Size = new System.Drawing.Size(178, 49);
            this.cbProvincia.StartIndex = 0;
            this.cbProvincia.TabIndex = 15;
            this.cbProvincia.SelectedIndexChanged += new System.EventHandler(this.cbProvincia_SelectedIndexChanged);
            // 
            // FRMPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 650);
            this.Controls.Add(this.cbProvincia);
            this.Controls.Add(this.PanelContent);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.DrawerAutoShow = true;
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "FRMPrincipal";
            this.Load += new System.EventHandler(this.Prueba_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnUsuario;
        private FontAwesome.Sharp.IconButton btHome;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel PanelContent;
        private FontAwesome.Sharp.IconButton iconButton3;
        private MaterialSkin.Controls.MaterialComboBox cbUsuario;
        private MaterialSkin.Controls.MaterialComboBox cbtipEmpresa;
        private MaterialSkin.Controls.MaterialComboBox cbProvincia;
    }
}