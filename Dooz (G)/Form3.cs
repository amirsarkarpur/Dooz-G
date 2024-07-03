using System.ComponentModel.DataAnnotations;
using System.Media;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;
using NAudio.Wave;

namespace Dooz__G_
{
    public partial class Form3 : Form
    {
        private WaveOutEvent outputDevice;
        private AudioFileReader audioFile;



        bool winer1 = false;
        bool winer2 = false;
        bool winer3 = false;
        bool winer4 = false;
        bool allwiner = false;
        string playername1;
        string playername2;
        string playername3;
        string playername4;
        int sum = 0;
        int Player1sum = 0;
        int Player2sum = 0;
        int Player3sum = 0;
        int Player4sum = 0;
        int nobat = 0;
        bool finish = true;
        int botnumber;
        bool timer = false;
        int timersum = 0;
        string charekter1;
        string charekter2;
        string charekter3;
        string charekter4;
        string howplayer;
        void playwinner()
        {


            outputDevice = new WaveOutEvent();
            audioFile = new AudioFileReader(@"C:\Users\Asus\Desktop\tamarin\Dooz (G)\Dooz (G)\bin\Debug\net8.0-windows\mixkit-arcade-retro-game-over-213.wav");
            outputDevice.Init(audioFile);

            outputDevice.Play();

        }

        void winer()
        {


            if ((number0.Text == charekter1 && number1.Text == charekter1 && number2.Text == charekter1) || (number1.Text == charekter1 && number2.Text == charekter1 && number3.Text == charekter1) || (number4.Text == charekter1 && number5.Text == charekter1 && number6.Text == charekter1)
         || (number5.Text == charekter1 && number6.Text == charekter1 && number7.Text == charekter1) || (number8.Text == charekter1 && number9.Text == charekter1 && number10.Text == charekter1) || (number9.Text == charekter1 && number10.Text == charekter1 && number11.Text == charekter1)
         || (number12.Text == charekter1 && number13.Text == charekter1 && number14.Text == charekter1) || (number13.Text == charekter1 && number14.Text == charekter1 && number15.Text == charekter1) || (number0.Text == charekter1 && number4.Text == charekter1 && number8.Text == charekter1) || (number4.Text == charekter1 && number8.Text == charekter1 && number12.Text == charekter1) || (number1.Text == charekter1 && number5.Text == charekter1 && number9.Text == charekter1)
         || (number5.Text == charekter1 && number9.Text == charekter1 && number13.Text == charekter1) || (number2.Text == charekter1 && number6.Text == charekter1 && number10.Text == charekter1) || (number6.Text == charekter1 && number10.Text == charekter1 && number11.Text == charekter1)
         || (number3.Text == charekter1 && number7.Text == charekter1 && number11.Text == charekter1) || (number7.Text == charekter1 && number11.Text == charekter1 && number15.Text == charekter1) || (number8.Text == charekter1 && number5.Text == charekter1 && number2.Text == charekter1) || (number12.Text == charekter1 && number9.Text == charekter1 && number6.Text == charekter1) || (number9.Text == charekter1 && number6.Text == charekter1 && number3.Text == charekter1)
         || (number13.Text == charekter1 && number10.Text == charekter1 && number7.Text == charekter1) || (number1.Text == charekter1 && number6.Text == charekter1 && number11.Text == charekter1) || (number0.Text == charekter1 && number5.Text == charekter1 && number10.Text == charekter1)
         || (number5.Text == charekter1 && number10.Text == charekter1 && number15.Text == charekter1) || (number4.Text == charekter1 && number9.Text == charekter1 && number14.Text == charekter1))
            {
                Player1sum++;
                winer1 = true;
            }

            else if ((number0.Text == charekter2 && number1.Text == charekter2 && number2.Text == charekter2) || (number1.Text == charekter2 && number2.Text == charekter2 && number3.Text == charekter2) || (number4.Text == charekter2 && number5.Text == charekter2 && number6.Text == charekter2)
         || (number5.Text == charekter2 && number6.Text == charekter2 && number7.Text == charekter2) || (number8.Text == charekter2 && number9.Text == charekter2 && number10.Text == charekter2) || (number9.Text == charekter2 && number10.Text == charekter2 && number11.Text == charekter2)
         || (number12.Text == charekter2 && number13.Text == charekter2 && number14.Text == charekter2) || (number13.Text == charekter2 && number14.Text == charekter2 && number15.Text == charekter2) || (number0.Text == charekter2 && number4.Text == charekter2 && number8.Text == charekter2) || (number4.Text == charekter2 && number8.Text == charekter2 && number12.Text == charekter2) || (number1.Text == charekter2 && number5.Text == charekter2 && number9.Text == charekter2)
         || (number5.Text == charekter2 && number9.Text == charekter2 && number13.Text == charekter2) || (number2.Text == charekter2 && number6.Text == charekter2 && number10.Text == charekter2) || (number6.Text == charekter2 && number10.Text == charekter2 && number11.Text == charekter2)
         || (number3.Text == charekter2 && number7.Text == charekter2 && number11.Text == charekter2) || (number7.Text == charekter2 && number11.Text == charekter2 && number15.Text == charekter2) || (number8.Text == charekter2 && number5.Text == charekter2 && number2.Text == charekter2) || (number12.Text == charekter2 && number9.Text == charekter2 && number6.Text == charekter2) || (number9.Text == charekter2 && number6.Text == charekter2 && number3.Text == charekter2)
         || (number13.Text == charekter2 && number10.Text == charekter2 && number7.Text == charekter2) || (number1.Text == charekter2 && number6.Text == charekter2 && number11.Text == charekter2) || (number0.Text == charekter2 && number5.Text == charekter2 && number10.Text == charekter2)
         || (number5.Text == charekter2 && number10.Text == charekter2 && number15.Text == charekter2) || (number4.Text == charekter2 && number9.Text == charekter2 && number14.Text == charekter2))
            {
                Player2sum++;
                winer2 = true;
            }


            else if ((number0.Text == charekter3 && number1.Text == charekter3 && number2.Text == charekter3) || (number1.Text == charekter3 && number2.Text == charekter3 && number3.Text == charekter3) || (number4.Text == charekter3 && number5.Text == charekter3 && number6.Text == charekter3)
         || (number5.Text == charekter3 && number6.Text == charekter3 && number7.Text == charekter3) || (number8.Text == charekter3 && number9.Text == charekter3 && number10.Text == charekter3) || (number9.Text == charekter3 && number10.Text == charekter3 && number11.Text == charekter3)
         || (number12.Text == charekter3 && number13.Text == charekter3 && number14.Text == charekter3) || (number13.Text == charekter3 && number14.Text == charekter3 && number15.Text == charekter3) || (number0.Text == charekter3 && number4.Text == charekter3 && number8.Text == charekter3) || (number4.Text == charekter3 && number8.Text == charekter3 && number12.Text == charekter3) || (number1.Text == charekter3 && number5.Text == charekter3 && number9.Text == charekter3)
         || (number5.Text == charekter3 && number9.Text == charekter3 && number13.Text == charekter3) || (number2.Text == charekter3 && number6.Text == charekter3 && number10.Text == charekter3) || (number6.Text == charekter3 && number10.Text == charekter3 && number11.Text == charekter3)
         || (number3.Text == charekter3 && number7.Text == charekter3 && number11.Text == charekter3) || (number7.Text == charekter3 && number11.Text == charekter3 && number15.Text == charekter3) || (number8.Text == charekter3 && number5.Text == charekter3 && number2.Text == charekter3) || (number12.Text == charekter3 && number9.Text == charekter3 && number6.Text == charekter3) || (number9.Text == charekter3 && number6.Text == charekter3 && number3.Text == charekter3)
         || (number13.Text == charekter3 && number10.Text == charekter3 && number7.Text == charekter3) || (number1.Text == charekter3 && number6.Text == charekter3 && number11.Text == charekter3) || (number0.Text == charekter3 && number5.Text == charekter3 && number10.Text == charekter3)
         || (number5.Text == charekter3 && number10.Text == charekter3 && number15.Text == charekter3) || (number4.Text == charekter3 && number9.Text == charekter3 && number14.Text == charekter3))
            {
                Player3sum++;
                winer3 = true;
            }


            else if ((number0.Text == charekter4 && number1.Text == charekter4 && number2.Text == charekter4) || (number1.Text == charekter4 && number2.Text == charekter4 && number3.Text == charekter4) || (number4.Text == charekter4 && number5.Text == charekter4 && number6.Text == charekter4)
         || (number5.Text == charekter4 && number6.Text == charekter4 && number7.Text == charekter4) || (number8.Text == charekter4 && number9.Text == charekter4 && number10.Text == charekter4) || (number9.Text == charekter4 && number10.Text == charekter4 && number11.Text == charekter4)
         || (number12.Text == charekter4 && number13.Text == charekter4 && number14.Text == charekter4) || (number13.Text == charekter4 && number14.Text == charekter4 && number15.Text == charekter4) || (number0.Text == charekter4 && number4.Text == charekter4 && number8.Text == charekter4) || (number4.Text == charekter4 && number8.Text == charekter4 && number12.Text == charekter4) || (number1.Text == charekter4 && number5.Text == charekter4 && number9.Text == charekter4)
         || (number5.Text == charekter4 && number9.Text == charekter4 && number13.Text == charekter4) || (number2.Text == charekter4 && number6.Text == charekter4 && number10.Text == charekter4) || (number6.Text == charekter4 && number10.Text == charekter4 && number11.Text == charekter4)
         || (number3.Text == charekter4 && number7.Text == charekter4 && number11.Text == charekter4) || (number7.Text == charekter4 && number11.Text == charekter4 && number15.Text == charekter4) || (number8.Text == charekter4 && number5.Text == charekter4 && number2.Text == charekter4) || (number12.Text == charekter4 && number9.Text == charekter4 && number6.Text == charekter4) || (number9.Text == charekter4 && number6.Text == charekter4 && number3.Text == charekter4)
         || (number13.Text == charekter4 && number10.Text == charekter4 && number7.Text == charekter4) || (number1.Text == charekter4 && number6.Text == charekter4 && number11.Text == charekter4) || (number0.Text == charekter4 && number5.Text == charekter4 && number10.Text == charekter4)
         || (number5.Text == charekter4 && number10.Text == charekter4 && number15.Text == charekter4) || (number4.Text == charekter4 && number9.Text == charekter4 && number14.Text == charekter4))
            {
                Player4sum++;
                winer4 = true;
            }


            else if (number0.Tag != "1" && number1.Tag != "2" && number2.Tag != "3" && number3.Tag != "4" && number4.Tag != "5" && number5.Tag != "6" && number6.Tag != "7" && number7.Tag != "8" && number8.Tag != "9" && number9.Tag != "10" && number10.Tag != "11" && number11.Tag != "12" && number12.Tag != "13" && number13.Tag != "14" && number14.Tag != "15" && number15.Tag != "16")
            {
                allwiner = true;
            }

            if (howplayer == "4")
            {
                label2.Text = playername1 + " : " + Player1sum + "\n" + playername2 + " : " + Player2sum + "\n" + playername3 + " : " + Player3sum + "\n" + playername4 + " : " + Player4sum;
            }

            else if (howplayer == "3")
            {
                label2.Text = playername1 + " : " + Player1sum + "\n" + playername2 + " : " + Player2sum + "\n" + playername3 + " : " + Player3sum;
            }

            else if (howplayer == "2")
            {
                label2.Text = playername1 + " : " + Player1sum + "\n" + playername2 + " : " + Player2sum;
            }

            else if (howplayer == "1")
            {
                label2.Text = playername1 + " : " + Player1sum + "\n" + playername2 + " : " + Player2sum;
            }

        }

        public Form3()
        {
            InitializeComponent();


        }


        private void button_Click(object sender, EventArgs e)
        {

            Button number = (Button)sender;

            if (howplayer == "1")
            {


                if (nobat >= 1)
                {
                    nobat = 0;
                }

                nobat++;



                if (nobat == 1)
                {



                    Mytimer.Stop();
                    Mytimer.Start();

                    Mytimer.Start();

                    label3.Text = "inter bot";




                    if (number.Text != charekter1 && number.Text != charekter2 && finish)
                    {


                        number.Text = charekter1;
                        number.Tag = charekter1;

                    }



                    else
                    {

                        MessageBox.Show("rakab khordi dash !!!");
                        finish = true;

                    }



                }
                if (nobat == 1)
                {



                    Mytimer.Stop();
                    Mytimer.Start();

                    Mytimer.Start();

                    label3.Text = "inter player ";

                    for (int i = 0; i < 100; i++)
                    {

                        Random rnd = new Random();
                        botnumber = rnd.Next(1, 17);


                        if (botnumber == 1 && number0.Text != charekter1 && number0.Text != charekter2)
                        {
                            number0.Text = charekter2;
                            number0.Tag = charekter2;
                            break;
                        }

                        else if (botnumber == 2 && number1.Text != charekter1 && number1.Text != charekter2)
                        {
                            number1.Text = charekter2;
                            number1.Tag = charekter2;
                            break;
                        }

                        else if (botnumber == 3 && number2.Text != charekter1 && number2.Text != charekter2)
                        {
                            number2.Text = charekter2;
                            number2.Tag = charekter2;
                            break;
                        }

                        else if (botnumber == 4 && number3.Text != charekter1 && number3.Text != charekter2)
                        {
                            number3.Text = charekter2;
                            number3.Tag = charekter2;
                            break;
                        }

                        else if (botnumber == 5 && number4.Text != charekter1 && number4.Text != charekter2)
                        {
                            number4.Text = charekter2;
                            number4.Tag = charekter2;
                            break;
                        }

                        else if (botnumber == 6 && number5.Text != charekter1 && number5.Text != charekter2)
                        {
                            number5.Text = charekter2;
                            number5.Tag = charekter2;
                            break;
                        }

                        else if (botnumber == 7 && number6.Text != charekter1 && number6.Text != charekter2)
                        {
                            number6.Text = charekter2;
                            number6.Tag = charekter2;
                            break;
                        }

                        else if (botnumber == 8 && number7.Text != charekter1 && number7.Text != charekter2)
                        {
                            number7.Text = charekter2;
                            number7.Tag = charekter2;
                            break;
                        }

                        else if (botnumber == 9 && number8.Text != charekter1 && number8.Text != charekter2)
                        {
                            number8.Text = charekter2;
                            number8.Tag = charekter2;
                            break;
                        }

                        if (botnumber == 10 && number9.Text != charekter1 && number9.Text != charekter2)
                        {
                            number9.Text = charekter2;
                            number9.Tag = charekter2;
                            break;
                        }

                        if (botnumber == 11 && number10.Text != charekter1 && number10.Text != charekter2)
                        {
                            number10.Text = charekter2;
                            number10.Tag = charekter2;
                            break;
                        }

                        if (botnumber == 12 && number11.Text != charekter1 && number11.Text != charekter2)
                        {
                            number11.Text = charekter2;
                            number11.Tag = charekter2;
                            break;
                        }

                        if (botnumber == 13 && number12.Text != charekter1 && number12.Text != charekter2)
                        {
                            number12.Text = charekter2;
                            number12.Tag = charekter2;
                            break;
                        }

                        if (botnumber == 14 && number13.Text != charekter1 && number13.Text != charekter2)
                        {
                            number13.Text = charekter2;
                            number13.Tag = charekter2;
                            break;
                        }

                        if (botnumber == 15 && number14.Text != charekter1 && number14.Text != charekter2)
                        {
                            number14.Text = charekter2;
                            number14.Tag = charekter2;
                            break;
                        }

                        if (botnumber == 16 && number15.Text != charekter1 && number15.Text != charekter2)
                        {
                            number15.Text = charekter2;
                            number15.Tag = charekter2;
                            break;
                        }

                    }
                }

            }

            if (howplayer == "2")
            {
                if (nobat >= 2)
                {
                    nobat = 0;
                }

                nobat++;

                if (nobat == 1)
                {

                    Mytimer.Stop();
                    Mytimer.Start();

                    Mytimer.Start();


                    label3.Text = "inter player 2";

                    if (number.Text != charekter1 && number.Text != charekter2 && finish)
                    {
                        number.Text = charekter1;
                        number.Tag = charekter1;
                    }
                    else
                    {
                        MessageBox.Show("rakab khordi dash !!!");
                        finish = true;
                    }

                }
                else
                {

                    Mytimer.Stop();
                    Mytimer.Start();

                    Mytimer.Start();

                    label3.Text = "inter player 1";

                    if (number.Text != charekter1 && number.Text != charekter2 && finish)
                    {
                        number.Text = charekter2;
                        number.Tag = charekter2;
                    }
                    else
                    {
                        MessageBox.Show("rakab khordi dash !!!");
                        finish = true;
                    }
                }
            }

            if (howplayer == "3")
            {
                if (nobat >= 3)
                {
                    nobat = 0;
                }

                nobat++;

                if (nobat == 1)
                {

                    Mytimer.Stop();
                    Mytimer.Start();

                    Mytimer.Start();

                    label3.Text = "inter player 2";

                    if (number.Text != charekter1 && number.Text != charekter2 && number.Text != charekter3 && finish)
                    {
                        number.Text = charekter1;
                        number.Tag = charekter1;
                    }
                    else
                    {
                        MessageBox.Show("rakab khordi dash !!!");
                        finish = true;
                    }

                }
                else if (nobat == 2)
                {

                    Mytimer.Stop();
                    Mytimer.Start();

                    Mytimer.Start();

                    label3.Text = "inter player 3";

                    if (number.Text != charekter1 && number.Text != charekter2 && number.Text != charekter3 && finish)
                    {
                        number.Text = charekter2;
                        number.Tag = charekter2;
                    }
                    else
                    {
                        MessageBox.Show("rakab khordi dash !!!");
                        finish = true;
                    }
                }
                else
                {

                    Mytimer.Stop();
                    Mytimer.Start();

                    Mytimer.Start();

                    label3.Text = "inter player 1";

                    if (number.Text != charekter1 && number.Text != charekter2 && number.Text != charekter3 && finish)
                    {
                        number.Text = charekter3;
                        number.Tag = charekter3;
                    }
                    else
                    {
                        MessageBox.Show("rakab khordi dash !!!");
                        finish = true;
                    }
                }
            }

            if (howplayer == "4")
            {
                if (nobat >= 4)
                {
                    nobat = 0;
                }

                nobat++;

                if (nobat == 1)
                {

                    Mytimer.Stop();
                    Mytimer.Start();

                    Mytimer.Start();

                    label3.Text = "inter player 2";

                    if (number.Text != charekter1 && number.Text != charekter2 && number.Text != charekter3 && number.Text != charekter4 && finish)
                    {
                        number.Text = charekter1;
                        number.Tag = charekter1;

                    }
                    else
                    {
                        MessageBox.Show("rakab khordi dash !!!");
                        finish = true;
                    }

                }
                else if (nobat == 2)
                {

                    Mytimer.Stop();
                    Mytimer.Start();

                    Mytimer.Start();

                    label3.Text = "inter player 3";

                    if (number.Text != charekter1 && number.Text != charekter2 && number.Text != charekter3 && number.Text != charekter4 && finish)
                    {
                        number.Text = charekter2;
                        number.Tag = charekter2;
                    }
                    else
                    {
                        MessageBox.Show("rakab khordi dash !!!");
                        finish = true;
                    }
                }
                else if (nobat == 3)
                {

                    Mytimer.Stop();
                    Mytimer.Start();

                    Mytimer.Start();

                    label3.Text = "inter player 4";

                    if (number.Text != charekter1 && number.Text != charekter2 && number.Text != charekter3 && number.Text != charekter4 && finish)
                    {
                        number.Text = charekter3;
                        number.Tag = charekter3;
                    }
                    else
                    {
                        MessageBox.Show("rakab khordi dash !!!");
                        finish = true;
                    }
                }
                else
                {

                    Mytimer.Stop();
                    Mytimer.Start();

                    Mytimer.Start();

                    label3.Text = "inter player 1";

                    if (number.Text != charekter1 && number.Text != charekter2 && number.Text != charekter3 && number.Text != charekter4 && finish)
                    {
                        number.Text = charekter4;
                        number.Tag = charekter4;
                    }
                    else
                    {
                        MessageBox.Show("rakab khordi dash !!!");
                        finish = true;
                    }
                }
            }

            winer();

            if (winer1)
            {
                Mytimer.Stop();
                Mytimer.Start();


                playwinner();

                MessageBox.Show("winnnner player 1 !!!");

                winer1 = false;

                number0.Text = "";
                number1.Text = "";
                number2.Text = "";
                number3.Text = "";
                number4.Text = "";
                number5.Text = "";
                number6.Text = "";
                number7.Text = "";
                number8.Text = "";
                number9.Text = "";
                number10.Text = "";
                number11.Text = "";
                number12.Text = "";
                number13.Text = "";
                number14.Text = "";
                number15.Text = "";

                number0.Tag = "1";
                number1.Tag = "2";
                number2.Tag = "3";
                number3.Tag = "4";
                number4.Tag = "5";
                number5.Tag = "6";
                number6.Tag = "7";
                number7.Tag = "8";
                number8.Tag = "9";
                number9.Tag = "10";
                number10.Tag = "11";
                number11.Tag = "12";
                number12.Tag = "13";
                number13.Tag = "14";
                number14.Tag = "15";
                number15.Tag = "16";


            }

            else if (winer2)
            {
                Mytimer.Stop();
                Mytimer.Start();


                playwinner();
                MessageBox.Show("winnnner player 2 !!!");
                winer2 = false;

                number0.Text = "";
                number1.Text = "";
                number2.Text = "";
                number3.Text = "";
                number4.Text = "";
                number5.Text = "";
                number6.Text = "";
                number7.Text = "";
                number8.Text = "";
                number9.Text = "";
                number10.Text = "";
                number11.Text = "";
                number12.Text = "";
                number13.Text = "";
                number14.Text = "";
                number15.Text = "";

                number0.Tag = "1";
                number1.Tag = "2";
                number2.Tag = "3";
                number3.Tag = "4";
                number4.Tag = "5";
                number5.Tag = "6";
                number6.Tag = "7";
                number7.Tag = "8";
                number8.Tag = "9";
                number9.Tag = "10";
                number10.Tag = "11";
                number11.Tag = "12";
                number12.Tag = "13";
                number13.Tag = "14";
                number14.Tag = "15";
                number15.Tag = "16";
            }

            else if (winer3)
            {
                Mytimer.Stop();
                Mytimer.Start();



                playwinner();
                MessageBox.Show("winnnner player 3 !!!");
                winer3 = false;

                number0.Text = "";
                number1.Text = "";
                number2.Text = "";
                number3.Text = "";
                number4.Text = "";
                number5.Text = "";
                number6.Text = "";
                number7.Text = "";
                number8.Text = "";
                number9.Text = "";
                number10.Text = "";
                number11.Text = "";
                number12.Text = "";
                number13.Text = "";
                number14.Text = "";
                number15.Text = "";

                number0.Tag = "1";
                number1.Tag = "2";
                number2.Tag = "3";
                number3.Tag = "4";
                number4.Tag = "5";
                number5.Tag = "6";
                number6.Tag = "7";
                number7.Tag = "8";
                number8.Tag = "9";
                number9.Tag = "10";
                number10.Tag = "11";
                number11.Tag = "12";
                number12.Tag = "13";
                number13.Tag = "14";
                number14.Tag = "15";
                number15.Tag = "16";
            }

            else if (winer4)
            {

                Mytimer.Stop();
                Mytimer.Start();



                playwinner();
                MessageBox.Show("winnnner player 4 !!!");
                winer4 = false;

                number0.Text = "";
                number1.Text = "";
                number2.Text = "";
                number3.Text = "";
                number4.Text = "";
                number5.Text = "";
                number6.Text = "";
                number7.Text = "";
                number8.Text = "";
                number9.Text = "";
                number10.Text = "";
                number11.Text = "";
                number12.Text = "";
                number13.Text = "";
                number14.Text = "";
                number15.Text = "";

                number0.Tag = "1";
                number1.Tag = "2";
                number2.Tag = "3";
                number3.Tag = "4";
                number4.Tag = "5";
                number5.Tag = "6";
                number6.Tag = "7";
                number7.Tag = "8";
                number8.Tag = "9";
                number9.Tag = "10";
                number10.Tag = "11";
                number11.Tag = "12";
                number12.Tag = "13";
                number13.Tag = "14";
                number14.Tag = "15";
                number15.Tag = "16";

            }

            else if (allwiner)
            {

                Mytimer.Stop();
                Mytimer.Start();


                playwinner();
                MessageBox.Show("winnnner " + playername1 + "  " + playername2 + "  " + playername3 + "  " + playername4 + "!!!");
                allwiner = false;

                number0.Text = "";
                number1.Text = "";
                number2.Text = "";
                number3.Text = "";
                number4.Text = "";
                number5.Text = "";
                number6.Text = "";
                number7.Text = "";
                number8.Text = "";
                number9.Text = "";
                number10.Text = "";
                number11.Text = "";
                number12.Text = "";
                number13.Text = "";
                number14.Text = "";
                number15.Text = "";

                number0.Tag = "1";
                number1.Tag = "2";
                number2.Tag = "3";
                number3.Tag = "4";
                number4.Tag = "5";
                number5.Tag = "6";
                number6.Tag = "7";
                number7.Tag = "8";
                number8.Tag = "9";
                number9.Tag = "10";
                number10.Tag = "11";
                number11.Tag = "12";
                number12.Tag = "13";
                number13.Tag = "14";
                number14.Tag = "15";
                number15.Tag = "16";

            }


        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (sum == 0)
            {
                howplayer = textBox1.Text;
                textBox1.Text = "";
                label1.Text = "inter char1 :";

            }

            if (sum == 1)
            {
                charekter1 = textBox1.Text;
                textBox1.Text = "";
                label1.Text = "inter char2 :";

            }

            if (howplayer == "1")
            {
                if (sum == 2)
                {
                    charekter2 = textBox1.Text;
                    textBox1.Text = "";
                    label1.Text = "name player 1 :";

                }
                else if (sum == 3)
                {
                    playername1 = textBox1.Text;
                    textBox1.Text = "";
                    label1.Text = "name player 2:";

                }
            }

            if (howplayer == "2")
            {
                if (sum == 2)
                {
                    charekter2 = textBox1.Text;
                    textBox1.Text = "";
                    label1.Text = "name player 1 :";

                }
                else if (sum == 3)
                {
                    playername1 = textBox1.Text;
                    textBox1.Text = "";
                    label1.Text = "name player 2:";

                }
            }

            if (howplayer == "3")
            {

                if (sum == 2)
                {
                    charekter2 = textBox1.Text;
                    textBox1.Text = "";
                    label1.Text = "inter char 3 :";

                }
                else if (sum == 3)
                {
                    charekter3 = textBox1.Text;
                    textBox1.Text = "";
                    label1.Text = "nmae player 1 :";

                }
                else if (sum == 4)
                {
                    playername1 = textBox1.Text;
                    textBox1.Text = "";
                    label1.Text = "name player 2 :";

                }

            }

            if (howplayer == "4")
            {

                if (sum == 2)
                {
                    charekter2 = textBox1.Text;
                    textBox1.Text = "";
                    label1.Text = "inter char 3 :";

                }
                else if (sum == 3)
                {
                    charekter3 = textBox1.Text;
                    textBox1.Text = "";
                    label1.Text = "inter char 4 :";

                }
                else if (sum == 4)
                {
                    charekter4 = textBox1.Text;
                    textBox1.Text = "";
                    label1.Text = "name player 1 :";

                }
                else if (sum == 5)
                {
                    playername1 = textBox1.Text;
                    textBox1.Text = "";
                    label1.Text = "name player 2 :";

                }
            }

            if (howplayer == "1")
            {
                if (sum == 4)
                {
                    textBox1.Hide();
                    label1.Hide();
                    OK.Hide();
                    label3.Show();
                    label2.Show();
                    Reast.Show();
                    Taghalob.Show();
                    Timer.Show();
                    number0.Show(); number1.Show(); number2.Show(); number3.Show(); number4.Show(); number5.Show(); number6.Show(); number7.Show(); number8.Show(); number9.Show(); number10.Show(); number11.Show(); number12.Show(); number13.Show(); number14.Show(); number15.Show();
                    playername2 = textBox1.Text;
                    textBox1.Text = " ";
                    label1.Text = " ";
                    labelname.Text = "player1 : " + playername1 + "\n" + "player2 : " + playername2;

                    label2.Text = playername1 + " : " + Player1sum + "\n" + playername2 + " : " + Player2sum;

                }
            }

            if (howplayer == "2")
            {
                if (sum == 4)
                {
                    textBox1.Hide();
                    label1.Hide();
                    OK.Hide();
                    label3.Show();
                    label2.Show();
                    Reast.Show();
                    Taghalob.Show();
                    Timer.Show();
                    number0.Show(); number1.Show(); number2.Show(); number3.Show(); number4.Show(); number5.Show(); number6.Show(); number7.Show(); number8.Show(); number9.Show(); number10.Show(); number11.Show(); number12.Show(); number13.Show(); number14.Show(); number15.Show();
                    playername2 = textBox1.Text;
                    textBox1.Text = " ";
                    label1.Text = " ";
                    labelname.Text = "player1 : " + playername1 + "\n" + "player2 : " + playername2;

                    label2.Text = playername1 + " : " + Player1sum + "\n" + playername2 + " : " + Player2sum;

                }
            }

            if (howplayer == "3")
            {

                if (sum == 5)
                {
                    playername2 = textBox1.Text;
                    textBox1.Text = "";
                    label1.Text = "name player 3 :";

                }

                else if (sum == 6)

                {
                    textBox1.Hide();
                    label1.Hide();
                    OK.Hide();
                    label3.Show();
                    label2.Show();
                    Reast.Show();
                    Taghalob.Show();
                    Timer.Show();
                    number0.Show(); number1.Show(); number2.Show(); number3.Show(); number4.Show(); number5.Show(); number6.Show(); number7.Show(); number8.Show(); number9.Show(); number10.Show(); number11.Show(); number12.Show(); number13.Show(); number14.Show(); number15.Show();
                    playername3 = textBox1.Text;
                    textBox1.Text = " ";
                    label1.Text = " ";
                    labelname.Text = "player1 : " + playername1 + "\n" + "player2 : " + playername2 + "\n" + "player3 : " + playername3;

                    label2.Text = playername1 + " : " + Player1sum + "\n" + playername2 + " : " + Player2sum + "\n" + playername3 + " : " + Player3sum;

                }
            }

            if (howplayer == "4")
            {
                if (sum == 6)
                {
                    playername2 = textBox1.Text;
                    textBox1.Text = "";
                    label1.Text = "name player 3 :";

                }

                else if (sum == 7)
                {
                    playername3 = textBox1.Text;
                    textBox1.Text = "";
                    label1.Text = "name player 4 :";

                }

                else if (sum == 8)

                {
                    textBox1.Hide();
                    label1.Hide();
                    OK.Hide();
                    label3.Show();
                    label2.Show();
                    Reast.Show();
                    Taghalob.Show();
                    Timer.Show();
                    number0.Show(); number1.Show(); number2.Show(); number3.Show(); number4.Show(); number5.Show(); number6.Show(); number7.Show(); number8.Show(); number9.Show(); number10.Show(); number11.Show(); number12.Show(); number13.Show(); number14.Show(); number15.Show();
                    playername4 = textBox1.Text;
                    textBox1.Text = " ";
                    label1.Text = " ";
                    labelname.Text = "player1 : " + playername1 + "\n" + "player2 : " + playername2 + "\n" + "player3 : " + playername3 + "\n" + "player4 : " + playername4;

                    label2.Text = playername1 + " : " + Player1sum + "\n" + playername2 + " : " + Player2sum + "\n" + playername3 + " : " + Player3sum + "\n" + playername4 + " : " + Player4sum;

                }
            }

            sum++;
        }

        private void Form3_Load_1(object sender, EventArgs e)
        {
            number0.Hide(); number1.Hide(); number2.Hide(); number3.Hide(); number4.Hide(); number5.Hide(); number6.Hide(); number7.Hide(); number8.Hide(); number9.Hide(); number10.Hide(); number11.Hide(); number12.Hide(); number13.Hide(); number14.Hide(); number15.Hide();
            label3.Hide();
            label2.Hide();
            Reast.Hide();
            Taghalob.Hide();
            Timer.Hide();
        }

        private void Reast_Click(object sender, EventArgs e)
        {
            number0.Text = "";
            number1.Text = "";
            number2.Text = "";
            number3.Text = "";
            number4.Text = "";
            number5.Text = "";
            number6.Text = "";
            number7.Text = "";
            number8.Text = "";
            number9.Text = "";
            number10.Text = "";
            number11.Text = "";
            number12.Text = "";
            number13.Text = "";
            number14.Text = "";
            number15.Text = "";

            number0.Tag = "1";
            number1.Tag = "2";
            number2.Tag = "3";
            number3.Tag = "4";
            number4.Tag = "5";
            number5.Tag = "6";
            number6.Tag = "7";
            number7.Tag = "8";
            number8.Tag = "9";
            number9.Tag = "10";
            number10.Tag = "11";
            number11.Tag = "12";
            number12.Tag = "13";
            number13.Tag = "14";
            number14.Tag = "15";
            number15.Tag = "16";

            sum = 0;
        }

        private void Mytimer_Tick(object sender, EventArgs e)
        {
            if (timer)
            {
                finish = false;
            }


        }

        private void timer_Click(object sender, EventArgs e)
        {

            if (timersum % 2 == 0)
            {
                timer = true;

                Mytimer.Stop();
                Mytimer.Start();

                Mytimer.Start();


            }
            else
            {
                timer = false;

                Mytimer.Stop();
                Mytimer.Start();
            }
            timersum++;
        }

        private void Taghalob_Click(object sender, EventArgs e)
        {


            if ((nobat == 4 && howplayer == "4") || (nobat == 3 && howplayer == "3") || (nobat == 2 && howplayer == "2"))
            {

                if ((number1.Text == charekter1 && number2.Text == charekter1 && number0.Tag == "1") || (number0.Text == charekter1 && number1.Text == charekter1 && number0.Tag == "1") || (number5.Text == charekter1 && number10.Text == charekter1 && number0.Tag == "1") || (number4.Text == charekter1 && number8.Text == charekter1 && number0.Tag == "1"))
                {

                    MessageBox.Show("1");

                }

                else if ((number2.Text == charekter1 && number3.Text == charekter1 && number1.Tag == "2") || (number5.Text == charekter1 && number9.Text == charekter1 && number1.Tag == "2") || (number6.Text == charekter1 && number11.Text == charekter1 && number1.Tag == "2") || (number0.Text == charekter1 && number2.Text == charekter1 && number1.Tag == "2"))
                {

                    MessageBox.Show("2");

                }

                else if ((number5.Text == charekter1 && number8.Text == charekter1 && number2.Tag == "3") || (number0.Text == charekter1 && number1.Text == charekter1 && number2.Tag == "3") || (number1.Text == charekter1 && number3.Text == charekter1 && number2.Tag == "3") || (number6.Text == charekter1 && number10.Text == charekter1 && number2.Tag == "3"))
                {

                    MessageBox.Show("3");

                }

                else if ((number1.Text == charekter1 && number2.Text == charekter1 && number3.Tag == "4") || (number7.Text == charekter1 && number11.Text == charekter1 && number3.Tag == "4") || (number6.Text == charekter1 && number9.Text == charekter1 && number3.Tag == "4"))
                {

                    MessageBox.Show("4");

                }

                else if ((number5.Text == charekter1 && number6.Text == charekter1 && number4.Tag == "5") || (number0.Text == charekter1 && number8.Text == charekter1 && number4.Tag == "5") || (number8.Text == charekter1 && number12.Text == charekter1 && number4.Tag == "5") || (number10.Text == charekter1 && number13.Text == charekter1 && number4.Tag == "5") || (number9.Text == charekter1 && number14.Text == charekter1 && number4.Tag == "5"))
                {

                    MessageBox.Show("5");

                }

                else if ((number6.Text == charekter1 && number7.Text == charekter1 && number5.Tag == "6") || (number0.Text == charekter1 && number10.Text == charekter1 && number5.Tag == "6") || (number1.Text == charekter1 && number9.Text == charekter1 && number5.Tag == "6") || (number1.Text == charekter1 && number9.Text == charekter1 && number5.Tag == "6") || (number9.Text == charekter1 && number13.Text == charekter1 && number5.Tag == "6") || (number10.Text == charekter1 && number15.Text == charekter1 && number5.Tag == "6") || (number2.Text == charekter1 && number8.Text == charekter1 && number5.Tag == "6") || (number6.Text == charekter1 && number4.Text == charekter1 && number5.Tag == "6"))
                {

                    MessageBox.Show("6");

                }

                else if ((number5.Text == charekter1 && number7.Text == charekter1 && number6.Tag == "7") || (number4.Text == charekter1 && number5.Text == charekter1 && number6.Tag == "7") || (number2.Text == charekter1 && number10.Text == charekter1 && number6.Tag == "7") || (number10.Text == charekter1 && number14.Text == charekter1 && number6.Tag == "7") || (number3.Text == charekter1 && number9.Text == charekter1 && number6.Tag == "7") || (number1.Text == charekter1 && number11.Text == charekter1 && number6.Tag == "7") || (number9.Text == charekter1 && number12.Text == charekter1 && number6.Tag == "7"))
                {

                    MessageBox.Show("7");

                }

                else if ((number5.Text == charekter1 && number6.Text == charekter1 && number7.Tag == "8") || (number3.Text == charekter1 && number11.Text == charekter1 && number7.Tag == "8") || (number11.Text == charekter1 && number15.Text == charekter1 && number7.Tag == "8"))
                {

                    MessageBox.Show("8");

                }

                else if ((number2.Text == charekter1 && number5.Text == charekter1 && number8.Tag == "9") || (number9.Text == charekter1 && number10.Text == charekter1 && number8.Tag == "9") || (number4.Text == charekter1 && number12.Text == charekter1 && number8.Tag == "9"))
                {

                    MessageBox.Show("9");

                }

                else if ((number10.Text == charekter1 && number11.Text == charekter1 && number9.Tag == "10") || (number4.Text == charekter1 && number14.Text == charekter1 && number9.Tag == "10") || (number6.Text == charekter1 && number12.Text == charekter1 && number9.Tag == "10") || (number8.Text == charekter1 && number10.Text == charekter1 && number9.Tag == "10") || (number1.Text == charekter1 && number5.Text == charekter1 && number9.Tag == "10") || (number5.Text == charekter1 && number13.Text == charekter1 && number9.Tag == "10") || (number3.Text == charekter1 && number6.Text == charekter1 && number9.Tag == "10"))
                {

                    MessageBox.Show("10");

                }

                else if ((number8.Text == charekter1 && number9.Text == charekter1 && number10.Tag == "11") || (number9.Text == charekter1 && number11.Text == charekter1 && number10.Tag == "11") || (number0.Text == charekter1 && number5.Text == charekter1 && number10.Tag == "11") || (number6.Text == charekter1 && number14.Text == charekter1 && number10.Tag == "11") || (number2.Text == charekter1 && number6.Text == charekter1 && number10.Tag == "11") || (number5.Text == charekter1 && number15.Text == charekter1 && number10.Tag == "11") || (number4.Text == charekter1 && number13.Text == charekter1 && number10.Tag == "11"))
                {

                    MessageBox.Show("11");

                }

                else if ((number1.Text == charekter1 && number6.Text == charekter1 && number11.Tag == "12") || (number9.Text == charekter1 && number10.Text == charekter1 && number11.Tag == "12") || (number3.Text == charekter1 && number7.Text == charekter1 && number11.Tag == "12") || (number7.Text == charekter1 && number15.Text == charekter1 && number11.Tag == "12"))
                {

                    MessageBox.Show("12");

                }

                else if ((number6.Text == charekter1 && number9.Text == charekter1 && number12.Tag == "13") || (number13.Text == charekter1 && number14.Text == charekter1 && number12.Tag == "13") || (number4.Text == charekter1 && number8.Text == charekter1 && number12.Tag == "13"))
                {

                    MessageBox.Show("13");

                }

                else if ((number4.Text == charekter1 && number10.Text == charekter1 && number13.Tag == "14") || (number12.Text == charekter1 && number14.Text == charekter1 && number13.Tag == "14") || (number14.Text == charekter1 && number15.Text == charekter1 && number13.Tag == "14") || (number5.Text == charekter1 && number9.Text == charekter1 && number13.Tag == "14"))
                {

                    MessageBox.Show("14");

                }

                else if ((number4.Text == charekter1 && number9.Text == charekter1 && number14.Tag == "15") || (number12.Text == charekter1 && number13.Text == charekter1 && number14.Tag == "15") || (number13.Text == charekter1 && number15.Text == charekter1 && number14.Tag == "15") || (number6.Text == charekter1 && number10.Text == charekter1 && number14.Tag == "15"))
                {

                    MessageBox.Show("15");

                }

                else if ((number13.Text == charekter1 && number14.Text == charekter1 && number15.Tag == "16") || (number7.Text == charekter1 && number11.Text == charekter1 && number15.Tag == "16") || (number5.Text == charekter1 && number10.Text == charekter1 && number15.Tag == "16"))
                {

                    MessageBox.Show("16");

                }

                else
                {
                    MessageBox.Show("continue the game");
                }
            }

            else if (nobat == 1)
            {


                if ((number1.Text == charekter2 && number2.Text == charekter2 && number0.Tag == "1") || (number0.Text == charekter2 && number1.Text == charekter2 && number0.Tag == "1") || (number5.Text == charekter2 && number10.Text == charekter2 && number0.Tag == "1") || (number4.Text == charekter2 && number8.Text == charekter2 && number0.Tag == "1"))
                {

                    MessageBox.Show("1");

                }

                else if ((number2.Text == charekter2 && number3.Text == charekter2 && number1.Tag == "2") || (number5.Text == charekter2 && number9.Text == charekter2 && number1.Tag == "2") || (number6.Text == charekter2 && number11.Text == charekter2 && number1.Tag == "2") || (number0.Text == charekter2 && number2.Text == charekter2 && number1.Tag == "2"))
                {

                    MessageBox.Show("2");

                }

                else if ((number5.Text == charekter2 && number8.Text == charekter2 && number2.Tag == "3") || (number0.Text == charekter2 && number1.Text == charekter2 && number2.Tag == "3") || (number1.Text == charekter2 && number3.Text == charekter2 && number2.Tag == "3") || (number6.Text == charekter2 && number10.Text == charekter2 && number2.Tag == "3"))
                {

                    MessageBox.Show("3");

                }

                else if ((number1.Text == charekter2 && number2.Text == charekter2 && number3.Tag == "4") || (number7.Text == charekter2 && number11.Text == charekter2 && number3.Tag == "4") || (number6.Text == charekter2 && number9.Text == charekter2 && number3.Tag == "4"))
                {

                    MessageBox.Show("4");

                }

                else if ((number5.Text == charekter2 && number6.Text == charekter2 && number4.Tag == "5") || (number0.Text == charekter2 && number8.Text == charekter2 && number4.Tag == "5") || (number8.Text == charekter2 && number12.Text == charekter2 && number4.Tag == "5") || (number10.Text == charekter2 && number13.Text == charekter2 && number4.Tag == "5") || (number9.Text == charekter2 && number14.Text == charekter2 && number4.Tag == "5"))
                {

                    MessageBox.Show("5");

                }

                else if ((number6.Text == charekter2 && number7.Text == charekter2 && number5.Tag == "6") || (number0.Text == charekter2 && number10.Text == charekter2 && number5.Tag == "6") || (number1.Text == charekter2 && number9.Text == charekter2 && number5.Tag == "6") || (number1.Text == charekter2 && number9.Text == charekter2 && number5.Tag == "6") || (number9.Text == charekter2 && number13.Text == charekter2 && number5.Tag == "6") || (number10.Text == charekter2 && number15.Text == charekter2 && number5.Tag == "6") || (number2.Text == charekter2 && number8.Text == charekter2 && number5.Tag == "6") || (number6.Text == charekter2 && number4.Text == charekter2 && number5.Tag == "6"))
                {

                    MessageBox.Show("6");

                }

                else if ((number5.Text == charekter2 && number7.Text == charekter2 && number6.Tag == "7") || (number4.Text == charekter2 && number5.Text == charekter2 && number6.Tag == "7") || (number2.Text == charekter2 && number10.Text == charekter2 && number6.Tag == "7") || (number10.Text == charekter2 && number14.Text == charekter2 && number6.Tag == "7") || (number3.Text == charekter2 && number9.Text == charekter2 && number6.Tag == "7") || (number1.Text == charekter2 && number11.Text == charekter2 && number6.Tag == "7") || (number9.Text == charekter2 && number12.Text == charekter2 && number6.Tag == "7"))
                {

                    MessageBox.Show("7");

                }

                else if ((number5.Text == charekter2 && number6.Text == charekter2 && number7.Tag == "8") || (number3.Text == charekter2 && number11.Text == charekter2 && number7.Tag == "8") || (number11.Text == charekter2 && number15.Text == charekter2 && number7.Tag == "8"))
                {

                    MessageBox.Show("8");

                }

                else if ((number2.Text == charekter2 && number5.Text == charekter2 && number8.Tag == "9") || (number9.Text == charekter2 && number10.Text == charekter2 && number8.Tag == "9") || (number4.Text == charekter2 && number12.Text == charekter2 && number8.Tag == "9"))
                {

                    MessageBox.Show("9");

                }

                else if ((number10.Text == charekter2 && number11.Text == charekter2 && number9.Tag == "10") || (number4.Text == charekter2 && number14.Text == charekter2 && number9.Tag == "10") || (number6.Text == charekter2 && number12.Text == charekter2 && number9.Tag == "10") || (number8.Text == charekter2 && number10.Text == charekter2 && number9.Tag == "10") || (number1.Text == charekter2 && number5.Text == charekter2 && number9.Tag == "10") || (number5.Text == charekter2 && number13.Text == charekter2 && number9.Tag == "10") || (number3.Text == charekter2 && number6.Text == charekter2 && number9.Tag == "10"))
                {

                    MessageBox.Show("10");

                }

                else if ((number8.Text == charekter2 && number9.Text == charekter2 && number10.Tag == "11") || (number9.Text == charekter2 && number11.Text == charekter2 && number10.Tag == "11") || (number0.Text == charekter2 && number5.Text == charekter2 && number10.Tag == "11") || (number6.Text == charekter2 && number14.Text == charekter2 && number10.Tag == "11") || (number2.Text == charekter2 && number6.Text == charekter2 && number10.Tag == "11") || (number5.Text == charekter2 && number15.Text == charekter2 && number10.Tag == "11") || (number4.Text == charekter2 && number13.Text == charekter2 && number10.Tag == "11"))
                {

                    MessageBox.Show("11");

                }

                else if ((number1.Text == charekter2 && number6.Text == charekter2 && number11.Tag == "12") || (number9.Text == charekter2 && number10.Text == charekter2 && number11.Tag == "12") || (number3.Text == charekter2 && number7.Text == charekter2 && number11.Tag == "12") || (number7.Text == charekter2 && number15.Text == charekter2 && number11.Tag == "12"))
                {

                    MessageBox.Show("12");

                }

                else if ((number6.Text == charekter2 && number9.Text == charekter2 && number12.Tag == "13") || (number13.Text == charekter2 && number14.Text == charekter2 && number12.Tag == "13") || (number4.Text == charekter2 && number8.Text == charekter2 && number12.Tag == "13"))
                {

                    MessageBox.Show("13");

                }

                else if ((number4.Text == charekter2 && number10.Text == charekter2 && number13.Tag == "14") || (number12.Text == charekter2 && number14.Text == charekter2 && number13.Tag == "14") || (number14.Text == charekter2 && number15.Text == charekter2 && number13.Tag == "14") || (number5.Text == charekter2 && number9.Text == charekter2 && number13.Tag == "14"))
                {

                    MessageBox.Show("14");

                }

                else if ((number4.Text == charekter2 && number9.Text == charekter2 && number14.Tag == "15") || (number12.Text == charekter2 && number13.Text == charekter2 && number14.Tag == "15") || (number13.Text == charekter2 && number15.Text == charekter2 && number14.Tag == "15") || (number6.Text == charekter2 && number10.Text == charekter2 && number14.Tag == "15"))
                {

                    MessageBox.Show("15");

                }

                else if ((number13.Text == charekter2 && number14.Text == charekter2 && number15.Tag == "16") || (number7.Text == charekter2 && number11.Text == charekter2 && number15.Tag == "16") || (number5.Text == charekter2 && number10.Text == charekter2 && number15.Tag == "16"))
                {

                    MessageBox.Show("16");

                }

                else
                {
                    MessageBox.Show("continue the game");
                }


            }

            else if ((nobat == 2 && howplayer == "4") || (nobat == 2 && howplayer == "3"))
            {

                if ((number1.Text == charekter3 && number2.Text == charekter3 && number0.Tag == "1") || (number0.Text == charekter3 && number1.Text == charekter3 && number0.Tag == "1") || (number5.Text == charekter3 && number10.Text == charekter3 && number0.Tag == "1") || (number4.Text == charekter3 && number8.Text == charekter3 && number0.Tag == "1"))
                {

                    MessageBox.Show("1");

                }

                else if ((number2.Text == charekter3 && number3.Text == charekter3 && number1.Tag == "2") || (number5.Text == charekter3 && number9.Text == charekter3 && number1.Tag == "2") || (number6.Text == charekter3 && number11.Text == charekter3 && number1.Tag == "2") || (number0.Text == charekter3 && number2.Text == charekter3 && number1.Tag == "2"))
                {

                    MessageBox.Show("2");

                }

                else if ((number5.Text == charekter3 && number8.Text == charekter3 && number2.Tag == "3") || (number0.Text == charekter3 && number1.Text == charekter3 && number2.Tag == "3") || (number1.Text == charekter3 && number3.Text == charekter3 && number2.Tag == "3") || (number6.Text == charekter3 && number10.Text == charekter3 && number2.Tag == "3"))
                {

                    MessageBox.Show("3");

                }

                else if ((number1.Text == charekter3 && number2.Text == charekter3 && number3.Tag == "4") || (number7.Text == charekter3 && number11.Text == charekter3 && number3.Tag == "4") || (number6.Text == charekter3 && number9.Text == charekter3 && number3.Tag == "4"))
                {

                    MessageBox.Show("4");

                }

                else if ((number5.Text == charekter3 && number6.Text == charekter3 && number4.Tag == "5") || (number0.Text == charekter3 && number8.Text == charekter3 && number4.Tag == "5") || (number8.Text == charekter3 && number12.Text == charekter3 && number4.Tag == "5") || (number10.Text == charekter3 && number13.Text == charekter3 && number4.Tag == "5") || (number9.Text == charekter3 && number14.Text == charekter3 && number4.Tag == "5"))
                {

                    MessageBox.Show("5");

                }

                else if ((number6.Text == charekter3 && number7.Text == charekter3 && number5.Tag == "6") || (number0.Text == charekter3 && number10.Text == charekter3 && number5.Tag == "6") || (number1.Text == charekter3 && number9.Text == charekter3 && number5.Tag == "6") || (number1.Text == charekter3 && number9.Text == charekter3 && number5.Tag == "6") || (number9.Text == charekter3 && number13.Text == charekter3 && number5.Tag == "6") || (number10.Text == charekter3 && number15.Text == charekter3 && number5.Tag == "6") || (number2.Text == charekter3 && number8.Text == charekter3 && number5.Tag == "6") || (number6.Text == charekter3 && number4.Text == charekter3 && number5.Tag == "6"))
                {

                    MessageBox.Show("6");

                }

                else if ((number5.Text == charekter3 && number7.Text == charekter3 && number6.Tag == "7") || (number4.Text == charekter3 && number5.Text == charekter3 && number6.Tag == "7") || (number2.Text == charekter3 && number10.Text == charekter3 && number6.Tag == "7") || (number10.Text == charekter3 && number14.Text == charekter3 && number6.Tag == "7") || (number3.Text == charekter3 && number9.Text == charekter3 && number6.Tag == "7") || (number1.Text == charekter3 && number11.Text == charekter3 && number6.Tag == "7") || (number9.Text == charekter3 && number12.Text == charekter3 && number6.Tag == "7"))
                {

                    MessageBox.Show("7");

                }

                else if ((number5.Text == charekter3 && number6.Text == charekter3 && number7.Tag == "8") || (number3.Text == charekter3 && number11.Text == charekter3 && number7.Tag == "8") || (number11.Text == charekter3 && number15.Text == charekter3 && number7.Tag == "8"))
                {

                    MessageBox.Show("8");

                }

                else if ((number2.Text == charekter3 && number5.Text == charekter3 && number8.Tag == "9") || (number9.Text == charekter3 && number10.Text == charekter3 && number8.Tag == "9") || (number4.Text == charekter3 && number12.Text == charekter3 && number8.Tag == "9"))
                {

                    MessageBox.Show("9");

                }

                else if ((number10.Text == charekter3 && number11.Text == charekter3 && number9.Tag == "10") || (number4.Text == charekter3 && number14.Text == charekter3 && number9.Tag == "10") || (number6.Text == charekter3 && number12.Text == charekter3 && number9.Tag == "10") || (number8.Text == charekter3 && number10.Text == charekter3 && number9.Tag == "10") || (number1.Text == charekter3 && number5.Text == charekter3 && number9.Tag == "10") || (number5.Text == charekter3 && number13.Text == charekter3 && number9.Tag == "10") || (number3.Text == charekter3 && number6.Text == charekter3 && number9.Tag == "10"))
                {

                    MessageBox.Show("10");

                }

                else if ((number8.Text == charekter3 && number9.Text == charekter3 && number10.Tag == "11") || (number9.Text == charekter3 && number11.Text == charekter3 && number10.Tag == "11") || (number0.Text == charekter3 && number5.Text == charekter3 && number10.Tag == "11") || (number6.Text == charekter3 && number14.Text == charekter3 && number10.Tag == "11") || (number2.Text == charekter3 && number6.Text == charekter3 && number10.Tag == "11") || (number5.Text == charekter3 && number15.Text == charekter3 && number10.Tag == "11") || (number4.Text == charekter3 && number13.Text == charekter3 && number10.Tag == "11"))
                {

                    MessageBox.Show("11");

                }

                else if ((number1.Text == charekter3 && number6.Text == charekter3 && number11.Tag == "12") || (number9.Text == charekter3 && number10.Text == charekter3 && number11.Tag == "12") || (number3.Text == charekter3 && number7.Text == charekter3 && number11.Tag == "12") || (number7.Text == charekter3 && number15.Text == charekter3 && number11.Tag == "12"))
                {

                    MessageBox.Show("12");

                }

                else if ((number6.Text == charekter3 && number9.Text == charekter3 && number12.Tag == "13") || (number13.Text == charekter3 && number14.Text == charekter3 && number12.Tag == "13") || (number4.Text == charekter3 && number8.Text == charekter3 && number12.Tag == "13"))
                {

                    MessageBox.Show("13");

                }

                else if ((number4.Text == charekter3 && number10.Text == charekter3 && number13.Tag == "14") || (number12.Text == charekter3 && number14.Text == charekter3 && number13.Tag == "14") || (number14.Text == charekter3 && number15.Text == charekter3 && number13.Tag == "14") || (number5.Text == charekter3 && number9.Text == charekter3 && number13.Tag == "14"))
                {

                    MessageBox.Show("14");

                }

                else if ((number4.Text == charekter3 && number9.Text == charekter3 && number14.Tag == "15") || (number12.Text == charekter3 && number13.Text == charekter3 && number14.Tag == "15") || (number13.Text == charekter3 && number15.Text == charekter3 && number14.Tag == "15") || (number6.Text == charekter3 && number10.Text == charekter3 && number14.Tag == "15"))
                {

                    MessageBox.Show("15");

                }

                else if ((number13.Text == charekter3 && number14.Text == charekter3 && number15.Tag == "16") || (number7.Text == charekter3 && number11.Text == charekter3 && number15.Tag == "16") || (number5.Text == charekter3 && number10.Text == charekter3 && number15.Tag == "16"))
                {

                    MessageBox.Show("16");

                }

                else
                {
                    MessageBox.Show("continue the game");
                }

            }

            else if (nobat == 3 && howplayer == "4")
            {

                if ((number1.Text == charekter4 && number2.Text == charekter4 && number0.Tag == "1") || (number0.Text == charekter4 && number1.Text == charekter4 && number0.Tag == "1") || (number5.Text == charekter4 && number10.Text == charekter4 && number0.Tag == "1") || (number4.Text == charekter4 && number8.Text == charekter3 && number0.Tag == "1"))
                {

                    MessageBox.Show("1");

                }

                else if ((number2.Text == charekter4 && number3.Text == charekter4 && number1.Tag == "2") || (number5.Text == charekter4 && number9.Text == charekter4 && number1.Tag == "2") || (number6.Text == charekter4 && number11.Text == charekter4 && number1.Tag == "2") || (number0.Text == charekter4 && number2.Text == charekter3 && number1.Tag == "2"))
                {

                    MessageBox.Show("2");

                }

                else if ((number5.Text == charekter4 && number8.Text == charekter4 && number2.Tag == "3") || (number0.Text == charekter4 && number1.Text == charekter4 && number2.Tag == "3") || (number1.Text == charekter4 && number3.Text == charekter4 && number2.Tag == "3") || (number6.Text == charekter4 && number10.Text == charekter3 && number2.Tag == "3"))
                {

                    MessageBox.Show("3");

                }

                else if ((number1.Text == charekter4 && number2.Text == charekter4 && number3.Tag == "4") || (number7.Text == charekter4 && number11.Text == charekter4 && number3.Tag == "4") || (number6.Text == charekter4 && number9.Text == charekter4 && number3.Tag == "4"))
                {

                    MessageBox.Show("4");

                }

                else if ((number5.Text == charekter4 && number6.Text == charekter4 && number4.Tag == "5") || (number0.Text == charekter4 && number8.Text == charekter4 && number4.Tag == "5") || (number8.Text == charekter4 && number12.Text == charekter4 && number4.Tag == "5") || (number10.Text == charekter4 && number13.Text == charekter4 && number4.Tag == "5") || (number9.Text == charekter4 && number14.Text == charekter4 && number4.Tag == "5"))
                {

                    MessageBox.Show("5");

                }

                else if ((number6.Text == charekter4 && number7.Text == charekter4 && number5.Tag == "6") || (number0.Text == charekter4 && number10.Text == charekter4 && number5.Tag == "6") || (number1.Text == charekter4 && number9.Text == charekter4 && number5.Tag == "6") || (number1.Text == charekter4 && number9.Text == charekter4 && number5.Tag == "6") || (number9.Text == charekter4 && number13.Text == charekter4 && number5.Tag == "6") || (number10.Text == charekter4 && number15.Text == charekter4 && number5.Tag == "6") || (number2.Text == charekter4 && number8.Text == charekter4 && number5.Tag == "6") || (number6.Text == charekter4 && number4.Text == charekter4 && number5.Tag == "6"))
                {

                    MessageBox.Show("6");

                }

                else if ((number5.Text == charekter4 && number7.Text == charekter4 && number6.Tag == "7") || (number4.Text == charekter4 && number5.Text == charekter4 && number6.Tag == "7") || (number2.Text == charekter4 && number10.Text == charekter4 && number6.Tag == "7") || (number10.Text == charekter4 && number14.Text == charekter4 && number6.Tag == "7") || (number3.Text == charekter4 && number9.Text == charekter4 && number6.Tag == "7") || (number1.Text == charekter4 && number11.Text == charekter4 && number6.Tag == "7") || (number9.Text == charekter4 && number12.Text == charekter4 && number6.Tag == "7"))
                {

                    MessageBox.Show("7");

                }

                else if ((number5.Text == charekter4 && number6.Text == charekter4 && number7.Tag == "8") || (number3.Text == charekter4 && number11.Text == charekter4 && number7.Tag == "8") || (number11.Text == charekter4 && number15.Text == charekter4 && number7.Tag == "8"))
                {

                    MessageBox.Show("8");

                }

                else if ((number2.Text == charekter4 && number5.Text == charekter4 && number8.Tag == "9") || (number9.Text == charekter4 && number10.Text == charekter4 && number8.Tag == "9") || (number4.Text == charekter4 && number12.Text == charekter4 && number8.Tag == "9"))
                {

                    MessageBox.Show("9");

                }

                else if ((number10.Text == charekter4 && number11.Text == charekter4 && number9.Tag == "10") || (number4.Text == charekter4 && number14.Text == charekter4 && number9.Tag == "10") || (number6.Text == charekter4 && number12.Text == charekter4 && number9.Tag == "10") || (number8.Text == charekter4 && number10.Text == charekter4 && number9.Tag == "10") || (number1.Text == charekter4 && number5.Text == charekter4 && number9.Tag == "10") || (number5.Text == charekter4 && number13.Text == charekter4 && number9.Tag == "10") || (number3.Text == charekter4 && number6.Text == charekter4 && number9.Tag == "10"))
                {

                    MessageBox.Show("10");

                }

                else if ((number8.Text == charekter4 && number9.Text == charekter4 && number10.Tag == "11") || (number9.Text == charekter4 && number11.Text == charekter4 && number10.Tag == "11") || (number0.Text == charekter4 && number5.Text == charekter4 && number10.Tag == "11") || (number6.Text == charekter4 && number14.Text == charekter4 && number10.Tag == "11") || (number2.Text == charekter4 && number6.Text == charekter4 && number10.Tag == "11") || (number5.Text == charekter4 && number15.Text == charekter4 && number10.Tag == "11") || (number4.Text == charekter4 && number13.Text == charekter4 && number10.Tag == "11"))
                {

                    MessageBox.Show("11");

                }

                else if ((number1.Text == charekter4 && number6.Text == charekter4 && number11.Tag == "12") || (number9.Text == charekter4 && number10.Text == charekter4 && number11.Tag == "12") || (number3.Text == charekter4 && number7.Text == charekter4 && number11.Tag == "12") || (number7.Text == charekter4 && number15.Text == charekter4 && number11.Tag == "12"))
                {

                    MessageBox.Show("12");

                }

                else if ((number6.Text == charekter4 && number9.Text == charekter4 && number12.Tag == "13") || (number13.Text == charekter4 && number14.Text == charekter4 && number12.Tag == "13") || (number4.Text == charekter4 && number8.Text == charekter4 && number12.Tag == "13"))
                {

                    MessageBox.Show("13");

                }

                else if ((number4.Text == charekter4 && number10.Text == charekter4 && number13.Tag == "14") || (number12.Text == charekter4 && number14.Text == charekter4 && number13.Tag == "14") || (number14.Text == charekter4 && number15.Text == charekter4 && number13.Tag == "14") || (number5.Text == charekter4 && number9.Text == charekter4 && number13.Tag == "14"))
                {

                    MessageBox.Show("14");

                }

                else if ((number4.Text == charekter4 && number9.Text == charekter4 && number14.Tag == "15") || (number12.Text == charekter4 && number13.Text == charekter4 && number14.Tag == "15") || (number13.Text == charekter4 && number15.Text == charekter4 && number14.Tag == "15") || (number6.Text == charekter4 && number10.Text == charekter4 && number14.Tag == "15"))
                {

                    MessageBox.Show("15");

                }

                else if ((number13.Text == charekter4 && number14.Text == charekter4 && number15.Tag == "16") || (number7.Text == charekter4 && number11.Text == charekter4 && number15.Tag == "16") || (number5.Text == charekter4 && number10.Text == charekter4 && number15.Tag == "16"))
                {

                    MessageBox.Show("16");

                }

                else
                {
                    MessageBox.Show("continue the game");
                }

            }
        }
    }
}
