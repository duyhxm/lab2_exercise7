namespace Lab2_NguyenHuuMinhDuy_2251012049
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
            addButton = new Button();
            label1 = new Label();
            departmentName = new Label();
            empNum = new Label();
            departmentNameValue = new TextBox();
            empNumValue = new TextBox();
            removeButton = new Button();
            clearButton = new Button();
            exitButton = new Button();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            SuspendLayout();
            // 
            // addButton
            // 
            addButton.Location = new Point(62, 493);
            addButton.Name = "addButton";
            addButton.Size = new Size(112, 45);
            addButton.TabIndex = 0;
            addButton.Text = "Thêm";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(249, 23);
            label1.Name = "label1";
            label1.Size = new Size(303, 38);
            label1.TabIndex = 1;
            label1.Text = "Thêm Phòng Ban Mới";
            label1.Click += label1_Click;
            // 
            // departmentName
            // 
            departmentName.AutoSize = true;
            departmentName.Location = new Point(62, 84);
            departmentName.Name = "departmentName";
            departmentName.Size = new Size(96, 25);
            departmentName.TabIndex = 2;
            departmentName.Text = "Tên phòng";
            // 
            // empNum
            // 
            empNum.AutoSize = true;
            empNum.Location = new Point(62, 139);
            empNum.Name = "empNum";
            empNum.Size = new Size(153, 25);
            empNum.TabIndex = 3;
            empNum.Text = "Số lượng nhân sự";
            // 
            // departmentNameValue
            // 
            departmentNameValue.Location = new Point(255, 80);
            departmentNameValue.Name = "departmentNameValue";
            departmentNameValue.Size = new Size(276, 31);
            departmentNameValue.TabIndex = 4;
            // 
            // empNumValue
            // 
            empNumValue.Location = new Point(255, 136);
            empNumValue.Name = "empNumValue";
            empNumValue.Size = new Size(276, 31);
            empNumValue.TabIndex = 6;
            // 
            // removeButton
            // 
            removeButton.Location = new Point(245, 493);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(112, 45);
            removeButton.TabIndex = 7;
            removeButton.Text = "Xóa";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(425, 493);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(112, 45);
            clearButton.TabIndex = 8;
            clearButton.Text = "Xóa hết";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(606, 493);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(112, 45);
            exitButton.TabIndex = 9;
            exitButton.Text = "Thoát";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listView1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listView1.GridLines = true;
            listView1.Location = new Point(62, 194);
            listView1.Name = "listView1";
            listView1.Size = new Size(656, 292);
            listView1.TabIndex = 10;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Phòng";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Số lượng";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 100;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 559);
            Controls.Add(listView1);
            Controls.Add(exitButton);
            Controls.Add(clearButton);
            Controls.Add(removeButton);
            Controls.Add(empNumValue);
            Controls.Add(departmentNameValue);
            Controls.Add(empNum);
            Controls.Add(departmentName);
            Controls.Add(label1);
            Controls.Add(addButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addButton;
        private Label label1;
        private Label departmentName;
        private Label empNum;
        private TextBox departmentNameValue;
        private TextBox empNumValue;
        private Button removeButton;
        private Button clearButton;
        private Button exitButton;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
    }
}
