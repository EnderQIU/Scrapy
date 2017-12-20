namespace Scrapy
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ResultDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConsoleTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SaveSelector = new System.Windows.Forms.ComboBox();
            this.LoadButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.infoDisplay = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ResultDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ResultDataGridView
            // 
            this.ResultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column7,
            this.Column4,
            this.Column5,
            this.Column6});
            this.ResultDataGridView.Location = new System.Drawing.Point(16, 318);
            this.ResultDataGridView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ResultDataGridView.Name = "ResultDataGridView";
            this.ResultDataGridView.RowTemplate.Height = 23;
            this.ResultDataGridView.Size = new System.Drawing.Size(1115, 417);
            this.ResultDataGridView.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "岗位名称";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "岗位职责";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "岗位要求";
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "工作地";
            this.Column7.Name = "Column7";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "公司名称";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "公司简介";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "公司网址";
            this.Column6.Name = "Column6";
            // 
            // ConsoleTextBox
            // 
            this.ConsoleTextBox.Location = new System.Drawing.Point(405, 33);
            this.ConsoleTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ConsoleTextBox.Multiline = true;
            this.ConsoleTextBox.Name = "ConsoleTextBox";
            this.ConsoleTextBox.ReadOnly = true;
            this.ConsoleTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ConsoleTextBox.Size = new System.Drawing.Size(724, 241);
            this.ConsoleTextBox.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(16, 175);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "读取与保存";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(16, 205);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "选择存档";
            // 
            // SaveSelector
            // 
            this.SaveSelector.FormattingEnabled = true;
            this.SaveSelector.Location = new System.Drawing.Point(119, 202);
            this.SaveSelector.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SaveSelector.Name = "SaveSelector";
            this.SaveSelector.Size = new System.Drawing.Size(160, 23);
            this.SaveSelector.TabIndex = 16;
            this.SaveSelector.DropDown += new System.EventHandler(this.DropDownOpened);
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(297, 202);
            this.LoadButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(100, 28);
            this.LoadButton.TabIndex = 17;
            this.LoadButton.Text = "读取";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButtonClicked);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(297, 247);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(100, 28);
            this.DeleteButton.TabIndex = 18;
            this.DeleteButton.Text = "删除";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButtonClicked);
            // 
            // infoDisplay
            // 
            this.infoDisplay.Location = new System.Drawing.Point(20, 247);
            this.infoDisplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.infoDisplay.Name = "infoDisplay";
            this.infoDisplay.Size = new System.Drawing.Size(260, 28);
            this.infoDisplay.TabIndex = 19;
            this.infoDisplay.Text = "信息展示";
            this.infoDisplay.UseVisualStyleBackColor = true;
            this.infoDisplay.Click += new System.EventHandler(this.infoDisplay_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(224, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "问卷";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 750);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.infoDisplay);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.SaveSelector);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ConsoleTextBox);
            this.Controls.Add(this.ResultDataGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.Text = "牛客网";
            ((System.ComponentModel.ISupportInitialize)(this.ResultDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView ResultDataGridView;
        public System.Windows.Forms.TextBox ConsoleTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox SaveSelector;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button infoDisplay;
        private System.Windows.Forms.Button button1;
    }
}

