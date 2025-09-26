namespace ProyectoProg
{
    partial class Form3
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
            this.button1 = new System.Windows.Forms.Button();
            this.piedra = new System.Windows.Forms.RadioButton();
            this.papel = new System.Windows.Forms.RadioButton();
            this.tijera = new System.Windows.Forms.RadioButton();
            this.CERRA = new System.Windows.Forms.Button();
            this.lbResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textCompu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(596, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "JUGA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // piedra
            // 
            this.piedra.AutoSize = true;
            this.piedra.Location = new System.Drawing.Point(295, 144);
            this.piedra.Name = "piedra";
            this.piedra.Size = new System.Drawing.Size(64, 20);
            this.piedra.TabIndex = 1;
            this.piedra.TabStop = true;
            this.piedra.Text = "RACK";
            this.piedra.UseVisualStyleBackColor = true;
            // 
            // papel
            // 
            this.papel.AutoSize = true;
            this.papel.Location = new System.Drawing.Point(295, 192);
            this.papel.Name = "papel";
            this.papel.Size = new System.Drawing.Size(77, 20);
            this.papel.TabIndex = 2;
            this.papel.TabStop = true;
            this.papel.Text = "PEIPER";
            this.papel.UseVisualStyleBackColor = true;
            // 
            // tijera
            // 
            this.tijera.AutoSize = true;
            this.tijera.Location = new System.Drawing.Point(295, 227);
            this.tijera.Name = "tijera";
            this.tijera.Size = new System.Drawing.Size(100, 20);
            this.tijera.TabIndex = 3;
            this.tijera.TabStop = true;
            this.tijera.Text = "CHAINSAW";
            this.tijera.UseVisualStyleBackColor = true;
            this.tijera.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // CERRA
            // 
            this.CERRA.Location = new System.Drawing.Point(614, 223);
            this.CERRA.Name = "CERRA";
            this.CERRA.Size = new System.Drawing.Size(75, 23);
            this.CERRA.TabIndex = 4;
            this.CERRA.Text = "NO VA MAS";
            this.CERRA.UseVisualStyleBackColor = true;
            this.CERRA.Click += new System.EventHandler(this.CERRA_Click);
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(399, 359);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(105, 16);
            this.lbResult.TabIndex = 5;
            this.lbResult.Text = "ESPERANDING";
            this.lbResult.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Eleccion de dios";
            // 
            // textCompu
            // 
            this.textCompu.AutoSize = true;
            this.textCompu.Location = new System.Drawing.Point(91, 359);
            this.textCompu.Name = "textCompu";
            this.textCompu.Size = new System.Drawing.Size(0, 16);
            this.textCompu.TabIndex = 7;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textCompu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.CERRA);
            this.Controls.Add(this.tijera);
            this.Controls.Add(this.papel);
            this.Controls.Add(this.piedra);
            this.Controls.Add(this.button1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton piedra;
        private System.Windows.Forms.RadioButton papel;
        private System.Windows.Forms.RadioButton tijera;
        private System.Windows.Forms.Button CERRA;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label textCompu;
    }
}