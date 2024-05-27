namespace computerController
{
    partial class userManage
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
            label1 = new Label();
            groupBox2 = new GroupBox();
            button5 = new Button();
            button4 = new Button();
            btnAdd = new Button();
            btnShow = new Button();
            dataGridView1 = new DataGridView();
            controller = new GroupBox();
            button1 = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            controller.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(419, 9);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 4;
            label1.Text = "Quản lí người dùng";
            label1.Click += label1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Controls.Add(btnShow);
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(88, 218);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(767, 272);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách người dùng";
            // 
            // button5
            // 
            button5.Location = new Point(657, 221);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 4;
            button5.Text = "Xóa";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(657, 156);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 3;
            button4.Text = "Sửa";
            button4.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(657, 90);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(657, 22);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(75, 23);
            btnShow.TabIndex = 1;
            btnShow.Text = "Hiển thị";
            btnShow.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(28, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(594, 222);
            dataGridView1.TabIndex = 0;
            // 
            // controller
            // 
            controller.Controls.Add(button1);
            controller.Controls.Add(label2);
            controller.Controls.Add(textBox1);
            controller.Location = new Point(88, 66);
            controller.Name = "controller";
            controller.Size = new Size(767, 74);
            controller.TabIndex = 6;
            controller.TabStop = false;
            controller.Text = "Tìm kiếm người dùng";
            // 
            // button1
            // 
            button1.Location = new Point(514, 31);
            button1.Name = "button1";
            button1.Size = new Size(138, 23);
            button1.TabIndex = 2;
            button1.Text = "Tìm kiếm phòng";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 34);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 1;
            label2.Text = "Nhập tên phòng:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(166, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(285, 23);
            textBox1.TabIndex = 0;
            // 
            // userManage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 588);
            Controls.Add(controller);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Name = "userManage";
            Text = " Quản lí người dùng";
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            controller.ResumeLayout(false);
            controller.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox2;
        private Button button5;
        private Button button4;
        private Button btnAdd;
        private Button btnShow;
        private DataGridView dataGridView1;
        private GroupBox controller;
        private Button button1;
        private Label label2;
        private TextBox textBox1;
    }
}