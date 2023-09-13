namespace VienHoa.View
{
    partial class ThemChatThaiView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemChatThaiView));
            panel1 = new System.Windows.Forms.Panel();
            comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            labelChatThai = new System.Windows.Forms.Label();
            labelLoaiChatThai = new System.Windows.Forms.Label();
            textEditTenChatThai = new DevExpress.XtraEditors.TextEdit();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            btnHuy = new DevExpress.XtraEditors.SimpleButton();
            btnThem = new DevExpress.XtraEditors.SimpleButton();
            panel2 = new System.Windows.Forms.Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)comboBoxEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEditTenChatThai.Properties).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(comboBoxEdit1);
            panel1.Controls.Add(labelChatThai);
            panel1.Controls.Add(labelLoaiChatThai);
            panel1.Controls.Add(textEditTenChatThai);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(50, 25);
            panel1.Margin = new System.Windows.Forms.Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(348, 174);
            panel1.TabIndex = 2;
            // 
            // comboBoxEdit1
            // 
            comboBoxEdit1.Location = new System.Drawing.Point(148, 0);
            comboBoxEdit1.Margin = new System.Windows.Forms.Padding(41, 4, 4, 3);
            comboBoxEdit1.MaximumSize = new System.Drawing.Size(200, 30);
            comboBoxEdit1.MinimumSize = new System.Drawing.Size(200, 30);
            comboBoxEdit1.Name = "comboBoxEdit1";
            comboBoxEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            comboBoxEdit1.Properties.Appearance.Options.UseFont = true;
            comboBoxEdit1.Properties.AutoHeight = false;
            comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            comboBoxEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            comboBoxEdit1.Size = new System.Drawing.Size(200, 30);
            comboBoxEdit1.TabIndex = 0;
            comboBoxEdit1.SelectedIndexChanged += comboBoxEdit1_SelectedIndexChanged;
            // 
            // labelChatThai
            // 
            labelChatThai.AutoSize = true;
            labelChatThai.ForeColor = System.Drawing.Color.Red;
            labelChatThai.Location = new System.Drawing.Point(148, 98);
            labelChatThai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelChatThai.Name = "labelChatThai";
            labelChatThai.Size = new System.Drawing.Size(0, 16);
            labelChatThai.TabIndex = 5;
            // 
            // labelLoaiChatThai
            // 
            labelLoaiChatThai.AutoSize = true;
            labelLoaiChatThai.ForeColor = System.Drawing.Color.Red;
            labelLoaiChatThai.Location = new System.Drawing.Point(148, 33);
            labelLoaiChatThai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelLoaiChatThai.Name = "labelLoaiChatThai";
            labelLoaiChatThai.Size = new System.Drawing.Size(0, 16);
            labelLoaiChatThai.TabIndex = 4;
            // 
            // textEditTenChatThai
            // 
            textEditTenChatThai.Location = new System.Drawing.Point(148, 64);
            textEditTenChatThai.Margin = new System.Windows.Forms.Padding(41, 4, 4, 4);
            textEditTenChatThai.MaximumSize = new System.Drawing.Size(200, 30);
            textEditTenChatThai.MinimumSize = new System.Drawing.Size(200, 30);
            textEditTenChatThai.Name = "textEditTenChatThai";
            textEditTenChatThai.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textEditTenChatThai.Properties.Appearance.Options.UseFont = true;
            textEditTenChatThai.Properties.AutoHeight = false;
            textEditTenChatThai.Size = new System.Drawing.Size(200, 30);
            textEditTenChatThai.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(0, 71);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(93, 17);
            label2.TabIndex = 2;
            label2.Text = "Tên chất thải:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(0, 7);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(94, 17);
            label1.TabIndex = 0;
            label1.Text = "Loại chất thải:";
            // 
            // btnHuy
            // 
            btnHuy.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnHuy.ImageOptions.Image");
            btnHuy.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            btnHuy.ImageOptions.ImageToTextIndent = 15;
            btnHuy.Location = new System.Drawing.Point(199, 0);
            btnHuy.Margin = new System.Windows.Forms.Padding(58, 4, 4, 4);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new System.Drawing.Size(100, 30);
            btnHuy.TabIndex = 3;
            btnHuy.Text = "Hủy";
            btnHuy.Click += btnHuy_Click_1;
            // 
            // btnThem
            // 
            btnThem.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnThem.ImageOptions.Image");
            btnThem.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            btnThem.ImageOptions.ImageToTextIndent = 15;
            btnThem.Location = new System.Drawing.Point(50, 0);
            btnThem.Margin = new System.Windows.Forms.Padding(58, 4, 4, 4);
            btnThem.Name = "btnThem";
            btnThem.Size = new System.Drawing.Size(100, 30);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.Click += btnThem_Click_1;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnThem);
            panel2.Controls.Add(btnHuy);
            panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel2.Location = new System.Drawing.Point(50, 169);
            panel2.Margin = new System.Windows.Forms.Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(348, 30);
            panel2.TabIndex = 3;
            // 
            // ThemChatThaiView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(448, 224);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new System.Windows.Forms.Padding(4);
            Name = "ThemChatThaiView";
            Padding = new System.Windows.Forms.Padding(50, 25, 50, 25);
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "ThemChatThaiView";
            Load += ThemChatThaiView_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)comboBoxEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEditTenChatThai.Properties).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.TextEdit textEditTenChatThai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelLoaiChatThai;
        private System.Windows.Forms.Label labelChatThai;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private System.Windows.Forms.Panel panel2;
    }
}