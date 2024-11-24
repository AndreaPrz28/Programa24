namespace Programa24
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
            panelprincipal = new Panel();
            richTextBoxResultados = new RichTextBox();
            buttonVer = new Button();
            textBoxnum = new TextBox();
            labelnumero = new Label();
            label1 = new Label();
            label2 = new Label();
            panelprincipal.SuspendLayout();
            SuspendLayout();
            // 
            // panelprincipal
            // 
            panelprincipal.BackColor = SystemColors.GradientActiveCaption;
            panelprincipal.Controls.Add(label2);
            panelprincipal.Controls.Add(richTextBoxResultados);
            panelprincipal.Controls.Add(buttonVer);
            panelprincipal.Controls.Add(textBoxnum);
            panelprincipal.Controls.Add(labelnumero);
            panelprincipal.Controls.Add(label1);
            panelprincipal.Location = new Point(13, 14);
            panelprincipal.Name = "panelprincipal";
            panelprincipal.Size = new Size(924, 601);
            panelprincipal.TabIndex = 0;
            panelprincipal.Paint += panelprincipal_Paint;
            // 
            // richTextBoxResultados
            // 
            richTextBoxResultados.BackColor = Color.Azure;
            richTextBoxResultados.Location = new Point(366, 308);
            richTextBoxResultados.Name = "richTextBoxResultados";
            richTextBoxResultados.Size = new Size(207, 272);
            richTextBoxResultados.TabIndex = 4;
            richTextBoxResultados.Text = "";
            // 
            // buttonVer
            // 
            buttonVer.Location = new Point(415, 257);
            buttonVer.Name = "buttonVer";
            buttonVer.Size = new Size(108, 36);
            buttonVer.TabIndex = 3;
            buttonVer.Text = "Ver Tabla";
            buttonVer.UseVisualStyleBackColor = true;
            buttonVer.Click += buttonVer_Click;
            // 
            // textBoxnum
            // 
            textBoxnum.BackColor = Color.Azure;
            textBoxnum.ForeColor = SystemColors.ActiveCaptionText;
            textBoxnum.Location = new Point(366, 207);
            textBoxnum.Name = "textBoxnum";
            textBoxnum.Size = new Size(207, 31);
            textBoxnum.TabIndex = 2;
            textBoxnum.TextAlign = HorizontalAlignment.Center;
            // 
            // labelnumero
            // 
            labelnumero.AutoSize = true;
            labelnumero.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelnumero.Location = new Point(346, 149);
            labelnumero.Name = "labelnumero";
            labelnumero.Size = new Size(252, 29);
            labelnumero.TabIndex = 1;
            labelnumero.Text = "¿Cuál tabla quieres?";
            labelnumero.UseMnemonic = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Harrington", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 64, 64);
            label1.Location = new Point(308, 92);
            label1.Name = "label1";
            label1.Size = new Size(344, 37);
            label1.TabIndex = 0;
            label1.Text = "~ Tabla de Multiplicar ~";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Blackadder ITC", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(210, 23);
            label2.Name = "label2";
            label2.Size = new Size(554, 46);
            label2.TabIndex = 5;
            label2.Text = "\"\"\"   Andrea Guadalupe Perez Jimenez   \"\"\"";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 646);
            Controls.Add(panelprincipal);
            Name = "Form1";
            Text = "Form1";
            panelprincipal.ResumeLayout(false);
            panelprincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelprincipal;
        private Label label1;
        private Label labelnumero;
        private TextBox textBoxnum;
        private RichTextBox richTextBoxResultados;
        private Button buttonVer;
        private Label label2;
    }
}
