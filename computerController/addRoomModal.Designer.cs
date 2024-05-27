namespace computerController
{
    partial class addRoomModal
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
            roomName = new TextBox();
            label2 = new Label();
            roomAddress = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 60);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 0;
            label1.Text = "Nhập tên phòng:";
            label1.Click += label1_Click;
            // 
            // roomName
            // 
            roomName.Location = new Point(143, 60);
            roomName.Name = "roomName";
            roomName.Size = new Size(169, 23);
            roomName.TabIndex = 1;
            roomName.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 111);
            label2.Name = "label2";
            label2.Size = new Size(115, 15);
            label2.TabIndex = 2;
            label2.Text = "Nhập địa chỉ phòng:";
            label2.Click += label2_Click;
            // 
            // roomAddress
            // 
            roomAddress.Location = new Point(143, 111);
            roomAddress.Name = "roomAddress";
            roomAddress.Size = new Size(169, 23);
            roomAddress.TabIndex = 3;
            roomAddress.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(75, 169);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(214, 169);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // addRoomModal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 234);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(roomAddress);
            Controls.Add(label2);
            Controls.Add(roomName);
            Controls.Add(label1);
            Name = "addRoomModal";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox roomName;
        private Label label2;
        private TextBox roomAddress;
        private Button button1;
        private Button button2;
    }
}