namespace TrackerUI
{
    partial class CreatePrizeForm
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
            this.createPrizeLabel = new System.Windows.Forms.Label();
            this.pricePercentageValue = new System.Windows.Forms.TextBox();
            this.prizePercentageLabel = new System.Windows.Forms.Label();
            this.priceAmountValue = new System.Windows.Forms.TextBox();
            this.priceAmountLabel = new System.Windows.Forms.Label();
            this.placeNameValue = new System.Windows.Forms.TextBox();
            this.placeNameLabel = new System.Windows.Forms.Label();
            this.placeNumberValue = new System.Windows.Forms.TextBox();
            this.placeNumberLabel = new System.Windows.Forms.Label();
            this.createPrizeButton = new System.Windows.Forms.Button();
            this.orLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createPrizeLabel
            // 
            this.createPrizeLabel.AutoSize = true;
            this.createPrizeLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPrizeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.createPrizeLabel.Location = new System.Drawing.Point(12, 9);
            this.createPrizeLabel.Name = "createPrizeLabel";
            this.createPrizeLabel.Size = new System.Drawing.Size(209, 50);
            this.createPrizeLabel.TabIndex = 12;
            this.createPrizeLabel.Text = "Create Prize";
            // 
            // pricePercentageValue
            // 
            this.pricePercentageValue.Location = new System.Drawing.Point(253, 315);
            this.pricePercentageValue.Name = "pricePercentageValue";
            this.pricePercentageValue.Size = new System.Drawing.Size(238, 35);
            this.pricePercentageValue.TabIndex = 24;
            this.pricePercentageValue.TextChanged += new System.EventHandler(this.cellphoneValue_TextChanged);
            // 
            // prizePercentageLabel
            // 
            this.prizePercentageLabel.AutoSize = true;
            this.prizePercentageLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizePercentageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.prizePercentageLabel.Location = new System.Drawing.Point(14, 315);
            this.prizePercentageLabel.Name = "prizePercentageLabel";
            this.prizePercentageLabel.Size = new System.Drawing.Size(212, 37);
            this.prizePercentageLabel.TabIndex = 23;
            this.prizePercentageLabel.Text = "Price Percentage";
            // 
            // priceAmountValue
            // 
            this.priceAmountValue.Location = new System.Drawing.Point(253, 165);
            this.priceAmountValue.Name = "priceAmountValue";
            this.priceAmountValue.Size = new System.Drawing.Size(238, 35);
            this.priceAmountValue.TabIndex = 22;
            this.priceAmountValue.TextChanged += new System.EventHandler(this.eMailValue_TextChanged);
            // 
            // priceAmountLabel
            // 
            this.priceAmountLabel.AutoSize = true;
            this.priceAmountLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceAmountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.priceAmountLabel.Location = new System.Drawing.Point(20, 165);
            this.priceAmountLabel.Name = "priceAmountLabel";
            this.priceAmountLabel.Size = new System.Drawing.Size(176, 37);
            this.priceAmountLabel.TabIndex = 21;
            this.priceAmountLabel.Text = "Price Amount";
            // 
            // placeNameValue
            // 
            this.placeNameValue.Location = new System.Drawing.Point(253, 124);
            this.placeNameValue.Name = "placeNameValue";
            this.placeNameValue.Size = new System.Drawing.Size(238, 35);
            this.placeNameValue.TabIndex = 20;
            // 
            // placeNameLabel
            // 
            this.placeNameLabel.AutoSize = true;
            this.placeNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.placeNameLabel.Location = new System.Drawing.Point(20, 124);
            this.placeNameLabel.Name = "placeNameLabel";
            this.placeNameLabel.Size = new System.Drawing.Size(157, 37);
            this.placeNameLabel.TabIndex = 19;
            this.placeNameLabel.Text = "Place Name";
            // 
            // placeNumberValue
            // 
            this.placeNumberValue.Location = new System.Drawing.Point(253, 83);
            this.placeNumberValue.Name = "placeNumberValue";
            this.placeNumberValue.Size = new System.Drawing.Size(238, 35);
            this.placeNumberValue.TabIndex = 18;
            // 
            // placeNumberLabel
            // 
            this.placeNumberLabel.AutoSize = true;
            this.placeNumberLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeNumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.placeNumberLabel.Location = new System.Drawing.Point(20, 83);
            this.placeNumberLabel.Name = "placeNumberLabel";
            this.placeNumberLabel.Size = new System.Drawing.Size(183, 37);
            this.placeNumberLabel.TabIndex = 17;
            this.placeNumberLabel.Text = "Place Number";
            this.placeNumberLabel.Click += new System.EventHandler(this.firstNameLabel_Click);
            // 
            // createPrizeButton
            // 
            this.createPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.createPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPrizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.createPrizeButton.Location = new System.Drawing.Point(147, 382);
            this.createPrizeButton.Name = "createPrizeButton";
            this.createPrizeButton.Size = new System.Drawing.Size(252, 45);
            this.createPrizeButton.TabIndex = 25;
            this.createPrizeButton.Text = "Create Prize";
            this.createPrizeButton.UseVisualStyleBackColor = true;
            // 
            // orLabel
            // 
            this.orLabel.AutoSize = true;
            this.orLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.orLabel.Location = new System.Drawing.Point(211, 241);
            this.orLabel.Name = "orLabel";
            this.orLabel.Size = new System.Drawing.Size(68, 37);
            this.orLabel.TabIndex = 26;
            this.orLabel.Text = "-Or-";
            this.orLabel.Click += new System.EventHandler(this.teamNameLabel_Click);
            // 
            // CreatePrizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(537, 448);
            this.Controls.Add(this.orLabel);
            this.Controls.Add(this.createPrizeButton);
            this.Controls.Add(this.pricePercentageValue);
            this.Controls.Add(this.prizePercentageLabel);
            this.Controls.Add(this.priceAmountValue);
            this.Controls.Add(this.priceAmountLabel);
            this.Controls.Add(this.placeNameValue);
            this.Controls.Add(this.placeNameLabel);
            this.Controls.Add(this.placeNumberValue);
            this.Controls.Add(this.placeNumberLabel);
            this.Controls.Add(this.createPrizeLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreatePrizeForm";
            this.Text = "Create Prize";
            this.Load += new System.EventHandler(this.CreatePrizeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label createPrizeLabel;
        private System.Windows.Forms.TextBox pricePercentageValue;
        private System.Windows.Forms.Label prizePercentageLabel;
        private System.Windows.Forms.TextBox priceAmountValue;
        private System.Windows.Forms.Label priceAmountLabel;
        private System.Windows.Forms.TextBox placeNameValue;
        private System.Windows.Forms.Label placeNameLabel;
        private System.Windows.Forms.TextBox placeNumberValue;
        private System.Windows.Forms.Label placeNumberLabel;
        private System.Windows.Forms.Button createPrizeButton;
        private System.Windows.Forms.Label orLabel;
    }
}