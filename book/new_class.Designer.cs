namespace book
{
  partial class new_class
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(new_class));
      this.panel1 = new System.Windows.Forms.Panel();
      this.exitbtn = new System.Windows.Forms.Button();
      this.savebtn = new System.Windows.Forms.Button();
      this.classnametext = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.classnumtext = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
      this.panel1.Controls.Add(this.exitbtn);
      this.panel1.Controls.Add(this.savebtn);
      this.panel1.Controls.Add(this.classnametext);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Controls.Add(this.classnumtext);
      this.panel1.Controls.Add(this.label2);
      this.panel1.Location = new System.Drawing.Point(275, 315);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(685, 456);
      this.panel1.TabIndex = 0;
      // 
      // exitbtn
      // 
      this.exitbtn.BackColor = System.Drawing.SystemColors.Window;
      this.exitbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitbtn.BackgroundImage")));
      this.exitbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.exitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.exitbtn.Location = new System.Drawing.Point(125, 283);
      this.exitbtn.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
      this.exitbtn.Name = "exitbtn";
      this.exitbtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.exitbtn.Size = new System.Drawing.Size(156, 62);
      this.exitbtn.TabIndex = 36;
      this.exitbtn.Text = "خروج";
      this.exitbtn.UseVisualStyleBackColor = false;
      this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
      // 
      // savebtn
      // 
      this.savebtn.BackColor = System.Drawing.SystemColors.Window;
      this.savebtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("savebtn.BackgroundImage")));
      this.savebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.savebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.savebtn.Location = new System.Drawing.Point(455, 283);
      this.savebtn.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
      this.savebtn.Name = "savebtn";
      this.savebtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.savebtn.Size = new System.Drawing.Size(155, 62);
      this.savebtn.TabIndex = 35;
      this.savebtn.Text = "حفظ";
      this.savebtn.UseVisualStyleBackColor = false;
      this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
      // 
      // classnametext
      // 
      this.classnametext.BackColor = System.Drawing.Color.White;
      this.classnametext.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.classnametext.Location = new System.Drawing.Point(100, 188);
      this.classnametext.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
      this.classnametext.Name = "classnametext";
      this.classnametext.Size = new System.Drawing.Size(274, 45);
      this.classnametext.TabIndex = 8;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.BackColor = System.Drawing.Color.Thistle;
      this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.label1.Location = new System.Drawing.Point(393, 188);
      this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(220, 44);
      this.label1.TabIndex = 7;
      this.label1.Text = "الصف الدراسي";
      // 
      // classnumtext
      // 
      this.classnumtext.BackColor = System.Drawing.Color.White;
      this.classnumtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.classnumtext.Location = new System.Drawing.Point(237, 103);
      this.classnumtext.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
      this.classnumtext.Name = "classnumtext";
      this.classnumtext.Size = new System.Drawing.Size(137, 45);
      this.classnumtext.TabIndex = 6;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.BackColor = System.Drawing.Color.Thistle;
      this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.label2.Location = new System.Drawing.Point(429, 103);
      this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(157, 44);
      this.label2.TabIndex = 5;
      this.label2.Text = "رقم الصف";
      // 
      // new_class
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1231, 767);
      this.Controls.Add(this.panel1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "new_class";
      this.Text = "new_class";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button exitbtn;
    private System.Windows.Forms.Button savebtn;
    private System.Windows.Forms.TextBox classnametext;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox classnumtext;
    private System.Windows.Forms.Label label2;
  }
}