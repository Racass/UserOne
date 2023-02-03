namespace UserCreatorUI.Forms
{
    partial class MainForm
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
            this.addBtn = new System.Windows.Forms.Button();
            this.connectBtn = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.validateBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(977, 1631);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(719, 159);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "Adicionar";
            this.addBtn.UseVisualStyleBackColor = true;
            // 
            // connectBtn
            // 
            this.connectBtn.Location = new System.Drawing.Point(1450, 12);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(246, 84);
            this.connectBtn.TabIndex = 1;
            this.connectBtn.Text = "Conectar";
            this.connectBtn.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 216);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(959, 1401);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // validateBtn
            // 
            this.validateBtn.Location = new System.Drawing.Point(12, 1631);
            this.validateBtn.Name = "validateBtn";
            this.validateBtn.Size = new System.Drawing.Size(544, 159);
            this.validateBtn.TabIndex = 3;
            this.validateBtn.Text = "Validar";
            this.validateBtn.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1708, 1802);
            this.Controls.Add(this.validateBtn);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.connectBtn);
            this.Controls.Add(this.addBtn);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button addBtn;
        private Button connectBtn;
        private RichTextBox richTextBox1;
        private Button validateBtn;
    }
}