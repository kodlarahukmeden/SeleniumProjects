
namespace GithubFormsApp.Forms
{
    partial class HomeForm
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
            this.LoginButton = new System.Windows.Forms.Button();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.userPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GetRepositoriesButton = new System.Windows.Forms.Button();
            this.repositoriesTreeView = new System.Windows.Forms.TreeView();
            this.process1 = new System.Diagnostics.Process();
            this.showPasswordButton = new System.Windows.Forms.Button();
            this.urlListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(104, 91);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(180, 26);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.Text = "Giriş Yap";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(104, 24);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(180, 23);
            this.userNameTextBox.TabIndex = 1;
            // 
            // userPasswordTextBox
            // 
            this.userPasswordTextBox.Location = new System.Drawing.Point(104, 63);
            this.userPasswordTextBox.Name = "userPasswordTextBox";
            this.userPasswordTextBox.Size = new System.Drawing.Size(119, 23);
            this.userPasswordTextBox.TabIndex = 1;
            this.userPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre";
            // 
            // GetRepositoriesButton
            // 
            this.GetRepositoriesButton.Location = new System.Drawing.Point(317, 24);
            this.GetRepositoriesButton.Name = "GetRepositoriesButton";
            this.GetRepositoriesButton.Size = new System.Drawing.Size(286, 23);
            this.GetRepositoriesButton.TabIndex = 3;
            this.GetRepositoriesButton.Text = "Repository İsimleri Getir";
            this.GetRepositoriesButton.UseVisualStyleBackColor = true;
            this.GetRepositoriesButton.Click += new System.EventHandler(this.GetRepositoriesButton_Click);
            // 
            // repositoriesTreeView
            // 
            this.repositoriesTreeView.Location = new System.Drawing.Point(317, 56);
            this.repositoriesTreeView.Name = "repositoriesTreeView";
            this.repositoriesTreeView.Size = new System.Drawing.Size(286, 302);
            this.repositoriesTreeView.TabIndex = 6;
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardInputEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // showPasswordButton
            // 
            this.showPasswordButton.Location = new System.Drawing.Point(229, 62);
            this.showPasswordButton.Name = "showPasswordButton";
            this.showPasswordButton.Size = new System.Drawing.Size(55, 23);
            this.showPasswordButton.TabIndex = 7;
            this.showPasswordButton.Text = "Göster";
            this.showPasswordButton.UseVisualStyleBackColor = true;
            this.showPasswordButton.Click += new System.EventHandler(this.showPasswordButton_Click);
            // 
            // urlListBox
            // 
            this.urlListBox.FormattingEnabled = true;
            this.urlListBox.ItemHeight = 15;
            this.urlListBox.Location = new System.Drawing.Point(609, 56);
            this.urlListBox.Name = "urlListBox";
            this.urlListBox.Size = new System.Drawing.Size(180, 304);
            this.urlListBox.TabIndex = 8;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 489);
            this.Controls.Add(this.urlListBox);
            this.Controls.Add(this.showPasswordButton);
            this.Controls.Add(this.repositoriesTreeView);
            this.Controls.Add(this.GetRepositoriesButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userPasswordTextBox);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.LoginButton);
            this.Name = "HomeForm";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox userPasswordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GetRepositoriesButton;
        private System.Windows.Forms.TreeView repositoriesTreeView;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.Button showPasswordButton;
        private System.Windows.Forms.ListBox urlListBox;
    }
}