﻿
namespace Lab8_3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series21 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series22 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series23 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series24 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series25 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.Val1Ed1 = new System.Windows.Forms.NumericUpDown();
            this.Val1Ed2 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.Val1Ed3 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.Val1Ed4 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.Val1Ed5 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.StartBtn = new System.Windows.Forms.Button();
            this.numEd = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.EmpVer1 = new System.Windows.Forms.Label();
            this.EmpVer2 = new System.Windows.Forms.Label();
            this.EmpVer3 = new System.Windows.Forms.Label();
            this.EmpVer4 = new System.Windows.Forms.Label();
            this.EmpVer5 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.vibSredLbl = new System.Windows.Forms.Label();
            this.lblb2 = new System.Windows.Forms.Label();
            this.DLbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.chiLbl = new System.Windows.Forms.Label();
            this.verGenBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Val1Ed1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Val1Ed2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Val1Ed3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Val1Ed4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Val1Ed5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEd)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea5.AxisX.Maximum = 7D;
            chartArea5.AxisX.Minimum = -1D;
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(393, 23);
            this.chart1.Name = "chart1";
            series21.ChartArea = "ChartArea1";
            series21.IsValueShownAsLabel = true;
            series21.Legend = "Legend1";
            series21.Name = "Вер1";
            series22.BorderWidth = 2;
            series22.ChartArea = "ChartArea1";
            series22.IsValueShownAsLabel = true;
            series22.Legend = "Legend1";
            series22.Name = "Вер2";
            series23.BorderWidth = 2;
            series23.ChartArea = "ChartArea1";
            series23.IsValueShownAsLabel = true;
            series23.Legend = "Legend1";
            series23.Name = "Вер3";
            series24.BorderWidth = 2;
            series24.ChartArea = "ChartArea1";
            series24.IsValueShownAsLabel = true;
            series24.Legend = "Legend1";
            series24.Name = "Вер4";
            series25.BorderWidth = 2;
            series25.ChartArea = "ChartArea1";
            series25.IsValueShownAsLabel = true;
            series25.Legend = "Legend1";
            series25.Name = "Вер5";
            this.chart1.Series.Add(series21);
            this.chart1.Series.Add(series22);
            this.chart1.Series.Add(series23);
            this.chart1.Series.Add(series24);
            this.chart1.Series.Add(series25);
            this.chart1.Size = new System.Drawing.Size(676, 487);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Вероятность 1";
            // 
            // Val1Ed1
            // 
            this.Val1Ed1.DecimalPlaces = 3;
            this.Val1Ed1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.Val1Ed1.Location = new System.Drawing.Point(152, 58);
            this.Val1Ed1.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Val1Ed1.Name = "Val1Ed1";
            this.Val1Ed1.Size = new System.Drawing.Size(120, 22);
            this.Val1Ed1.TabIndex = 2;
            this.Val1Ed1.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.Val1Ed1.ValueChanged += new System.EventHandler(this.Val1Ed4_ValueChanged);
            // 
            // Val1Ed2
            // 
            this.Val1Ed2.DecimalPlaces = 3;
            this.Val1Ed2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.Val1Ed2.Location = new System.Drawing.Point(152, 105);
            this.Val1Ed2.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Val1Ed2.Name = "Val1Ed2";
            this.Val1Ed2.Size = new System.Drawing.Size(120, 22);
            this.Val1Ed2.TabIndex = 4;
            this.Val1Ed2.Value = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            this.Val1Ed2.ValueChanged += new System.EventHandler(this.Val1Ed4_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Вероятность 2";
            // 
            // Val1Ed3
            // 
            this.Val1Ed3.DecimalPlaces = 3;
            this.Val1Ed3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.Val1Ed3.Location = new System.Drawing.Point(152, 159);
            this.Val1Ed3.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Val1Ed3.Name = "Val1Ed3";
            this.Val1Ed3.Size = new System.Drawing.Size(120, 22);
            this.Val1Ed3.TabIndex = 6;
            this.Val1Ed3.Value = new decimal(new int[] {
            15,
            0,
            0,
            131072});
            this.Val1Ed3.ValueChanged += new System.EventHandler(this.Val1Ed4_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Вероятность 3";
            // 
            // Val1Ed4
            // 
            this.Val1Ed4.DecimalPlaces = 3;
            this.Val1Ed4.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.Val1Ed4.Location = new System.Drawing.Point(152, 213);
            this.Val1Ed4.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Val1Ed4.Name = "Val1Ed4";
            this.Val1Ed4.Size = new System.Drawing.Size(120, 22);
            this.Val1Ed4.TabIndex = 8;
            this.Val1Ed4.Value = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.Val1Ed4.ValueChanged += new System.EventHandler(this.Val1Ed4_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Вероятность 4";
            // 
            // Val1Ed5
            // 
            this.Val1Ed5.DecimalPlaces = 3;
            this.Val1Ed5.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.Val1Ed5.Location = new System.Drawing.Point(152, 272);
            this.Val1Ed5.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Val1Ed5.Name = "Val1Ed5";
            this.Val1Ed5.ReadOnly = true;
            this.Val1Ed5.Size = new System.Drawing.Size(120, 22);
            this.Val1Ed5.TabIndex = 10;
            this.Val1Ed5.ValueChanged += new System.EventHandler(this.Val1Ed4_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Вероятность 5";
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(60, 501);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(166, 55);
            this.StartBtn.TabIndex = 11;
            this.StartBtn.Text = "Старт";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // numEd
            // 
            this.numEd.Location = new System.Drawing.Point(152, 364);
            this.numEd.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numEd.Name = "numEd";
            this.numEd.Size = new System.Drawing.Size(120, 22);
            this.numEd.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Испытаний:";
            // 
            // EmpVer1
            // 
            this.EmpVer1.AutoSize = true;
            this.EmpVer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmpVer1.Location = new System.Drawing.Point(278, 60);
            this.EmpVer1.Name = "EmpVer1";
            this.EmpVer1.Size = new System.Drawing.Size(0, 20);
            this.EmpVer1.TabIndex = 14;
            // 
            // EmpVer2
            // 
            this.EmpVer2.AutoSize = true;
            this.EmpVer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmpVer2.Location = new System.Drawing.Point(278, 107);
            this.EmpVer2.Name = "EmpVer2";
            this.EmpVer2.Size = new System.Drawing.Size(0, 20);
            this.EmpVer2.TabIndex = 15;
            // 
            // EmpVer3
            // 
            this.EmpVer3.AutoSize = true;
            this.EmpVer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmpVer3.Location = new System.Drawing.Point(278, 159);
            this.EmpVer3.Name = "EmpVer3";
            this.EmpVer3.Size = new System.Drawing.Size(0, 20);
            this.EmpVer3.TabIndex = 16;
            // 
            // EmpVer4
            // 
            this.EmpVer4.AutoSize = true;
            this.EmpVer4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmpVer4.Location = new System.Drawing.Point(278, 212);
            this.EmpVer4.Name = "EmpVer4";
            this.EmpVer4.Size = new System.Drawing.Size(0, 20);
            this.EmpVer4.TabIndex = 17;
            // 
            // EmpVer5
            // 
            this.EmpVer5.AutoSize = true;
            this.EmpVer5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmpVer5.Location = new System.Drawing.Point(278, 271);
            this.EmpVer5.Name = "EmpVer5";
            this.EmpVer5.Size = new System.Drawing.Size(0, 20);
            this.EmpVer5.TabIndex = 18;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl1.Location = new System.Drawing.Point(12, 591);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(194, 20);
            this.lbl1.TabIndex = 19;
            this.lbl1.Text = "Выборочное среднее:";
            // 
            // vibSredLbl
            // 
            this.vibSredLbl.AutoSize = true;
            this.vibSredLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vibSredLbl.Location = new System.Drawing.Point(226, 591);
            this.vibSredLbl.Name = "vibSredLbl";
            this.vibSredLbl.Size = new System.Drawing.Size(0, 20);
            this.vibSredLbl.TabIndex = 20;
            // 
            // lblb2
            // 
            this.lblb2.AutoSize = true;
            this.lblb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblb2.Location = new System.Drawing.Point(389, 591);
            this.lblb2.Name = "lblb2";
            this.lblb2.Size = new System.Drawing.Size(105, 20);
            this.lblb2.TabIndex = 21;
            this.lblb2.Text = "Дисперсия:";
            // 
            // DLbl
            // 
            this.DLbl.AutoSize = true;
            this.DLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DLbl.Location = new System.Drawing.Point(500, 591);
            this.DLbl.Name = "DLbl";
            this.DLbl.Size = new System.Drawing.Size(0, 20);
            this.DLbl.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(673, 591);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 20);
            this.label9.TabIndex = 30;
            this.label9.Text = "Кси-квадрат:";
            // 
            // chiLbl
            // 
            this.chiLbl.AutoSize = true;
            this.chiLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chiLbl.Location = new System.Drawing.Point(800, 591);
            this.chiLbl.Name = "chiLbl";
            this.chiLbl.Size = new System.Drawing.Size(0, 20);
            this.chiLbl.TabIndex = 31;
            // 
            // verGenBtn
            // 
            this.verGenBtn.Location = new System.Drawing.Point(60, 420);
            this.verGenBtn.Name = "verGenBtn";
            this.verGenBtn.Size = new System.Drawing.Size(166, 55);
            this.verGenBtn.TabIndex = 32;
            this.verGenBtn.Text = "Генерация вероятностей";
            this.verGenBtn.UseVisualStyleBackColor = true;
            this.verGenBtn.Click += new System.EventHandler(this.verGenBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 655);
            this.Controls.Add(this.verGenBtn);
            this.Controls.Add(this.chiLbl);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DLbl);
            this.Controls.Add(this.lblb2);
            this.Controls.Add(this.vibSredLbl);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.EmpVer5);
            this.Controls.Add(this.EmpVer4);
            this.Controls.Add(this.EmpVer3);
            this.Controls.Add(this.EmpVer2);
            this.Controls.Add(this.EmpVer1);
            this.Controls.Add(this.numEd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.Val1Ed5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Val1Ed4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Val1Ed3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Val1Ed2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Val1Ed1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Val1Ed1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Val1Ed2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Val1Ed3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Val1Ed4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Val1Ed5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Val1Ed1;
        private System.Windows.Forms.NumericUpDown Val1Ed2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Val1Ed3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown Val1Ed4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown Val1Ed5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.NumericUpDown numEd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label EmpVer1;
        private System.Windows.Forms.Label EmpVer2;
        private System.Windows.Forms.Label EmpVer3;
        private System.Windows.Forms.Label EmpVer4;
        private System.Windows.Forms.Label EmpVer5;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label vibSredLbl;
        private System.Windows.Forms.Label lblb2;
        private System.Windows.Forms.Label DLbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label chiLbl;
        private System.Windows.Forms.Button verGenBtn;
    }
}

