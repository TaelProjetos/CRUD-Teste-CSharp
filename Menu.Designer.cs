namespace CRUD
{
    partial class Menu
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
            this.btnSaida = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mnsMenu = new System.Windows.Forms.MenuStrip();
            this.mntMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.htsHome = new System.Windows.Forms.ToolStripMenuItem();
            this.htsProd = new System.Windows.Forms.ToolStripMenuItem();
            this.htsCli = new System.Windows.Forms.ToolStripMenuItem();
            this.htsVend = new System.Windows.Forms.ToolStripMenuItem();
            this.htsFunc = new System.Windows.Forms.ToolStripMenuItem();
            this.btnProd = new System.Windows.Forms.Button();
            this.btnCli = new System.Windows.Forms.Button();
            this.btnVend = new System.Windows.Forms.Button();
            this.btnFunc = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.mnsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.btnSaida);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 31);
            this.panel1.TabIndex = 0;
            // 
            // btnSaida
            // 
            this.btnSaida.Location = new System.Drawing.Point(745, 3);
            this.btnSaida.Name = "btnSaida";
            this.btnSaida.Size = new System.Drawing.Size(44, 26);
            this.btnSaida.TabIndex = 5;
            this.btnSaida.Text = "Saida";
            this.btnSaida.UseVisualStyleBackColor = true;
            this.btnSaida.Click += new System.EventHandler(this.btnSaida_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.mnsMenu);
            this.panel2.Location = new System.Drawing.Point(3, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(212, 30);
            this.panel2.TabIndex = 0;
            // 
            // mnsMenu
            // 
            this.mnsMenu.BackColor = System.Drawing.Color.RoyalBlue;
            this.mnsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mntMenu});
            this.mnsMenu.Location = new System.Drawing.Point(0, 0);
            this.mnsMenu.Name = "mnsMenu";
            this.mnsMenu.Size = new System.Drawing.Size(212, 24);
            this.mnsMenu.Stretch = false;
            this.mnsMenu.TabIndex = 1;
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
            this.mntMenu.Click += new System.EventHandler(this.mntMenu_Click);
            // 
            // htsHome
            // 
            this.htsHome.Name = "htsHome";
            this.htsHome.Size = new System.Drawing.Size(180, 22);
            this.htsHome.Text = "Home";
            // 
            // htsProd
            // 
            this.htsProd.Name = "htsProd";
            this.htsProd.Size = new System.Drawing.Size(180, 22);
            this.htsProd.Text = "Produtos";
            // 
            // htsCli
            // 
            this.htsCli.Name = "htsCli";
            this.htsCli.Size = new System.Drawing.Size(180, 22);
            this.htsCli.Text = "Clientes";
            // 
            // htsVend
            // 
            this.htsVend.Name = "htsVend";
            this.htsVend.Size = new System.Drawing.Size(180, 22);
            this.htsVend.Text = "Vendas";
            // 
            // htsFunc
            // 
            this.htsFunc.Name = "htsFunc";
            this.htsFunc.Size = new System.Drawing.Size(180, 22);
            this.htsFunc.Text = "Funcionários";
            // 
            // btnProd
            // 
            this.btnProd.Location = new System.Drawing.Point(189, 158);
            this.btnProd.Name = "btnProd";
            this.btnProd.Size = new System.Drawing.Size(84, 99);
            this.btnProd.TabIndex = 1;
            this.btnProd.Text = "Produtos";
            this.btnProd.UseVisualStyleBackColor = true;
            this.btnProd.Click += new System.EventHandler(this.btnProd_Click);
            // 
            // btnCli
            // 
            this.btnCli.Location = new System.Drawing.Point(297, 158);
            this.btnCli.Name = "btnCli";
            this.btnCli.Size = new System.Drawing.Size(84, 99);
            this.btnCli.TabIndex = 2;
            this.btnCli.Text = "Clientes";
            this.btnCli.UseVisualStyleBackColor = true;
            // 
            // btnVend
            // 
            this.btnVend.Location = new System.Drawing.Point(403, 158);
            this.btnVend.Name = "btnVend";
            this.btnVend.Size = new System.Drawing.Size(84, 99);
            this.btnVend.TabIndex = 3;
            this.btnVend.Text = "Vendas";
            this.btnVend.UseVisualStyleBackColor = true;
            // 
            // btnFunc
            // 
            this.btnFunc.Location = new System.Drawing.Point(510, 158);
            this.btnFunc.Name = "btnFunc";
            this.btnFunc.Size = new System.Drawing.Size(84, 99);
            this.btnFunc.TabIndex = 4;
            this.btnFunc.Text = "Funcionários";
            this.btnFunc.UseVisualStyleBackColor = true;
            this.btnFunc.Click += new System.EventHandler(this.btnFunc_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFunc);
            this.Controls.Add(this.btnVend);
            this.Controls.Add(this.btnCli);
            this.Controls.Add(this.btnProd);
            this.Controls.Add(this.panel1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.mnsMenu.ResumeLayout(false);
            this.mnsMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btnProd;
        private Button btnCli;
        private Button btnVend;
        private Button btnFunc;
        private Button btnSaida;
        private Panel panel2;
        private MenuStrip mnsMenu;
        private ToolStripMenuItem mntMenu;
        private ToolStripMenuItem htsHome;
        private ToolStripMenuItem htsProd;
        private ToolStripMenuItem htsCli;
        private ToolStripMenuItem htsVend;
        private ToolStripMenuItem htsFunc;
    }
}