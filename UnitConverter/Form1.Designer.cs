namespace UnitConverter
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
            label1 = new Label();
            txtAmount = new TextBox();
            panel1 = new Panel();
            label2 = new Label();
            cmbType = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            lstFrom = new ListBox();
            lstTo = new ListBox();
            btnConvert = new Button();
            panel2 = new Panel();
            txtConvertedAmount = new TextBox();
            label5 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(54, 34);
            label1.Name = "label1";
            label1.Size = new Size(53, 17);
            label1.TabIndex = 0;
            label1.Text = "Amount";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(113, 33);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(234, 23);
            txtAmount.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtAmount);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(140, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(398, 100);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(194, 142);
            label2.Name = "label2";
            label2.Size = new Size(35, 17);
            label2.TabIndex = 3;
            label2.Text = "Type";
            // 
            // cmbType
            // 
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(253, 142);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(190, 23);
            cmbType.TabIndex = 4;
            cmbType.SelectedIndexChanged += cmbType_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(160, 212);
            label3.Name = "label3";
            label3.Size = new Size(38, 17);
            label3.TabIndex = 5;
            label3.Text = "From";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(387, 212);
            label4.Name = "label4";
            label4.Size = new Size(22, 17);
            label4.TabIndex = 6;
            label4.Text = "To";
            label4.Click += label4_Click;
            // 
            // lstFrom
            // 
            lstFrom.FormattingEnabled = true;
            lstFrom.ItemHeight = 15;
            lstFrom.Location = new Point(160, 244);
            lstFrom.Name = "lstFrom";
            lstFrom.Size = new Size(118, 154);
            lstFrom.TabIndex = 7;
            // 
            // lstTo
            // 
            lstTo.FormattingEnabled = true;
            lstTo.ItemHeight = 15;
            lstTo.Location = new Point(387, 244);
            lstTo.Name = "lstTo";
            lstTo.Size = new Size(118, 154);
            lstTo.TabIndex = 8;
            // 
            // btnConvert
            // 
            btnConvert.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnConvert.Location = new Point(298, 304);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(71, 31);
            btnConvert.TabIndex = 9;
            btnConvert.Text = "Convert";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtConvertedAmount);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(140, 486);
            panel2.Name = "panel2";
            panel2.Size = new Size(398, 100);
            panel2.TabIndex = 10;
            // 
            // txtConvertedAmount
            // 
            txtConvertedAmount.Location = new Point(157, 38);
            txtConvertedAmount.Name = "txtConvertedAmount";
            txtConvertedAmount.Size = new Size(190, 23);
            txtConvertedAmount.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(34, 39);
            label5.Name = "label5";
            label5.Size = new Size(117, 17);
            label5.TabIndex = 0;
            label5.Text = "Converted Amount";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 625);
            Controls.Add(panel2);
            Controls.Add(btnConvert);
            Controls.Add(lstTo);
            Controls.Add(lstFrom);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cmbType);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Unit Converter";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtAmount;
        private Panel panel1;
        private Label label2;
        private ComboBox cmbType;
        private Label label3;
        private Label label4;
        private ListBox lstFrom;
        private ListBox lstTo;
        private Button btnConvert;
        private Panel panel2;
        private TextBox txtConvertedAmount;
        private Label label5;
    }
}