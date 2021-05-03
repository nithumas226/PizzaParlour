
namespace PizzaParlour
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
            this.pizzaLabel = new System.Windows.Forms.Label();
            this.toppingLabel = new System.Windows.Forms.Label();
            this.toppingsInput = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.priceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pizzaLabel
            // 
            this.pizzaLabel.BackColor = System.Drawing.Color.Red;
            this.pizzaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pizzaLabel.ForeColor = System.Drawing.Color.White;
            this.pizzaLabel.Location = new System.Drawing.Point(-1, -2);
            this.pizzaLabel.Name = "pizzaLabel";
            this.pizzaLabel.Size = new System.Drawing.Size(808, 99);
            this.pizzaLabel.TabIndex = 0;
            this.pizzaLabel.Text = "Pizza Parlour";
            this.pizzaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toppingLabel
            // 
            this.toppingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toppingLabel.ForeColor = System.Drawing.Color.White;
            this.toppingLabel.Location = new System.Drawing.Point(94, 139);
            this.toppingLabel.Name = "toppingLabel";
            this.toppingLabel.Size = new System.Drawing.Size(279, 37);
            this.toppingLabel.TabIndex = 1;
            this.toppingLabel.Text = "Number of Toppings";
            this.toppingLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // toppingsInput
            // 
            this.toppingsInput.Location = new System.Drawing.Point(403, 156);
            this.toppingsInput.Name = "toppingsInput";
            this.toppingsInput.Size = new System.Drawing.Size(199, 20);
            this.toppingsInput.TabIndex = 2;
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.Black;
            this.calculateButton.FlatAppearance.BorderSize = 2;
            this.calculateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.ForeColor = System.Drawing.Color.White;
            this.calculateButton.Location = new System.Drawing.Point(335, 204);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(109, 31);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // priceLabel
            // 
            this.priceLabel.BackColor = System.Drawing.Color.White;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(165, 271);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(398, 81);
            this.priceLabel.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 375);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.toppingsInput);
            this.Controls.Add(this.toppingLabel);
            this.Controls.Add(this.pizzaLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Pizza Parlour";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pizzaLabel;
        private System.Windows.Forms.Label toppingLabel;
        private System.Windows.Forms.TextBox toppingsInput;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label priceLabel;
    }
}

