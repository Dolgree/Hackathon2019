namespace HackathonMFClever
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
            this.Generator = new System.Windows.Forms.Button();
            this.Reservation = new System.Windows.Forms.Button();
            this.Data = new System.Windows.Forms.Label();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Generator
            // 
            this.Generator.Location = new System.Drawing.Point(645, 491);
            this.Generator.Name = "Generator";
            this.Generator.Size = new System.Drawing.Size(143, 45);
            this.Generator.TabIndex = 0;
            this.Generator.Text = "Generate";
            this.Generator.UseVisualStyleBackColor = true;
            this.Generator.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Reservation
            // 
            this.Reservation.Location = new System.Drawing.Point(645, 435);
            this.Reservation.Name = "Reservation";
            this.Reservation.Size = new System.Drawing.Size(143, 50);
            this.Reservation.TabIndex = 2;
            this.Reservation.Text = "Reserve";
            this.Reservation.UseVisualStyleBackColor = true;
            this.Reservation.Click += new System.EventHandler(this.Reservation_Click);
            // 
            // Data
            // 
            this.Data.AutoSize = true;
            this.Data.Location = new System.Drawing.Point(12, 9);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(0, 17);
            this.Data.TabIndex = 3;
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(645, 380);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(143, 49);
            this.RefreshButton.TabIndex = 4;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 547);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.Reservation);
            this.Controls.Add(this.Generator);
            this.Name = "Form1";
            this.Text = "HackathonMFClever";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Generator;
        private System.Windows.Forms.Button Reservation;
        private System.Windows.Forms.Label Data;
        private System.Windows.Forms.Button RefreshButton;
    }
}

