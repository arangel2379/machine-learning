namespace AGAARV
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this._btnrun = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this._txtBestCrom = new System.Windows.Forms.RichTextBox();
            this._txtWorstCrom = new System.Windows.Forms.RichTextBox();
            this._txtPC = new System.Windows.Forms.TextBox();
            this._txtPM = new System.Windows.Forms.TextBox();
            this._txtEvol = new System.Windows.Forms.TextBox();
            this._btnAG = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // _btnrun
            // 
            this._btnrun.Location = new System.Drawing.Point(615, 9);
            this._btnrun.Name = "_btnrun";
            this._btnrun.Size = new System.Drawing.Size(117, 23);
            this._btnrun.TabIndex = 0;
            this._btnrun.Text = "Generar Poblacion";
            this._btnrun.UseVisualStyleBackColor = true;
            this._btnrun.Click += new System.EventHandler(this._btnrun_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Probabilidad de Cruza:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Probabilidad de Mutacion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(422, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Evoluciones:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._btnAG);
            this.groupBox1.Controls.Add(this._txtEvol);
            this.groupBox1.Controls.Add(this._txtPM);
            this.groupBox1.Controls.Add(this._txtPC);
            this.groupBox1.Controls.Add(this._btnrun);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(737, 60);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Iniciales";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this._txtBestCrom);
            this.groupBox2.Location = new System.Drawing.Point(12, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(732, 304);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mejores Cromosomas";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this._txtWorstCrom);
            this.groupBox3.Location = new System.Drawing.Point(12, 411);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(732, 269);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Peores Cromosomas";
            // 
            // _txtBestCrom
            // 
            this._txtBestCrom.Location = new System.Drawing.Point(6, 19);
            this._txtBestCrom.Name = "_txtBestCrom";
            this._txtBestCrom.Size = new System.Drawing.Size(706, 254);
            this._txtBestCrom.TabIndex = 0;
            this._txtBestCrom.Text = "";
            // 
            // _txtWorstCrom
            // 
            this._txtWorstCrom.Location = new System.Drawing.Point(9, 19);
            this._txtWorstCrom.Name = "_txtWorstCrom";
            this._txtWorstCrom.Size = new System.Drawing.Size(703, 228);
            this._txtWorstCrom.TabIndex = 0;
            this._txtWorstCrom.Text = "";
            // 
            // _txtPC
            // 
            this._txtPC.Location = new System.Drawing.Point(125, 21);
            this._txtPC.Name = "_txtPC";
            this._txtPC.Size = new System.Drawing.Size(66, 20);
            this._txtPC.TabIndex = 4;
            this._txtPC.Text = "0.70";
            // 
            // _txtPM
            // 
            this._txtPM.Location = new System.Drawing.Point(350, 21);
            this._txtPM.Name = "_txtPM";
            this._txtPM.Size = new System.Drawing.Size(59, 20);
            this._txtPM.TabIndex = 5;
            this._txtPM.Text = "0.0555";
            // 
            // _txtEvol
            // 
            this._txtEvol.Location = new System.Drawing.Point(496, 25);
            this._txtEvol.Name = "_txtEvol";
            this._txtEvol.Size = new System.Drawing.Size(100, 20);
            this._txtEvol.TabIndex = 6;
            this._txtEvol.Text = "30";
            // 
            // _btnAG
            // 
            this._btnAG.Location = new System.Drawing.Point(615, 34);
            this._btnAG.Name = "_btnAG";
            this._btnAG.Size = new System.Drawing.Size(117, 23);
            this._btnAG.TabIndex = 7;
            this._btnAG.Text = "Ejecutar AG";
            this._btnAG.UseVisualStyleBackColor = true;
            this._btnAG.Click += new System.EventHandler(this._btnAG_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(800, 42);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(155, 408);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 706);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _btnrun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button _btnAG;
        private System.Windows.Forms.TextBox _txtEvol;
        private System.Windows.Forms.TextBox _txtPM;
        private System.Windows.Forms.TextBox _txtPC;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox _txtBestCrom;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox _txtWorstCrom;
        private System.Windows.Forms.ListView listView1;
    }
}

