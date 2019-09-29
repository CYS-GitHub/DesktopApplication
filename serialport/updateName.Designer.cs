namespace serialport
{
    partial class updateName
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
            this.components = new System.ComponentModel.Container();
            this.btn_Ok = new CCWin.SkinControl.SkinButton();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.lbl_txt = new CCWin.SkinControl.SkinLabel();
            this.btn_Can = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // btn_Ok
            // 
            this.btn_Ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btn_Ok.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_Ok.DownBack = null;
            this.btn_Ok.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Ok.Location = new System.Drawing.Point(51, 111);
            this.btn_Ok.MouseBack = null;
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.NormlBack = null;
            this.btn_Ok.Size = new System.Drawing.Size(90, 30);
            this.btn_Ok.TabIndex = 212;
            this.btn_Ok.Text = "确定";
            this.btn_Ok.UseVisualStyleBackColor = false;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_Name.Location = new System.Drawing.Point(90, 76);
            this.txt_Name.MaxLength = 10;
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(104, 25);
            this.txt_Name.TabIndex = 211;
            // 
            // lbl_txt
            // 
            this.lbl_txt.AutoSize = true;
            this.lbl_txt.BackColor = System.Drawing.Color.Transparent;
            this.lbl_txt.BorderColor = System.Drawing.Color.White;
            this.lbl_txt.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_txt.Location = new System.Drawing.Point(89, 56);
            this.lbl_txt.Name = "lbl_txt";
            this.lbl_txt.Size = new System.Drawing.Size(107, 17);
            this.lbl_txt.TabIndex = 210;
            this.lbl_txt.Text = "请输入条目的注释:";
            // 
            // btn_Can
            // 
            this.btn_Can.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btn_Can.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_Can.DownBack = null;
            this.btn_Can.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Can.Location = new System.Drawing.Point(147, 111);
            this.btn_Can.MouseBack = null;
            this.btn_Can.Name = "btn_Can";
            this.btn_Can.NormlBack = null;
            this.btn_Can.Size = new System.Drawing.Size(90, 30);
            this.btn_Can.TabIndex = 213;
            this.btn_Can.Text = "取消";
            this.btn_Can.UseVisualStyleBackColor = false;
            this.btn_Can.Click += new System.EventHandler(this.btn_Can_Click);
            // 
            // updateName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(280, 165);
            this.Controls.Add(this.btn_Can);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.lbl_txt);
            this.Name = "updateName";
            this.Text = "注释";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinButton btn_Ok;
        private System.Windows.Forms.TextBox txt_Name;
        private CCWin.SkinControl.SkinLabel lbl_txt;
        private CCWin.SkinControl.SkinButton btn_Can;
    }
}