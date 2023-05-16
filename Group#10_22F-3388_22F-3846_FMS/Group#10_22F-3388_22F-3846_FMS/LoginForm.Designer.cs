using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Group_10_22F_3388_22F_3846_FMS
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            label2 = new Label();
            label3 = new Label();
            userbox = new TextBox();
            passbox = new TextBox();
            login = new Button();
            pictureBox1 = new PictureBox();
            showpassword = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(230, 294);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 2;
            label2.Text = "Username";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(234, 336);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 3;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // userbox
            // 
            userbox.Anchor = AnchorStyles.None;
            userbox.Location = new Point(316, 294);
            userbox.Name = "userbox";
            userbox.Size = new Size(201, 27);
            userbox.TabIndex = 4;
            userbox.TextChanged += userbox_TextChanged;
            // 
            // passbox
            // 
            passbox.Anchor = AnchorStyles.None;
            passbox.Location = new Point(316, 333);
            passbox.Name = "passbox";
            passbox.PasswordChar = '*';
            passbox.Size = new Size(201, 27);
            passbox.TabIndex = 5;
            passbox.TextChanged += passbox_TextChanged;
            // 
            // login
            // 
            login.Anchor = AnchorStyles.None;
            login.Cursor = Cursors.Hand;
            login.Location = new Point(327, 384);
            login.Name = "login";
            login.Size = new Size(179, 30);
            login.TabIndex = 6;
            login.Text = "Login";
            login.UseVisualStyleBackColor = true;
            login.Click += login_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.flexlogo1;
            pictureBox1.Location = new Point(214, 83);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(351, 131);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // showpassword
            // 
            showpassword.BackColor = Color.White;
            showpassword.Location = new Point(523, 336);
            showpassword.Name = "showpassword";
            showpassword.Size = new Size(26, 27);
            showpassword.TabIndex = 8;
            showpassword.Text = "👁";
            showpassword.TextAlign = ContentAlignment.TopCenter;
            showpassword.UseVisualStyleBackColor = false;
            showpassword.Click += showpassword_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.waves;
            pictureBox2.Location = new Point(-96, 229);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(962, 447);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(782, 553);
            Controls.Add(showpassword);
            Controls.Add(pictureBox1);
            Controls.Add(login);
            Controls.Add(passbox);
            Controls.Add(userbox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            ForeColor = Color.Black;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(800, 600);
            MinimumSize = new Size(800, 600);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Flex Academic Portal";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private TextBox userbox;
        private TextBox passbox;
        private Button login;
        private PictureBox pictureBox1;
        private Button showpassword;
        private PictureBox pictureBox2;
    }
}