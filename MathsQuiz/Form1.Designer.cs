
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace MathsQuiz
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.labelQuestion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MathsQuiz.Properties.Resources.Q5;
            this.pictureBox1.Location = new System.Drawing.Point(1, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(638, 239);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(27, 371);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(236, 65);
            this.button5.TabIndex = 1;
            this.button5.Tag = "1";
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(27, 450);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(236, 65);
            this.button6.TabIndex = 2;
            this.button6.Tag = "3";
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(369, 371);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(261, 65);
            this.button7.TabIndex = 3;
            this.button7.Tag = "2";
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(369, 450);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(261, 65);
            this.button8.TabIndex = 4;
            this.button8.Tag = "4";
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // labelQuestion
            // 
            this.labelQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuestion.Location = new System.Drawing.Point(1, 267);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(638, 70);
            this.labelQuestion.TabIndex = 5;
            this.labelQuestion.Text = "Question";
            this.labelQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(641, 527);
            this.Controls.Add(this.labelQuestion);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label labelQuestion;

        public Form1(IContainer components, PictureBox pictureBox1, Button button5, Button button6, Button button7, Button button8, Label labelQuestion, EventHandler checkAnswerEvent, EventHandler labelQuestion_Click, int correctAnswer, int questionNumber, int score, int percentage, int totalQuestions)
        {
            this.components = components;
            this.pictureBox1 = pictureBox1;
            this.button5 = button5;
            this.button6 = button6;
            this.button7 = button7;
            this.button8 = button8;
            this.labelQuestion = labelQuestion;
            CheckAnswerEvent = checkAnswerEvent;
            this.labelQuestion_Click = labelQuestion_Click;
            this.correctAnswer = correctAnswer;
            this.questionNumber = questionNumber;
            this.score = score;
            this.percentage = percentage;
            this.totalQuestions = totalQuestions;
        }

        public EventHandler CheckAnswerEvent { get; private set; }
        public EventHandler labelQuestion_Click { get; private set; }
    }
}

