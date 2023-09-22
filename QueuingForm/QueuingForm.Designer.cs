namespace QueuingForm
{
    partial class QueuingForm
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
            btnCashier = new Button();
            lblQueue = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnCashier
            // 
            btnCashier.Location = new Point(35, 40);
            btnCashier.Name = "btnCashier";
            btnCashier.Size = new Size(110, 93);
            btnCashier.TabIndex = 0;
            btnCashier.Text = "Cashier";
            btnCashier.UseVisualStyleBackColor = true;
            btnCashier.Click += btnCashier_Click;
            // 
            // lblQueue
            // 
            lblQueue.AutoSize = true;
            lblQueue.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblQueue.Location = new Point(220, 77);
            lblQueue.Name = "lblQueue";
            lblQueue.Size = new Size(45, 30);
            lblQueue.TabIndex = 1;
            lblQueue.Text = "P - ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(220, 40);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 2;
            label1.Text = "Position Queue";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(35, 146);
            label2.Name = "label2";
            label2.Size = new Size(122, 13);
            label2.TabIndex = 3;
            label2.Text = "*Click to get a number";
            // 
            // QueuingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 183);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblQueue);
            Controls.Add(btnCashier);
            Name = "QueuingForm";
            Text = "QueuingForm";
            Load += QueuingForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCashier;
        private Label lblQueue;
        private Label label1;
        private Label label2;
    }
}