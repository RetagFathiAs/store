namespace book
{
  partial class dashboard
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
      this.newstrbtn = new System.Windows.Forms.Button();
      this.newclassstr = new System.Windows.Forms.Button();
      this.newbookstr = new System.Windows.Forms.Button();
      this.panel1 = new System.Windows.Forms.Panel();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.uslebel = new System.Windows.Forms.Label();
      this.storelebel = new System.Windows.Forms.Label();
      this.button3 = new System.Windows.Forms.Button();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // newstrbtn
      // 
      this.newstrbtn.BackColor = System.Drawing.SystemColors.ControlLight;
      this.newstrbtn.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.newstrbtn.ForeColor = System.Drawing.Color.Black;
      this.newstrbtn.Location = new System.Drawing.Point(1172, 48);
      this.newstrbtn.Name = "newstrbtn";
      this.newstrbtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.newstrbtn.Size = new System.Drawing.Size(281, 69);
      this.newstrbtn.TabIndex = 33;
      this.newstrbtn.Text = "تسجيل المخازن";
      this.newstrbtn.UseVisualStyleBackColor = false;
      this.newstrbtn.Click += new System.EventHandler(this.button1_Click);
      // 
      // newclassstr
      // 
      this.newclassstr.BackColor = System.Drawing.SystemColors.ControlLight;
      this.newclassstr.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.newclassstr.ForeColor = System.Drawing.Color.Black;
      this.newclassstr.Location = new System.Drawing.Point(1172, 240);
      this.newclassstr.Name = "newclassstr";
      this.newclassstr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.newclassstr.Size = new System.Drawing.Size(281, 67);
      this.newclassstr.TabIndex = 34;
      this.newclassstr.Text = "تسجيل الصفوف";
      this.newclassstr.UseVisualStyleBackColor = false;
      this.newclassstr.Click += new System.EventHandler(this.newclassstr_Click);
      // 
      // newbookstr
      // 
      this.newbookstr.BackColor = System.Drawing.SystemColors.ControlLight;
      this.newbookstr.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.newbookstr.ForeColor = System.Drawing.Color.Black;
      this.newbookstr.Location = new System.Drawing.Point(1172, 148);
      this.newbookstr.Name = "newbookstr";
      this.newbookstr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.newbookstr.Size = new System.Drawing.Size(281, 67);
      this.newbookstr.TabIndex = 32;
      this.newbookstr.Text = "تسجيل الكتاب ";
      this.newbookstr.UseVisualStyleBackColor = false;
      this.newbookstr.Click += new System.EventHandler(this.newbookstr_Click);
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
      this.panel1.Controls.Add(this.button3);
      this.panel1.Controls.Add(this.newstrbtn);
      this.panel1.Controls.Add(this.newclassstr);
      this.panel1.Controls.Add(this.newbookstr);
      this.panel1.Location = new System.Drawing.Point(0, 347);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(1500, 381);
      this.panel1.TabIndex = 35;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(1328, 270);
      this.label2.Name = "label2";
      this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.label2.Size = new System.Drawing.Size(144, 36);
      this.label2.TabIndex = 43;
      this.label2.Text = "مدير مخزن ";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(1358, 208);
      this.label1.Name = "label1";
      this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.label1.Size = new System.Drawing.Size(101, 31);
      this.label1.TabIndex = 42;
      this.label1.Text = "المستخدم";
      // 
      // uslebel
      // 
      this.uslebel.AutoSize = true;
      this.uslebel.BackColor = System.Drawing.Color.Thistle;
      this.uslebel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.uslebel.Location = new System.Drawing.Point(1254, 208);
      this.uslebel.Name = "uslebel";
      this.uslebel.Size = new System.Drawing.Size(53, 38);
      this.uslebel.TabIndex = 44;
      this.uslebel.Text = "22";
      // 
      // storelebel
      // 
      this.storelebel.AutoSize = true;
      this.storelebel.BackColor = System.Drawing.Color.Thistle;
      this.storelebel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.storelebel.Location = new System.Drawing.Point(1254, 270);
      this.storelebel.Name = "storelebel";
      this.storelebel.Size = new System.Drawing.Size(53, 38);
      this.storelebel.TabIndex = 45;
      this.storelebel.Text = "11";
      // 
      // button3
      // 
      this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
      this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button3.Location = new System.Drawing.Point(27, 299);
      this.button3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(174, 56);
      this.button3.TabIndex = 46;
      this.button3.Text = "خروج";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // dashboard
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FloralWhite;
      this.ClientSize = new System.Drawing.Size(1492, 747);
      this.Controls.Add(this.storelebel);
      this.Controls.Add(this.uslebel);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.panel1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "dashboard";
      this.Text = "dashboard";
      this.Load += new System.EventHandler(this.dashboard_Load);
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button newstrbtn;
    private System.Windows.Forms.Button newclassstr;
    private System.Windows.Forms.Button newbookstr;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label uslebel;
    private System.Windows.Forms.Label storelebel;
    private System.Windows.Forms.Button button3;
  }
}