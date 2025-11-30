namespace SelecaoCoresComboBox
{
    partial class Frm_TelaInicial
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
            Lbl_Titulo = new Label();
            Cmb_Cores = new ComboBox();
            Btn_Aplicar = new Button();
            Btn_Resetar = new Button();
            Pnl_Cor = new Panel();
            Lbl_TituloCorEscolhida = new Label();
            Lbl_CorEscolhida = new Label();
            SuspendLayout();
            // 
            // Lbl_Titulo
            // 
            Lbl_Titulo.AutoSize = true;
            Lbl_Titulo.Location = new Point(12, 9);
            Lbl_Titulo.Name = "Lbl_Titulo";
            Lbl_Titulo.Size = new Size(97, 15);
            Lbl_Titulo.TabIndex = 0;
            Lbl_Titulo.Text = "Escolha uma cor:";
            // 
            // Cmb_Cores
            // 
            Cmb_Cores.FormattingEnabled = true;
            Cmb_Cores.Location = new Point(12, 27);
            Cmb_Cores.Name = "Cmb_Cores";
            Cmb_Cores.Size = new Size(200, 23);
            Cmb_Cores.TabIndex = 1;
            // 
            // Btn_Aplicar
            // 
            Btn_Aplicar.Location = new Point(137, 56);
            Btn_Aplicar.Name = "Btn_Aplicar";
            Btn_Aplicar.Size = new Size(75, 23);
            Btn_Aplicar.TabIndex = 2;
            Btn_Aplicar.Text = "Aplicar";
            Btn_Aplicar.UseVisualStyleBackColor = true;
            Btn_Aplicar.Click += Btn_Aplicar_Click;
            // 
            // Btn_Resetar
            // 
            Btn_Resetar.Location = new Point(56, 56);
            Btn_Resetar.Name = "Btn_Resetar";
            Btn_Resetar.Size = new Size(75, 23);
            Btn_Resetar.TabIndex = 3;
            Btn_Resetar.Text = "Resetar";
            Btn_Resetar.UseVisualStyleBackColor = true;
            Btn_Resetar.Click += Btn_Resetar_Click;
            // 
            // Pnl_Cor
            // 
            Pnl_Cor.Location = new Point(261, 27);
            Pnl_Cor.Name = "Pnl_Cor";
            Pnl_Cor.Size = new Size(200, 100);
            Pnl_Cor.TabIndex = 4;
            // 
            // Lbl_TituloCorEscolhida
            // 
            Lbl_TituloCorEscolhida.AutoSize = true;
            Lbl_TituloCorEscolhida.Location = new Point(261, 9);
            Lbl_TituloCorEscolhida.Name = "Lbl_TituloCorEscolhida";
            Lbl_TituloCorEscolhida.Size = new Size(82, 15);
            Lbl_TituloCorEscolhida.TabIndex = 5;
            Lbl_TituloCorEscolhida.Text = "Cor Escolhida:";
            // 
            // Lbl_CorEscolhida
            // 
            Lbl_CorEscolhida.AutoSize = true;
            Lbl_CorEscolhida.Location = new Point(340, 9);
            Lbl_CorEscolhida.Name = "Lbl_CorEscolhida";
            Lbl_CorEscolhida.Size = new Size(0, 15);
            Lbl_CorEscolhida.TabIndex = 6;
            // 
            // Frm_TelaInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 146);
            Controls.Add(Lbl_CorEscolhida);
            Controls.Add(Lbl_TituloCorEscolhida);
            Controls.Add(Pnl_Cor);
            Controls.Add(Btn_Resetar);
            Controls.Add(Btn_Aplicar);
            Controls.Add(Cmb_Cores);
            Controls.Add(Lbl_Titulo);
            MaximizeBox = false;
            Name = "Frm_TelaInicial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Seleção de Cores ComboBox";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbl_Titulo;
        private ComboBox Cmb_Cores;
        private Button Btn_Aplicar;
        private Button Btn_Resetar;
        private Panel Pnl_Cor;
        private Label Lbl_TituloCorEscolhida;
        private Label Lbl_CorEscolhida;
    }
}
