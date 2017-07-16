namespace pytania_quiz
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.bBack = new System.Windows.Forms.Button();
            this.bApply = new System.Windows.Forms.Button();
            this.gbOpt2 = new System.Windows.Forms.GroupBox();
            this.showGoodAnswers = new System.Windows.Forms.CheckBox();
            this.autoCheck = new System.Windows.Forms.CheckBox();
            this.bgOpt1 = new System.Windows.Forms.GroupBox();
            this.sPhone = new System.Windows.Forms.RadioButton();
            this.sPaper = new System.Windows.Forms.RadioButton();
            this.sShit = new System.Windows.Forms.RadioButton();
            this.sSalmon = new System.Windows.Forms.RadioButton();
            this.sMarine = new System.Windows.Forms.RadioButton();
            this.bAuthor = new System.Windows.Forms.Button();
            this.bOption = new System.Windows.Forms.Button();
            this.bRandom = new System.Windows.Forms.Button();
            this.bLine = new System.Windows.Forms.Button();
            this.testTitle = new System.Windows.Forms.Label();
            this.gbTestLine = new System.Windows.Forms.GroupBox();
            this.gbScore = new System.Windows.Forms.GroupBox();
            this.Info = new System.Windows.Forms.Label();
            this.counterTable = new System.Windows.Forms.TableLayoutPanel();
            this.scoreInformer = new System.Windows.Forms.Label();
            this.resultTable = new System.Windows.Forms.TableLayoutPanel();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelCorrectAnswer = new System.Windows.Forms.Label();
            this.labelInformer = new System.Windows.Forms.Label();
            this.bNextQuestion = new System.Windows.Forms.Button();
            this.gbAnswerLine = new System.Windows.Forms.GroupBox();
            this.ansD = new System.Windows.Forms.Label();
            this.bAnswerD = new System.Windows.Forms.Button();
            this.bAnswerC = new System.Windows.Forms.Button();
            this.ansC = new System.Windows.Forms.Label();
            this.bAnswerB = new System.Windows.Forms.Button();
            this.ansB = new System.Windows.Forms.Label();
            this.ansA = new System.Windows.Forms.Label();
            this.bAnswerA = new System.Windows.Forms.Button();
            this.gbQuestionLIne = new System.Windows.Forms.GroupBox();
            this.textQuestion = new System.Windows.Forms.TextBox();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.labelCounter = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbOptions.SuspendLayout();
            this.gbOpt2.SuspendLayout();
            this.bgOpt1.SuspendLayout();
            this.gbTestLine.SuspendLayout();
            this.gbScore.SuspendLayout();
            this.counterTable.SuspendLayout();
            this.resultTable.SuspendLayout();
            this.gbAnswerLine.SuspendLayout();
            this.gbQuestionLIne.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gbOptions);
            this.groupBox1.Controls.Add(this.bAuthor);
            this.groupBox1.Controls.Add(this.bOption);
            this.groupBox1.Controls.Add(this.bRandom);
            this.groupBox1.Controls.Add(this.bLine);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // gbOptions
            // 
            this.gbOptions.Controls.Add(this.bBack);
            this.gbOptions.Controls.Add(this.bApply);
            this.gbOptions.Controls.Add(this.gbOpt2);
            this.gbOptions.Controls.Add(this.bgOpt1);
            resources.ApplyResources(this.gbOptions, "gbOptions");
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.TabStop = false;
            // 
            // bBack
            // 
            resources.ApplyResources(this.bBack, "bBack");
            this.bBack.Name = "bBack";
            this.bBack.UseVisualStyleBackColor = true;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // bApply
            // 
            resources.ApplyResources(this.bApply, "bApply");
            this.bApply.Name = "bApply";
            this.bApply.UseVisualStyleBackColor = true;
            this.bApply.Click += new System.EventHandler(this.bApply_Click);
            // 
            // gbOpt2
            // 
            this.gbOpt2.Controls.Add(this.showGoodAnswers);
            this.gbOpt2.Controls.Add(this.autoCheck);
            resources.ApplyResources(this.gbOpt2, "gbOpt2");
            this.gbOpt2.Name = "gbOpt2";
            this.gbOpt2.TabStop = false;
            // 
            // showGoodAnswers
            // 
            resources.ApplyResources(this.showGoodAnswers, "showGoodAnswers");
            this.showGoodAnswers.Name = "showGoodAnswers";
            this.showGoodAnswers.UseVisualStyleBackColor = true;
            // 
            // autoCheck
            // 
            resources.ApplyResources(this.autoCheck, "autoCheck");
            this.autoCheck.Name = "autoCheck";
            this.autoCheck.UseVisualStyleBackColor = true;
            // 
            // bgOpt1
            // 
            this.bgOpt1.Controls.Add(this.sPhone);
            this.bgOpt1.Controls.Add(this.sPaper);
            this.bgOpt1.Controls.Add(this.sShit);
            this.bgOpt1.Controls.Add(this.sSalmon);
            this.bgOpt1.Controls.Add(this.sMarine);
            resources.ApplyResources(this.bgOpt1, "bgOpt1");
            this.bgOpt1.Name = "bgOpt1";
            this.bgOpt1.TabStop = false;
            // 
            // sPhone
            // 
            resources.ApplyResources(this.sPhone, "sPhone");
            this.sPhone.Name = "sPhone";
            this.sPhone.TabStop = true;
            this.sPhone.UseVisualStyleBackColor = true;
            // 
            // sPaper
            // 
            resources.ApplyResources(this.sPaper, "sPaper");
            this.sPaper.Name = "sPaper";
            this.sPaper.TabStop = true;
            this.sPaper.UseVisualStyleBackColor = true;
            // 
            // sShit
            // 
            resources.ApplyResources(this.sShit, "sShit");
            this.sShit.Name = "sShit";
            this.sShit.TabStop = true;
            this.sShit.UseVisualStyleBackColor = true;
            // 
            // sSalmon
            // 
            resources.ApplyResources(this.sSalmon, "sSalmon");
            this.sSalmon.Name = "sSalmon";
            this.sSalmon.TabStop = true;
            this.sSalmon.UseVisualStyleBackColor = true;
            // 
            // sMarine
            // 
            resources.ApplyResources(this.sMarine, "sMarine");
            this.sMarine.Name = "sMarine";
            this.sMarine.TabStop = true;
            this.sMarine.UseVisualStyleBackColor = true;
            // 
            // bAuthor
            // 
            resources.ApplyResources(this.bAuthor, "bAuthor");
            this.bAuthor.Name = "bAuthor";
            this.bAuthor.UseVisualStyleBackColor = true;
            this.bAuthor.Click += new System.EventHandler(this.bAuthor_Click);
            // 
            // bOption
            // 
            resources.ApplyResources(this.bOption, "bOption");
            this.bOption.Name = "bOption";
            this.bOption.UseVisualStyleBackColor = true;
            this.bOption.Click += new System.EventHandler(this.bOption_Click);
            // 
            // bRandom
            // 
            resources.ApplyResources(this.bRandom, "bRandom");
            this.bRandom.Name = "bRandom";
            this.bRandom.UseVisualStyleBackColor = true;
            this.bRandom.Click += new System.EventHandler(this.bRandom_Click);
            // 
            // bLine
            // 
            resources.ApplyResources(this.bLine, "bLine");
            this.bLine.Name = "bLine";
            this.bLine.UseVisualStyleBackColor = true;
            this.bLine.Click += new System.EventHandler(this.bLine_Click);
            // 
            // testTitle
            // 
            resources.ApplyResources(this.testTitle, "testTitle");
            this.testTitle.Name = "testTitle";
            // 
            // gbTestLine
            // 
            this.gbTestLine.Controls.Add(this.labelCorrectAnswer);
            this.gbTestLine.Controls.Add(this.labelInformer);
            this.gbTestLine.Controls.Add(this.bNextQuestion);
            this.gbTestLine.Controls.Add(this.gbAnswerLine);
            this.gbTestLine.Controls.Add(this.gbQuestionLIne);
            resources.ApplyResources(this.gbTestLine, "gbTestLine");
            this.gbTestLine.Name = "gbTestLine";
            this.gbTestLine.TabStop = false;
            // 
            // gbScore
            // 
            this.gbScore.Controls.Add(this.Info);
            this.gbScore.Controls.Add(this.counterTable);
            this.gbScore.Controls.Add(this.resultTable);
            resources.ApplyResources(this.gbScore, "gbScore");
            this.gbScore.Name = "gbScore";
            this.gbScore.TabStop = false;
            // 
            // Info
            // 
            resources.ApplyResources(this.Info, "Info");
            this.Info.Name = "Info";
            // 
            // counterTable
            // 
            resources.ApplyResources(this.counterTable, "counterTable");
            this.counterTable.Controls.Add(this.scoreInformer, 0, 0);
            this.counterTable.Name = "counterTable";
            // 
            // scoreInformer
            // 
            resources.ApplyResources(this.scoreInformer, "scoreInformer");
            this.scoreInformer.Name = "scoreInformer";
            // 
            // resultTable
            // 
            resources.ApplyResources(this.resultTable, "resultTable");
            this.resultTable.Controls.Add(this.labelResult, 0, 0);
            this.resultTable.Name = "resultTable";
            // 
            // labelResult
            // 
            resources.ApplyResources(this.labelResult, "labelResult");
            this.labelResult.Name = "labelResult";
            // 
            // labelCorrectAnswer
            // 
            resources.ApplyResources(this.labelCorrectAnswer, "labelCorrectAnswer");
            this.labelCorrectAnswer.Name = "labelCorrectAnswer";
            // 
            // labelInformer
            // 
            resources.ApplyResources(this.labelInformer, "labelInformer");
            this.labelInformer.Name = "labelInformer";
            // 
            // bNextQuestion
            // 
            resources.ApplyResources(this.bNextQuestion, "bNextQuestion");
            this.bNextQuestion.Name = "bNextQuestion";
            this.bNextQuestion.UseVisualStyleBackColor = true;
            this.bNextQuestion.Click += new System.EventHandler(this.bNextQuestion_Click);
            // 
            // gbAnswerLine
            // 
            this.gbAnswerLine.Controls.Add(this.ansD);
            this.gbAnswerLine.Controls.Add(this.bAnswerD);
            this.gbAnswerLine.Controls.Add(this.bAnswerC);
            this.gbAnswerLine.Controls.Add(this.ansC);
            this.gbAnswerLine.Controls.Add(this.bAnswerB);
            this.gbAnswerLine.Controls.Add(this.ansB);
            this.gbAnswerLine.Controls.Add(this.ansA);
            this.gbAnswerLine.Controls.Add(this.bAnswerA);
            resources.ApplyResources(this.gbAnswerLine, "gbAnswerLine");
            this.gbAnswerLine.Name = "gbAnswerLine";
            this.gbAnswerLine.TabStop = false;
            // 
            // ansD
            // 
            resources.ApplyResources(this.ansD, "ansD");
            this.ansD.Name = "ansD";
            // 
            // bAnswerD
            // 
            resources.ApplyResources(this.bAnswerD, "bAnswerD");
            this.bAnswerD.Name = "bAnswerD";
            this.bAnswerD.UseVisualStyleBackColor = true;
            this.bAnswerD.Click += new System.EventHandler(this.bAnswerD_Click);
            // 
            // bAnswerC
            // 
            resources.ApplyResources(this.bAnswerC, "bAnswerC");
            this.bAnswerC.Name = "bAnswerC";
            this.bAnswerC.UseVisualStyleBackColor = true;
            this.bAnswerC.Click += new System.EventHandler(this.bAnswerC_Click);
            // 
            // ansC
            // 
            resources.ApplyResources(this.ansC, "ansC");
            this.ansC.Name = "ansC";
            // 
            // bAnswerB
            // 
            resources.ApplyResources(this.bAnswerB, "bAnswerB");
            this.bAnswerB.Name = "bAnswerB";
            this.bAnswerB.UseVisualStyleBackColor = true;
            this.bAnswerB.Click += new System.EventHandler(this.bAnswerB_Click);
            // 
            // ansB
            // 
            resources.ApplyResources(this.ansB, "ansB");
            this.ansB.Name = "ansB";
            // 
            // ansA
            // 
            resources.ApplyResources(this.ansA, "ansA");
            this.ansA.Name = "ansA";
            // 
            // bAnswerA
            // 
            resources.ApplyResources(this.bAnswerA, "bAnswerA");
            this.bAnswerA.Name = "bAnswerA";
            this.bAnswerA.UseVisualStyleBackColor = true;
            this.bAnswerA.Click += new System.EventHandler(this.bAnswerA_Click);
            // 
            // gbQuestionLIne
            // 
            this.gbQuestionLIne.Controls.Add(this.textQuestion);
            resources.ApplyResources(this.gbQuestionLIne, "gbQuestionLIne");
            this.gbQuestionLIne.Name = "gbQuestionLIne";
            this.gbQuestionLIne.TabStop = false;
            // 
            // textQuestion
            // 
            resources.ApplyResources(this.textQuestion, "textQuestion");
            this.textQuestion.Name = "textQuestion";
            this.textQuestion.ReadOnly = true;
            // 
            // labelQuestion
            // 
            resources.ApplyResources(this.labelQuestion, "labelQuestion");
            this.labelQuestion.ForeColor = System.Drawing.Color.Red;
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Click += new System.EventHandler(this.labelQuestion_Click);
            // 
            // labelCounter
            // 
            resources.ApplyResources(this.labelCounter, "labelCounter");
            this.labelCounter.Name = "labelCounter";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbScore);
            this.Controls.Add(this.labelQuestion);
            this.Controls.Add(this.labelCounter);
            this.Controls.Add(this.gbTestLine);
            this.Controls.Add(this.testTitle);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.gbOptions.ResumeLayout(false);
            this.gbOpt2.ResumeLayout(false);
            this.gbOpt2.PerformLayout();
            this.bgOpt1.ResumeLayout(false);
            this.bgOpt1.PerformLayout();
            this.gbTestLine.ResumeLayout(false);
            this.gbTestLine.PerformLayout();
            this.gbScore.ResumeLayout(false);
            this.gbScore.PerformLayout();
            this.counterTable.ResumeLayout(false);
            this.counterTable.PerformLayout();
            this.resultTable.ResumeLayout(false);
            this.resultTable.PerformLayout();
            this.gbAnswerLine.ResumeLayout(false);
            this.gbAnswerLine.PerformLayout();
            this.gbQuestionLIne.ResumeLayout(false);
            this.gbQuestionLIne.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bAuthor;
        private System.Windows.Forms.Button bOption;
        private System.Windows.Forms.Button bRandom;
        private System.Windows.Forms.Button bLine;
        private System.Windows.Forms.Label testTitle;
        private System.Windows.Forms.GroupBox gbOptions;
        private System.Windows.Forms.Button bBack;
        private System.Windows.Forms.Button bApply;
        private System.Windows.Forms.GroupBox gbOpt2;
        private System.Windows.Forms.CheckBox showGoodAnswers;
        private System.Windows.Forms.CheckBox autoCheck;
        private System.Windows.Forms.GroupBox bgOpt1;
        private System.Windows.Forms.RadioButton sPhone;
        private System.Windows.Forms.RadioButton sPaper;
        private System.Windows.Forms.RadioButton sShit;
        private System.Windows.Forms.RadioButton sSalmon;
        private System.Windows.Forms.RadioButton sMarine;
        private System.Windows.Forms.GroupBox gbTestLine;
        private System.Windows.Forms.Button bNextQuestion;
        private System.Windows.Forms.GroupBox gbAnswerLine;
        private System.Windows.Forms.Label ansD;
        private System.Windows.Forms.Button bAnswerD;
        private System.Windows.Forms.Button bAnswerC;
        private System.Windows.Forms.Label ansC;
        private System.Windows.Forms.Button bAnswerB;
        private System.Windows.Forms.Label ansB;
        private System.Windows.Forms.Label ansA;
        private System.Windows.Forms.Button bAnswerA;
        private System.Windows.Forms.GroupBox gbQuestionLIne;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.Label labelCorrectAnswer;
        private System.Windows.Forms.Label labelInformer;
        private System.Windows.Forms.Label labelCounter;
        private System.Windows.Forms.GroupBox gbScore;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label scoreInformer;
        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.TableLayoutPanel counterTable;
        private System.Windows.Forms.TableLayoutPanel resultTable;
        private System.Windows.Forms.TextBox textQuestion;


    }
}

