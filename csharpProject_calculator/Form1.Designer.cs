namespace csharpProject_calculator
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
            screenCalculator = new TextBox();
            btn_tan = new Button();
            btn_sin = new Button();
            btn_cos = new Button();
            btn_sqrt = new Button();
            btn_rad = new Button();
            btn_ln = new Button();
            btn_deg = new Button();
            btn_log = new Button();
            btn_pi = new Button();
            btn_pow_x_y = new Button();
            button11 = new Button();
            btn_factoriel = new Button();
            btn_exponentiel = new Button();
            btn_8 = new Button();
            btn_addition = new Button();
            btn_7 = new Button();
            btn_multiplication = new Button();
            btn_2 = new Button();
            btn_6 = new Button();
            btn_1 = new Button();
            btn_soustraction = new Button();
            btn_0 = new Button();
            btn_3 = new Button();
            btn_point = new Button();
            bnt_division = new Button();
            btn_5 = new Button();
            btn_9 = new Button();
            btn_4 = new Button();
            btn_ac = new Button();
            btn_egal = new Button();
            btn_close = new Button();
            btn_paranthese_ouvrante = new Button();
            btn_paranthese_fermante = new Button();
            screenResultat = new TextBox();
            btn_del = new Button();
            SuspendLayout();
            // 
            // screenCalculator
            // 
            screenCalculator.BackColor = Color.FromArgb(44, 44, 44);
            screenCalculator.BorderStyle = BorderStyle.None;
            screenCalculator.Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point);
            screenCalculator.ForeColor = SystemColors.Info;
            screenCalculator.Location = new Point(0, 0);
            screenCalculator.Multiline = true;
            screenCalculator.Name = "screenCalculator";
            screenCalculator.ReadOnly = true;
            screenCalculator.ScrollBars = ScrollBars.Horizontal;
            screenCalculator.Size = new Size(243, 39);
            screenCalculator.TabIndex = 0;
            screenCalculator.TextChanged += screenCalculator_TextChanged;
            // 
            // btn_tan
            // 
            btn_tan.BackColor = Color.FromArgb(28, 28, 28);
            btn_tan.FlatAppearance.BorderSize = 0;
            btn_tan.FlatAppearance.MouseOverBackColor = SystemColors.AppWorkspace;
            btn_tan.FlatStyle = FlatStyle.Flat;
            btn_tan.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_tan.ForeColor = Color.FromArgb(160, 83, 16);
            btn_tan.Location = new Point(0, 101);
            btn_tan.Margin = new Padding(0);
            btn_tan.Name = "btn_tan";
            btn_tan.Size = new Size(60, 35);
            btn_tan.TabIndex = 1;
            btn_tan.Text = "tan";
            btn_tan.UseVisualStyleBackColor = false;
            btn_tan.Click += boutton_CLick;
            // 
            // btn_sin
            // 
            btn_sin.BackColor = Color.FromArgb(28, 28, 28);
            btn_sin.FlatAppearance.BorderSize = 0;
            btn_sin.FlatAppearance.MouseOverBackColor = SystemColors.AppWorkspace;
            btn_sin.FlatStyle = FlatStyle.Flat;
            btn_sin.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_sin.ForeColor = Color.FromArgb(160, 83, 16);
            btn_sin.Location = new Point(122, 101);
            btn_sin.Margin = new Padding(1);
            btn_sin.Name = "btn_sin";
            btn_sin.Size = new Size(60, 35);
            btn_sin.TabIndex = 3;
            btn_sin.Text = "sin";
            btn_sin.UseVisualStyleBackColor = false;
            btn_sin.Click += boutton_CLick;
            // 
            // btn_cos
            // 
            btn_cos.BackColor = Color.FromArgb(28, 28, 28);
            btn_cos.FlatAppearance.BorderSize = 0;
            btn_cos.FlatAppearance.MouseOverBackColor = SystemColors.AppWorkspace;
            btn_cos.FlatStyle = FlatStyle.Flat;
            btn_cos.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_cos.ForeColor = Color.FromArgb(160, 83, 16);
            btn_cos.Location = new Point(61, 101);
            btn_cos.Margin = new Padding(1);
            btn_cos.Name = "btn_cos";
            btn_cos.Size = new Size(60, 35);
            btn_cos.TabIndex = 2;
            btn_cos.Text = "cos";
            btn_cos.UseVisualStyleBackColor = false;
            btn_cos.Click += boutton_CLick;
            // 
            // btn_sqrt
            // 
            btn_sqrt.BackColor = Color.FromArgb(28, 28, 28);
            btn_sqrt.FlatAppearance.BorderSize = 0;
            btn_sqrt.FlatAppearance.MouseOverBackColor = SystemColors.AppWorkspace;
            btn_sqrt.FlatStyle = FlatStyle.Flat;
            btn_sqrt.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_sqrt.ForeColor = Color.FromArgb(160, 83, 16);
            btn_sqrt.Location = new Point(183, 101);
            btn_sqrt.Margin = new Padding(5, 1, 1, 1);
            btn_sqrt.Name = "btn_sqrt";
            btn_sqrt.Size = new Size(60, 35);
            btn_sqrt.TabIndex = 4;
            btn_sqrt.Text = "√";
            btn_sqrt.UseVisualStyleBackColor = false;
            btn_sqrt.Click += boutton_CLick;
            // 
            // btn_rad
            // 
            btn_rad.BackColor = Color.FromArgb(28, 28, 28);
            btn_rad.FlatAppearance.BorderSize = 0;
            btn_rad.FlatAppearance.MouseOverBackColor = SystemColors.AppWorkspace;
            btn_rad.FlatStyle = FlatStyle.Flat;
            btn_rad.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_rad.ForeColor = Color.FromArgb(160, 83, 16);
            btn_rad.Location = new Point(183, 137);
            btn_rad.Name = "btn_rad";
            btn_rad.Size = new Size(60, 35);
            btn_rad.TabIndex = 8;
            btn_rad.Text = "rad";
            btn_rad.UseVisualStyleBackColor = false;
            btn_rad.Click += boutton_CLick;
            // 
            // btn_ln
            // 
            btn_ln.BackColor = Color.FromArgb(28, 28, 28);
            btn_ln.FlatAppearance.BorderSize = 0;
            btn_ln.FlatAppearance.MouseOverBackColor = SystemColors.AppWorkspace;
            btn_ln.FlatStyle = FlatStyle.Flat;
            btn_ln.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_ln.ForeColor = Color.FromArgb(160, 83, 16);
            btn_ln.Location = new Point(61, 137);
            btn_ln.Name = "btn_ln";
            btn_ln.Size = new Size(60, 35);
            btn_ln.TabIndex = 6;
            btn_ln.Text = "ln";
            btn_ln.UseVisualStyleBackColor = false;
            btn_ln.Click += boutton_CLick;
            // 
            // btn_deg
            // 
            btn_deg.BackColor = Color.FromArgb(28, 28, 28);
            btn_deg.FlatAppearance.BorderSize = 0;
            btn_deg.FlatAppearance.MouseOverBackColor = SystemColors.AppWorkspace;
            btn_deg.FlatStyle = FlatStyle.Flat;
            btn_deg.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_deg.ForeColor = Color.FromArgb(160, 83, 16);
            btn_deg.Location = new Point(122, 137);
            btn_deg.Name = "btn_deg";
            btn_deg.Size = new Size(60, 35);
            btn_deg.TabIndex = 7;
            btn_deg.Text = "deg";
            btn_deg.UseVisualStyleBackColor = false;
            btn_deg.Click += boutton_CLick;
            // 
            // btn_log
            // 
            btn_log.BackColor = Color.FromArgb(28, 28, 28);
            btn_log.FlatAppearance.BorderSize = 0;
            btn_log.FlatAppearance.MouseOverBackColor = SystemColors.AppWorkspace;
            btn_log.FlatStyle = FlatStyle.Flat;
            btn_log.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_log.ForeColor = Color.FromArgb(160, 83, 16);
            btn_log.Location = new Point(0, 137);
            btn_log.Name = "btn_log";
            btn_log.Size = new Size(60, 35);
            btn_log.TabIndex = 5;
            btn_log.Text = "log";
            btn_log.UseVisualStyleBackColor = false;
            btn_log.Click += boutton_CLick;
            // 
            // btn_pi
            // 
            btn_pi.BackColor = Color.FromArgb(28, 28, 28);
            btn_pi.FlatAppearance.BorderSize = 0;
            btn_pi.FlatAppearance.MouseOverBackColor = SystemColors.AppWorkspace;
            btn_pi.FlatStyle = FlatStyle.Flat;
            btn_pi.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_pi.ForeColor = Color.FromArgb(160, 83, 16);
            btn_pi.Location = new Point(183, 173);
            btn_pi.Name = "btn_pi";
            btn_pi.Size = new Size(60, 35);
            btn_pi.TabIndex = 12;
            btn_pi.Text = "π";
            btn_pi.UseVisualStyleBackColor = false;
            btn_pi.Click += boutton_CLick;
            // 
            // btn_pow_x_y
            // 
            btn_pow_x_y.BackColor = Color.FromArgb(28, 28, 28);
            btn_pow_x_y.FlatAppearance.BorderSize = 0;
            btn_pow_x_y.FlatAppearance.MouseOverBackColor = SystemColors.AppWorkspace;
            btn_pow_x_y.FlatStyle = FlatStyle.Flat;
            btn_pow_x_y.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_pow_x_y.ForeColor = Color.FromArgb(160, 83, 16);
            btn_pow_x_y.Location = new Point(61, 173);
            btn_pow_x_y.Name = "btn_pow_x_y";
            btn_pow_x_y.Size = new Size(60, 35);
            btn_pow_x_y.TabIndex = 10;
            btn_pow_x_y.Text = "x^y";
            btn_pow_x_y.UseVisualStyleBackColor = false;
            btn_pow_x_y.Click += boutton_CLick;
            // 
            // button11
            // 
            button11.BackColor = Color.FromArgb(28, 28, 28);
            button11.FlatAppearance.BorderSize = 0;
            button11.FlatAppearance.MouseOverBackColor = SystemColors.AppWorkspace;
            button11.FlatStyle = FlatStyle.Flat;
            button11.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button11.ForeColor = Color.FromArgb(160, 83, 16);
            button11.Location = new Point(122, 173);
            button11.Name = "button11";
            button11.Size = new Size(60, 35);
            button11.TabIndex = 11;
            button11.Text = "%";
            button11.UseVisualStyleBackColor = false;
            button11.Click += boutton_CLick;
            // 
            // btn_factoriel
            // 
            btn_factoriel.BackColor = Color.FromArgb(28, 28, 28);
            btn_factoriel.FlatAppearance.BorderSize = 0;
            btn_factoriel.FlatAppearance.MouseOverBackColor = SystemColors.AppWorkspace;
            btn_factoriel.FlatStyle = FlatStyle.Flat;
            btn_factoriel.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_factoriel.ForeColor = Color.FromArgb(160, 83, 16);
            btn_factoriel.Location = new Point(0, 173);
            btn_factoriel.Name = "btn_factoriel";
            btn_factoriel.Size = new Size(60, 35);
            btn_factoriel.TabIndex = 9;
            btn_factoriel.Text = "!";
            btn_factoriel.UseVisualStyleBackColor = false;
            btn_factoriel.Click += boutton_CLick;
            // 
            // btn_exponentiel
            // 
            btn_exponentiel.BackColor = Color.FromArgb(28, 28, 28);
            btn_exponentiel.FlatAppearance.BorderSize = 0;
            btn_exponentiel.FlatAppearance.MouseOverBackColor = SystemColors.AppWorkspace;
            btn_exponentiel.FlatStyle = FlatStyle.Flat;
            btn_exponentiel.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_exponentiel.ForeColor = Color.FromArgb(160, 83, 16);
            btn_exponentiel.Location = new Point(122, 353);
            btn_exponentiel.Name = "btn_exponentiel";
            btn_exponentiel.Size = new Size(60, 35);
            btn_exponentiel.TabIndex = 31;
            btn_exponentiel.Text = "e";
            btn_exponentiel.UseVisualStyleBackColor = false;
            btn_exponentiel.Click += boutton_CLick;
            // 
            // btn_8
            // 
            btn_8.BackColor = Color.FromArgb(28, 28, 28);
            btn_8.FlatAppearance.BorderSize = 0;
            btn_8.FlatAppearance.MouseOverBackColor = SystemColors.AppWorkspace;
            btn_8.FlatStyle = FlatStyle.Flat;
            btn_8.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_8.ForeColor = Color.FromArgb(160, 83, 16);
            btn_8.Location = new Point(61, 245);
            btn_8.Name = "btn_8";
            btn_8.Size = new Size(60, 35);
            btn_8.TabIndex = 18;
            btn_8.Text = "8";
            btn_8.UseVisualStyleBackColor = false;
            btn_8.Click += boutton_CLick;
            // 
            // btn_addition
            // 
            btn_addition.BackColor = Color.FromArgb(10, 8, 13);
            btn_addition.FlatAppearance.BorderSize = 0;
            btn_addition.FlatAppearance.MouseOverBackColor = SystemColors.AppWorkspace;
            btn_addition.FlatStyle = FlatStyle.Flat;
            btn_addition.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_addition.ForeColor = Color.FromArgb(160, 83, 16);
            btn_addition.Location = new Point(183, 353);
            btn_addition.Name = "btn_addition";
            btn_addition.Size = new Size(60, 35);
            btn_addition.TabIndex = 32;
            btn_addition.Text = "+";
            btn_addition.UseVisualStyleBackColor = false;
            btn_addition.Click += boutton_CLick;
            // 
            // btn_7
            // 
            btn_7.BackColor = Color.FromArgb(28, 28, 28);
            btn_7.FlatAppearance.BorderSize = 0;
            btn_7.FlatAppearance.MouseOverBackColor = SystemColors.AppWorkspace;
            btn_7.FlatStyle = FlatStyle.Flat;
            btn_7.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_7.ForeColor = Color.FromArgb(160, 83, 16);
            btn_7.Location = new Point(0, 245);
            btn_7.Name = "btn_7";
            btn_7.Size = new Size(60, 35);
            btn_7.TabIndex = 17;
            btn_7.Text = "7";
            btn_7.UseVisualStyleBackColor = false;
            btn_7.Click += boutton_CLick;
            // 
            // btn_multiplication
            // 
            btn_multiplication.BackColor = Color.FromArgb(10, 8, 13);
            btn_multiplication.FlatAppearance.BorderSize = 0;
            btn_multiplication.FlatAppearance.MouseOverBackColor = SystemColors.AppWorkspace;
            btn_multiplication.FlatStyle = FlatStyle.Flat;
            btn_multiplication.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_multiplication.ForeColor = Color.FromArgb(160, 83, 16);
            btn_multiplication.Location = new Point(183, 281);
            btn_multiplication.Name = "btn_multiplication";
            btn_multiplication.Size = new Size(60, 35);
            btn_multiplication.TabIndex = 24;
            btn_multiplication.Text = "x";
            btn_multiplication.UseVisualStyleBackColor = false;
            btn_multiplication.Click += boutton_CLick;
            // 
            // btn_2
            // 
            btn_2.BackColor = Color.FromArgb(28, 28, 28);
            btn_2.FlatAppearance.BorderSize = 0;
            btn_2.FlatAppearance.MouseOverBackColor = SystemColors.AppWorkspace;
            btn_2.FlatStyle = FlatStyle.Flat;
            btn_2.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_2.ForeColor = Color.FromArgb(160, 83, 16);
            btn_2.Location = new Point(61, 317);
            btn_2.Name = "btn_2";
            btn_2.Size = new Size(60, 35);
            btn_2.TabIndex = 26;
            btn_2.Text = "2";
            btn_2.UseVisualStyleBackColor = false;
            btn_2.Click += boutton_CLick;
            // 
            // btn_6
            // 
            btn_6.BackColor = Color.FromArgb(28, 28, 28);
            btn_6.FlatAppearance.BorderSize = 0;
            btn_6.FlatAppearance.MouseOverBackColor = SystemColors.AppWorkspace;
            btn_6.FlatStyle = FlatStyle.Flat;
            btn_6.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_6.ForeColor = Color.FromArgb(160, 83, 16);
            btn_6.Location = new Point(122, 281);
            btn_6.Name = "btn_6";
            btn_6.Size = new Size(60, 35);
            btn_6.TabIndex = 23;
            btn_6.Text = "6";
            btn_6.UseVisualStyleBackColor = false;
            btn_6.Click += boutton_CLick;
            // 
            // btn_1
            // 
            btn_1.BackColor = Color.FromArgb(28, 28, 28);
            btn_1.FlatAppearance.BorderSize = 0;
            btn_1.FlatAppearance.MouseOverBackColor = SystemColors.AppWorkspace;
            btn_1.FlatStyle = FlatStyle.Flat;
            btn_1.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_1.ForeColor = Color.FromArgb(160, 83, 16);
            btn_1.Location = new Point(0, 317);
            btn_1.Name = "btn_1";
            btn_1.Size = new Size(60, 35);
            btn_1.TabIndex = 25;
            btn_1.Text = "1";
            btn_1.UseVisualStyleBackColor = false;
            btn_1.Click += boutton_CLick;
            // 
            // btn_soustraction
            // 
            btn_soustraction.BackColor = Color.FromArgb(10, 8, 13);
            btn_soustraction.FlatAppearance.BorderSize = 0;
            btn_soustraction.FlatAppearance.MouseOverBackColor = SystemColors.AppWorkspace;
            btn_soustraction.FlatStyle = FlatStyle.Flat;
            btn_soustraction.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_soustraction.ForeColor = Color.FromArgb(160, 83, 16);
            btn_soustraction.Location = new Point(183, 317);
            btn_soustraction.Name = "btn_soustraction";
            btn_soustraction.Size = new Size(60, 35);
            btn_soustraction.TabIndex = 28;
            btn_soustraction.Text = "-";
            btn_soustraction.UseVisualStyleBackColor = false;
            btn_soustraction.Click += boutton_CLick;
            // 
            // btn_0
            // 
            btn_0.BackColor = Color.FromArgb(28, 28, 28);
            btn_0.FlatAppearance.BorderSize = 0;
            btn_0.FlatAppearance.MouseOverBackColor = SystemColors.AppWorkspace;
            btn_0.FlatStyle = FlatStyle.Flat;
            btn_0.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_0.ForeColor = Color.FromArgb(160, 83, 16);
            btn_0.Location = new Point(61, 353);
            btn_0.Name = "btn_0";
            btn_0.Size = new Size(60, 35);
            btn_0.TabIndex = 30;
            btn_0.Text = "0";
            btn_0.UseVisualStyleBackColor = false;
            btn_0.Click += boutton_CLick;
            // 
            // btn_3
            // 
            btn_3.BackColor = Color.FromArgb(28, 28, 28);
            btn_3.FlatAppearance.BorderSize = 0;
            btn_3.FlatAppearance.MouseOverBackColor = SystemColors.AppWorkspace;
            btn_3.FlatStyle = FlatStyle.Flat;
            btn_3.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_3.ForeColor = Color.FromArgb(160, 83, 16);
            btn_3.Location = new Point(122, 317);
            btn_3.Name = "btn_3";
            btn_3.Size = new Size(60, 35);
            btn_3.TabIndex = 27;
            btn_3.Text = "3";
            btn_3.UseVisualStyleBackColor = false;
            btn_3.Click += boutton_CLick;
            // 
            // btn_point
            // 
            btn_point.BackColor = Color.FromArgb(28, 28, 28);
            btn_point.FlatAppearance.BorderSize = 0;
            btn_point.FlatAppearance.MouseOverBackColor = SystemColors.AppWorkspace;
            btn_point.FlatStyle = FlatStyle.Flat;
            btn_point.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_point.ForeColor = Color.FromArgb(160, 83, 16);
            btn_point.Location = new Point(0, 353);
            btn_point.Name = "btn_point";
            btn_point.Size = new Size(60, 35);
            btn_point.TabIndex = 29;
            btn_point.Text = ".";
            btn_point.UseVisualStyleBackColor = false;
            btn_point.Click += boutton_CLick;
            // 
            // bnt_division
            // 
            bnt_division.BackColor = Color.FromArgb(10, 8, 13);
            bnt_division.FlatAppearance.BorderSize = 0;
            bnt_division.FlatAppearance.MouseOverBackColor = SystemColors.AppWorkspace;
            bnt_division.FlatStyle = FlatStyle.Flat;
            bnt_division.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            bnt_division.ForeColor = Color.FromArgb(160, 83, 16);
            bnt_division.Location = new Point(183, 245);
            bnt_division.Name = "bnt_division";
            bnt_division.Size = new Size(60, 35);
            bnt_division.TabIndex = 20;
            bnt_division.Text = "/";
            bnt_division.UseVisualStyleBackColor = false;
            bnt_division.Click += boutton_CLick;
            // 
            // btn_5
            // 
            btn_5.BackColor = Color.FromArgb(28, 28, 28);
            btn_5.FlatAppearance.BorderSize = 0;
            btn_5.FlatAppearance.MouseOverBackColor = SystemColors.AppWorkspace;
            btn_5.FlatStyle = FlatStyle.Flat;
            btn_5.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_5.ForeColor = Color.FromArgb(160, 83, 16);
            btn_5.Location = new Point(61, 281);
            btn_5.Name = "btn_5";
            btn_5.Size = new Size(60, 35);
            btn_5.TabIndex = 22;
            btn_5.Text = "5";
            btn_5.UseVisualStyleBackColor = false;
            btn_5.Click += boutton_CLick;
            // 
            // btn_9
            // 
            btn_9.BackColor = Color.FromArgb(28, 28, 28);
            btn_9.FlatAppearance.BorderSize = 0;
            btn_9.FlatAppearance.MouseOverBackColor = SystemColors.AppWorkspace;
            btn_9.FlatStyle = FlatStyle.Flat;
            btn_9.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_9.ForeColor = Color.FromArgb(160, 83, 16);
            btn_9.Location = new Point(122, 245);
            btn_9.Name = "btn_9";
            btn_9.Size = new Size(60, 35);
            btn_9.TabIndex = 19;
            btn_9.Text = "9";
            btn_9.UseVisualStyleBackColor = false;
            btn_9.Click += boutton_CLick;
            // 
            // btn_4
            // 
            btn_4.BackColor = Color.FromArgb(28, 28, 28);
            btn_4.FlatAppearance.BorderSize = 0;
            btn_4.FlatAppearance.MouseOverBackColor = SystemColors.AppWorkspace;
            btn_4.FlatStyle = FlatStyle.Flat;
            btn_4.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_4.ForeColor = Color.FromArgb(160, 83, 16);
            btn_4.Location = new Point(0, 281);
            btn_4.Name = "btn_4";
            btn_4.Size = new Size(60, 35);
            btn_4.TabIndex = 21;
            btn_4.Text = "4";
            btn_4.UseVisualStyleBackColor = false;
            btn_4.Click += boutton_CLick;
            // 
            // btn_ac
            // 
            btn_ac.BackColor = Color.FromArgb(10, 8, 13);
            btn_ac.FlatAppearance.BorderSize = 0;
            btn_ac.FlatAppearance.MouseOverBackColor = SystemColors.AppWorkspace;
            btn_ac.FlatStyle = FlatStyle.Flat;
            btn_ac.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_ac.ForeColor = Color.FromArgb(160, 83, 16);
            btn_ac.Location = new Point(122, 209);
            btn_ac.Name = "btn_ac";
            btn_ac.Size = new Size(60, 35);
            btn_ac.TabIndex = 15;
            btn_ac.Text = "AC";
            btn_ac.UseVisualStyleBackColor = false;
            btn_ac.Click += boutton_CLick;
            // 
            // btn_egal
            // 
            btn_egal.BackColor = Color.FromArgb(219, 110, 7);
            btn_egal.FlatAppearance.BorderSize = 0;
            btn_egal.FlatAppearance.MouseOverBackColor = SystemColors.AppWorkspace;
            btn_egal.FlatStyle = FlatStyle.Flat;
            btn_egal.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_egal.ForeColor = Color.White;
            btn_egal.Location = new Point(-10, 389);
            btn_egal.Name = "btn_egal";
            btn_egal.Size = new Size(192, 35);
            btn_egal.TabIndex = 33;
            btn_egal.Text = "=";
            btn_egal.UseVisualStyleBackColor = false;
            btn_egal.Click += boutton_CLick;
            // 
            // btn_close
            // 
            btn_close.BackColor = Color.FromArgb(10, 8, 13);
            btn_close.FlatAppearance.BorderSize = 0;
            btn_close.FlatAppearance.MouseOverBackColor = SystemColors.AppWorkspace;
            btn_close.FlatStyle = FlatStyle.Flat;
            btn_close.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_close.ForeColor = Color.FromArgb(160, 83, 16);
            btn_close.Location = new Point(183, 389);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(60, 35);
            btn_close.TabIndex = 34;
            btn_close.Text = "close";
            btn_close.UseVisualStyleBackColor = false;
            btn_close.Click += boutton_CLick;
            // 
            // btn_paranthese_ouvrante
            // 
            btn_paranthese_ouvrante.BackColor = Color.FromArgb(28, 28, 28);
            btn_paranthese_ouvrante.FlatAppearance.BorderSize = 0;
            btn_paranthese_ouvrante.FlatAppearance.MouseOverBackColor = SystemColors.AppWorkspace;
            btn_paranthese_ouvrante.FlatStyle = FlatStyle.Flat;
            btn_paranthese_ouvrante.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_paranthese_ouvrante.ForeColor = Color.FromArgb(160, 83, 16);
            btn_paranthese_ouvrante.Location = new Point(0, 209);
            btn_paranthese_ouvrante.Name = "btn_paranthese_ouvrante";
            btn_paranthese_ouvrante.Size = new Size(60, 35);
            btn_paranthese_ouvrante.TabIndex = 13;
            btn_paranthese_ouvrante.Text = "(";
            btn_paranthese_ouvrante.UseVisualStyleBackColor = false;
            btn_paranthese_ouvrante.Click += boutton_CLick;
            // 
            // btn_paranthese_fermante
            // 
            btn_paranthese_fermante.BackColor = Color.FromArgb(28, 28, 28);
            btn_paranthese_fermante.FlatAppearance.BorderSize = 0;
            btn_paranthese_fermante.FlatAppearance.MouseOverBackColor = SystemColors.AppWorkspace;
            btn_paranthese_fermante.FlatStyle = FlatStyle.Flat;
            btn_paranthese_fermante.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_paranthese_fermante.ForeColor = Color.FromArgb(160, 83, 16);
            btn_paranthese_fermante.Location = new Point(61, 209);
            btn_paranthese_fermante.Name = "btn_paranthese_fermante";
            btn_paranthese_fermante.Size = new Size(60, 35);
            btn_paranthese_fermante.TabIndex = 14;
            btn_paranthese_fermante.Text = ")";
            btn_paranthese_fermante.UseVisualStyleBackColor = false;
            btn_paranthese_fermante.Click += boutton_CLick;
            // 
            // screenResultat
            // 
            screenResultat.BackColor = Color.FromArgb(44, 44, 44);
            screenResultat.BorderStyle = BorderStyle.None;
            screenResultat.Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point);
            screenResultat.ForeColor = SystemColors.Info;
            screenResultat.Location = new Point(0, 34);
            screenResultat.Multiline = true;
            screenResultat.Name = "screenResultat";
            screenResultat.ReadOnly = true;
            screenResultat.ScrollBars = ScrollBars.Horizontal;
            screenResultat.Size = new Size(243, 66);
            screenResultat.TabIndex = 35;
            screenResultat.TextAlign = HorizontalAlignment.Right;
            // 
            // btn_del
            // 
            btn_del.BackColor = Color.FromArgb(10, 8, 13);
            btn_del.FlatAppearance.BorderSize = 0;
            btn_del.FlatAppearance.MouseOverBackColor = SystemColors.AppWorkspace;
            btn_del.FlatStyle = FlatStyle.Flat;
            btn_del.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_del.ForeColor = Color.FromArgb(160, 83, 16);
            btn_del.Location = new Point(183, 209);
            btn_del.Name = "btn_del";
            btn_del.Size = new Size(60, 35);
            btn_del.TabIndex = 16;
            btn_del.Text = "DEL";
            btn_del.UseVisualStyleBackColor = false;
            btn_del.Click += boutton_CLick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(243, 425);
            ControlBox = false;
            Controls.Add(btn_del);
            Controls.Add(screenResultat);
            Controls.Add(btn_paranthese_fermante);
            Controls.Add(btn_paranthese_ouvrante);
            Controls.Add(btn_close);
            Controls.Add(btn_egal);
            Controls.Add(btn_ac);
            Controls.Add(bnt_division);
            Controls.Add(btn_5);
            Controls.Add(btn_9);
            Controls.Add(btn_4);
            Controls.Add(btn_soustraction);
            Controls.Add(btn_0);
            Controls.Add(btn_3);
            Controls.Add(btn_point);
            Controls.Add(btn_multiplication);
            Controls.Add(btn_2);
            Controls.Add(btn_6);
            Controls.Add(btn_1);
            Controls.Add(btn_exponentiel);
            Controls.Add(btn_8);
            Controls.Add(btn_addition);
            Controls.Add(btn_7);
            Controls.Add(btn_pi);
            Controls.Add(btn_pow_x_y);
            Controls.Add(button11);
            Controls.Add(btn_factoriel);
            Controls.Add(btn_rad);
            Controls.Add(btn_ln);
            Controls.Add(btn_deg);
            Controls.Add(btn_log);
            Controls.Add(btn_sqrt);
            Controls.Add(btn_cos);
            Controls.Add(btn_sin);
            Controls.Add(btn_tan);
            Controls.Add(screenCalculator);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox screenCalculator;
        private Button btn_tan;
        private Button btn_sin;
        private Button btn_cos;
        private Button btn_sqrt;
        private Button btn_rad;
        private Button btn_ln;
        private Button btn_deg;
        private Button btn_log;
        private Button btn_pi;
        private Button btn_pow_x_y;
        private Button button11;
        private Button btn_factoriel;
        private Button btn_exponentiel;
        private Button btn_8;
        private Button btn_addition;
        private Button btn_7;
        private Button btn_multiplication;
        private Button btn_2;
        private Button btn_6;
        private Button btn_1;
        private Button btn_soustraction;
        private Button btn_0;
        private Button btn_3;
        private Button btn_point;
        private Button bnt_division;
        private Button btn_5;
        private Button btn_9;
        private Button btn_4;
        private Button btn_ac;
        private Button btn_egal;
        private Button btn_close;
        private Button btn_paranthese_ouvrante;
        private Button btn_paranthese_fermante;
        private TextBox screenResultat;
        private Button btn_del;
    }
}
