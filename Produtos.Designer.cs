namespace CRUD
{
    partial class Produtos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mnsMenu = new System.Windows.Forms.MenuStrip();
            this.mntMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.htsHome = new System.Windows.Forms.ToolStripMenuItem();
            this.htsProd = new System.Windows.Forms.ToolStripMenuItem();
            this.htsCli = new System.Windows.Forms.ToolStripMenuItem();
            this.htsVend = new System.Windows.Forms.ToolStripMenuItem();
            this.htsFunc = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.bntPesq = new System.Windows.Forms.Button();
            this.bntEditar = new System.Windows.Forms.Button();
            this.bntDele = new System.Windows.Forms.Button();
            this.bntAdicionar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.mnsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gerenciameno de Produtos ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(-3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 41);
            this.panel1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(400, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Voltar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.mnsMenu);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(194, 49);
            this.panel2.TabIndex = 4;
            // 
            // mnsMenu
            // 
            this.mnsMenu.BackColor = System.Drawing.Color.RoyalBlue;
            this.mnsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mntMenu});
            this.mnsMenu.Location = new System.Drawing.Point(0, 0);
            this.mnsMenu.Name = "mnsMenu";
            this.mnsMenu.Size = new System.Drawing.Size(194, 24);
            this.mnsMenu.Stretch = false;
            this.mnsMenu.TabIndex = 2;
            this.mnsMenu.Text = "menuStrip1";
            // 
            // mntMenu
            // 
            this.mntMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.htsHome,
            this.htsProd,
            this.htsCli,
            this.htsVend,
            this.htsFunc});
            this.mntMenu.Name = "mntMenu";
            this.mntMenu.Size = new System.Drawing.Size(50, 20);
            this.mntMenu.Text = "Menu";
            // 
            // htsHome
            // 
            this.htsHome.Name = "htsHome";
            this.htsHome.Size = new System.Drawing.Size(142, 22);
            this.htsHome.Text = "Home";
            // 
            // htsProd
            // 
            this.htsProd.Name = "htsProd";
            this.htsProd.Size = new System.Drawing.Size(142, 22);
            this.htsProd.Text = "Produtos";
            // 
            // htsCli
            // 
            this.htsCli.Name = "htsCli";
            this.htsCli.Size = new System.Drawing.Size(142, 22);
            this.htsCli.Text = "Clientes";
            // 
            // htsVend
            // 
            this.htsVend.Name = "htsVend";
            this.htsVend.Size = new System.Drawing.Size(142, 22);
            this.htsVend.Text = "Vendas";
            // 
            // htsFunc
            // 
            this.htsFunc.Name = "htsFunc";
            this.htsFunc.Size = new System.Drawing.Size(142, 22);
            this.htsFunc.Text = "Funcionários";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(725, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Saida";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // bntPesq
            // 
            this.bntPesq.Location = new System.Drawing.Point(722, 76);
            this.bntPesq.Name = "bntPesq";
            this.bntPesq.Size = new System.Drawing.Size(75, 23);
            this.bntPesq.TabIndex = 3;
            this.bntPesq.Text = "Pesquisar";
            this.bntPesq.UseVisualStyleBackColor = true;
            // 
            // bntEditar
            // 
            this.bntEditar.Location = new System.Drawing.Point(531, 123);
            this.bntEditar.Name = "bntEditar";
            this.bntEditar.Size = new System.Drawing.Size(75, 23);
            this.bntEditar.TabIndex = 4;
            this.bntEditar.Text = "Editar";
            this.bntEditar.UseVisualStyleBackColor = true;
            // 
            // bntDele
            // 
            this.bntDele.Location = new System.Drawing.Point(626, 123);
            this.bntDele.Name = "bntDele";
            this.bntDele.Size = new System.Drawing.Size(75, 23);
            this.bntDele.TabIndex = 5;
            this.bntDele.Text = "Deletar";
            this.bntDele.UseVisualStyleBackColor = true;
            // 
            // bntAdicionar
            // 
            this.bntAdicionar.Location = new System.Drawing.Point(713, 123);
            this.bntAdicionar.Name = "bntAdicionar";
            this.bntAdicionar.Size = new System.Drawing.Size(75, 23);
            this.bntAdicionar.TabIndex = 6;
            this.bntAdicionar.Text = "Adicionar ";
            this.bntAdicionar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 163);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(776, 275);
            this.dataGridView1.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(468, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 23);
            this.textBox1.TabIndex = 8;
            // 
            // Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bntAdicionar);
            this.Controls.Add(this.bntDele);
            this.Controls.Add(this.bntEditar);
            this.Controls.Add(this.bntPesq);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Produtos";
            this.Text = "Produtos";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.mnsMenu.ResumeLayout(false);
            this.mnsMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Panel panel1;
        private Button button1;
        private Button bntPesq;
        private Button bntEditar;
        private Button bntDele;
        private Button bntAdicionar;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Panel panel2;
        private MenuStrip mnsMenu;
        private ToolStripMenuItem mntMenu;
        private ToolStripMenuItem htsHome;
        private ToolStripMenuItem htsProd;
        private ToolStripMenuItem htsCli;
        private ToolStripMenuItem htsVend;
        private ToolStripMenuItem htsFunc;
        private Button button2;
    }
}