using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BingoApp
{
    public partial class Form1 : Form
    {

        bool b1 = false;
        bool b2 = false;
        bool b3 = false;
        bool b4 = false;
        bool b5 = false;

        bool i1 = false;
        bool i2 = false;
        bool i3 = false;
        bool i4 = false;
        bool i5 = false;

        bool n1 = false;
        bool n2 = false;
        bool n3 = false;
        bool n4 = false;
        bool n5 = false;

        bool g1 = false;
        bool g2 = false;
        bool g3 = false;
        bool g4 = false;
        bool g5 = false;

        bool o1 = false;
        bool o2 = false;
        bool o3 = false;
        bool o4 = false;
        bool o5 = false;

        bool winner = false;

        List<string> gusEddy = new List<string>();

        List<string> nlss = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        public bool checkBingo()
        {
            if(b1 && b2 && b3 && b4 && b5) 
            {
                return true;
            } else if (i1 && i2 && i3 && i4 && i5) 
            {
                return true;
            } else if (n1 && n2 && n3 && n4 && n5) 
            {
                return true;
            } else if (g1 && g2 && g3 && g4 && g5)
            {
                return true;
            } else if (o1 && o2 && o3 && o4 && o5)
            {
                return true;
            } else if (b1 && i1 && n1 && g1 && o1)
            {
                return true;
            } else if (b2 && i2 && n2 && g2 && o2)
            {
                return true;
            } else if (b3 && i3 && n3 && g3 && o3)
            {
                return true;
            } else if (b4 && i4 && n4 && g4 && o4)
            {
                return true;
            } else if (b5 && i5 && n5 && g5 && o5)
            {
                return true;
            } else if (b1 && i2 && n3 && g4 && o5)
            {
                return true;
            } else if (b5 && i4 && n3 && g2 && o1)
            {
                return true;
            } else
            {
                return false;
            }
        }



        public void winningCard()
        {
            if (!winner) {
                winner = true;
                MessageBox.Show("winner");
            }
        }

        public void resetGame()
        {
            b1 = false;
            b2 = false;
            b3 = false;
            b4 = false;
            b5 = false;

            i1 = false;
            i2 = false;
            i3 = false;
            i4 = false;
            i5 = false;

            n1 = false;
            n2 = false;
            n3 = false;
            n4 = false;
            n5 = false;

            g1 = false;
            g2 = false;
            g3 = false;
            g4 = false;
            g5 = false;

            o1 = false;
            o2 = false;
            o3 = false;
            o4 = false;
            o5 = false;

            winner = false;

            btnB1.BackColor = Color.White;
            btnI1.BackColor = Color.White;
            btnN1.BackColor = Color.White;
            btnG1.BackColor = Color.White;
            btnO1.BackColor = Color.White;

            btnB2.BackColor = Color.White;
            btnI2.BackColor = Color.White;
            btnN2.BackColor = Color.White;
            btnG2.BackColor = Color.White;
            btnO2.BackColor = Color.White;

            btnB3.BackColor = Color.White;
            btnI3.BackColor = Color.White;
            btnN3.BackColor = Color.White;
            btnG3.BackColor = Color.White;
            btnO3.BackColor = Color.White;

            btnB4.BackColor = Color.White;
            btnI4.BackColor = Color.White;
            btnN4.BackColor = Color.White;
            btnG4.BackColor = Color.White;
            btnO4.BackColor = Color.White;

            btnB5.BackColor = Color.White;
            btnI5.BackColor = Color.White;
            btnN5.BackColor = Color.White;
            btnG5.BackColor = Color.White;
            btnO5.BackColor = Color.White;
        }
        private void fillGE()
        {
            for (int i = 0; i < gusEddy.Count; i++)
            {
                gusEddy.RemoveAt(i);
            }

            gusEddy.Add("\"For people that don't know\"");
            gusEddy.Add("Mention booger wall");
            gusEddy.Add("Someone whispers into the mic");
            gusEddy.Add("Gus and Eddy don't agree with a boy on a disagreement");
            gusEddy.Add("Tony calls and hangs up immediately");
            gusEddy.Add("A knife is used");
            gusEddy.Add("Guest episode");
            gusEddy.Add("Twitch is mentioned");
            gusEddy.Add("NakeyJakey");
            gusEddy.Add("MMMMAIIIILLLLL");
            gusEddy.Add("Fuck single moms");
            gusEddy.Add("Fuck Ohio");
            gusEddy.Add("Preguntas");
            gusEddy.Add("Someone plays dumb");
            gusEddy.Add("Eddy mentions a Zach");
            gusEddy.Add("Drinking Episode");
            gusEddy.Add("Preguntas is translated");
            gusEddy.Add("Tony ignores a requested edit");
            gusEddy.Add("Someone walks off the frame");
            gusEddy.Add("\"Have I said this on the podcast\"");
            gusEddy.Add("Gus promises something outlandish");
            gusEddy.Add("Story/segments ends with \"Fuck you\" / \"Fuck off\"");
            gusEddy.Add("The boys are thanked for the support");
            gusEddy.Add("Boy of the week");
            gusEddy.Add("Fuck audio listeners");
            gusEddy.Add("Discord has issues");
            gusEddy.Add("Audio is cut");
            gusEddy.Add("Camera problems");
            gusEddy.Add("Sven Johnson");
            gusEddy.Add("Bingo is mentioned");
        }

        private void fillNLSS()
        {
            nlss.Add("Isaac is mentioned");
            nlss.Add("J O S H");
            nlss.Add("Apollo");
            nlss.Add("Being bald is mentioned");
            nlss.Add("Danglish");
            nlss.Add("Let's go");
            nlss.Add("Hey K8");
            nlss.Add("Ryan gets interrupted");
            nlss.Add("9");
            nlss.Add("10");
            nlss.Add("11");
            nlss.Add("12");
            nlss.Add("13");
            nlss.Add("14");
            nlss.Add("15");
            nlss.Add("16");
            nlss.Add("17");
            nlss.Add("18");
            nlss.Add("19");
            nlss.Add("20");
            nlss.Add("21");
            nlss.Add("22");
            nlss.Add("23");
            nlss.Add("24");
            nlss.Add("25");
            nlss.Add("26");
            nlss.Add("27");
            nlss.Add("28");
            nlss.Add("29");
            nlss.Add("30");
        }

        private void btnB1_Click(object sender, EventArgs e)
        {
            if (!b1)
            {
                b1 = true;
                if (checkBingo())
                {
                    winningCard();
                }
                btnB1.BackColor = Color.LightBlue;
            } else
            {
                b1 = false;
                btnB1.BackColor = Color.White;
            }
            
        }

        private void btnI1_Click(object sender, EventArgs e)
        {
            if (!i1)
            {
                i1 = true;
                if (checkBingo())
                {
                    winningCard();
                }
                btnI1.BackColor = Color.LightBlue;
            }
            else
            {
                i1 = false;
                btnI1.BackColor = Color.White;
            }
        }

        private void btnN1_Click(object sender, EventArgs e)
        {
            if (!n1)
            {
                n1 = true;
                if (checkBingo())
                {
                    winningCard();
                }
                btnN1.BackColor = Color.LightBlue;
            }
            else
            {
                n1 = false;
                btnN1.BackColor = Color.White;
            }
        }

        private void btnG1_Click(object sender, EventArgs e)
        {
            if (!g1)
            {
                g1 = true;
                if (checkBingo())
                {
                    winningCard();
                }
                btnG1.BackColor = Color.LightBlue;
            }
            else
            {
                g1 = false;
                btnB1.BackColor = Color.White;
            }
        }

        private void btnO1_Click(object sender, EventArgs e)
        {
            if (!o1)
            {
                o1 = true;
                if (checkBingo())
                {
                    winningCard();
                }
                btnO1.BackColor = Color.LightBlue;
            }
            else
            {
                o1 = false;
                btnO1.BackColor = Color.White;
            }
        }

        private void btnB2_Click(object sender, EventArgs e)
        {
            if (!b2)
            {
                b2 = true;
                if (checkBingo())
                {
                    winningCard();
                }
                btnB2.BackColor = Color.LightBlue;
            }
            else
            {
                b2 = false;
                btnB2.BackColor = Color.White;
            }
        }

        private void btnI2_Click(object sender, EventArgs e)
        {
            if (!i2)
            {
                i2 = true;
                if (checkBingo())
                {
                    winningCard();
                }
                btnI2.BackColor = Color.LightBlue;
            }
            else
            {
                i2 = false;
                btnI2.BackColor = Color.White;
            }
        }

        private void btnN2_Click(object sender, EventArgs e)
        {
            if (!n2)
            {
                n2 = true;
                if (checkBingo())
                {
                    winningCard();
                }
                btnN2.BackColor = Color.LightBlue;
            }
            else
            {
                n2 = false;
                btnN2.BackColor = Color.White;
            }
        }

        private void btnG2_Click(object sender, EventArgs e)
        {
            if (!g2)
            {
                g2 = true;
                if (checkBingo())
                {
                    winningCard();
                }
                btnG2.BackColor = Color.LightBlue;
            }
            else
            {
                g2 = false;
                btnG2.BackColor = Color.White;
            }
        }

        private void btnO2_Click(object sender, EventArgs e)
        {
            if (!o2)
            {
                o2 = true;
                if (checkBingo())
                {
                    winningCard();
                }
                btnO2.BackColor = Color.LightBlue;
            }
            else
            {
                o2 = false;
                btnO2.BackColor = Color.White;
            }
        }

        private void btnB3_Click(object sender, EventArgs e)
        {
            if (!b3)
            {
                b3 = true;
                if (checkBingo())
                {
                    winningCard();
                }
                btnB3.BackColor = Color.LightBlue;
            }
            else
            {
                b3 = false;
                btnB3.BackColor = Color.White;
            }
        }

        private void btnI3_Click(object sender, EventArgs e)
        {
            if (!i3)
            {
                i3 = true;
                if (checkBingo())
                {
                    winningCard();
                }
                btnI3.BackColor = Color.LightBlue;
            }
            else
            {
                i3 = false;
                btnI3.BackColor = Color.White;
            }
        }

        private void btnN3_Click(object sender, EventArgs e)
        {
            if (!n3)
            {
                n3 = true;
                if (checkBingo())
                {
                    winningCard();
                }
                btnN3.BackColor = Color.LightBlue;
            }
            else
            {
                n3 = false;
                btnN3.BackColor = Color.White;
            }
        }

        private void btnG3_Click(object sender, EventArgs e)
        {
            if (!g3)
            {
                g3 = true;
                if (checkBingo())
                {
                    winningCard();
                }
                btnG3.BackColor = Color.LightBlue;
            }
            else
            {
                g3 = false;
                btnG3.BackColor = Color.White;
            }
        }

        private void btnO3_Click(object sender, EventArgs e)
        {
            if (!o3)
            {
                o3 = true;
                if (checkBingo())
                {
                    winningCard();
                }
                btnO3.BackColor = Color.LightBlue;
            }
            else
            {
                o3 = false;
                btnO3.BackColor = Color.White;
            }
        }

        private void btnB4_Click(object sender, EventArgs e)
        {
            if (!b4)
            {
                b4 = true;
                if (checkBingo())
                {
                    winningCard();
                }
                btnB4.BackColor = Color.LightBlue;
            }
            else
            {
                b4 = false;
                btnB4.BackColor = Color.White;
            }
        }

        private void btnI4_Click(object sender, EventArgs e)
        {
            if (!i4)
            {
                i4 = true;
                if (checkBingo())
                {
                    winningCard();
                }
                btnI4.BackColor = Color.LightBlue;
            }
            else
            {
                i4 = false;
                btnI4.BackColor = Color.White;
            }
        }

        private void btnN4_Click(object sender, EventArgs e)
        {
            if (!n4)
            {
                n4 = true;
                if (checkBingo())
                {
                    winningCard();
                }
                btnN4.BackColor = Color.LightBlue;
            }
            else
            {
                n4 = false;
                btnN4.BackColor = Color.White;
            }
        }

        private void btnG4_Click(object sender, EventArgs e)
        {
            if (!g4)
            {
                g4 = true;
                if (checkBingo())
                {
                    winningCard();
                }
                btnG4.BackColor = Color.LightBlue;
            }
            else
            {
                g4 = false;
                btnG4.BackColor = Color.White;
            }
        }

        private void btnO4_Click(object sender, EventArgs e)
        {
            if (!o4)
            {
                o4 = true;
                if (checkBingo())
                {
                    winningCard();
                }
                btnO4.BackColor = Color.LightBlue;
            }
            else
            {
                o4 = false;
                btnO4.BackColor = Color.White;
            }
        }

        private void btnB5_Click(object sender, EventArgs e)
        {
            if (!b5)
            {
                b5 = true;
                if (checkBingo())
                {
                    winningCard();
                }
                btnB5.BackColor = Color.LightBlue;
            }
            else
            {
                b5 = false;
                btnB5.BackColor = Color.White;
            }
        }

        private void btnI5_Click(object sender, EventArgs e)
        {
            if (!i5)
            {
                i5 = true;
                if (checkBingo())
                {
                    winningCard();
                }
                btnI5.BackColor = Color.LightBlue;
            }
            else
            {
                i5 = false;
                btnI5.BackColor = Color.White;
            }
        }

        private void btnN5_Click(object sender, EventArgs e)
        {
            if (!n5)
            {
                n5 = true;
                if (checkBingo())
                {
                    winningCard();
                }
                btnN5.BackColor = Color.LightBlue;
            }
            else
            {
                n5 = false;
                btnN5.BackColor = Color.White;
            }
        }

        private void btnG5_Click(object sender, EventArgs e)
        {
            if (!g5)
            {
                g5 = true;
                if (checkBingo())
                {
                    winningCard();
                }
                btnG5.BackColor = Color.LightBlue;
            }
            else
            {
                g5 = false;
                btnG5.BackColor = Color.White;
            }
        }

        private void btnO5_Click(object sender, EventArgs e)
        {
            if (!o5)
            {
                o5 = true;
                if (checkBingo())
                {
                    winningCard();
                }
                btnO5.BackColor = Color.LightBlue;
            }
            else
            {
                o5 = false;
                btnO5.BackColor = Color.White;
            }
        }

        private void cboGame_SelectedIndexChanged(object sender, EventArgs e)
        {
            Random rand = new Random();

            resetGame();

            if (cboGame.SelectedIndex == 0)
            {
                fillGE();
                int val = -1;

                val = rand.Next(0, gusEddy.Count);
                btnB1.Text = gusEddy[val];
                gusEddy.RemoveAt(val);
                val = rand.Next(0, gusEddy.Count);
                btnI1.Text = gusEddy[val];
                gusEddy.RemoveAt(val);
                val = rand.Next(0, gusEddy.Count);
                btnN1.Text = gusEddy[val];
                gusEddy.RemoveAt(val);
                val = rand.Next(0, gusEddy.Count);
                btnG1.Text = gusEddy[val];
                gusEddy.RemoveAt(val);
                val = rand.Next(0, gusEddy.Count);
                btnO1.Text = gusEddy[val];
                gusEddy.RemoveAt(val);

                val = rand.Next(0, gusEddy.Count);
                btnB2.Text = gusEddy[val];
                gusEddy.RemoveAt(val);
                val = rand.Next(0, gusEddy.Count);
                btnI2.Text = gusEddy[val];
                gusEddy.RemoveAt(val);
                val = rand.Next(0, gusEddy.Count);
                btnN2.Text = gusEddy[val];
                gusEddy.RemoveAt(val);
                val = rand.Next(0, gusEddy.Count);
                btnG2.Text = gusEddy[val];
                gusEddy.RemoveAt(val);
                val = rand.Next(0, gusEddy.Count);
                btnO2.Text = gusEddy[val];
                gusEddy.RemoveAt(val);

                val = rand.Next(0, gusEddy.Count);
                btnB3.Text = gusEddy[val];
                gusEddy.RemoveAt(val);
                val = rand.Next(0, gusEddy.Count);
                btnI3.Text = gusEddy[val];
                gusEddy.RemoveAt(val);
                val = rand.Next(0, gusEddy.Count);
                btnN3.Text = gusEddy[val];
                gusEddy.RemoveAt(val);
                val = rand.Next(0, gusEddy.Count);
                btnG3.Text = gusEddy[val];
                gusEddy.RemoveAt(val);
                val = rand.Next(0, gusEddy.Count);
                btnO3.Text = gusEddy[val];
                gusEddy.RemoveAt(val);

                val = rand.Next(0, gusEddy.Count);
                btnB4.Text = gusEddy[val];
                gusEddy.RemoveAt(val);
                val = rand.Next(0, gusEddy.Count);
                btnI4.Text = gusEddy[val];
                gusEddy.RemoveAt(val);
                val = rand.Next(0, gusEddy.Count);
                btnN4.Text = gusEddy[val];
                gusEddy.RemoveAt(val);
                val = rand.Next(0, gusEddy.Count);
                btnG4.Text = gusEddy[val];
                gusEddy.RemoveAt(val);
                val = rand.Next(0, gusEddy.Count);
                btnO4.Text = gusEddy[val];
                gusEddy.RemoveAt(val);

                val = rand.Next(0, gusEddy.Count);
                btnB5.Text = gusEddy[val];
                gusEddy.RemoveAt(val);
                val = rand.Next(0, gusEddy.Count);
                btnI5.Text = gusEddy[val];
                gusEddy.RemoveAt(val);
                val = rand.Next(0, gusEddy.Count);
                btnN5.Text = gusEddy[val];
                gusEddy.RemoveAt(val);
                val = rand.Next(0, gusEddy.Count);
                btnG5.Text = gusEddy[val];
                gusEddy.RemoveAt(val);
                val = rand.Next(0, gusEddy.Count);
                btnO5.Text = gusEddy[val];
                gusEddy.RemoveAt(val);

            }

            if (cboGame.SelectedIndex == 1)
            {
                fillNLSS();
                int val = -1;

                val = rand.Next(0, nlss.Count);
                btnB1.Text = nlss[val];
                nlss.RemoveAt(val);
                val = rand.Next(0, nlss.Count);
                btnI1.Text = nlss[val];
                nlss.RemoveAt(val);
                val = rand.Next(0, nlss.Count);
                btnN1.Text = nlss[val];
                nlss.RemoveAt(val);
                val = rand.Next(0, nlss.Count);
                btnG1.Text = nlss[val];
                nlss.RemoveAt(val);
                val = rand.Next(0, nlss.Count);
                btnO1.Text = nlss[val];
                nlss.RemoveAt(val);

                val = rand.Next(0, nlss.Count);
                btnB2.Text = nlss[val];
                nlss.RemoveAt(val);
                val = rand.Next(0, nlss.Count);
                btnI2.Text = nlss[val];
                nlss.RemoveAt(val);
                val = rand.Next(0, nlss.Count);
                btnN2.Text = nlss[val];
                nlss.RemoveAt(val);
                val = rand.Next(0, nlss.Count);
                btnG2.Text = nlss[val];
                nlss.RemoveAt(val);
                val = rand.Next(0, nlss.Count);
                btnO2.Text = nlss[val];
                nlss.RemoveAt(val);

                val = rand.Next(0, nlss.Count);
                btnB3.Text = nlss[val];
                nlss.RemoveAt(val);
                val = rand.Next(0, nlss.Count);
                btnI3.Text = nlss[val];
                nlss.RemoveAt(val);
                val = rand.Next(0, nlss.Count);
                btnN3.Text = nlss[val];
                nlss.RemoveAt(val);
                val = rand.Next(0, nlss.Count);
                btnG3.Text = nlss[val];
                nlss.RemoveAt(val);
                val = rand.Next(0, nlss.Count);
                btnO3.Text = nlss[val];
                nlss.RemoveAt(val);

                val = rand.Next(0, nlss.Count);
                btnB4.Text = nlss[val];
                nlss.RemoveAt(val);
                val = rand.Next(0, nlss.Count);
                btnI4.Text = nlss[val];
                nlss.RemoveAt(val);
                val = rand.Next(0, nlss.Count);
                btnN4.Text = nlss[val];
                nlss.RemoveAt(val);
                val = rand.Next(0, nlss.Count);
                btnG4.Text = nlss[val];
                nlss.RemoveAt(val);
                val = rand.Next(0, nlss.Count);
                btnO4.Text = nlss[val];
                nlss.RemoveAt(val);

                val = rand.Next(0, nlss.Count);
                btnB5.Text = nlss[val];
                nlss.RemoveAt(val);
                val = rand.Next(0, nlss.Count);
                btnI5.Text = nlss[val];
                nlss.RemoveAt(val);
                val = rand.Next(0, nlss.Count);
                btnN5.Text = nlss[val];
                nlss.RemoveAt(val);
                val = rand.Next(0, nlss.Count);
                btnG5.Text = nlss[val];
                nlss.RemoveAt(val);
                val = rand.Next(0, nlss.Count);
                btnO5.Text = nlss[val];
                nlss.RemoveAt(val);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
