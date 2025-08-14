namespace CLIENTE
{
    partial class FormPrincipal
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
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.mnuConexion = new System.Windows.Forms.ToolStripMenuItem();
            this.mniConectar = new System.Windows.Forms.ToolStripMenuItem();
            this.mniDesconectar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPedidos = new System.Windows.Forms.ToolStripMenuItem();
            this.mniRegistrarPedido = new System.Windows.Forms.ToolStripMenuItem();
            this.mniConsultarPedidos = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblServidor = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblClienteNombre = new System.Windows.Forms.Label();
            this.lblEtiquetaCliente = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtClienteId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblLoginTitulo = new System.Windows.Forms.Label();
            this.menuMain.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuConexion,
            this.mnuPedidos});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(800, 24);
            this.menuMain.TabIndex = 0;
            this.menuMain.Text = "menuStrip1";
            // 
            // mnuConexion
            // 
            this.mnuConexion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniConectar,
            this.mniDesconectar});
            this.mnuConexion.Name = "mnuConexion";
            this.mnuConexion.Size = new System.Drawing.Size(69, 20);
            this.mnuConexion.Text = "Conexión";
            // 
            // mniConectar
            // 
            this.mniConectar.Name = "mniConectar";
            this.mniConectar.Size = new System.Drawing.Size(180, 22);
            this.mniConectar.Text = "Conectar";
            // 
            // mniDesconectar
            // 
            this.mniDesconectar.Name = "mniDesconectar";
            this.mniDesconectar.Size = new System.Drawing.Size(180, 22);
            this.mniDesconectar.Text = "Desconectar";
            // 
            // mnuPedidos
            // 
            this.mnuPedidos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniRegistrarPedido,
            this.mniConsultarPedidos});
            this.mnuPedidos.Name = "mnuPedidos";
            this.mnuPedidos.Size = new System.Drawing.Size(61, 20);
            this.mnuPedidos.Text = "Pedidos";
            // 
            // mniRegistrarPedido
            // 
            this.mniRegistrarPedido.Name = "mniRegistrarPedido";
            this.mniRegistrarPedido.Size = new System.Drawing.Size(192, 22);
            this.mniRegistrarPedido.Text = "Registrar pedido";
            // 
            // mniConsultarPedidos
            // 
            this.mniConsultarPedidos.Name = "mniConsultarPedidos";
            this.mniConsultarPedidos.Size = new System.Drawing.Size(192, 22);
            this.mniConsultarPedidos.Text = "Consultar mis pedidos";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblEstado,
            this.lblServidor});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblEstado
            // 
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(82, 17);
            this.lblEstado.Text = "Desconectado";
            // 
            // lblServidor
            // 
            this.lblServidor.Name = "lblServidor";
            this.lblServidor.Size = new System.Drawing.Size(134, 17);
            this.lblServidor.Text = "Servidor: 127.0.0.1:14100";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblClienteNombre);
            this.panel1.Controls.Add(this.lblEtiquetaCliente);
            this.panel1.Controls.Add(this.btnIngresar);
            this.panel1.Controls.Add(this.txtClienteId);
            this.panel1.Controls.Add(this.lblId);
            this.panel1.Controls.Add(this.lblLoginTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 404);
            this.panel1.TabIndex = 2;
            // 
            // lblClienteNombre
            // 
            this.lblClienteNombre.AutoSize = true;
            this.lblClienteNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteNombre.Location = new System.Drawing.Point(469, 37);
            this.lblClienteNombre.Name = "lblClienteNombre";
            this.lblClienteNombre.Size = new System.Drawing.Size(81, 13);
            this.lblClienteNombre.TabIndex = 3;
            this.lblClienteNombre.Text = "(no validado)";
            // 
            // lblEtiquetaCliente
            // 
            this.lblEtiquetaCliente.AutoSize = true;
            this.lblEtiquetaCliente.Location = new System.Drawing.Point(421, 37);
            this.lblEtiquetaCliente.Name = "lblEtiquetaCliente";
            this.lblEtiquetaCliente.Size = new System.Drawing.Size(42, 13);
            this.lblEtiquetaCliente.TabIndex = 2;
            this.lblEtiquetaCliente.Text = "Cliente:";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(287, 32);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 1;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            // 
            // txtClienteId
            // 
            this.txtClienteId.Location = new System.Drawing.Point(91, 34);
            this.txtClienteId.MaxLength = 10;
            this.txtClienteId.Name = "txtClienteId";
            this.txtClienteId.Size = new System.Drawing.Size(190, 20);
            this.txtClienteId.TabIndex = 0;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(12, 37);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(73, 13);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "Identificación:";
            // 
            // lblLoginTitulo
            // 
            this.lblLoginTitulo.AutoSize = true;
            this.lblLoginTitulo.Location = new System.Drawing.Point(12, 10);
            this.lblLoginTitulo.Name = "lblLoginTitulo";
            this.lblLoginTitulo.Size = new System.Drawing.Size(91, 13);
            this.lblLoginTitulo.TabIndex = 0;
            this.lblLoginTitulo.Text = "Ingreso de cliente";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuMain);
            this.MainMenuStrip = this.menuMain;
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuConexion;
        private System.Windows.Forms.ToolStripMenuItem mniConectar;
        private System.Windows.Forms.ToolStripMenuItem mniDesconectar;
        private System.Windows.Forms.ToolStripMenuItem mnuPedidos;
        private System.Windows.Forms.ToolStripMenuItem mniRegistrarPedido;
        private System.Windows.Forms.ToolStripMenuItem mniConsultarPedidos;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblEstado;
        private System.Windows.Forms.ToolStripStatusLabel lblServidor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblLoginTitulo;
        private System.Windows.Forms.Label lblClienteNombre;
        private System.Windows.Forms.Label lblEtiquetaCliente;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtClienteId;
    }
}

