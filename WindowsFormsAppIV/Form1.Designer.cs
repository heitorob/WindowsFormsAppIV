namespace WindowsFormsAppIV
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblQTDE = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnINSERIR = new System.Windows.Forms.Button();
            this.btnORDENAR = new System.Windows.Forms.Button();
            this.btnREMOVER = new System.Windows.Forms.Button();
            this.btnEXIBIR = new System.Windows.Forms.Button();
            this.txtTEXTO = new System.Windows.Forms.TextBox();
            this.txtCONTEUDO = new System.Windows.Forms.TextBox();
            this.txtINDICE = new System.Windows.Forms.TextBox();
            this.cmbLISTA = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Texto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lista:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantidade:";
            // 
            // lblQTDE
            // 
            this.lblQTDE.AutoSize = true;
            this.lblQTDE.Location = new System.Drawing.Point(211, 314);
            this.lblQTDE.Name = "lblQTDE";
            this.lblQTDE.Size = new System.Drawing.Size(13, 13);
            this.lblQTDE.TabIndex = 3;
            this.lblQTDE.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 421);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Índice do Combo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 463);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Texto do Combo:";
            // 
            // btnINSERIR
            // 
            this.btnINSERIR.Location = new System.Drawing.Point(137, 89);
            this.btnINSERIR.Name = "btnINSERIR";
            this.btnINSERIR.Size = new System.Drawing.Size(155, 42);
            this.btnINSERIR.TabIndex = 6;
            this.btnINSERIR.Text = "Inserir no Combo";
            this.btnINSERIR.UseVisualStyleBackColor = true;
            this.btnINSERIR.Click += new System.EventHandler(this.btnINSERIR_Click);
            // 
            // btnORDENAR
            // 
            this.btnORDENAR.Location = new System.Drawing.Point(507, 89);
            this.btnORDENAR.Name = "btnORDENAR";
            this.btnORDENAR.Size = new System.Drawing.Size(155, 42);
            this.btnORDENAR.TabIndex = 7;
            this.btnORDENAR.Text = "Ordenar o Combo";
            this.btnORDENAR.UseVisualStyleBackColor = true;
            this.btnORDENAR.Click += new System.EventHandler(this.btnORDENAR_Click);
            // 
            // btnREMOVER
            // 
            this.btnREMOVER.Location = new System.Drawing.Point(322, 246);
            this.btnREMOVER.Name = "btnREMOVER";
            this.btnREMOVER.Size = new System.Drawing.Size(155, 42);
            this.btnREMOVER.TabIndex = 8;
            this.btnREMOVER.Text = "Remover do Combo";
            this.btnREMOVER.UseVisualStyleBackColor = true;
            this.btnREMOVER.Click += new System.EventHandler(this.btnREMOVER_Click);
            // 
            // btnEXIBIR
            // 
            this.btnEXIBIR.Location = new System.Drawing.Point(322, 353);
            this.btnEXIBIR.Name = "btnEXIBIR";
            this.btnEXIBIR.Size = new System.Drawing.Size(155, 42);
            this.btnEXIBIR.TabIndex = 9;
            this.btnEXIBIR.Text = "Exibir Dados no Combo";
            this.btnEXIBIR.UseVisualStyleBackColor = true;
            this.btnEXIBIR.Click += new System.EventHandler(this.btnEXIBIR_Click);
            // 
            // txtTEXTO
            // 
            this.txtTEXTO.Location = new System.Drawing.Point(165, 26);
            this.txtTEXTO.Name = "txtTEXTO";
            this.txtTEXTO.Size = new System.Drawing.Size(471, 20);
            this.txtTEXTO.TabIndex = 10;
            // 
            // txtCONTEUDO
            // 
            this.txtCONTEUDO.Location = new System.Drawing.Point(165, 456);
            this.txtCONTEUDO.Name = "txtCONTEUDO";
            this.txtCONTEUDO.Size = new System.Drawing.Size(471, 20);
            this.txtCONTEUDO.TabIndex = 11;
            // 
            // txtINDICE
            // 
            this.txtINDICE.Location = new System.Drawing.Point(165, 414);
            this.txtINDICE.Name = "txtINDICE";
            this.txtINDICE.Size = new System.Drawing.Size(471, 20);
            this.txtINDICE.TabIndex = 12;
            // 
            // cmbLISTA
            // 
            this.cmbLISTA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLISTA.FormattingEnabled = true;
            this.cmbLISTA.Location = new System.Drawing.Point(165, 162);
            this.cmbLISTA.Name = "cmbLISTA";
            this.cmbLISTA.Size = new System.Drawing.Size(471, 21);
            this.cmbLISTA.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 540);
            this.Controls.Add(this.cmbLISTA);
            this.Controls.Add(this.txtINDICE);
            this.Controls.Add(this.txtCONTEUDO);
            this.Controls.Add(this.txtTEXTO);
            this.Controls.Add(this.btnEXIBIR);
            this.Controls.Add(this.btnREMOVER);
            this.Controls.Add(this.btnORDENAR);
            this.Controls.Add(this.btnINSERIR);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblQTDE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblQTDE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnINSERIR;
        private System.Windows.Forms.Button btnORDENAR;
        private System.Windows.Forms.Button btnREMOVER;
        private System.Windows.Forms.Button btnEXIBIR;
        private System.Windows.Forms.TextBox txtTEXTO;
        private System.Windows.Forms.TextBox txtCONTEUDO;
        private System.Windows.Forms.TextBox txtINDICE;
        private System.Windows.Forms.ComboBox cmbLISTA;
    }
}

