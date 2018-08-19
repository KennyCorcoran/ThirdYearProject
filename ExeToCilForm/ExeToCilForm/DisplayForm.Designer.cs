namespace ExeToCilForm
{
    partial class DisplayForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.goBackButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.convertToReadableButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.CilLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.outputRichTextBox = new System.Windows.Forms.RichTextBox();
            this.readableLabel = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.goBackButton);
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Controls.Add(this.clearButton);
            this.panel1.Controls.Add(this.convertToReadableButton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(24, 84);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1898, 1068);
            this.panel1.TabIndex = 0;
            // 
            // goBackButton
            // 
            this.goBackButton.BackColor = System.Drawing.Color.White;
            this.goBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goBackButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBackButton.ForeColor = System.Drawing.Color.Black;
            this.goBackButton.Location = new System.Drawing.Point(9, 1009);
            this.goBackButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(194, 50);
            this.goBackButton.TabIndex = 9;
            this.goBackButton.Text = "Go Back";
            this.goBackButton.UseVisualStyleBackColor = false;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.White;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.Black;
            this.closeButton.Location = new System.Drawing.Point(1696, 1012);
            this.closeButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(194, 50);
            this.closeButton.TabIndex = 8;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.White;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.Color.Black;
            this.clearButton.Location = new System.Drawing.Point(1050, 1012);
            this.clearButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(194, 50);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // convertToReadableButton
            // 
            this.convertToReadableButton.BackColor = System.Drawing.Color.White;
            this.convertToReadableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.convertToReadableButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertToReadableButton.ForeColor = System.Drawing.Color.Black;
            this.convertToReadableButton.Location = new System.Drawing.Point(672, 1012);
            this.convertToReadableButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.convertToReadableButton.Name = "convertToReadableButton";
            this.convertToReadableButton.Size = new System.Drawing.Size(194, 50);
            this.convertToReadableButton.TabIndex = 4;
            this.convertToReadableButton.Text = "Convert";
            this.convertToReadableButton.UseVisualStyleBackColor = false;
            this.convertToReadableButton.Click += new System.EventHandler(this.convertToReadableButton_Click);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Controls.Add(this.CilLabel);
            this.panel2.Location = new System.Drawing.Point(6, 25);
            this.panel2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(860, 975);
            this.panel2.TabIndex = 5;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(3, 48);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(854, 924);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            this.richTextBox1.WordWrap = false;
            // 
            // CilLabel
            // 
            this.CilLabel.AutoSize = true;
            this.CilLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CilLabel.ForeColor = System.Drawing.Color.White;
            this.CilLabel.Location = new System.Drawing.Point(102, 0);
            this.CilLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.CilLabel.Name = "CilLabel";
            this.CilLabel.Size = new System.Drawing.Size(656, 46);
            this.CilLabel.TabIndex = 2;
            this.CilLabel.Text = "Common Intermediate Language";
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.Controls.Add(this.outputRichTextBox);
            this.panel3.Controls.Add(this.readableLabel);
            this.panel3.Location = new System.Drawing.Point(1044, 25);
            this.panel3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(848, 978);
            this.panel3.TabIndex = 6;
            // 
            // outputRichTextBox
            // 
            this.outputRichTextBox.Location = new System.Drawing.Point(6, 45);
            this.outputRichTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.outputRichTextBox.Name = "outputRichTextBox";
            this.outputRichTextBox.Size = new System.Drawing.Size(836, 927);
            this.outputRichTextBox.TabIndex = 1;
            this.outputRichTextBox.Text = "";
            this.outputRichTextBox.WordWrap = false;
            // 
            // readableLabel
            // 
            this.readableLabel.AutoSize = true;
            this.readableLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readableLabel.ForeColor = System.Drawing.Color.White;
            this.readableLabel.Location = new System.Drawing.Point(240, 0);
            this.readableLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.readableLabel.Name = "readableLabel";
            this.readableLabel.Size = new System.Drawing.Size(379, 46);
            this.readableLabel.TabIndex = 3;
            this.readableLabel.Text = "Interpreter Output";
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.White;
            this.headerLabel.Location = new System.Drawing.Point(646, 17);
            this.headerLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(683, 55);
            this.headerLabel.TabIndex = 4;
            this.headerLabel.Text = "Convert CIL to readable text";
            // 
            // DisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1965, 1181);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "DisplayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DisplayForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label readableLabel;
        private System.Windows.Forms.Label CilLabel;
        private System.Windows.Forms.RichTextBox outputRichTextBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button convertToReadableButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button goBackButton;
    }
}