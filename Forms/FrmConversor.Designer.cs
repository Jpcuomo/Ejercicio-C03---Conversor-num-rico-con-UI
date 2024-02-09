namespace Forms
{
    partial class FrmConversor
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConversor));
            lblADecimal = new Label();
            lblABinario = new Label();
            tbxBinADec = new TextBox();
            tbxDecABin = new TextBox();
            btnBinarioADecimal = new Button();
            imgIconos = new ImageList(components);
            btnDecimalABinario = new Button();
            tbxBinario = new TextBox();
            tbxDecimal = new TextBox();
            lblBinarioErroneo = new Label();
            lblDecimalErroneo = new Label();
            SuspendLayout();
            // 
            // lblADecimal
            // 
            lblADecimal.AutoSize = true;
            lblADecimal.Location = new Point(10, 28);
            lblADecimal.Name = "lblADecimal";
            lblADecimal.Size = new Size(127, 20);
            lblADecimal.TabIndex = 0;
            lblADecimal.Text = "Binario a Decimal";
            // 
            // lblABinario
            // 
            lblABinario.AutoSize = true;
            lblABinario.Location = new Point(10, 80);
            lblABinario.Name = "lblABinario";
            lblABinario.Size = new Size(127, 20);
            lblABinario.TabIndex = 1;
            lblABinario.Text = "Decimal a Binario";
            // 
            // tbxBinADec
            // 
            tbxBinADec.Location = new Point(143, 24);
            tbxBinADec.Name = "tbxBinADec";
            tbxBinADec.Size = new Size(171, 27);
            tbxBinADec.TabIndex = 2;
            tbxBinADec.TextChanged += tbxBinADec_TextChanged;
            // 
            // tbxDecABin
            // 
            tbxDecABin.Location = new Point(143, 77);
            tbxDecABin.Name = "tbxDecABin";
            tbxDecABin.Size = new Size(171, 27);
            tbxDecABin.TabIndex = 3;
            tbxDecABin.TextChanged += tbxDecABin_TextChanged;
            // 
            // btnBinarioADecimal
            // 
            btnBinarioADecimal.ImageIndex = 0;
            btnBinarioADecimal.ImageList = imgIconos;
            btnBinarioADecimal.Location = new Point(320, 24);
            btnBinarioADecimal.Name = "btnBinarioADecimal";
            btnBinarioADecimal.Size = new Size(94, 29);
            btnBinarioADecimal.TabIndex = 4;
            btnBinarioADecimal.UseVisualStyleBackColor = true;
            btnBinarioADecimal.Click += btnBinarioADecimal_Click;
            // 
            // imgIconos
            // 
            imgIconos.ColorDepth = ColorDepth.Depth32Bit;
            imgIconos.ImageStream = (ImageListStreamer)resources.GetObject("imgIconos.ImageStream");
            imgIconos.TransparentColor = Color.Transparent;
            imgIconos.Images.SetKeyName(0, "281.png");
            // 
            // btnDecimalABinario
            // 
            btnDecimalABinario.ImageIndex = 0;
            btnDecimalABinario.ImageList = imgIconos;
            btnDecimalABinario.Location = new Point(320, 77);
            btnDecimalABinario.Name = "btnDecimalABinario";
            btnDecimalABinario.Size = new Size(94, 29);
            btnDecimalABinario.TabIndex = 5;
            btnDecimalABinario.UseVisualStyleBackColor = true;
            btnDecimalABinario.Click += btnDecimalABinario_Click;
            // 
            // tbxBinario
            // 
            tbxBinario.Location = new Point(420, 79);
            tbxBinario.Name = "tbxBinario";
            tbxBinario.Size = new Size(171, 27);
            tbxBinario.TabIndex = 7;
            // 
            // tbxDecimal
            // 
            tbxDecimal.Location = new Point(420, 26);
            tbxDecimal.Name = "tbxDecimal";
            tbxDecimal.Size = new Size(171, 27);
            tbxDecimal.TabIndex = 6;
            // 
            // lblBinarioErroneo
            // 
            lblBinarioErroneo.AutoSize = true;
            lblBinarioErroneo.ForeColor = Color.OrangeRed;
            lblBinarioErroneo.Location = new Point(143, 54);
            lblBinarioErroneo.Name = "lblBinarioErroneo";
            lblBinarioErroneo.Size = new Size(0, 20);
            lblBinarioErroneo.TabIndex = 8;
            // 
            // lblDecimalErroneo
            // 
            lblDecimalErroneo.AutoSize = true;
            lblDecimalErroneo.ForeColor = Color.OrangeRed;
            lblDecimalErroneo.Location = new Point(143, 107);
            lblDecimalErroneo.Name = "lblDecimalErroneo";
            lblDecimalErroneo.Size = new Size(0, 20);
            lblDecimalErroneo.TabIndex = 9;
            // 
            // FrmConversor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 135);
            Controls.Add(lblDecimalErroneo);
            Controls.Add(lblBinarioErroneo);
            Controls.Add(tbxBinario);
            Controls.Add(tbxDecimal);
            Controls.Add(btnDecimalABinario);
            Controls.Add(btnBinarioADecimal);
            Controls.Add(tbxDecABin);
            Controls.Add(tbxBinADec);
            Controls.Add(lblABinario);
            Controls.Add(lblADecimal);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FrmConversor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Conversor Numérico";
            Load += FrmConversor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblADecimal;
        private Label lblABinario;
        private TextBox tbxBinADec;
        private TextBox tbxDecABin;
        private Button btnBinarioADecimal;
        private Button btnDecimalABinario;
        private TextBox tbxBinario;
        private TextBox tbxDecimal;
        private ImageList imgIconos;
        private Label lblBinarioErroneo;
        private Label lblDecimalErroneo;
    }
}
