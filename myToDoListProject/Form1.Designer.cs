
namespace myToDoListProject
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtbBtn = new ePOSOne.btnProduct.RoundedButton2();
            this.rmvBtn = new ePOSOne.btnProduct.RoundedButton2();
            this.addBtn = new ePOSOne.btnProduct.RoundedButton2();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtbBtn);
            this.panel1.Controls.Add(this.rmvBtn);
            this.panel1.Controls.Add(this.addBtn);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 593);
            this.panel1.TabIndex = 3;
            // 
            // dtbBtn
            // 
            this.dtbBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtbBtn.BackColor = System.Drawing.Color.Transparent;
            this.dtbBtn.BackgroundImage = global::myToDoListProject.Properties.Resources.DatabaseButton2;
            this.dtbBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dtbBtn.BorderColor = System.Drawing.Color.Transparent;
            this.dtbBtn.ButtonColor = System.Drawing.Color.Transparent;
            this.dtbBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtbBtn.FlatAppearance.BorderSize = 0;
            this.dtbBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtbBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtbBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dtbBtn.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.dtbBtn.Location = new System.Drawing.Point(238, 55);
            this.dtbBtn.Margin = new System.Windows.Forms.Padding(6);
            this.dtbBtn.Name = "dtbBtn";
            this.dtbBtn.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.dtbBtn.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.dtbBtn.OnHoverTextColor = System.Drawing.Color.Gray;
            this.dtbBtn.Size = new System.Drawing.Size(78, 76);
            this.dtbBtn.TabIndex = 2;
            this.dtbBtn.TextColor = System.Drawing.Color.White;
            this.dtbBtn.UseVisualStyleBackColor = false;
            this.dtbBtn.Click += new System.EventHandler(this.roundedButton23_Click);
            this.dtbBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.roundedButton23_MouseDown);
            this.dtbBtn.MouseHover += new System.EventHandler(this.dtbBtn_MouseHover);
            this.dtbBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.roundedButton23_MouseUp);
            // 
            // rmvBtn
            // 
            this.rmvBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rmvBtn.BackColor = System.Drawing.Color.Transparent;
            this.rmvBtn.BackgroundImage = global::myToDoListProject.Properties.Resources.MinusButton;
            this.rmvBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rmvBtn.BorderColor = System.Drawing.Color.Transparent;
            this.rmvBtn.ButtonColor = System.Drawing.Color.Transparent;
            this.rmvBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rmvBtn.FlatAppearance.BorderSize = 0;
            this.rmvBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rmvBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rmvBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rmvBtn.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.rmvBtn.Location = new System.Drawing.Point(137, 55);
            this.rmvBtn.Margin = new System.Windows.Forms.Padding(6);
            this.rmvBtn.Name = "rmvBtn";
            this.rmvBtn.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.rmvBtn.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.rmvBtn.OnHoverTextColor = System.Drawing.Color.Gray;
            this.rmvBtn.Size = new System.Drawing.Size(78, 76);
            this.rmvBtn.TabIndex = 1;
            this.rmvBtn.TextColor = System.Drawing.Color.White;
            this.rmvBtn.UseVisualStyleBackColor = false;
            this.rmvBtn.Click += new System.EventHandler(this.roundedButton22_Click);
            this.rmvBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.roundedButton22_MouseDown);
            this.rmvBtn.MouseHover += new System.EventHandler(this.rmvBtn_MouseHover);
            this.rmvBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.roundedButton22_MouseUp);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.Transparent;
            this.addBtn.BackgroundImage = global::myToDoListProject.Properties.Resources.PlusButton;
            this.addBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addBtn.BorderColor = System.Drawing.Color.Transparent;
            this.addBtn.ButtonColor = System.Drawing.Color.Transparent;
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.FlatAppearance.BorderSize = 0;
            this.addBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.addBtn.Location = new System.Drawing.Point(28, 55);
            this.addBtn.Margin = new System.Windows.Forms.Padding(6);
            this.addBtn.Name = "addBtn";
            this.addBtn.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.addBtn.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.addBtn.OnHoverTextColor = System.Drawing.Color.Gray;
            this.addBtn.Size = new System.Drawing.Size(78, 76);
            this.addBtn.TabIndex = 0;
            this.addBtn.TextColor = System.Drawing.Color.White;
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.roundedButton21_Click);
            this.addBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.roundedButton21_MouseDown);
            this.addBtn.MouseHover += new System.EventHandler(this.addBtn_MouseHover);
            this.addBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.roundedButton21_MouseUp);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 166);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(337, 422);
            this.flowLayoutPanel1.TabIndex = 3;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(348, 593);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ToDo List";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ePOSOne.btnProduct.RoundedButton2 addBtn;
        private ePOSOne.btnProduct.RoundedButton2 rmvBtn;
        private ePOSOne.btnProduct.RoundedButton2 dtbBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

