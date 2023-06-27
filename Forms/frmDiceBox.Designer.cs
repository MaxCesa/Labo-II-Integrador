namespace PrimerParcialLabo_Intento2.Forms
{
    partial class frmDiceBox
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
            lblDiceScore = new Label();
            lblDiceBox = new Label();
            SuspendLayout();
            // 
            // lblDiceScore
            // 
            lblDiceScore.Location = new Point(0, 0);
            lblDiceScore.Name = "lblDiceScore";
            lblDiceScore.Size = new Size(114, 31);
            lblDiceScore.TabIndex = 2;
            // 
            // lblDiceBox
            // 
            lblDiceBox.AutoSize = true;
            lblDiceBox.Font = new Font("Segoe Script", 70F, FontStyle.Regular, GraphicsUnit.Point);
            lblDiceBox.Location = new Point(78, 137);
            lblDiceBox.Name = "lblDiceBox";
            lblDiceBox.Size = new Size(317, 185);
            lblDiceBox.TabIndex = 1;
            lblDiceBox.Text = "Test";
            lblDiceBox.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmDiceBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 481);
            Controls.Add(lblDiceBox);
            Controls.Add(lblDiceScore);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmDiceBox";
            Text = "frmDiceBox";
            Paint += frmDiceBox_Paint;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDiceScore;
        public Label lblDiceBox;
    }
}