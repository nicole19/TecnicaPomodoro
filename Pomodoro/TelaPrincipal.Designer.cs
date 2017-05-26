namespace Pomodoro
{
    partial class TelaPrincipal
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
            this.btnAlarme = new System.Windows.Forms.Button();
            this.btnTarefas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAlarme
            // 
            this.btnAlarme.Location = new System.Drawing.Point(29, 22);
            this.btnAlarme.Name = "btnAlarme";
            this.btnAlarme.Size = new System.Drawing.Size(94, 73);
            this.btnAlarme.TabIndex = 0;
            this.btnAlarme.Text = "Iniciar Tarefas";
            this.btnAlarme.UseVisualStyleBackColor = true;
            this.btnAlarme.Click += new System.EventHandler(this.btnAlarme_Click);
            // 
            // btnTarefas
            // 
            this.btnTarefas.Location = new System.Drawing.Point(162, 22);
            this.btnTarefas.Name = "btnTarefas";
            this.btnTarefas.Size = new System.Drawing.Size(94, 73);
            this.btnTarefas.TabIndex = 1;
            this.btnTarefas.Text = "Administrar Tarefas";
            this.btnTarefas.UseVisualStyleBackColor = true;
            this.btnTarefas.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 178);
            this.Controls.Add(this.btnTarefas);
            this.Controls.Add(this.btnAlarme);
            this.Name = "Form1";
            this.Text = "Tarefas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAlarme;
        private System.Windows.Forms.Button btnTarefas;
    }
}

