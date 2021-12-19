using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ii_course_project
{
    internal class DiagramInterection
    {
        public Knowleges know { get; set; }

        public DiagramInterection(Knowleges know) 
        {
            this.know = know;
        }
        public double CalculatePeriodWidth(string pitchType) 
        {
            if (pitchType == "side") 
            {
                return Math.Round(9 * (Math.Round(know._waveSpeed - know._waveLenght / (1.2 * know._sidePith), 2) -
                                       Math.Round(know._waveSpeed - know._waveLenght / (0.8 * know._sidePith), 2)),0);
            }
            if (pitchType == "parametric side") 
            {
                return Math.Round(7.5 * (Math.Round(know._waveSpeed - know._waveLenght / (2.15 * know._sidePith), 2) -
                                         Math.Round(know._waveSpeed - know._waveLenght / (1.85 * know._sidePith), 2)),0);
            }
            if (pitchType == "keel") 
            {
                return Math.Round(9 * (Math.Round(know._waveSpeed - know._waveLenght / (1.2 * know._keelPith), 2) -
                                       Math.Round(know._waveSpeed - know._waveLenght / (0.8 * know._keelPith), 2)),0);
            }
            return double.MinValue;
        }

        public double CalculatePeriodEnd(string pitchType) 
        {
            if (pitchType == "side")
            {
                return Math.Round(know._waveSpeed - know._waveLenght / (1.2 * know._sidePith), 2);
            }
            if (pitchType == "parametric side")
            {
                return Math.Round(know._waveSpeed - know._waveLenght / (2.15 * know._sidePith), 2);
            }
            if (pitchType == "keel")
            {
                return Math.Round(know._waveSpeed - know._waveLenght / (1.2 * know._keelPith), 2);
            }
            return double.MinValue;
        }

        public Bitmap UpdateBitmap(string imagePath,int zeroX,int zeroY,int startSide, int startPSide, int startKeel, int sideWidth, int pSideWidth, int keelWidth) 
        {
            int centerX = 220;
            int topY = 26;

            

            Bitmap modifyDiagram = new Bitmap(imagePath);

            using (Graphics gr = Graphics.FromImage(modifyDiagram))
            {
                gr.FillRectangle(new SolidBrush(Color.FromArgb(100, Color.Aqua)), zeroX + 190 - startSide, 0, sideWidth, zeroY);
                gr.FillRectangle(new SolidBrush(Color.FromArgb(100, Color.Red)), zeroX + 190 - startPSide, 0, pSideWidth, zeroY);
                gr.FillRectangle(new SolidBrush(Color.FromArgb(100, Color.Yellow)), zeroX + 190 - startKeel, 0, keelWidth, zeroY);


                int ellipseD = Convert.ToInt32(know._shipSpeed*13);
                int ellipseR = ellipseD / 2;

                int ellipseX = centerX - ellipseR - 2;
                int ellipseY = zeroY - ellipseR;

                gr.DrawEllipse(new Pen(Color.Blue), ellipseX, ellipseY, ellipseD,ellipseD);

                var x = centerX+((ellipseR * (float)Math.Cos(90)));
                var y = zeroY+((ellipseR * -(float)Math.Sin(90)));

                
                x = Convert.ToInt32(x);
                y = Convert.ToInt32(y);

                MessageBox.Show(x + " -- "+ y );
                gr.DrawLine(new Pen(Color.Red), centerX, zeroY, x, y);
            }

            return modifyDiagram;
        }
    }
}
