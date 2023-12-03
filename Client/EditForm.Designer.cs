namespace Client
{
    partial class EditForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.idLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.cpuNameLabel = new System.Windows.Forms.Label();
            this.gpuNameLabel = new System.Windows.Forms.Label();
            this.motherLabel = new System.Windows.Forms.Label();
            this.powerLabel = new System.Windows.Forms.Label();
            this.memoryLabel = new System.Windows.Forms.Label();
            this.ssdLabel = new System.Windows.Forms.Label();
            this.hddLabel = new System.Windows.Forms.Label();
            this.oslabel = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.NumericUpDown();
            this.name = new System.Windows.Forms.TextBox();
            this.cpuName = new System.Windows.Forms.TextBox();
            this.gpuName = new System.Windows.Forms.TextBox();
            this.mother = new System.Windows.Forms.TextBox();
            this.ssd = new System.Windows.Forms.CheckBox();
            this.hdd = new System.Windows.Forms.CheckBox();
            this.os = new System.Windows.Forms.CheckBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.power = new System.Windows.Forms.NumericUpDown();
            this.memory = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.power)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memory)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.idLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.nameLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cpuNameLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.gpuNameLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.motherLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.powerLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.memoryLabel, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.ssdLabel, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.hddLabel, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.oslabel, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.id, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.name, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cpuName, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.gpuName, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.mother, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.ssd, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.hdd, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.os, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.power, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.memory, 1, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.31579F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.68421F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(408, 449);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // idLabel
            // 
            this.idLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(3, 15);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(198, 13);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "ID";
            this.idLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(3, 57);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(198, 13);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Название";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cpuNameLabel
            // 
            this.cpuNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cpuNameLabel.AutoSize = true;
            this.cpuNameLabel.Location = new System.Drawing.Point(3, 103);
            this.cpuNameLabel.Name = "cpuNameLabel";
            this.cpuNameLabel.Size = new System.Drawing.Size(198, 13);
            this.cpuNameLabel.TabIndex = 2;
            this.cpuNameLabel.Text = "Название процессора";
            this.cpuNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gpuNameLabel
            // 
            this.gpuNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gpuNameLabel.AutoSize = true;
            this.gpuNameLabel.Location = new System.Drawing.Point(3, 153);
            this.gpuNameLabel.Name = "gpuNameLabel";
            this.gpuNameLabel.Size = new System.Drawing.Size(198, 13);
            this.gpuNameLabel.TabIndex = 3;
            this.gpuNameLabel.Text = "Название видеокарты";
            this.gpuNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // motherLabel
            // 
            this.motherLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.motherLabel.AutoSize = true;
            this.motherLabel.Location = new System.Drawing.Point(3, 201);
            this.motherLabel.Name = "motherLabel";
            this.motherLabel.Size = new System.Drawing.Size(198, 13);
            this.motherLabel.TabIndex = 4;
            this.motherLabel.Text = "Материнская плата";
            this.motherLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // powerLabel
            // 
            this.powerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.powerLabel.AutoSize = true;
            this.powerLabel.Location = new System.Drawing.Point(3, 248);
            this.powerLabel.Name = "powerLabel";
            this.powerLabel.Size = new System.Drawing.Size(198, 13);
            this.powerLabel.TabIndex = 5;
            this.powerLabel.Text = "Мощность блока питания";
            this.powerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // memoryLabel
            // 
            this.memoryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.memoryLabel.AutoSize = true;
            this.memoryLabel.Location = new System.Drawing.Point(3, 292);
            this.memoryLabel.Name = "memoryLabel";
            this.memoryLabel.Size = new System.Drawing.Size(198, 13);
            this.memoryLabel.TabIndex = 6;
            this.memoryLabel.Text = "Общая память компьютера";
            this.memoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ssdLabel
            // 
            this.ssdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ssdLabel.AutoSize = true;
            this.ssdLabel.Location = new System.Drawing.Point(3, 337);
            this.ssdLabel.Name = "ssdLabel";
            this.ssdLabel.Size = new System.Drawing.Size(198, 13);
            this.ssdLabel.TabIndex = 7;
            this.ssdLabel.Text = "Наличие ssd";
            this.ssdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hddLabel
            // 
            this.hddLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.hddLabel.AutoSize = true;
            this.hddLabel.Location = new System.Drawing.Point(3, 383);
            this.hddLabel.Name = "hddLabel";
            this.hddLabel.Size = new System.Drawing.Size(198, 13);
            this.hddLabel.TabIndex = 8;
            this.hddLabel.Text = "Наличие hdd";
            this.hddLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // oslabel
            // 
            this.oslabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.oslabel.AutoSize = true;
            this.oslabel.Location = new System.Drawing.Point(3, 424);
            this.oslabel.Name = "oslabel";
            this.oslabel.Size = new System.Drawing.Size(198, 13);
            this.oslabel.TabIndex = 9;
            this.oslabel.Text = "Наличие операционной системы";
            this.oslabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // id
            // 
            this.id.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.id.Location = new System.Drawing.Point(207, 11);
            this.id.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(198, 20);
            this.id.TabIndex = 10;
            // 
            // name
            // 
            this.name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.name.Location = new System.Drawing.Point(207, 53);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(198, 20);
            this.name.TabIndex = 13;
            // 
            // cpuName
            // 
            this.cpuName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cpuName.Location = new System.Drawing.Point(207, 99);
            this.cpuName.Name = "cpuName";
            this.cpuName.Size = new System.Drawing.Size(198, 20);
            this.cpuName.TabIndex = 14;
            // 
            // gpuName
            // 
            this.gpuName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gpuName.Location = new System.Drawing.Point(207, 149);
            this.gpuName.Name = "gpuName";
            this.gpuName.Size = new System.Drawing.Size(198, 20);
            this.gpuName.TabIndex = 15;
            // 
            // mother
            // 
            this.mother.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mother.Location = new System.Drawing.Point(207, 198);
            this.mother.Name = "mother";
            this.mother.Size = new System.Drawing.Size(198, 20);
            this.mother.TabIndex = 16;
            // 
            // ssd
            // 
            this.ssd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ssd.AutoSize = true;
            this.ssd.Location = new System.Drawing.Point(207, 335);
            this.ssd.Name = "ssd";
            this.ssd.Size = new System.Drawing.Size(198, 17);
            this.ssd.TabIndex = 17;
            this.ssd.Text = "есть такое";
            this.ssd.UseVisualStyleBackColor = true;
            // 
            // hdd
            // 
            this.hdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.hdd.AutoSize = true;
            this.hdd.Location = new System.Drawing.Point(207, 381);
            this.hdd.Name = "hdd";
            this.hdd.Size = new System.Drawing.Size(198, 17);
            this.hdd.TabIndex = 18;
            this.hdd.Text = "есть такое";
            this.hdd.UseVisualStyleBackColor = true;
            // 
            // os
            // 
            this.os.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.os.AutoSize = true;
            this.os.Location = new System.Drawing.Point(207, 422);
            this.os.Name = "os";
            this.os.Size = new System.Drawing.Size(198, 17);
            this.os.TabIndex = 19;
            this.os.Text = "есть такое";
            this.os.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(219, 469);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(201, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveButton.Location = new System.Drawing.Point(12, 469);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(201, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // power
            // 
            this.power.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.power.Location = new System.Drawing.Point(207, 244);
            this.power.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.power.Name = "power";
            this.power.Size = new System.Drawing.Size(198, 20);
            this.power.TabIndex = 20;
            // 
            // memory
            // 
            this.memory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.memory.Location = new System.Drawing.Point(207, 289);
            this.memory.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.memory.Name = "memory";
            this.memory.Size = new System.Drawing.Size(198, 20);
            this.memory.TabIndex = 21;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 504);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EditForm";
            this.Text = "Редактирование";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.power)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label cpuNameLabel;
        private System.Windows.Forms.Label gpuNameLabel;
        private System.Windows.Forms.Label motherLabel;
        private System.Windows.Forms.Label powerLabel;
        private System.Windows.Forms.Label memoryLabel;
        private System.Windows.Forms.Label ssdLabel;
        private System.Windows.Forms.Label hddLabel;
        private System.Windows.Forms.Label oslabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.NumericUpDown id;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox cpuName;
        private System.Windows.Forms.TextBox gpuName;
        private System.Windows.Forms.TextBox mother;
        private System.Windows.Forms.CheckBox ssd;
        private System.Windows.Forms.CheckBox hdd;
        private System.Windows.Forms.CheckBox os;
        private System.Windows.Forms.NumericUpDown power;
        private System.Windows.Forms.NumericUpDown memory;
    }
}