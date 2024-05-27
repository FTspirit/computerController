namespace computerController
{
    partial class roomManage
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
            controller = new GroupBox();
            button1 = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            dataGridView2 = new DataGridView();
            groupBox2 = new GroupBox();
            button5 = new Button();
            button4 = new Button();
            btnAdd = new Button();
            btnShow = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            button2 = new Button();
            button3 = new Button();
            button6 = new Button();
            controller.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // controller
            // 
            controller.Controls.Add(button1);
            controller.Controls.Add(label2);
            controller.Controls.Add(textBox1);
            controller.Location = new Point(72, 38);
            controller.Name = "controller";
            controller.Size = new Size(767, 74);
            controller.TabIndex = 0;
            controller.TabStop = false;
            controller.Text = "Tìm kiếm phòng";
            controller.Enter += controller_Enter;
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
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(166, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(285, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(dataGridView2);
            groupBox1.Location = new Point(72, 127);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(767, 129);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "lịch sử dùng phòng";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(28, 22);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(594, 83);
            dataGridView2.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Controls.Add(btnShow);
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(72, 280);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(767, 272);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách phòng";
            groupBox2.Enter += groupBox2_Enter;
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
            btnAdd.Click += button3_Click;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(657, 22);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(75, 23);
            btnShow.TabIndex = 1;
            btnShow.Text = "Hiển thị";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(28, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(594, 222);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(422, 9);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 3;
            label1.Text = "Quản lí phòng";
            label1.Click += label1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(657, 22);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Xóa";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(657, 82);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 5;
            button3.Text = "In báo cáo";
            button3.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(657, 51);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 6;
            button6.Text = "Sửa";
            button6.UseVisualStyleBackColor = true;
            // 
            // roomManage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 588);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(controller);
            Name = "roomManage";
            Text = "Quản lí phòng";
            controller.ResumeLayout(false);
            controller.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox controller;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Button button1;
        private DataGridView dataGridView1;
        private Button button5;
        private Button button4;
        private Button btnAdd;
        private Button btnShow;
        private DataGridView dataGridView2;
        private Button button3;
        private Button button2;
        private Button button6;
    }
}