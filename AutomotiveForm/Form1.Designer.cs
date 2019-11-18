namespace AutomotiveForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lubejobCheckbox = new System.Windows.Forms.CheckBox();
            this.oilchangeCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.transmissionflushCheckbox = new System.Windows.Forms.CheckBox();
            this.radiatorflushCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tirerotationCheckbox = new System.Windows.Forms.CheckBox();
            this.replacemufferCheckbox = new System.Windows.Forms.CheckBox();
            this.inspectionCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.laborTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.partsTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.totalfeesoutputLabel = new System.Windows.Forms.Label();
            this.taxOutputlabel = new System.Windows.Forms.Label();
            this.partsoutputLabel = new System.Windows.Forms.Label();
            this.serviceslaborOutputlabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.totalButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lubejobCheckbox);
            this.groupBox1.Controls.Add(this.oilchangeCheckbox);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 83);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Oil and Lube";
            // 
            // lubejobCheckbox
            // 
            this.lubejobCheckbox.AutoSize = true;
            this.lubejobCheckbox.Location = new System.Drawing.Point(6, 53);
            this.lubejobCheckbox.Name = "lubejobCheckbox";
            this.lubejobCheckbox.Size = new System.Drawing.Size(130, 21);
            this.lubejobCheckbox.TabIndex = 1;
            this.lubejobCheckbox.Text = "Lube Job ($18.00)";
            this.lubejobCheckbox.UseVisualStyleBackColor = true;
            this.lubejobCheckbox.CheckedChanged += new System.EventHandler(this.lubejobCheckbox_CheckedChanged);
            // 
            // oilchangeCheckbox
            // 
            this.oilchangeCheckbox.AutoSize = true;
            this.oilchangeCheckbox.Location = new System.Drawing.Point(6, 25);
            this.oilchangeCheckbox.Name = "oilchangeCheckbox";
            this.oilchangeCheckbox.Size = new System.Drawing.Size(141, 21);
            this.oilchangeCheckbox.TabIndex = 0;
            this.oilchangeCheckbox.Text = "Oil Change ($26.00)";
            this.oilchangeCheckbox.UseVisualStyleBackColor = true;
            this.oilchangeCheckbox.CheckedChanged += new System.EventHandler(this.oilchangeCheckbox_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.transmissionflushCheckbox);
            this.groupBox2.Controls.Add(this.radiatorflushCheckbox);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(219, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(219, 82);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Flushes";
            // 
            // transmissionflushCheckbox
            // 
            this.transmissionflushCheckbox.AutoSize = true;
            this.transmissionflushCheckbox.Location = new System.Drawing.Point(6, 52);
            this.transmissionflushCheckbox.Name = "transmissionflushCheckbox";
            this.transmissionflushCheckbox.Size = new System.Drawing.Size(185, 21);
            this.transmissionflushCheckbox.TabIndex = 1;
            this.transmissionflushCheckbox.Text = "Transmission Flush ($80.00)";
            this.transmissionflushCheckbox.UseVisualStyleBackColor = true;
            this.transmissionflushCheckbox.CheckedChanged += new System.EventHandler(this.transmissionflushCheckbox_CheckedChanged);
            // 
            // radiatorflushCheckbox
            // 
            this.radiatorflushCheckbox.AutoSize = true;
            this.radiatorflushCheckbox.Location = new System.Drawing.Point(6, 24);
            this.radiatorflushCheckbox.Name = "radiatorflushCheckbox";
            this.radiatorflushCheckbox.Size = new System.Drawing.Size(160, 21);
            this.radiatorflushCheckbox.TabIndex = 0;
            this.radiatorflushCheckbox.Text = "Radiator Flush ($30.00)";
            this.radiatorflushCheckbox.UseVisualStyleBackColor = true;
            this.radiatorflushCheckbox.CheckedChanged += new System.EventHandler(this.radiatorflushCheckbox_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tirerotationCheckbox);
            this.groupBox3.Controls.Add(this.replacemufferCheckbox);
            this.groupBox3.Controls.Add(this.inspectionCheckbox);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 104);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 117);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Misc";
            // 
            // tirerotationCheckbox
            // 
            this.tirerotationCheckbox.AutoSize = true;
            this.tirerotationCheckbox.Location = new System.Drawing.Point(6, 83);
            this.tirerotationCheckbox.Name = "tirerotationCheckbox";
            this.tirerotationCheckbox.Size = new System.Drawing.Size(152, 21);
            this.tirerotationCheckbox.TabIndex = 2;
            this.tirerotationCheckbox.Text = "Tire Rotation ($20.00)";
            this.tirerotationCheckbox.UseVisualStyleBackColor = true;
            this.tirerotationCheckbox.CheckedChanged += new System.EventHandler(this.tirerotationCheckbox_CheckedChanged);
            // 
            // replacemufferCheckbox
            // 
            this.replacemufferCheckbox.AutoSize = true;
            this.replacemufferCheckbox.Location = new System.Drawing.Point(6, 54);
            this.replacemufferCheckbox.Name = "replacemufferCheckbox";
            this.replacemufferCheckbox.Size = new System.Drawing.Size(176, 21);
            this.replacemufferCheckbox.TabIndex = 1;
            this.replacemufferCheckbox.Text = "Replace Muffler ($100.00)";
            this.replacemufferCheckbox.UseVisualStyleBackColor = true;
            this.replacemufferCheckbox.CheckedChanged += new System.EventHandler(this.replacemufferCheckbox_CheckedChanged);
            // 
            // inspectionCheckbox
            // 
            this.inspectionCheckbox.AutoSize = true;
            this.inspectionCheckbox.Location = new System.Drawing.Point(6, 25);
            this.inspectionCheckbox.Name = "inspectionCheckbox";
            this.inspectionCheckbox.Size = new System.Drawing.Size(136, 21);
            this.inspectionCheckbox.TabIndex = 0;
            this.inspectionCheckbox.Text = "Inspection ($15.00)";
            this.inspectionCheckbox.UseVisualStyleBackColor = true;
            this.inspectionCheckbox.CheckedChanged += new System.EventHandler(this.inspectionCheckbox_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.laborTextbox);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.partsTextbox);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(219, 104);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(219, 117);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Parts and Labor";
            // 
            // laborTextbox
            // 
            this.laborTextbox.Location = new System.Drawing.Point(79, 70);
            this.laborTextbox.Name = "laborTextbox";
            this.laborTextbox.Size = new System.Drawing.Size(100, 25);
            this.laborTextbox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Labor ($):";
            // 
            // partsTextbox
            // 
            this.partsTextbox.Location = new System.Drawing.Point(75, 33);
            this.partsTextbox.Name = "partsTextbox";
            this.partsTextbox.Size = new System.Drawing.Size(100, 25);
            this.partsTextbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Parts ($):";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.totalfeesoutputLabel);
            this.groupBox5.Controls.Add(this.taxOutputlabel);
            this.groupBox5.Controls.Add(this.partsoutputLabel);
            this.groupBox5.Controls.Add(this.serviceslaborOutputlabel);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(12, 228);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(427, 163);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Summary";
            // 
            // totalfeesoutputLabel
            // 
            this.totalfeesoutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalfeesoutputLabel.Location = new System.Drawing.Point(141, 122);
            this.totalfeesoutputLabel.Name = "totalfeesoutputLabel";
            this.totalfeesoutputLabel.Size = new System.Drawing.Size(114, 29);
            this.totalfeesoutputLabel.TabIndex = 7;
            this.totalfeesoutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // taxOutputlabel
            // 
            this.taxOutputlabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.taxOutputlabel.Location = new System.Drawing.Point(141, 91);
            this.taxOutputlabel.Name = "taxOutputlabel";
            this.taxOutputlabel.Size = new System.Drawing.Size(114, 29);
            this.taxOutputlabel.TabIndex = 6;
            this.taxOutputlabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // partsoutputLabel
            // 
            this.partsoutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.partsoutputLabel.Location = new System.Drawing.Point(141, 60);
            this.partsoutputLabel.Name = "partsoutputLabel";
            this.partsoutputLabel.Size = new System.Drawing.Size(114, 29);
            this.partsoutputLabel.TabIndex = 5;
            this.partsoutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // serviceslaborOutputlabel
            // 
            this.serviceslaborOutputlabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.serviceslaborOutputlabel.Location = new System.Drawing.Point(141, 27);
            this.serviceslaborOutputlabel.Name = "serviceslaborOutputlabel";
            this.serviceslaborOutputlabel.Size = new System.Drawing.Size(114, 29);
            this.serviceslaborOutputlabel.TabIndex = 4;
            this.serviceslaborOutputlabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Total Fees:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tax (On Parts):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Parts:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Services and Labor:";
            // 
            // totalButton
            // 
            this.totalButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalButton.Location = new System.Drawing.Point(31, 405);
            this.totalButton.Name = "totalButton";
            this.totalButton.Size = new System.Drawing.Size(125, 40);
            this.totalButton.TabIndex = 5;
            this.totalButton.Text = "Calculate Total";
            this.totalButton.UseVisualStyleBackColor = true;
            this.totalButton.Click += new System.EventHandler(this.totalButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(162, 405);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(125, 40);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(294, 405);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(125, 40);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 460);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.totalButton);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Joe\'s Automotive";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox lubejobCheckbox;
        private System.Windows.Forms.CheckBox oilchangeCheckbox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox transmissionflushCheckbox;
        private System.Windows.Forms.CheckBox radiatorflushCheckbox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox tirerotationCheckbox;
        private System.Windows.Forms.CheckBox replacemufferCheckbox;
        private System.Windows.Forms.CheckBox inspectionCheckbox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox laborTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox partsTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button totalButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label totalfeesoutputLabel;
        private System.Windows.Forms.Label taxOutputlabel;
        private System.Windows.Forms.Label partsoutputLabel;
        private System.Windows.Forms.Label serviceslaborOutputlabel;
    }
}

