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
            Bitmap modifyDiagram = new Bitmap(imagePath);

            using (Graphics gr = Graphics.FromImage(modifyDiagram))
            {
                gr.FillRectangle(new SolidBrush(Color.FromArgb(100, Color.Aqua)), zeroX + 175 - startSide, 0, sideWidth, zeroY);
                gr.FillRectangle(new SolidBrush(Color.FromArgb(100, Color.Red)), zeroX + 175 - startPSide, 0, pSideWidth, zeroY);
                gr.FillRectangle(new SolidBrush(Color.FromArgb(100, Color.Yellow)), zeroX + 185 - startKeel, 0, keelWidth, zeroY);
            }

            return modifyDiagram;//
        }
    }
}
