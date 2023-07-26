namespace Aula13cadastrodeusuarios
{
    partial class Form1
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblnome = new System.Windows.Forms.Label();
            this.lblidade = new System.Windows.Forms.Label();
            this.lblrua = new System.Windows.Forms.Label();
            this.lblcidade = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtidade = new System.Windows.Forms.TextBox();
            this.txtrua = new System.Windows.Forms.TextBox();
            this.txtcidade = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalvar.Location = new System.Drawing.Point(85, 381);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(143, 33);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblnome.Location = new System.Drawing.Point(74, 44);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(137, 20);
            this.lblnome.TabIndex = 1;
            this.lblnome.Text = "Digite o seu nome;";
            // 
            // lblidade
            // 
            this.lblidade.AutoSize = true;
            this.lblidade.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblidade.Location = new System.Drawing.Point(73, 135);
            this.lblidade.Name = "lblidade";
            this.lblidade.Size = new System.Drawing.Size(51, 20);
            this.lblidade.TabIndex = 2;
            this.lblidade.Text = "Idade:";
            // 
            // lblrua
            // 
            this.lblrua.AutoSize = true;
            this.lblrua.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblrua.Location = new System.Drawing.Point(73, 213);
            this.lblrua.Name = "lblrua";
            this.lblrua.Size = new System.Drawing.Size(39, 20);
            this.lblrua.TabIndex = 3;
            this.lblrua.Text = "Rua:";
            // 
            // lblcidade
            // 
            this.lblcidade.AutoSize = true;
            this.lblcidade.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblcidade.Location = new System.Drawing.Point(74, 300);
            this.lblcidade.Name = "lblcidade";
            this.lblcidade.Size = new System.Drawing.Size(60, 20);
            this.lblcidade.TabIndex = 4;
            this.lblcidade.Text = "Cidade:";
            this.lblcidade.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(364, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Usuarios Cadastrados:";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(364, 80);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(244, 334);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(74, 68);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(170, 23);
            this.txtnome.TabIndex = 7;
            // 
            // txtidade
            // 
            this.txtidade.Location = new System.Drawing.Point(74, 158);
            this.txtidade.Name = "txtidade";
            this.txtidade.Size = new System.Drawing.Size(170, 23);
            this.txtidade.TabIndex = 8;
            // 
            // txtrua
            // 
            this.txtrua.Location = new System.Drawing.Point(74, 236);
            this.txtrua.Name = "txtrua";
            this.txtrua.Size = new System.Drawing.Size(170, 23);
            this.txtrua.TabIndex = 9;
            // 
            // txtcidade
            // 
            this.txtcidade.Location = new System.Drawing.Point(74, 323);
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.Size = new System.Drawing.Size(170, 23);
            this.txtcidade.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtcidade);
            this.Controls.Add(this.txtrua);
            this.Controls.Add(this.txtidade);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblcidade);
            this.Controls.Add(this.lblrua);
            this.Controls.Add(this.lblidade);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.btnSalvar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSalvar;
        private Label lblnome;
        private Label lblidade;
        private Label lblrua;
        private Label lblcidade;
        private Label label5;
        private ListView listView1;
        private TextBox txtnome;
        private TextBox txtidade;
        private TextBox txtrua;
        private TextBox txtcidade;
    }
}