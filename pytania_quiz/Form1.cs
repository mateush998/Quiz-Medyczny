using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pytania_quiz
{
    public partial class Form1 : Form
    {

        Pytania pytajnik = new Pytania();
        int numQuestion = 1;
        int ansGiven = 0;
        //int ansGiven2 = 0;
        //int ansGiven3 = 0;
        //int ansGiven4 = 0;

        int countAns = 1;
        int scorenAns = 0;

        int sumPoints = 0;

        bool automaticCheck = false;
        bool showAnswers = false;

        

        public Form1()
        {
            InitializeComponent();
            //pytajnik.GiveMeQuestion(numQuestion);
            //bLine.Text = pytajnik.textAnswer1;
            //bRandom.Text = pytajnik.textAnswer2;
            //bOption.Text = pytajnik.textAnswer3;
            //bAuthor.Text = pytajnik.textAnswer4;

            pytajnik.GiveMeQuestion(numQuestion);
            textQuestion.Text = pytajnik.textQuestion;
            bAnswerA.Text = pytajnik.textAnswer1;
            bAnswerB.Text = pytajnik.textAnswer2;
            bAnswerC.Text = pytajnik.textAnswer3;
            bAnswerD.Text = pytajnik.textAnswer4;

            gbOptions.Visible = false;
            gbOpt2.Visible = false;
            bgOpt1.Visible = false;
            bApply.Visible = false;
            bBack.Visible = false;

            gbTestLine.Visible = false;
            gbAnswerLine.Visible = false;
            gbQuestionLIne.Visible = false;

            bNextQuestion.Enabled = false;

            labelCounter.Visible = false;

            labelCounter.Text = countAns.ToString() + "/70";

            //labelResult.Visible = false;
            //scoreInformer.Visible = false;
            //Info.Visible = false;

            gbScore.Visible = false;

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bLine_Click(object sender, EventArgs e)
        {
            gbTestLine.Visible = true;
            gbAnswerLine.Visible = true;
            gbQuestionLIne.Visible = true;

            labelCounter.Visible = true;

            pytajnik.GiveMeQuestion(numQuestion);
            textQuestion.Text = pytajnik.textQuestion;
            bAnswerA.Text = pytajnik.textAnswer1;
            bAnswerB.Text = pytajnik.textAnswer2;
            bAnswerC.Text = pytajnik.textAnswer3;
            bAnswerD.Text = pytajnik.textAnswer4;
        }

        private void bRandom_Click(object sender, EventArgs e)
        {

        }

        private void bOption_Click(object sender, EventArgs e)
        {
            gbOptions.Visible = true;
            gbOpt2.Visible = true;
            bgOpt1.Visible = true;
            bApply.Visible = true;
            bBack.Visible = true;

            groupBox1.Visible = true;
        }

        private void bAuthor_Click(object sender, EventArgs e)
        {           
            //numQuestion++;
            
            //pytajnik.GiveMeQuestion(numQuestion);
            //bLine.Text = pytajnik.textAnswer1;
            //bRandom.Text = pytajnik.textAnswer2;
            //bOption.Text = pytajnik.textAnswer3;
            //bAuthor.Text = pytajnik.textAnswer4;

            MessageBox.Show("Autorem tego wątpliwego dzieła jest Mateusz Podsiadło. Miłej zabawy!");
            
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            gbOptions.Visible = false;
            gbOpt2.Visible = false;
            bgOpt1.Visible = false;
            bApply.Visible = false;
            bBack.Visible = false;

            groupBox1.Visible = true;
        }

        private void bApply_Click(object sender, EventArgs e)
        {
            if(sMarine.Checked == true)
            {
                groupBox1.BackColor = Color.SeaGreen;
                gbOptions.BackColor = Color.SeaGreen;
                gbOpt2.BackColor = Color.Aqua;
                bgOpt1.BackColor = Color.Aqua;
                gbTestLine.BackColor = Color.SeaGreen;
                gbQuestionLIne.BackColor = Color.Aqua;
                gbAnswerLine.BackColor = Color.Aqua;
            }

            if(sSalmon.Checked == true)
            {
                groupBox1.BackColor = Color.DarkSalmon;
                gbOptions.BackColor = Color.DarkSalmon;                
                gbOpt2.BackColor = Color.PaleGoldenrod;
                bgOpt1.BackColor = Color.PaleGoldenrod;
                gbTestLine.BackColor = Color.DarkSalmon;
                gbQuestionLIne.BackColor = Color.PaleGoldenrod;
                gbAnswerLine.BackColor = Color.PaleGoldenrod;
            }

            if(sShit.Checked == true)
            {
                groupBox1.BackColor = Color.SaddleBrown;
                gbOptions.BackColor = Color.SaddleBrown;
                gbOpt2.BackColor = Color.BurlyWood;
                bgOpt1.BackColor = Color.BurlyWood;
                gbTestLine.BackColor = Color.SaddleBrown;
                gbQuestionLIne.BackColor = Color.BurlyWood;
                gbAnswerLine.BackColor = Color.BurlyWood;
            }

            if(sPhone.Checked == true)
            {
                groupBox1.BackColor = Color.LightSlateGray;
                gbOptions.BackColor = Color.LightSlateGray;
                gbOpt2.BackColor = Color.DimGray;
                bgOpt1.BackColor = Color.DimGray;
                gbTestLine.BackColor = Color.LightSlateGray;
                gbQuestionLIne.BackColor = Color.DimGray;
                labelQuestion.ForeColor = Color.Wheat;
                gbAnswerLine.BackColor = Color.DimGray;

            }

            if(sPaper.Checked == true)
            {
                groupBox1.BackColor = default(Color);
                gbOptions.BackColor = default(Color);
                gbOpt2.BackColor = default(Color);
                bgOpt1.BackColor = default(Color);
                gbTestLine.BackColor = default(Color);
                gbQuestionLIne.BackColor = default(Color);
                gbAnswerLine.BackColor = default(Color);
            }

            if(autoCheck.Checked == true)
            {
                automaticCheck = true;
            }
            else
            {
                automaticCheck = false;
            }

            if(showGoodAnswers.Checked == true)
            {
                 showAnswers = true;
            }
            else
            {
                showAnswers = false;
            }

        }

        private void bNextQuestion_Click(object sender, EventArgs e)
        {
            numQuestion++;

            if (ansGiven == pytajnik.numAnswer)
            {
                scorenAns++;
            }

            countAns++;

            ansGiven = 0;

            bNextQuestion.Enabled = false;

            pytajnik.GiveMeQuestion(numQuestion);
            
            textQuestion.Text = pytajnik.textQuestion;
            bAnswerA.Text = pytajnik.textAnswer1;
            bAnswerB.Text = pytajnik.textAnswer2;
            bAnswerC.Text = pytajnik.textAnswer3;
            bAnswerD.Text = pytajnik.textAnswer4;

            labelCounter.Text = countAns.ToString() + "/70";

            if(countAns == 13)
            {

                gbScore.Visible = true;

                gbTestLine.Visible = false;

                labelCounter.Visible = false;

                
               

                scoreInformer.Text = "Poprawnie odpowiedziałeś na " + scorenAns.ToString() + " pytań!";

                if(scorenAns > 0)
                {
                    sumPoints = (scorenAns * 100) / 70;
                }
                else
                {
                    sumPoints = 0;
                }


                if (scorenAns < 5)
                {
                    labelResult.ForeColor = Color.Red;
                    labelResult.Text = "Niestety nie zdałeś. Uzyskałeś zbyt małą liczbę punktów (zaliczenie od 60). Twój wynik to " + sumPoints.ToString() + "% z ogółu 70 pytań";
                }

                if(scorenAns > 10)
                {
                    labelResult.ForeColor = Color.Green;
                    labelResult.Text = "Gratulację! Uzyskałeś odpwiednią liczbę punktów (zaliczenie od 60). Twój wynik to " + sumPoints.ToString() + "% z ogółu 70 pytań";
                }

                if(scorenAns == 12)
                {
                    labelResult.ForeColor = Color.Blue;
                    labelResult.Text = "NIESAMOWITE! JESTEŚ GENIUSZEM! Odpowiedziałeś poprawnie na wszystkie pytania! Uzyskałeś 100% wyniku.";
                }

                

            }

            
        }

        //int checkIfWorking = 0;

        private void bAnswerA_Click(object sender, EventArgs e)
        {
            ansGiven = 1;
            labelCorrectAnswer.Text = "Wybrano odpwiedź: " + ansGiven.ToString();
            
            if(ansGiven == pytajnik.numAnswer)
            {
                labelInformer.Text = "Wybrano prawidłową odpowiedź";
            }
            else
            {
                labelInformer.Text = "Wybrano błędną odpowiedź";
            }

            bNextQuestion.Enabled = true;
        }

        private void bAnswerC_Click(object sender, EventArgs e)
        {
            ansGiven = 3;
            labelCorrectAnswer.Text = "Wybrano odpwiedź: " + ansGiven.ToString();

            if (ansGiven == pytajnik.numAnswer)
            {
                labelInformer.Text = "Wybrano prawidłową odpowiedź";
            }
            else
            {
                labelInformer.Text = "Wybrano błędną odpowiedź";
            }

            bNextQuestion.Enabled = true;
        }

        private void bAnswerB_Click(object sender, EventArgs e)
        {
            ansGiven = 2;
            labelCorrectAnswer.Text = "Wybrano odpwiedź: " + ansGiven.ToString();

            if (ansGiven == pytajnik.numAnswer)
            {
                labelInformer.Text = "Wybrano prawidłową odpowiedź";
            }
            else
            {
                labelInformer.Text = "Wybrano błędną odpowiedź";
            }

            bNextQuestion.Enabled = true;
        }

        private void bAnswerD_Click(object sender, EventArgs e)
        {
            ansGiven = 4;
            labelCorrectAnswer.Text = "Wybrano odpwiedź: " + ansGiven.ToString();

            if (ansGiven == pytajnik.numAnswer)
            {
                labelInformer.Text = "Wybrano prawidłową odpowiedź";
            }
            else
            {
                labelInformer.Text = "Wybrano błędną odpowiedź";
            }

            bNextQuestion.Enabled = true;
        }

        private void labelQuestion_Click(object sender, EventArgs e)
        {

        }
    }
}
