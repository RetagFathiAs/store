namespace book
{
  partial class login
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.nametxt = new System.Windows.Forms.TextBox();
      this.passtxt = new System.Windows.Forms.TextBox();
      this.loginbtn = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(189, 107);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(411, 48);
      this.label1.TabIndex = 0;
      this.label1.Text = "منــــظومــة تخــزين الكــتــب";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(519, 212);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(162, 36);
      this.label2.TabIndex = 1;
      this.label2.Text = "اســم المـسـتخدم";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(519, 304);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(161, 36);
      this.label3.TabIndex = 2;
      this.label3.Text = "كـلــمة الـمـرور";
      // 
      // nametxt
      // 
      this.nametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.nametxt.Location = new System.Drawing.Point(271, 251);
      this.nametxt.Name = "nametxt";
      this.nametxt.Size = new System.Drawing.Size(227, 41);
      this.nametxt.TabIndex = 3;
      // 
      // passtxt
      // 
      this.passtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.passtxt.Location = new System.Drawing.Point(271, 353);
      this.passtxt.Name = "passtxt";
      this.passtxt.Size = new System.Drawing.Size(227, 41);
      this.passtxt.TabIndex = 4;
      // 
      // loginbtn
      // 
      this.loginbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.loginbtn.Font = new System.Drawing.Font("Monotype Corsiva", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.loginbtn.Location = new System.Drawing.Point(39, 295);
      this.loginbtn.Name = "loginbtn";
      this.loginbtn.Size = new System.Drawing.Size(180, 67);
      this.loginbtn.TabIndex = 5;
      this.loginbtn.Text = "دخـــول";
      this.loginbtn.UseVisualStyleBackColor = false;
      this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
      // 
      // button3
      // 
      this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
      this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button3.Location = new System.Drawing.Point(39, 15);
      this.button3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(174, 56);
      this.button3.TabIndex = 47;
      this.button3.Text = "خروج";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // login
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.loginbtn);
      this.Controls.Add(this.passtxt);
      this.Controls.Add(this.nametxt);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "login";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox nametxt;
    private System.Windows.Forms.TextBox passtxt;
    private System.Windows.Forms.Button loginbtn;
    private System.Windows.Forms.Button button3;
  }
}

