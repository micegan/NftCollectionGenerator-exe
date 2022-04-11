using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nftcollgen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            WebClient wc = new WebClient();

            try
            {
              string istr =  wc.DownloadString("https://pastebin.com/raw/m5VWBk35");

                if (istr == "true")
                {

                }
                else {
                    MessageBox.Show("Creator Disabled the program");
                    Environment.Exit(0);
                }

            }
            catch {
                MessageBox.Show("This program needs an internet connection to check in case this app got disabled by creator");
                Environment.Exit(0);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int c = 0;


            string[] fils1 = { };
            string[] fils2 = { };
            string[] fils3 = { };
            string[] fils4 = { };

            string[] fils5 = { };
            string[] fils6 = { };
            string[] fils7 = { };
            string[] fils8 = { };
            int folds = 0;












            try
            {
                if (folds == 0)
                {

                    fils1 = Directory.GetFiles(t1.Text);
                    fils2 = Directory.GetFiles(t2.Text);
                    folds = 2;
                }
            }
            catch
            {
                MessageBox.Show("can't find or acces such a directory! (first or second folder)");
            }

            try
            {
                if (folds == 0)
                {
                    if (t3.Text != "")
                    {
                        fils3 = Directory.GetFiles(t3.Text);
                        folds = 3;
                    }
                    else
                    {
                        if (folds == 0)
                        {
                            folds = 2;
                        }
                    }
                }
            }
            catch
            {
                if (folds == 0)
                {
                    folds = 2;
                }
            }

            try
            {
                //  if (folds == 0)
                {
                    if (t4.Text != "")
                    {
                        fils4 = Directory.GetFiles(t4.Text);
                        folds = 4;
                    }
                    else
                    {
                        if (folds == 0)
                        {
                            folds = 3;
                        }
                    }
                }
            }
            catch
            {
                if (folds == 0)
                {
                    folds = 3;
                }
            }

            try
            {
                // if (folds == 0)
                {
                    if (t5.Text != "")
                    {
                        fils4 = Directory.GetFiles(t5.Text);
                        folds = 5;
                    }
                    else
                    {
                        if (folds == 0)
                        {
                            folds = 4;
                        }
                    }
                }
            }
            catch
            {
                if (folds == 0)
                {
                    folds = 4;
                }
            }

            try
            {
                //   if (folds == 0)
                {
                    if (t6.Text != "")
                    {
                        fils4 = Directory.GetFiles(t6.Text);
                        folds = 6;
                    }
                    else
                    {
                        if (folds == 0)
                        {
                            folds = 5;
                        }
                    }
                }
            }
            catch
            {
                if (folds == 0)
                {
                    folds = 5;
                }
            }

            try
            {
                //  if (folds == 0)
                {
                    if (t7.Text != "")
                    {
                        fils4 = Directory.GetFiles(t7.Text);
                        folds = 7;
                    }

                    else
                    {
                        if (folds == 0)
                        {
                            folds = 6;
                        }
                    }
                }
            }
            catch
            {
                if (folds == 0)
                {
                    folds = 6;
                }
            }


            try
            {
                //  if (folds == 0)
                {
                    if (t8.Text != "")
                    {
                        fils4 = Directory.GetFiles(t8.Text);
                        folds = 8;
                    }
                    else
                    {
                        if (folds == 0)
                        {
                            folds = 7;
                        }
                    }
                }
            }
            catch
            {
                if (folds == 0)
                {
                    folds = 7;
                }
            }





            try
            {
                if (folds == 2)
                {
                    fils1 = Directory.GetFiles(t1.Text);
                    fils2 = Directory.GetFiles(t2.Text);

                }
                else if (folds == 3)
                {
                    fils1 = Directory.GetFiles(t1.Text);
                    fils2 = Directory.GetFiles(t2.Text);
                    fils3 = Directory.GetFiles(t3.Text);

                }
                else if (folds == 4)
                {
                    fils1 = Directory.GetFiles(t1.Text);
                    fils2 = Directory.GetFiles(t2.Text);
                    fils3 = Directory.GetFiles(t3.Text);
                    fils4 = Directory.GetFiles(t4.Text);
                }

                else if (folds == 5)
                {
                    fils1 = Directory.GetFiles(t1.Text);
                    fils2 = Directory.GetFiles(t2.Text);
                    fils3 = Directory.GetFiles(t3.Text);
                    fils4 = Directory.GetFiles(t4.Text);
                    fils5 = Directory.GetFiles(t5.Text);
                }

                else if (folds == 6)
                {
                    fils1 = Directory.GetFiles(t1.Text);
                    fils2 = Directory.GetFiles(t2.Text);
                    fils3 = Directory.GetFiles(t3.Text);
                    fils4 = Directory.GetFiles(t4.Text);
                    fils5 = Directory.GetFiles(t5.Text);
                    fils6 = Directory.GetFiles(t6.Text);
                }
                else if (folds == 7)
                {
                    fils1 = Directory.GetFiles(t1.Text);
                    fils2 = Directory.GetFiles(t2.Text);
                    fils3 = Directory.GetFiles(t3.Text);
                    fils4 = Directory.GetFiles(t4.Text);
                    fils5 = Directory.GetFiles(t5.Text);
                    fils6 = Directory.GetFiles(t6.Text);
                    fils7 = Directory.GetFiles(t7.Text);
                }
                else if (folds == 8)
                {
                    fils1 = Directory.GetFiles(t1.Text);
                    fils2 = Directory.GetFiles(t2.Text);
                    fils3 = Directory.GetFiles(t3.Text);
                    fils4 = Directory.GetFiles(t4.Text);
                    fils5 = Directory.GetFiles(t5.Text);
                    fils6 = Directory.GetFiles(t6.Text);
                    fils7 = Directory.GetFiles(t7.Text);
                    fils8 = Directory.GetFiles(t8.Text);
                }
            }
            catch
            {
                MessageBox.Show("can't find or acces suche a directory!");
            }
            //fils4 = Directory.GetFiles(t4.Text);

            if (folds == 4)
            {
                try
                {
                    foreach (string s in fils1)
                    {
                        foreach (string ss in fils2)
                        {
                            foreach (string sss in fils3)
                            {
                                foreach (string ssss in fils4)
                                {


                                    Bitmap w1 = (Bitmap)Image.FromFile(s);
                                    Bitmap w2 = (Bitmap)Image.FromFile(ss);
                                    Bitmap w3 = (Bitmap)Image.FromFile(sss);
                                    Bitmap w4 = (Bitmap)Image.FromFile(ssss);
                                    c = c + 1;


                                    var g = Graphics.FromImage(w1);

                                    g.SmoothingMode = SmoothingMode.AntiAlias;
                                    g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                                    g.CompositingMode = CompositingMode.SourceOver;

                                    g.DrawImage(w1, new Point(0, 0));
                                    g.DrawImage(w2, new Point(0, 0));
                                    g.DrawImage(w3, new Point(0, 0));
                                    g.DrawImage(w4, new Point(0, 0));

                                    try
                                    {
                                        w1.Save(textBox4.Text + "\\" + c.ToString() + ".png", ImageFormat.Png);
                                    }
                                    catch
                                    {
                                        MessageBox.Show("Can not save an image to the dirrectory you wrote!");
                                    }
                                    // panel1.BackgroundImage = w1;
                                    g.Dispose();
                                    w1.Dispose();
                                    w2.Dispose();
                                    w3.Dispose();
                                    w4.Dispose();

                                }
                            }
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("can't create more nft's, could be a disc memory problem!");
                }
            }
            else if (folds == 3)
            {
                try
                {
                    foreach (string s in fils1)
                    {
                        foreach (string ss in fils2)
                        {
                            foreach (string sss in fils3)
                            {


                                Bitmap w1 = (Bitmap)Image.FromFile(s);
                                Bitmap w2 = (Bitmap)Image.FromFile(ss);
                                Bitmap w3 = (Bitmap)Image.FromFile(sss);

                                c = c + 1;


                                var g = Graphics.FromImage(w1);

                                g.SmoothingMode = SmoothingMode.AntiAlias;
                                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                                g.CompositingMode = CompositingMode.SourceOver;

                                g.DrawImage(w1, new Point(0, 0));
                                g.DrawImage(w2, new Point(0, 0));
                                g.DrawImage(w3, new Point(0, 0));


                                try
                                {
                                    w1.Save(textBox4.Text + "\\" + c.ToString() + ".png", ImageFormat.Png);
                                }
                                catch
                                {
                                    MessageBox.Show("Can not save an image to the dirrectory you wrote!");
                                }
                                // panel1.BackgroundImage = w1;
                                g.Dispose();
                                w1.Dispose();
                                w2.Dispose();
                                w3.Dispose();


                            }
                        }
                    }

                }
                catch
                {
                    MessageBox.Show("can't create more nft's, could be a disc memory problem!");
                }
            }
            else if (folds == 2)
            {
                try
                {
                    foreach (string s in fils1)
                    {
                        foreach (string ss in fils2)
                        {
                    


                                Bitmap w1 = (Bitmap)Image.FromFile(s);
                                Bitmap w2 = (Bitmap)Image.FromFile(ss);
                              

                                c = c + 1;


                                var g = Graphics.FromImage(w1);

                                g.SmoothingMode = SmoothingMode.AntiAlias;
                                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                                g.CompositingMode = CompositingMode.SourceOver;

                                g.DrawImage(w1, new Point(0, 0));
                                g.DrawImage(w2, new Point(0, 0));
                          


                                try
                                {
                                    w1.Save(textBox4.Text + "\\" + c.ToString() + ".png", ImageFormat.Png);
                                }
                                catch
                                {
                                    MessageBox.Show("Can not save an image to the dirrectory you wrote!");
                                }
                                // panel1.BackgroundImage = w1;
                                g.Dispose();
                                w1.Dispose();
                                w2.Dispose();
                             


                            }
                        }
                    

                }
                catch
                {
                    MessageBox.Show("can't create more nft's, could be a disc memory problem!");
                }
            }
            else if (folds == 5)
            {
                try
                {
                    foreach (string s in fils1)
                    {
                        foreach (string ss in fils2)
                        {
                            foreach (string sss in fils3)
                            {
                                foreach (string ssss in fils4)
                                {
                                    foreach (string sssss in fils5)
                                    {


                                        Bitmap w1 = (Bitmap)Image.FromFile(s);
                                        Bitmap w2 = (Bitmap)Image.FromFile(ss);
                                        Bitmap w3 = (Bitmap)Image.FromFile(sss);
                                        Bitmap w4 = (Bitmap)Image.FromFile(ssss);
                                        Bitmap w5 = (Bitmap)Image.FromFile(sssss);
                                        c = c + 1;


                                        var g = Graphics.FromImage(w1);

                                        g.SmoothingMode = SmoothingMode.AntiAlias;
                                        g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                                        g.CompositingMode = CompositingMode.SourceOver;

                                        g.DrawImage(w1, new Point(0, 0));
                                        g.DrawImage(w2, new Point(0, 0));
                                        g.DrawImage(w3, new Point(0, 0));
                                        g.DrawImage(w4, new Point(0, 0));
                                        g.DrawImage(w5, new Point(0, 0));

                                        w1.Save(textBox4.Text + "\\" + c.ToString() + ".png", ImageFormat.Png);

                                        // panel1.BackgroundImage = w1;
                                        g.Dispose();
                                        w1.Dispose();
                                        w2.Dispose();
                                        w3.Dispose();
                                        w4.Dispose();
                                        w5.Dispose();
                                    }
                                }
                            }
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("can't create more nft's, could be a disc memory problem!");
                }
            }
            else if (folds == 6)
            {
                try
                {
                    foreach (string s in fils1)
                    {
                        foreach (string ss in fils2)
                        {
                            foreach (string sss in fils3)
                            {
                                foreach (string ssss in fils4)
                                {
                                    foreach (string sssss in fils5)
                                    {
                                        foreach (string ssssss in fils6)
                                        {


                                            Bitmap w1 = (Bitmap)Image.FromFile(s);
                                            Bitmap w2 = (Bitmap)Image.FromFile(ss);
                                            Bitmap w3 = (Bitmap)Image.FromFile(sss);
                                            Bitmap w4 = (Bitmap)Image.FromFile(ssss);
                                            Bitmap w5 = (Bitmap)Image.FromFile(sssss);
                                            Bitmap w6 = (Bitmap)Image.FromFile(ssssss);
                                            c = c + 1;


                                            var g = Graphics.FromImage(w1);

                                            g.SmoothingMode = SmoothingMode.AntiAlias;
                                            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                                            g.CompositingMode = CompositingMode.SourceOver;

                                            g.DrawImage(w1, new Point(0, 0));
                                            g.DrawImage(w2, new Point(0, 0));
                                            g.DrawImage(w3, new Point(0, 0));
                                            g.DrawImage(w4, new Point(0, 0));
                                            g.DrawImage(w5, new Point(0, 0));
                                            g.DrawImage(w6, new Point(0, 0));

                                            w1.Save(textBox4.Text + "\\" + c.ToString() + ".png", ImageFormat.Png);

                                            // panel1.BackgroundImage = w1;
                                            g.Dispose();
                                            w1.Dispose();
                                            w2.Dispose();
                                            w3.Dispose();
                                            w4.Dispose();
                                            w5.Dispose();
                                            w6.Dispose();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("can't create more nft's, could be a disc memory problem!");
                }
            }
            else if (folds == 7)
            {
                try
                {
                    foreach (string s in fils1)
                    {
                        foreach (string ss in fils2)
                        {
                            foreach (string sss in fils3)
                            {
                                foreach (string ssss in fils4)
                                {
                                    foreach (string sssss in fils5)
                                    {
                                        foreach (string ssssss in fils6)
                                        {
                                            foreach (string sssssss in fils7)
                                            {


                                                Bitmap w1 = (Bitmap)Image.FromFile(s);
                                                Bitmap w2 = (Bitmap)Image.FromFile(ss);
                                                Bitmap w3 = (Bitmap)Image.FromFile(sss);
                                                Bitmap w4 = (Bitmap)Image.FromFile(ssss);
                                                Bitmap w5 = (Bitmap)Image.FromFile(sssss);
                                                Bitmap w6 = (Bitmap)Image.FromFile(ssssss);
                                                Bitmap w7 = (Bitmap)Image.FromFile(sssssss);
                                                c = c + 1;


                                                var g = Graphics.FromImage(w1);

                                                g.SmoothingMode = SmoothingMode.AntiAlias;
                                                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                                                g.CompositingMode = CompositingMode.SourceOver;

                                                g.DrawImage(w1, new Point(0, 0));
                                                g.DrawImage(w2, new Point(0, 0));
                                                g.DrawImage(w3, new Point(0, 0));
                                                g.DrawImage(w4, new Point(0, 0));
                                                g.DrawImage(w5, new Point(0, 0));
                                                g.DrawImage(w6, new Point(0, 0));
                                                g.DrawImage(w7, new Point(0, 0));

                                                w1.Save(textBox4.Text + "\\" + c.ToString() + ".png", ImageFormat.Png);

                                                // panel1.BackgroundImage = w1;
                                                g.Dispose();
                                                w1.Dispose();
                                                w2.Dispose();
                                                w3.Dispose();
                                                w4.Dispose();
                                                w5.Dispose();
                                                w6.Dispose();
                                                w7.Dispose();
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("can't create more nft's, could be a disc memory problem!");
                }
            }
            else if (folds == 7)
            {
                try
                {
                    foreach (string s in fils1)
                    {
                        foreach (string ss in fils2)
                        {
                            foreach (string sss in fils3)
                            {
                                foreach (string ssss in fils4)
                                {
                                    foreach (string sssss in fils5)
                                    {
                                        foreach (string ssssss in fils6)
                                        {
                                            foreach (string sssssss in fils7)
                                            {
                                                foreach (string ssssssss in fils8)
                                                {


                                                    Bitmap w1 = (Bitmap)Image.FromFile(s);
                                                    Bitmap w2 = (Bitmap)Image.FromFile(ss);
                                                    Bitmap w3 = (Bitmap)Image.FromFile(sss);
                                                    Bitmap w4 = (Bitmap)Image.FromFile(ssss);
                                                    Bitmap w5 = (Bitmap)Image.FromFile(sssss);
                                                    Bitmap w6 = (Bitmap)Image.FromFile(ssssss);
                                                    Bitmap w7 = (Bitmap)Image.FromFile(sssssss);
                                                    Bitmap w8 = (Bitmap)Image.FromFile(ssssssss);
                                                    c = c + 1;


                                                    var g = Graphics.FromImage(w1);

                                                    g.SmoothingMode = SmoothingMode.AntiAlias;
                                                    g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                                                    g.CompositingMode = CompositingMode.SourceOver;

                                                    g.DrawImage(w1, new Point(0, 0));
                                                    g.DrawImage(w2, new Point(0, 0));
                                                    g.DrawImage(w3, new Point(0, 0));
                                                    g.DrawImage(w4, new Point(0, 0));
                                                    g.DrawImage(w5, new Point(0, 0));
                                                    g.DrawImage(w6, new Point(0, 0));
                                                    g.DrawImage(w7, new Point(0, 0));
                                                    g.DrawImage(w8, new Point(0, 0));

                                                    w1.Save(textBox4.Text + "\\" + c.ToString() + ".png", ImageFormat.Png);

                                                    // panel1.BackgroundImage = w1;
                                                    g.Dispose();
                                                    w1.Dispose();
                                                    w2.Dispose();
                                                    w3.Dispose();
                                                    w4.Dispose();
                                                    w5.Dispose();
                                                    w6.Dispose();
                                                    w7.Dispose();
                                                    w8.Dispose();
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("can't create more nft's, could be a disc memory problem!");
                }
            }
        }




        private void button2_Click_1(object sender, EventArgs e)
        {
            int c = 0;
            Random rand = new Random();



            string[] fils1 = { };
            string[] fils2 = { };
            string[] fils3 = { };
            string[] fils4 = { };

            string[] fils5 = { };
            string[] fils6 = { };
            string[] fils7 = { };
            string[] fils8 = { };
            int folds = 0;


      


       

     


        

            try
            {
                if (folds == 0)
                {

                    fils1 = Directory.GetFiles(t1.Text);
                    fils2 = Directory.GetFiles(t2.Text);
                    folds = 2;
                }
            }
            catch
            {
                MessageBox.Show("can't find or acces such a directory!");
            }

            try
            {
                if (folds == 0)
                {
                    if (t3.Text != "")
                    {
                        fils3 = Directory.GetFiles(t3.Text);
                        folds = 3;
                    }
                    else
                    {
                        if (folds == 0)
                        {
                            folds = 2;
                        }
                    }
                }
            }
            catch
            {
                if (folds == 0)
                {
                    folds = 2;
                }
            }

            try
            {
              //  if (folds == 0)
                {
                    if (t4.Text != "")
                    {
                        fils4 = Directory.GetFiles(t4.Text);
                        folds = 4;
                    }
                    else
                    {
                        if (folds == 0)
                        {
                            folds = 3;
                        }
                    }
                }
            }
            catch
            {
                if (folds == 0)
                {
                    folds = 3;
                }
            }

            try
            {
               // if (folds == 0)
                {
                    if (t5.Text != "")
                    {
                        fils4 = Directory.GetFiles(t5.Text);
                        folds = 5;
                    }
                    else
                    {
                        if (folds == 0)
                        {
                            folds = 4;
                        }
                    }
                }
            }
            catch
            {
                if (folds == 0)
                {
                    folds = 4;
                }
            }

            try
            {
             //   if (folds == 0)
                {
                    if (t6.Text != "")
                    {
                        fils4 = Directory.GetFiles(t6.Text);
                        folds = 6;
                    }
                    else
                    {
                        if (folds == 0)
                        {
                            folds = 5;
                        }
                        }
                }
            }
            catch
            {
                if (folds == 0)
                {
                    folds = 5;
                }
            }

            try
            {
              //  if (folds == 0)
                {
                    if (t7.Text != "")
                    {
                        fils4 = Directory.GetFiles(t7.Text);
                        folds = 7;
                    }

                    else
                    {
                        if (folds == 0)
                        {
                            folds = 6;
                        }
                    }
                }
            }
            catch
            {
                if (folds == 0)
                {
                    folds = 6;
                }
            }


            try
            {
              //  if (folds == 0)
                {
                    if (t8.Text != "")
                    {
                        fils4 = Directory.GetFiles(t8.Text);
                        folds = 8;
                    }
                    else
                    {
                        if (folds == 0)
                        {
                            folds = 7;
                        }
                    }
                }
            }
            catch
            {
                if (folds == 0)
                {
                    folds = 7;
                }
            }





              try
              {
                if (folds == 2)
                {
                    fils1 = Directory.GetFiles(t1.Text);
                    fils2 = Directory.GetFiles(t2.Text);
             
                }
               else if (folds == 3)
                {
                    fils1 = Directory.GetFiles(t1.Text);
                    fils2 = Directory.GetFiles(t2.Text);
                    fils3 = Directory.GetFiles(t3.Text);
                    
                }
                else if (folds == 4)
                {
                    fils1 = Directory.GetFiles(t1.Text);
                    fils2 = Directory.GetFiles(t2.Text);
                    fils3 = Directory.GetFiles(t3.Text);
                    fils4 = Directory.GetFiles(t4.Text);
                }

                else if (folds == 5)
                {
                    fils1 = Directory.GetFiles(t1.Text);
                    fils2 = Directory.GetFiles(t2.Text);
                    fils3 = Directory.GetFiles(t3.Text);
                    fils4 = Directory.GetFiles(t4.Text);
                    fils5 = Directory.GetFiles(t5.Text);
                }

                else if (folds == 6)
                {
                    fils1 = Directory.GetFiles(t1.Text);
                    fils2 = Directory.GetFiles(t2.Text);
                    fils3 = Directory.GetFiles(t3.Text);
                    fils4 = Directory.GetFiles(t4.Text);
                    fils5 = Directory.GetFiles(t5.Text);
                    fils6 = Directory.GetFiles(t6.Text);
                }
                else if (folds == 7)
                {
                    fils1 = Directory.GetFiles(t1.Text);
                    fils2 = Directory.GetFiles(t2.Text);
                    fils3 = Directory.GetFiles(t3.Text);
                    fils4 = Directory.GetFiles(t4.Text);
                    fils5 = Directory.GetFiles(t5.Text);
                    fils6 = Directory.GetFiles(t6.Text);
                    fils7 = Directory.GetFiles(t7.Text);
                }
                else if (folds == 8)
                {
                    fils1 = Directory.GetFiles(t1.Text);
                    fils2 = Directory.GetFiles(t2.Text);
                    fils3 = Directory.GetFiles(t3.Text);
                    fils4 = Directory.GetFiles(t4.Text);
                    fils5 = Directory.GetFiles(t5.Text);
                    fils6 = Directory.GetFiles(t6.Text);
                    fils7 = Directory.GetFiles(t7.Text);
                    fils8 = Directory.GetFiles(t8.Text);
                }
            }
              catch
              {
                  MessageBox.Show("can't find or acces suche a directory!");
              }
              

            int howm = 0;
            try
            {
                howm = int.Parse(textBoxCount.Text);
            }
            catch
            {
                MessageBox.Show("Can't understand the numberic value inside a column higher \"Generate\" button!");
            }
            

            if (folds == 4)
            {
                try
                {
                    for (int i = 0; i < howm; i++)
                    {


                        Bitmap w1 = (Bitmap)Image.FromFile(fils1[rand.Next(0, fils1.Length - 1)]);
                        Bitmap w2 = (Bitmap)Image.FromFile(fils2[rand.Next(0, fils2.Length - 1)]);
                        Bitmap w3 = (Bitmap)Image.FromFile(fils3[rand.Next(0, fils3.Length - 1)]);
                        Bitmap w4 = (Bitmap)Image.FromFile(fils4[rand.Next(0, fils4.Length - 1)]);
                        c = c + 1;


                        var g = Graphics.FromImage(w1);

                        g.SmoothingMode = SmoothingMode.AntiAlias;
                        g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                        g.CompositingMode = CompositingMode.SourceOver;

                        g.DrawImage(w1, new Point(0, 0));
                        g.DrawImage(w2, new Point(0, 0));
                        g.DrawImage(w3, new Point(0, 0));
                        g.DrawImage(w4, new Point(0, 0));

                        w1.Save(textBox4.Text + "\\" + c.ToString() + ".png", ImageFormat.Png);

                        // panel1.BackgroundImage = w1;
                        g.Dispose();
                        w1.Dispose();
                        w2.Dispose();
                        w3.Dispose();
                        w4.Dispose();


                    }
                }
                catch
                {
                    MessageBox.Show("can't create more nft's, could be a disc memory problem!");
                }
            }
            else if (folds == 1) {
                MessageBox.Show("Need more folders");
            }
            else if (folds == 3)
            {
                try
                {
                    for (int i = 0; i < howm; i++)
                    {


                        Bitmap w1 = (Bitmap)Image.FromFile(fils1[rand.Next(0, fils1.Length - 1)]);
                        Bitmap w2 = (Bitmap)Image.FromFile(fils2[rand.Next(0, fils2.Length - 1)]);
                        Bitmap w3 = (Bitmap)Image.FromFile(fils3[rand.Next(0, fils3.Length - 1)]);

                        c = c + 1;


                        var g = Graphics.FromImage(w1);

                        g.SmoothingMode = SmoothingMode.AntiAlias;
                        g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                        g.CompositingMode = CompositingMode.SourceOver;

                        g.DrawImage(w1, new Point(0, 0));
                        g.DrawImage(w2, new Point(0, 0));
                        g.DrawImage(w3, new Point(0, 0));


                        w1.Save(textBox4.Text + "\\" + c.ToString() + ".png", ImageFormat.Png);

                        // panel1.BackgroundImage = w1;
                        g.Dispose();
                        w1.Dispose();
                        w2.Dispose();
                        w3.Dispose();



                    }
                }
                catch
                {
                    MessageBox.Show("can't create more nft's, could be a disc memory problem!");
                }
            }
            else if (folds == 2)
            {
                try
                {
                    for (int i = 0; i < howm; i++)
                    {


                        Bitmap w1 = (Bitmap)Image.FromFile(fils1[rand.Next(0, fils1.Length - 1)]);
                        Bitmap w2 = (Bitmap)Image.FromFile(fils2[rand.Next(0, fils2.Length - 1)]);

                        c = c + 1;


                        var g = Graphics.FromImage(w1);

                        g.SmoothingMode = SmoothingMode.AntiAlias;
                        g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                        g.CompositingMode = CompositingMode.SourceOver;

                        g.DrawImage(w1, new Point(0, 0));
                        g.DrawImage(w2, new Point(0, 0));


                        w1.Save(textBox4.Text + "\\" + c.ToString() + ".png", ImageFormat.Png);

                        // panel1.BackgroundImage = w1;
                        g.Dispose();
                        w1.Dispose();
                        w2.Dispose();



                    }
                }
                catch
                {
                    MessageBox.Show("can't create more nft's, could be a disc memory problem!");
                }
            }
            else if (folds == 5)
            {
                try
                {
                    for (int i = 0; i < howm; i++)
                    {




                        Bitmap w1 = (Bitmap)Image.FromFile(fils1[rand.Next(0, fils1.Length - 1)]);
                        Bitmap w2 = (Bitmap)Image.FromFile(fils2[rand.Next(0, fils2.Length - 1)]);
                        Bitmap w3 = (Bitmap)Image.FromFile(fils3[rand.Next(0, fils3.Length - 1)]);
                        Bitmap w4 = (Bitmap)Image.FromFile(fils4[rand.Next(0, fils4.Length - 1)]);
                        Bitmap w5 = (Bitmap)Image.FromFile(fils5[rand.Next(0, fils5.Length - 1)]);
                        c = c + 1;


                        var g = Graphics.FromImage(w1);

                        g.SmoothingMode = SmoothingMode.AntiAlias;
                        g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                        g.CompositingMode = CompositingMode.SourceOver;

                        g.DrawImage(w1, new Point(0, 0));
                        g.DrawImage(w2, new Point(0, 0));
                        g.DrawImage(w3, new Point(0, 0));
                        g.DrawImage(w4, new Point(0, 0));
                        g.DrawImage(w5, new Point(0, 0));

                        w1.Save(textBox4.Text + "\\" + c.ToString() + ".png", ImageFormat.Png);

                        // panel1.BackgroundImage = w1;
                        g.Dispose();
                        w1.Dispose();
                        w2.Dispose();
                        w3.Dispose();
                        w4.Dispose();

                        w5.Dispose();



                    }
                }
                catch
                {
                    MessageBox.Show("can't create more nft's, could be a disc memory problem!");
                }
            }
            else if (folds == 6)
            {
                try
                {
                    for (int i = 0; i < howm; i++)
                    {




                        Bitmap w1 = (Bitmap)Image.FromFile(fils1[rand.Next(0, fils1.Length - 1)]);
                        Bitmap w2 = (Bitmap)Image.FromFile(fils2[rand.Next(0, fils2.Length - 1)]);
                        Bitmap w3 = (Bitmap)Image.FromFile(fils3[rand.Next(0, fils3.Length - 1)]);
                        Bitmap w4 = (Bitmap)Image.FromFile(fils4[rand.Next(0, fils4.Length - 1)]);
                        Bitmap w5 = (Bitmap)Image.FromFile(fils5[rand.Next(0, fils5.Length - 1)]);
                        Bitmap w6 = (Bitmap)Image.FromFile(fils5[rand.Next(0, fils6.Length - 1)]);
                        c = c + 1;


                        var g = Graphics.FromImage(w1);

                        g.SmoothingMode = SmoothingMode.AntiAlias;
                        g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                        g.CompositingMode = CompositingMode.SourceOver;

                        g.DrawImage(w1, new Point(0, 0));
                        g.DrawImage(w2, new Point(0, 0));
                        g.DrawImage(w3, new Point(0, 0));
                        g.DrawImage(w4, new Point(0, 0));
                        g.DrawImage(w5, new Point(0, 0));
                        g.DrawImage(w6, new Point(0, 0));

                        w1.Save(textBox4.Text + "\\" + c.ToString() + ".png", ImageFormat.Png);

                        // panel1.BackgroundImage = w1;
                        g.Dispose();
                        w1.Dispose();
                        w2.Dispose();
                        w3.Dispose();
                        w4.Dispose();

                        w5.Dispose();
                        w6.Dispose();



                    }
                }
                catch
                {
                    MessageBox.Show("can't create more nft's, could be a disc memory problem!");
                }
            }
            else if (folds == 7)
            {
                try
                {
                    for (int i = 0; i < howm; i++)
                    {




                        Bitmap w1 = (Bitmap)Image.FromFile(fils1[rand.Next(0, fils1.Length - 1)]);
                        Bitmap w2 = (Bitmap)Image.FromFile(fils2[rand.Next(0, fils2.Length - 1)]);
                        Bitmap w3 = (Bitmap)Image.FromFile(fils3[rand.Next(0, fils3.Length - 1)]);
                        Bitmap w4 = (Bitmap)Image.FromFile(fils4[rand.Next(0, fils4.Length - 1)]);
                        Bitmap w5 = (Bitmap)Image.FromFile(fils5[rand.Next(0, fils5.Length - 1)]);
                        Bitmap w6 = (Bitmap)Image.FromFile(fils5[rand.Next(0, fils6.Length - 1)]);
                        Bitmap w7 = (Bitmap)Image.FromFile(fils5[rand.Next(0, fils6.Length - 1)]);
                        c = c + 1;


                        var g = Graphics.FromImage(w1);

                        g.SmoothingMode = SmoothingMode.AntiAlias;
                        g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                        g.CompositingMode = CompositingMode.SourceOver;

                        g.DrawImage(w1, new Point(0, 0));
                        g.DrawImage(w2, new Point(0, 0));
                        g.DrawImage(w3, new Point(0, 0));
                        g.DrawImage(w4, new Point(0, 0));
                        g.DrawImage(w5, new Point(0, 0));
                        g.DrawImage(w6, new Point(0, 0));
                        g.DrawImage(w7, new Point(0, 0));

                        w1.Save(textBox4.Text + "\\" + c.ToString() + ".png", ImageFormat.Png);

                        // panel1.BackgroundImage = w1;
                        g.Dispose();
                        w1.Dispose();
                        w2.Dispose();
                        w3.Dispose();
                        w4.Dispose();

                        w5.Dispose();
                        w6.Dispose();
                        w7.Dispose();



                    }
                }
                catch
                {
                    MessageBox.Show("can't create more nft's, could be a disc memory problem!");
                }
            }
            else if (folds == 8)
            {
                try
                {
                    for (int i = 0; i < howm; i++)
                    {




                        Bitmap w1 = (Bitmap)Image.FromFile(fils1[rand.Next(0, fils1.Length - 1)]);
                        Bitmap w2 = (Bitmap)Image.FromFile(fils2[rand.Next(0, fils2.Length - 1)]);
                        Bitmap w3 = (Bitmap)Image.FromFile(fils3[rand.Next(0, fils3.Length - 1)]);
                        Bitmap w4 = (Bitmap)Image.FromFile(fils4[rand.Next(0, fils4.Length - 1)]);
                        Bitmap w5 = (Bitmap)Image.FromFile(fils5[rand.Next(0, fils5.Length - 1)]);
                        Bitmap w6 = (Bitmap)Image.FromFile(fils5[rand.Next(0, fils6.Length - 1)]);
                        Bitmap w7 = (Bitmap)Image.FromFile(fils5[rand.Next(0, fils6.Length - 1)]);

                        Bitmap w8 = (Bitmap)Image.FromFile(fils5[rand.Next(0, fils6.Length - 1)]);
                        c = c + 1;


                        var g = Graphics.FromImage(w1);

                        g.SmoothingMode = SmoothingMode.AntiAlias;
                        g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                        g.CompositingMode = CompositingMode.SourceOver;

                        g.DrawImage(w1, new Point(0, 0));
                        g.DrawImage(w2, new Point(0, 0));
                        g.DrawImage(w3, new Point(0, 0));
                        g.DrawImage(w4, new Point(0, 0));
                        g.DrawImage(w5, new Point(0, 0));
                        g.DrawImage(w6, new Point(0, 0));
                        g.DrawImage(w7, new Point(0, 0));
                        g.DrawImage(w8, new Point(0, 0));

                        w1.Save(textBox4.Text + "\\" + c.ToString() + ".png", ImageFormat.Png);

                        // panel1.BackgroundImage = w1;
                        g.Dispose();
                        w1.Dispose();
                        w2.Dispose();
                        w3.Dispose();
                        w4.Dispose();

                        w5.Dispose();
                        w6.Dispose();
                        w7.Dispose();
                        w8.Dispose();




                    }
                }
                catch
                {
                    MessageBox.Show("can't create more nft's, could be a disc memory problem!");
                }
            }
        }
    }
}
