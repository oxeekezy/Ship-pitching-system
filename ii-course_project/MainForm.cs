using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace ii_course_project
{
    public partial class MainForm : Form
    {
        [DllImport("Kernel32.dll")]
        static extern Boolean AllocConsole();

        string path = Directory.GetCurrentDirectory() + "/img/diagram.png";

        Knowleges know;
        DiagramInterection interection;
        DesisionMaker make;
        public MainForm()
        {
            InitializeComponent();
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            know = new Knowleges(13.5);

            diagramBox.Image = Image.FromFile(path);
            diagramBox.SizeMode = PictureBoxSizeMode.StretchImage;
            resultBox.SelectionAlignment = HorizontalAlignment.Center;

            tbxAngle.Text = (120).ToString();
            tbxTeta.Text = (15).ToString();
            tbxPsi.Text = (3).ToString();

            tbxShipLenght.Text = know._shipLenght.ToString();
            tbxShipWidth.Text = know._shipWidth.ToString();
            tbxShipDraught.Text = know._shipDraught.ToString();
            tbxMetaHeight.Text = know._metaHeight.ToString();
            tbxShipSpeed.Text = know._shipSpeed.ToString();
            tbxWaveLenght.Text = know._waveLenght.ToString();

            tbxPE.Text = know.PE.ToString();
            tbxHNOE.Text = know.PHnotE.ToString();
            tbxPHE.Text = know.PHE.ToString();
            tbxMDHE1.Text = know.MDHE1.ToString();
            tbxMDHE2.Text = know.MDHE2.ToString();

            sidePanel.BackColor = Color.FromArgb(100, Color.Aqua);
            psidePanel.BackColor = Color.FromArgb(100, Color.Red);
            keelPanel.BackColor = Color.FromArgb(100, Color.Yellow);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ///<summary>
            ///Значения из текстбоксов
            ///</summary>>
            int inputAngle = 0;
            int inputTeta = 0;
            int inputPsi = 0;

            ///<summary>
            ///Парсим значения 
            ///</summary>>
            if (int.TryParse(tbxAngle.Text,out inputAngle))
                inputAngle = Convert.ToInt32(tbxAngle.Text);
            if(int.TryParse(tbxTeta.Text, out inputTeta))
                inputTeta = Convert.ToInt32(tbxTeta.Text);
            if(int.TryParse(tbxPsi.Text,out inputPsi))
                inputPsi = Convert.ToInt32(tbxPsi.Text);

            if (inputAngle == 0 || inputTeta == 0 || inputPsi == 0)
            {
                MessageBox.Show("Укажите верные параметры.","Ошибка!");
            }
            else 
            {
                double sp = know._shipSpeed;//test
                know = new Knowleges(Convert.ToDouble(tbxShipSpeed.Text));//test

                interection = new DiagramInterection(know);
                know.WaveInit(inputAngle,inputTeta,inputPsi);

                
                ///<summary>
                ///Получаем значения о ширине и расположении зон 
                ///</summary>>
                int sideWidth = (int)interection.CalculatePeriodWidth("side");
                int parametricSideWidth= (int)interection.CalculatePeriodWidth("parametric side");
                int keelWidth = (int)interection.CalculatePeriodWidth("keel");

                int sideEnd = 9 * (int)interection.CalculatePeriodEnd("side");
                int parametricSideEnd = Convert.ToInt32(7.5 * interection.CalculatePeriodEnd("parametric side"));
                int keelEnd = 9 * (int)interection.CalculatePeriodEnd("keel");

                ///<summary>
                ///Обновляем битмап
                ///</summary>>
                int zeroX = 34;                                                                                         // Отмечаем ноль по Y с учётом особенностей битмапа
                int zeroY = diagramBox.Height + 11;                                                                     // Отмечаем ноль по Y с учётом особенностей битмапа


                diagramBox.Image = interection.UpdateBitmap(path, zeroX, zeroY, sideEnd, parametricSideEnd, keelEnd, 
                                                            sideWidth, parametricSideWidth, keelWidth);                 // Рисуем на битмапе зоны


                ///<summary>
                ///Обновляем результаты
                ///</summary>>
                if (debugCheck.Checked)                                                                                 // Режим отладки.
                                                                                                                        // Пробегаемся с текущими пармаетрами по курсам от 0 до 180
                {
                    AllocConsole();
                    Debug debug;
                    for (int i = 0; i <= 180; i++) 
                    {
                        know.WaveInit(i,inputTeta,inputPsi);
                        debug = new Debug(know);
                        make = new DesisionMaker(know);                                                                 
                        Console.WriteLine(debug.GetString(i,make.ClearMaker()));                                        // Выводим результат в консоль                      
                        logBox.Text = know.GetKnowledgeParameters();                                                    // Пишем логи с нужными параметрами                                                                                              
                    }
                }
                else                                                                                                    // Обычный режим с заданным курсом
                {
                    make = new DesisionMaker(know);
                    resultBox.Text = make.ClearMaker();                                                                 // Выводим результат в текстбокс                      
                    logBox.Text = know.GetKnowledgeParameters();                                                        // Пишем логи с нужными параметрами 
                }
            }

        }

        private void resultBox_TextChanged(object sender, EventArgs e)
        {
            if (resultBox.Text != "Резонансных качек не обнаружено."&& resultBox.Text.Length!=0) 
            {
                resultBox.Text += "Достоверность возникновения сильной резонансной качки: " + know._probably;
            }
        }

        private void debugCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (debugCheck.Checked)
                tbxAngle.Enabled = false;
            else
                tbxAngle.Enabled = true;
        }
    }
}
