
namespace MemeMaker
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTituloIMG = new System.Windows.Forms.Label();
            this.groupBoxMeme = new System.Windows.Forms.GroupBox();
            this.labelLegendaIMG = new System.Windows.Forms.Label();
            this.picBoxMeme = new System.Windows.Forms.PictureBox();
            this.labelTituloPag = new System.Windows.Forms.Label();
            this.labelLegendaTXT = new System.Windows.Forms.Label();
            this.textBoxLegenda = new System.Windows.Forms.TextBox();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.labelTituloTXT = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonIMG1 = new System.Windows.Forms.RadioButton();
            this.radioButtonIMG2 = new System.Windows.Forms.RadioButton();
            this.radioButtonIMG3 = new System.Windows.Forms.RadioButton();
            this.radioButtonIMG4 = new System.Windows.Forms.RadioButton();
            this.radioButtonIMG5 = new System.Windows.Forms.RadioButton();
            this.checkBoxTema = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonSair = new System.Windows.Forms.Button();
            this.buttonEnviar = new System.Windows.Forms.Button();
            this.groupBoxMeme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMeme)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTituloIMG
            // 
            this.labelTituloIMG.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloIMG.Location = new System.Drawing.Point(6, 16);
            this.labelTituloIMG.Name = "labelTituloIMG";
            this.labelTituloIMG.Size = new System.Drawing.Size(263, 41);
            this.labelTituloIMG.TabIndex = 0;
            this.labelTituloIMG.Text = "Titulo do meme ";
            // 
            // groupBoxMeme
            // 
            this.groupBoxMeme.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxMeme.Controls.Add(this.picBoxMeme);
            this.groupBoxMeme.Controls.Add(this.labelLegendaIMG);
            this.groupBoxMeme.Controls.Add(this.labelTituloIMG);
            this.groupBoxMeme.Location = new System.Drawing.Point(513, 12);
            this.groupBoxMeme.Name = "groupBoxMeme";
            this.groupBoxMeme.Size = new System.Drawing.Size(275, 426);
            this.groupBoxMeme.TabIndex = 1;
            this.groupBoxMeme.TabStop = false;
            this.groupBoxMeme.Text = "Meme";
            // 
            // labelLegendaIMG
            // 
            this.labelLegendaIMG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLegendaIMG.Location = new System.Drawing.Point(6, 362);
            this.labelLegendaIMG.Name = "labelLegendaIMG";
            this.labelLegendaIMG.Size = new System.Drawing.Size(263, 61);
            this.labelLegendaIMG.TabIndex = 1;
            this.labelLegendaIMG.Text = "Legenda do meme";
            // 
            // picBoxMeme
            // 
            this.picBoxMeme.Image = global::MemeMaker.Properties.Resources.image5;
            this.picBoxMeme.Location = new System.Drawing.Point(9, 60);
            this.picBoxMeme.Name = "picBoxMeme";
            this.picBoxMeme.Size = new System.Drawing.Size(259, 299);
            this.picBoxMeme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxMeme.TabIndex = 2;
            this.picBoxMeme.TabStop = false;
            // 
            // labelTituloPag
            // 
            this.labelTituloPag.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloPag.Location = new System.Drawing.Point(12, 9);
            this.labelTituloPag.Name = "labelTituloPag";
            this.labelTituloPag.Size = new System.Drawing.Size(263, 41);
            this.labelTituloPag.TabIndex = 3;
            this.labelTituloPag.Text = "Meme Maker";
            // 
            // labelLegendaTXT
            // 
            this.labelLegendaTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLegendaTXT.Location = new System.Drawing.Point(15, 92);
            this.labelLegendaTXT.Name = "labelLegendaTXT";
            this.labelLegendaTXT.Size = new System.Drawing.Size(160, 28);
            this.labelLegendaTXT.TabIndex = 3;
            this.labelLegendaTXT.Text = "Legenda:";
            // 
            // textBoxLegenda
            // 
            this.textBoxLegenda.Location = new System.Drawing.Point(19, 114);
            this.textBoxLegenda.Name = "textBoxLegenda";
            this.textBoxLegenda.Size = new System.Drawing.Size(375, 26);
            this.textBoxLegenda.TabIndex = 4;
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(19, 56);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(375, 26);
            this.textBoxTitulo.TabIndex = 6;
            // 
            // labelTituloTXT
            // 
            this.labelTituloTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloTXT.Location = new System.Drawing.Point(15, 34);
            this.labelTituloTXT.Name = "labelTituloTXT";
            this.labelTituloTXT.Size = new System.Drawing.Size(160, 19);
            this.labelTituloTXT.TabIndex = 5;
            this.labelTituloTXT.Text = "Título: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonIMG5);
            this.groupBox2.Controls.Add(this.radioButtonIMG4);
            this.groupBox2.Controls.Add(this.radioButtonIMG3);
            this.groupBox2.Controls.Add(this.radioButtonIMG2);
            this.groupBox2.Controls.Add(this.radioButtonIMG1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 200);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(178, 157);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Escolha a imagem:";
            // 
            // radioButtonIMG1
            // 
            this.radioButtonIMG1.AutoSize = true;
            this.radioButtonIMG1.Location = new System.Drawing.Point(13, 31);
            this.radioButtonIMG1.Name = "radioButtonIMG1";
            this.radioButtonIMG1.Size = new System.Drawing.Size(98, 24);
            this.radioButtonIMG1.TabIndex = 0;
            this.radioButtonIMG1.TabStop = true;
            this.radioButtonIMG1.Text = "Imagem 1";
            this.radioButtonIMG1.UseVisualStyleBackColor = true;
            this.radioButtonIMG1.CheckedChanged += new System.EventHandler(this.radioButtonIMG1_CheckedChanged);
            // 
            // radioButtonIMG2
            // 
            this.radioButtonIMG2.AutoSize = true;
            this.radioButtonIMG2.Location = new System.Drawing.Point(13, 54);
            this.radioButtonIMG2.Name = "radioButtonIMG2";
            this.radioButtonIMG2.Size = new System.Drawing.Size(98, 24);
            this.radioButtonIMG2.TabIndex = 1;
            this.radioButtonIMG2.TabStop = true;
            this.radioButtonIMG2.Text = "Imagem 2";
            this.radioButtonIMG2.UseVisualStyleBackColor = true;
            this.radioButtonIMG2.CheckedChanged += new System.EventHandler(this.radioButtonIMG2_CheckedChanged);
            // 
            // radioButtonIMG3
            // 
            this.radioButtonIMG3.AutoSize = true;
            this.radioButtonIMG3.Location = new System.Drawing.Point(13, 77);
            this.radioButtonIMG3.Name = "radioButtonIMG3";
            this.radioButtonIMG3.Size = new System.Drawing.Size(98, 24);
            this.radioButtonIMG3.TabIndex = 2;
            this.radioButtonIMG3.TabStop = true;
            this.radioButtonIMG3.Text = "Imagem 3";
            this.radioButtonIMG3.UseVisualStyleBackColor = true;
            this.radioButtonIMG3.CheckedChanged += new System.EventHandler(this.radioButtonIMG3_CheckedChanged);
            // 
            // radioButtonIMG4
            // 
            this.radioButtonIMG4.AutoSize = true;
            this.radioButtonIMG4.Location = new System.Drawing.Point(13, 100);
            this.radioButtonIMG4.Name = "radioButtonIMG4";
            this.radioButtonIMG4.Size = new System.Drawing.Size(98, 24);
            this.radioButtonIMG4.TabIndex = 3;
            this.radioButtonIMG4.TabStop = true;
            this.radioButtonIMG4.Text = "Imagem 4";
            this.radioButtonIMG4.UseVisualStyleBackColor = true;
            this.radioButtonIMG4.CheckedChanged += new System.EventHandler(this.radioButtonIMG4_CheckedChanged);
            // 
            // radioButtonIMG5
            // 
            this.radioButtonIMG5.AutoSize = true;
            this.radioButtonIMG5.Location = new System.Drawing.Point(13, 123);
            this.radioButtonIMG5.Name = "radioButtonIMG5";
            this.radioButtonIMG5.Size = new System.Drawing.Size(98, 24);
            this.radioButtonIMG5.TabIndex = 4;
            this.radioButtonIMG5.TabStop = true;
            this.radioButtonIMG5.Text = "Imagem 5";
            this.radioButtonIMG5.UseVisualStyleBackColor = true;
            this.radioButtonIMG5.CheckedChanged += new System.EventHandler(this.radioButtonIMG5_CheckedChanged);
            // 
            // checkBoxTema
            // 
            this.checkBoxTema.AutoSize = true;
            this.checkBoxTema.Location = new System.Drawing.Point(13, 27);
            this.checkBoxTema.Name = "checkBoxTema";
            this.checkBoxTema.Size = new System.Drawing.Size(122, 24);
            this.checkBoxTema.TabIndex = 8;
            this.checkBoxTema.Text = "Modo Escuro";
            this.checkBoxTema.UseVisualStyleBackColor = true;
            this.checkBoxTema.CheckedChanged += new System.EventHandler(this.checkBoxTema_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBoxTema);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(215, 200);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(197, 57);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fundo da imagem";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxLegenda);
            this.groupBox4.Controls.Add(this.labelLegendaTXT);
            this.groupBox4.Controls.Add(this.labelTituloTXT);
            this.groupBox4.Controls.Add(this.textBoxTitulo);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 37);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(400, 157);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Digite as informações pedidas: ";
            // 
            // buttonSair
            // 
            this.buttonSair.Location = new System.Drawing.Point(316, 277);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(96, 41);
            this.buttonSair.TabIndex = 11;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // buttonEnviar
            // 
            this.buttonEnviar.Location = new System.Drawing.Point(214, 277);
            this.buttonEnviar.Name = "buttonEnviar";
            this.buttonEnviar.Size = new System.Drawing.Size(96, 41);
            this.buttonEnviar.TabIndex = 12;
            this.buttonEnviar.Text = "Enviar";
            this.buttonEnviar.UseVisualStyleBackColor = true;
            this.buttonEnviar.Click += new System.EventHandler(this.buttonEnviar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonEnviar);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.labelTituloPag);
            this.Controls.Add(this.groupBoxMeme);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxMeme.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMeme)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTituloIMG;
        private System.Windows.Forms.GroupBox groupBoxMeme;
        private System.Windows.Forms.PictureBox picBoxMeme;
        private System.Windows.Forms.Label labelLegendaIMG;
        private System.Windows.Forms.Label labelTituloPag;
        private System.Windows.Forms.Label labelLegendaTXT;
        private System.Windows.Forms.TextBox textBoxLegenda;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.Label labelTituloTXT;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonIMG3;
        private System.Windows.Forms.RadioButton radioButtonIMG2;
        private System.Windows.Forms.RadioButton radioButtonIMG1;
        private System.Windows.Forms.RadioButton radioButtonIMG5;
        private System.Windows.Forms.RadioButton radioButtonIMG4;
        private System.Windows.Forms.CheckBox checkBoxTema;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Button buttonEnviar;
    }
}

