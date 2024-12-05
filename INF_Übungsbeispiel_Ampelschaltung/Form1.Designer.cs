namespace INF_Übungsbeispiel_Ampelschaltung
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tmr1 = new System.Windows.Forms.Timer(components);
            pnlCar = new Panel();
            pnlTrafficLight = new Panel();
            rbtnManual = new RadioButton();
            rbtnAutomatic = new RadioButton();
            btnToGreen = new Button();
            btnToRed = new Button();
            tmrTrafficLight = new System.Windows.Forms.Timer(components);
            txtRedDuration = new TextBox();
            txtGreenDuration = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // tmr1
            // 
            tmr1.Enabled = true;
            tmr1.Interval = 33;
            // 
            // pnlCar
            // 
            pnlCar.BackColor = SystemColors.ControlDarkDark;
            pnlCar.Location = new Point(1122, 620);
            pnlCar.Name = "pnlCar";
            pnlCar.Size = new Size(144, 67);
            pnlCar.TabIndex = 2;
            // 
            // pnlTrafficLight
            // 
            pnlTrafficLight.BackColor = Color.Green;
            pnlTrafficLight.Location = new Point(649, 390);
            pnlTrafficLight.Name = "pnlTrafficLight";
            pnlTrafficLight.Size = new Size(89, 78);
            pnlTrafficLight.TabIndex = 3;
            // 
            // rbtnManual
            // 
            rbtnManual.AutoSize = true;
            rbtnManual.Location = new Point(72, 36);
            rbtnManual.Name = "rbtnManual";
            rbtnManual.Size = new Size(281, 41);
            rbtnManual.TabIndex = 0;
            rbtnManual.TabStop = true;
            rbtnManual.Text = "&manuelle Schaltung";
            rbtnManual.UseVisualStyleBackColor = true;
            // 
            // rbtnAutomatic
            // 
            rbtnAutomatic.AutoSize = true;
            rbtnAutomatic.Location = new Point(72, 105);
            rbtnAutomatic.Name = "rbtnAutomatic";
            rbtnAutomatic.Size = new Size(331, 41);
            rbtnAutomatic.TabIndex = 4;
            rbtnAutomatic.TabStop = true;
            rbtnAutomatic.Text = "&automatische Schaltung";
            rbtnAutomatic.UseVisualStyleBackColor = true;
            // 
            // btnToGreen
            // 
            btnToGreen.Location = new Point(834, 125);
            btnToGreen.Name = "btnToGreen";
            btnToGreen.Size = new Size(293, 52);
            btnToGreen.TabIndex = 5;
            btnToGreen.Text = "Schalte auf &Grün";
            btnToGreen.UseVisualStyleBackColor = true;
            // 
            // btnToRed
            // 
            btnToRed.Location = new Point(834, 36);
            btnToRed.Name = "btnToRed";
            btnToRed.Size = new Size(293, 52);
            btnToRed.TabIndex = 6;
            btnToRed.Text = "Schalte auf &Rot";
            btnToRed.UseVisualStyleBackColor = true;
            // 
            // txtRedDuration
            // 
            txtRedDuration.Location = new Point(72, 221);
            txtRedDuration.Name = "txtRedDuration";
            txtRedDuration.Size = new Size(82, 43);
            txtRedDuration.TabIndex = 7;
            txtRedDuration.Text = "3";
            txtRedDuration.TextAlign = HorizontalAlignment.Right;
            // 
            // txtGreenDuration
            // 
            txtGreenDuration.Location = new Point(72, 299);
            txtGreenDuration.Name = "txtGreenDuration";
            txtGreenDuration.Size = new Size(82, 43);
            txtGreenDuration.TabIndex = 8;
            txtGreenDuration.Text = "3";
            txtGreenDuration.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(218, 227);
            label1.Name = "label1";
            label1.Size = new Size(251, 37);
            label1.TabIndex = 9;
            label1.Text = "Dauer der Rotphase";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(218, 305);
            label2.Name = "label2";
            label2.Size = new Size(269, 37);
            label2.TabIndex = 10;
            label2.Text = "Dauer der Grünphase";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(160, 221);
            label3.Name = "label3";
            label3.Size = new Size(28, 37);
            label3.TabIndex = 11;
            label3.Text = "s";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(160, 302);
            label4.Name = "label4";
            label4.Size = new Size(28, 37);
            label4.TabIndex = 12;
            label4.Text = "s";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1346, 860);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtGreenDuration);
            Controls.Add(txtRedDuration);
            Controls.Add(btnToRed);
            Controls.Add(btnToGreen);
            Controls.Add(rbtnAutomatic);
            Controls.Add(rbtnManual);
            Controls.Add(pnlTrafficLight);
            Controls.Add(pnlCar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer tmr1;
        private Panel pnlCar;
        private Panel pnlTrafficLight;
        private RadioButton rbtnManual;
        private RadioButton rbtnAutomatic;
        private Button btnToGreen;
        private Button btnToRed;
        private System.Windows.Forms.Timer tmrTrafficLight;
        private TextBox txtRedDuration;
        private TextBox txtGreenDuration;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
