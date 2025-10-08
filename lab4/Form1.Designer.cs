namespace Task22
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
            lblName = new Label();
            lblId = new Label();
            lblAge = new Label();
            txtAge = new TextBox();
            txtId = new TextBox();
            txtName = new TextBox();
            btnShow = new Button();
            btnclose = new Button();
            cmbDepartments = new ComboBox();
            cmbStudents = new ComboBox();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(91, 59);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(91, 113);
            lblId.Name = "lblId";
            lblId.Size = new Size(17, 15);
            lblId.TabIndex = 1;
            lblId.Text = "Id";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(91, 171);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(28, 15);
            lblAge.TabIndex = 2;
            lblAge.Text = "Age";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(203, 168);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(204, 23);
            txtAge.TabIndex = 3;
            // 
            // txtId
            // 
            txtId.Location = new Point(203, 110);
            txtId.Name = "txtId";
            txtId.Size = new Size(204, 23);
            txtId.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Location = new Point(203, 56);
            txtName.Name = "txtName";
            txtName.Size = new Size(204, 23);
            txtName.TabIndex = 5;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(203, 219);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(75, 23);
            btnShow.TabIndex = 6;
            btnShow.Text = "Show";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // btnclose
            // 
            btnclose.Location = new Point(332, 219);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(75, 23);
            btnclose.TabIndex = 7;
            btnclose.Text = "Close";
            btnclose.UseVisualStyleBackColor = true;
            btnclose.Click += btnclose_Click;
            // 
            // cmbDepartments
            // 
            cmbDepartments.FormattingEnabled = true;
            cmbDepartments.Items.AddRange(new object[] { "OS", "SD", ".NET", "BI" });
            cmbDepartments.Location = new Point(531, 59);
            cmbDepartments.Name = "cmbDepartments";
            cmbDepartments.Size = new Size(121, 23);
            cmbDepartments.TabIndex = 8;
            // 
            // cmbStudents
            // 
            cmbStudents.FormattingEnabled = true;
            cmbStudents.Location = new Point(531, 105);
            cmbStudents.Name = "cmbStudents";
            cmbStudents.Size = new Size(121, 23);
            cmbStudents.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbStudents);
            Controls.Add(cmbDepartments);
            Controls.Add(btnclose);
            Controls.Add(btnShow);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(txtAge);
            Controls.Add(lblAge);
            Controls.Add(lblId);
            Controls.Add(lblName);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblId;
        private Label lblAge;
        private TextBox txtAge;
        private TextBox txtId;
        private TextBox txtName;
        private Button btnShow;
        private Button btnclose;
        private ComboBox cmbDepartments;
        private ComboBox cmbStudents;
    }
}
