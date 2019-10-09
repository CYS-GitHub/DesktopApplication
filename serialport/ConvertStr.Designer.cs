namespace serialport
{
    partial class ConvertStr
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
            this.skinGroupBox11 = new CCWin.SkinControl.SkinGroupBox();
            this.txt_resultsData = new CCWin.SkinControl.RtfRichTextBox();
            this.txt_originalData = new CCWin.SkinControl.RtfRichTextBox();
            this.cbo_IntoTheSystem = new CCWin.SkinControl.SkinComboBox();
            this.btn_Conversion = new CCWin.SkinControl.SkinButton();
            this.skinGroupBox11.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinGroupBox11
            // 
            this.skinGroupBox11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.skinGroupBox11.BorderColor = System.Drawing.Color.Black;
            this.skinGroupBox11.Controls.Add(this.txt_resultsData);
            this.skinGroupBox11.Controls.Add(this.txt_originalData);
            this.skinGroupBox11.Controls.Add(this.cbo_IntoTheSystem);
            this.skinGroupBox11.Controls.Add(this.btn_Conversion);
            this.skinGroupBox11.ForeColor = System.Drawing.Color.Black;
            this.skinGroupBox11.Location = new System.Drawing.Point(18, 36);
            this.skinGroupBox11.Name = "skinGroupBox11";
            this.skinGroupBox11.RectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.skinGroupBox11.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox11.Size = new System.Drawing.Size(346, 97);
            this.skinGroupBox11.TabIndex = 175;
            this.skinGroupBox11.TabStop = false;
            this.skinGroupBox11.Text = "格式转换";
            this.skinGroupBox11.TitleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.skinGroupBox11.TitleRectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.skinGroupBox11.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // txt_resultsData
            // 
            this.txt_resultsData.BackColor = System.Drawing.SystemColors.Window;
            this.txt_resultsData.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_resultsData.HiglightColor = CCWin.SkinControl.RtfRichTextBox.RtfColor.White;
            this.txt_resultsData.Location = new System.Drawing.Point(238, 19);
            this.txt_resultsData.Name = "txt_resultsData";
            this.txt_resultsData.Size = new System.Drawing.Size(95, 65);
            this.txt_resultsData.TabIndex = 10;
            this.txt_resultsData.Text = "";
            this.txt_resultsData.TextColor = CCWin.SkinControl.RtfRichTextBox.RtfColor.Black;
            // 
            // txt_originalData
            // 
            this.txt_originalData.BackColor = System.Drawing.SystemColors.Window;
            this.txt_originalData.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_originalData.HiglightColor = CCWin.SkinControl.RtfRichTextBox.RtfColor.White;
            this.txt_originalData.Location = new System.Drawing.Point(13, 19);
            this.txt_originalData.Name = "txt_originalData";
            this.txt_originalData.Size = new System.Drawing.Size(95, 65);
            this.txt_originalData.TabIndex = 8;
            this.txt_originalData.Text = "";
            this.txt_originalData.TextColor = CCWin.SkinControl.RtfRichTextBox.RtfColor.Black;
            // 
            // cbo_IntoTheSystem
            // 
            this.cbo_IntoTheSystem.BackColor = System.Drawing.Color.White;
            this.cbo_IntoTheSystem.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.cbo_IntoTheSystem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.cbo_IntoTheSystem.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_IntoTheSystem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_IntoTheSystem.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbo_IntoTheSystem.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cbo_IntoTheSystem.FormattingEnabled = true;
            this.cbo_IntoTheSystem.Items.AddRange(new object[] {
            "10进制转16进制",
            "16进制转10进制",
            "10进制转2进制",
            "2进制转10进制",
            "字符串转ASCILL码",
            "ASCILL码转字符串"});
            this.cbo_IntoTheSystem.Location = new System.Drawing.Point(110, 19);
            this.cbo_IntoTheSystem.Name = "cbo_IntoTheSystem";
            this.cbo_IntoTheSystem.Size = new System.Drawing.Size(126, 24);
            this.cbo_IntoTheSystem.TabIndex = 205;
            this.cbo_IntoTheSystem.WaterText = "";
            // 
            // btn_Conversion
            // 
            this.btn_Conversion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btn_Conversion.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_Conversion.DownBack = null;
            this.btn_Conversion.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Conversion.Location = new System.Drawing.Point(110, 46);
            this.btn_Conversion.MouseBack = null;
            this.btn_Conversion.Name = "btn_Conversion";
            this.btn_Conversion.NormlBack = null;
            this.btn_Conversion.Size = new System.Drawing.Size(126, 38);
            this.btn_Conversion.TabIndex = 9;
            this.btn_Conversion.Text = "转换";
            this.btn_Conversion.UseVisualStyleBackColor = false;
            this.btn_Conversion.Click += new System.EventHandler(this.btn_Conversion_Click);
            // 
            // ConvertStr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(385, 151);
            this.Controls.Add(this.skinGroupBox11);
            this.Name = "ConvertStr";
            this.Text = "格式转换";
            this.skinGroupBox11.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinGroupBox skinGroupBox11;
        public CCWin.SkinControl.RtfRichTextBox txt_resultsData;
        public CCWin.SkinControl.RtfRichTextBox txt_originalData;
        private CCWin.SkinControl.SkinComboBox cbo_IntoTheSystem;
        private CCWin.SkinControl.SkinButton btn_Conversion;
    }
}