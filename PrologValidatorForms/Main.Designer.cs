﻿
namespace PrologValidatorForms
{
    /// <summary>
    /// Klasa inicjalizacyjna GUI
    /// </summary>
    /// <param name="folderBrowserDialog1">Przetrzymuje obiekt typu System.Windows.Forms.FolderBrowserDialog</param>
    /// <param name="cb1">Przetrzymuje obiekt typu PrologValidatorForms.Library.Eksplorator</param>
    /// <param name="cb2">Przetrzymuje obiekt typu PrologValidatorForms.Library.Eksplorator</param>
    /// <param name="btn_confirm">Przetrzymuje obiekt typu System.Windows.Forms.Button</param>
    /// <param name="labelInfo">Przetrzymuje obiekt typu System.Windows.Forms.Label</param>
    /// <param name="btn_export">Przetrzymuje obiekt typu System.Windows.Forms.Button</param>
    /// <param name="label1">Przetrzymuje obiekt typu System.Windows.Forms.Label</param>
    /// <param name="label2">Przetrzymuje obiekt typu System.Windows.Forms.Label</param>
    /// <param name="panel1">Przetrzymuje obiekt typu System.Windows.Forms.Panel</param>
    /// <param name="panel2">Przetrzymuje obiekt typu System.Windows.Forms.Panel</param>
    /// <param name="panel3">Przetrzymuje obiekt typu System.Windows.Forms.Panel</param>
    /// <param name="panel4">Przetrzymuje obiekt typu System.Windows.Forms.Panel</param>
    /// <param name="panel5">Przetrzymuje obiekt typu System.Windows.Forms.Panel</param>
    /// <param name="timer1">Przetrzymuje obiekt typu System.Windows.Forms.Timer</param>
    /// <param name="button1">Przetrzymuje obiekt typu System.Windows.Forms.Button</param>
    /// <param name="button2">Przetrzymuje obiekt typu System.Windows.Forms.Button</param>
    /// <param name="pictureBox1">Przetrzymuje obiekt typu System.Windows.Forms.PictureBox</param>
    /// <param name="toolTip1">Przetrzymuje obiekt typu System.Windows.Forms.ToolTip</param>
    /// <param name="informator1">Przetrzymuje obiekt typu System.Windows.Forms.PictureBox</param>
    partial class Main
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.btn_export = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.informator1 = new System.Windows.Forms.PictureBox();
            this.cb2 = new PrologValidatorForms.Library.Eksplorator();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cb1 = new PrologValidatorForms.Library.Eksplorator();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.informator1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_confirm
            // 
            this.btn_confirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btn_confirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_confirm.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_confirm.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_confirm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_confirm.Location = new System.Drawing.Point(623, 538);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(621, 35);
            this.btn_confirm.TabIndex = 8;
            this.btn_confirm.Text = "Zatwierdź";
            this.btn_confirm.UseVisualStyleBackColor = false;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(719, 560);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(0, 13);
            this.labelInfo.TabIndex = 9;
            // 
            // btn_export
            // 
            this.btn_export.Location = new System.Drawing.Point(54, 593);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(75, 23);
            this.btn_export.TabIndex = 10;
            this.btn_export.Text = "Zapisz";
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(202, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 33);
            this.label1.TabIndex = 11;
            this.label1.Text = "Załaduj projekt do analizy";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label2.Font = new System.Drawing.Font("Calibri Light", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(221, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 33);
            this.label2.TabIndex = 12;
            this.label2.Text = "Wybierz lokalizację zapisu";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btn_export);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 685);
            this.panel1.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PrologValidatorForms.Properties.Resources.Wisdom;
            this.pictureBox1.Location = new System.Drawing.Point(11, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.informator1);
            this.panel2.Controls.Add(this.cb2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(224, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(701, 445);
            this.panel2.TabIndex = 15;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint_1);
            // 
            // informator1
            // 
            this.informator1.BackColor = System.Drawing.Color.White;
            this.informator1.Image = ((System.Drawing.Image)(resources.GetObject("informator1.Image")));
            this.informator1.Location = new System.Drawing.Point(498, 21);
            this.informator1.Name = "informator1";
            this.informator1.Size = new System.Drawing.Size(25, 23);
            this.informator1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.informator1.TabIndex = 12;
            this.informator1.TabStop = false;
            this.informator1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.informator1_MouseClick);
            this.informator1.MouseHover += new System.EventHandler(this.informator1_MouseHover);
            // 
            // cb2
            // 
            this.cb2.BackColor = System.Drawing.Color.Transparent;
            this.cb2.Location = new System.Drawing.Point(19, 48);
            this.cb2.Margin = new System.Windows.Forms.Padding(1);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(663, 369);
            this.cb2.TabIndex = 7;
            this.cb2.Load += new System.EventHandler(this.cb2_Load);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.cb1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(931, 74);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(701, 445);
            this.panel3.TabIndex = 16;
            // 
            // cb1
            // 
            this.cb1.BackColor = System.Drawing.Color.Transparent;
            this.cb1.Location = new System.Drawing.Point(21, 48);
            this.cb1.Margin = new System.Windows.Forms.Padding(1);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(663, 369);
            this.cb1.TabIndex = 6;
            this.cb1.Load += new System.EventHandler(this.cb1_Load);
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(224, 593);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1408, 29);
            this.panel4.TabIndex = 17;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.ForestGreen;
            this.panel5.Location = new System.Drawing.Point(224, 593);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 29);
            this.panel5.TabIndex = 18;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(1597, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 34);
            this.button1.TabIndex = 19;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(1556, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 34);
            this.button2.TabIndex = 20;
            this.button2.Text = "__";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(132)))), ((int)(((byte)(156)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1679, 684);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1679, 684);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1679, 684);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prolog Validator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Main_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.informator1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        



        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private PrologValidatorForms.Library.Eksplorator cb1;
        private PrologValidatorForms.Library.Eksplorator cb2;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox informator1;
    }
}

