namespace WinFormsApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtDisplay = new TextBox();
            btnPorcentagem = new BotaoArredondado();
            btnCE = new BotaoArredondado();
            btnDelete = new BotaoArredondado();
            btnDivisao = new BotaoArredondado();
            btnRaiz = new BotaoArredondado();
            btnQuadrado = new BotaoArredondado();
            btnFracao = new BotaoArredondado();
            btnMultiplicacao = new BotaoArredondado();
            btn3 = new BotaoArredondado();
            btn2 = new BotaoArredondado();
            btn1 = new BotaoArredondado();
            btnSubtracao = new BotaoArredondado();
            btn6 = new BotaoArredondado();
            btn5 = new BotaoArredondado();
            btn4 = new BotaoArredondado();
            btnSoma = new BotaoArredondado();
            btn9 = new BotaoArredondado();
            btn8 = new BotaoArredondado();
            btn7 = new BotaoArredondado();
            btnIgual = new BotaoArredondado();
            btnPonto = new BotaoArredondado();
            btn0 = new BotaoArredondado();
            btnInversao = new BotaoArredondado();
            btnC = new BotaoArredondado();
            lblHistorico = new Label();
            SuspendLayout();

            txtDisplay.Location = new Point(12, 34);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.ReadOnly = true;
            txtDisplay.Size = new Size(218, 23);
            txtDisplay.TabIndex = 0;
            txtDisplay.TextChanged += txtDisplay_TextChanged;

            // Row 1 - Y:63
            btnPorcentagem.Location = new Point(3, 63); btnPorcentagem.Size = new Size(58, 39); btnPorcentagem.Text = "%"; btnPorcentagem.TabIndex = 1; btnPorcentagem.Click += btnPorcentagem_Click;
            btnCE.Location = new Point(63, 63); btnCE.Size = new Size(58, 39); btnCE.Text = "CE"; btnCE.TabIndex = 2; btnCE.Click += btnCE_Click;
            btnC.Location = new Point(123, 63); btnC.Size = new Size(58, 39); btnC.Text = "C"; btnC.TabIndex = 3; btnC.Click += btnC_Click;
            btnDelete.Location = new Point(183, 63); btnDelete.Size = new Size(58, 39); btnDelete.Text = "⌫"; btnDelete.TabIndex = 4; btnDelete.Click += btnDelete_Click;

            // Row 2 - Y:105
            btnFracao.Location = new Point(3, 105); btnFracao.Size = new Size(58, 39); btnFracao.Text = "½"; btnFracao.TabIndex = 5; btnFracao.Click += btnFracao_Click;
            btnQuadrado.Location = new Point(63, 105); btnQuadrado.Size = new Size(58, 39); btnQuadrado.Text = "x²"; btnQuadrado.TabIndex = 6; btnQuadrado.Click += btnQuadrado_Click;
            btnRaiz.Location = new Point(123, 105); btnRaiz.Size = new Size(58, 39); btnRaiz.Text = "²√x"; btnRaiz.TabIndex = 7; btnRaiz.Click += btnRaiz_Click;
            btnDivisao.Location = new Point(183, 105); btnDivisao.Size = new Size(58, 39); btnDivisao.Text = "÷"; btnDivisao.TabIndex = 8; btnDivisao.Click += btnDivisao_Click;

            // Row 3 - Y:147
            btn1.Location = new Point(3, 147); btn1.Size = new Size(58, 39); btn1.Text = "1"; btn1.TabIndex = 9; btn1.Click += btn1_Click;
            btn2.Location = new Point(63, 147); btn2.Size = new Size(58, 39); btn2.Text = "2"; btn2.TabIndex = 10; btn2.Click += btn2_Click;
            btn3.Location = new Point(123, 147); btn3.Size = new Size(58, 39); btn3.Text = "3"; btn3.TabIndex = 11; btn3.Click += btn3_Click;
            btnMultiplicacao.Location = new Point(183, 147); btnMultiplicacao.Size = new Size(58, 39); btnMultiplicacao.Text = "x"; btnMultiplicacao.TabIndex = 12; btnMultiplicacao.Click += btnMultiplicacao_Click;

            // Row 4 - Y:189
            btn4.Location = new Point(3, 189); btn4.Size = new Size(58, 39); btn4.Text = "4"; btn4.TabIndex = 13; btn4.Click += btn4_Click;
            btn5.Location = new Point(63, 189); btn5.Size = new Size(58, 39); btn5.Text = "5"; btn5.TabIndex = 14; btn5.Click += btn5_Click;
            btn6.Location = new Point(123, 189); btn6.Size = new Size(58, 39); btn6.Text = "6"; btn6.TabIndex = 15; btn6.Click += btn6_Click;
            btnSubtracao.Location = new Point(183, 189); btnSubtracao.Size = new Size(58, 39); btnSubtracao.Text = "-"; btnSubtracao.TabIndex = 16; btnSubtracao.Click += btnSubtracao_Click;

            // Row 5 - Y:231
            btn7.Location = new Point(3, 231); btn7.Size = new Size(58, 39); btn7.Text = "7"; btn7.TabIndex = 17; btn7.Click += btn7_Click;
            btn8.Location = new Point(63, 231); btn8.Size = new Size(58, 39); btn8.Text = "8"; btn8.TabIndex = 18; btn8.Click += btn8_Click;
            btn9.Location = new Point(123, 231); btn9.Size = new Size(58, 39); btn9.Text = "9"; btn9.TabIndex = 19; btn9.Click += btn9_Click;
            btnSoma.Location = new Point(183, 231); btnSoma.Size = new Size(58, 39); btnSoma.Text = "+"; btnSoma.TabIndex = 20; btnSoma.Click += btnSoma_Click;

            // Row 6 - Y:273
            btnInversao.Location = new Point(3, 273); btnInversao.Size = new Size(58, 39); btnInversao.Text = "+/-"; btnInversao.TabIndex = 21; btnInversao.Click += btnInversao_Click;
            btn0.Location = new Point(63, 273); btn0.Size = new Size(58, 39); btn0.Text = "0"; btn0.TabIndex = 22; btn0.Click += btn0_Click;
            btnPonto.Location = new Point(123, 273); btnPonto.Size = new Size(58, 39); btnPonto.Text = "."; btnPonto.TabIndex = 23; btnPonto.Click += btnPonto_Click;
            btnIgual.Location = new Point(183, 273); btnIgual.Size = new Size(58, 39); btnIgual.Text = "="; btnIgual.TabIndex = 24; btnIgual.Click += btnIgual_Click;

            lblHistorico.AutoSize = true;
            lblHistorico.Location = new Point(2, 9);
            lblHistorico.Name = "lblHistorico";
            lblHistorico.Size = new Size(0, 15);
            lblHistorico.TabIndex = 25;
            lblHistorico.TextAlign = ContentAlignment.MiddleRight;
            lblHistorico.Click += lblHistorico_Click;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(244, 318);
            Controls.Add(lblHistorico);
            Controls.Add(btnIgual); Controls.Add(btnPonto); Controls.Add(btn0); Controls.Add(btnInversao);
            Controls.Add(btnSoma); Controls.Add(btn9); Controls.Add(btn8); Controls.Add(btn7);
            Controls.Add(btnSubtracao); Controls.Add(btn6); Controls.Add(btn5); Controls.Add(btn4);
            Controls.Add(btnMultiplicacao); Controls.Add(btn3); Controls.Add(btn2); Controls.Add(btn1);
            Controls.Add(btnDivisao); Controls.Add(btnRaiz); Controls.Add(btnQuadrado); Controls.Add(btnFracao);
            Controls.Add(btnDelete); Controls.Add(btnC); Controls.Add(btnCE); Controls.Add(btnPorcentagem);
            Controls.Add(txtDisplay);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox txtDisplay;
        private BotaoArredondado btnPorcentagem;
        private BotaoArredondado btnCE;
        private BotaoArredondado btnDelete;
        private BotaoArredondado btnDivisao;
        private BotaoArredondado btnRaiz;
        private BotaoArredondado btnQuadrado;
        private BotaoArredondado btnFracao;
        private BotaoArredondado btnMultiplicacao;
        private BotaoArredondado btn3;
        private BotaoArredondado btn2;
        private BotaoArredondado btn1;
        private BotaoArredondado btnSubtracao;
        private BotaoArredondado btn6;
        private BotaoArredondado btn5;
        private BotaoArredondado btn4;
        private BotaoArredondado btnSoma;
        private BotaoArredondado btn9;
        private BotaoArredondado btn8;
        private BotaoArredondado btn7;
        private BotaoArredondado btnIgual;
        private BotaoArredondado btnPonto;
        private BotaoArredondado btn0;
        private BotaoArredondado btnInversao;
        private BotaoArredondado btnC;
        private Label lblHistorico;
    }
}