namespace CalculadoraTP
{
    partial class Calculadora
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
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.btnSoma = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnVezes = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnRaix = new System.Windows.Forms.Button();
            this.btnEleva = new System.Windows.Forms.Button();
            this.btnJunta = new System.Windows.Forms.Button();
            this.btnFaxineira = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(12, 12);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(234, 20);
            this.txtNum1.TabIndex = 0;
            this.txtNum1.TextChanged += new System.EventHandler(this.txtNum1_TextChanged);
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(252, 12);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(234, 20);
            this.txtNum2.TabIndex = 1;
            // 
            // btnSoma
            // 
            this.btnSoma.Location = new System.Drawing.Point(129, 148);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(75, 23);
            this.btnSoma.TabIndex = 2;
            this.btnSoma.Text = "+";
            this.btnSoma.UseVisualStyleBackColor = true;
            this.btnSoma.Click += new System.EventHandler(this.btnSoma_Click);
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(210, 148);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(75, 23);
            this.btnSub.TabIndex = 3;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnVezes
            // 
            this.btnVezes.Location = new System.Drawing.Point(291, 148);
            this.btnVezes.Name = "btnVezes";
            this.btnVezes.Size = new System.Drawing.Size(75, 23);
            this.btnVezes.TabIndex = 4;
            this.btnVezes.Text = "X";
            this.btnVezes.UseVisualStyleBackColor = true;
            this.btnVezes.Click += new System.EventHandler(this.btnVezes_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(129, 177);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(75, 23);
            this.btnDivide.TabIndex = 5;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnRaix
            // 
            this.btnRaix.Location = new System.Drawing.Point(210, 177);
            this.btnRaix.Name = "btnRaix";
            this.btnRaix.Size = new System.Drawing.Size(75, 23);
            this.btnRaix.TabIndex = 6;
            this.btnRaix.Text = "Raíx";
            this.btnRaix.UseVisualStyleBackColor = true;
            this.btnRaix.Click += new System.EventHandler(this.btnRaix_Click);
            // 
            // btnEleva
            // 
            this.btnEleva.Location = new System.Drawing.Point(291, 177);
            this.btnEleva.Name = "btnEleva";
            this.btnEleva.Size = new System.Drawing.Size(75, 23);
            this.btnEleva.TabIndex = 7;
            this.btnEleva.Text = "Eleva";
            this.btnEleva.UseVisualStyleBackColor = true;
            this.btnEleva.Click += new System.EventHandler(this.btnEleva_Click);
            // 
            // btnJunta
            // 
            this.btnJunta.Location = new System.Drawing.Point(210, 119);
            this.btnJunta.Name = "btnJunta";
            this.btnJunta.Size = new System.Drawing.Size(75, 23);
            this.btnJunta.TabIndex = 8;
            this.btnJunta.Text = "ComAtena";
            this.btnJunta.UseVisualStyleBackColor = true;
            this.btnJunta.Click += new System.EventHandler(this.btnJunta_Click);
            // 
            // btnFaxineira
            // 
            this.btnFaxineira.Location = new System.Drawing.Point(210, 267);
            this.btnFaxineira.Name = "btnFaxineira";
            this.btnFaxineira.Size = new System.Drawing.Size(75, 23);
            this.btnFaxineira.TabIndex = 9;
            this.btnFaxineira.Text = "Limpa";
            this.btnFaxineira.UseVisualStyleBackColor = true;
            this.btnFaxineira.Click += new System.EventHandler(this.btnFaxineira_Click);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = global::CalculadoraTP.Properties.Resources.Sem_título;
            this.ClientSize = new System.Drawing.Size(499, 306);
            this.Controls.Add(this.btnFaxineira);
            this.Controls.Add(this.btnJunta);
            this.Controls.Add(this.btnEleva);
            this.Controls.Add(this.btnRaix);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnVezes);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Calculadora";
            this.Text = "SoulEater";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnVezes;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnRaix;
        private System.Windows.Forms.Button btnEleva;
        private System.Windows.Forms.Button btnJunta;
        private System.Windows.Forms.Button btnFaxineira;
    }
}

