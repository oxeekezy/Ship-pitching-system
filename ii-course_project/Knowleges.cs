using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ii_course_project
{
    internal class Knowleges
    {
        /// <summary>
        /// Константные значения
        /// </summary>
        public double _shipLenght = 55.0;   // Длина корабля
        public double _shipWidth = 9.0;     // Ширина корабля
        public double _shipDraught = 3.7;   // Осадка корабля
        public double _metaHeight = 0.57;   // Метацентрическая высота
        public double _shipSpeed = 13.5;    // Скорость корабля
        public double _waveLenght = 55.0;   // Длина волны
        public double _tetaM = 15;          // Амплитуда качки тета
        public double _psiM = 3;            // Амплитуда качки пси

        /// <summary>
        /// Формульные значения
        /// </summary>
        public double _waveSpeed;           // Скорость волны
        public double _waveApparentPeriod;  // Период волны (кажущийся)
        public double _sidePith;            // Период бортовой качки (собственный)
        public double _keelPith;            // Период килевой качки (собственный)

        /// <summary>
        /// Исходные оценки вероятностей
        /// </summary>
        public double PE = 0.67;
        public double PHE = 0.73;
        public double PHnotE = 0.03;
        public double MDHE1 = 0.83;
        public double MDHE2 = 0.85;

        /// <summary>
        /// Расчёт вероятностей
        /// </summary>
        public double BayesFormula;         // Значение из формулы Байеса
        public double ShortliffFormula;     // Значение формулы Шортлиффа
        public double _probably;            // Вероятность

        /// <summary>
        /// Входные значения
        /// </summary>
        public double _teta;                // Входное значение амплитуды качки тета
        public double _psi;                 // Входное значение амплитуды качки пси

        public Knowleges(double speed)
        {
            //Формульные значения
            _waveSpeed = 1.25 * Math.Pow(_waveLenght, 0.5);
            _sidePith = 0.8 * _shipWidth / Math.Pow(_metaHeight, 0.5);
            _keelPith = 2.5 * Math.Pow(_shipDraught, 0.5);

            //Расчёт вероятностей по формулам
            BayesFormula = PHE * PE + PHnotE * (1 - PE) + (1 - PHE) * PE + PHE * (1 - PE);
            ShortliffFormula = MDHE1 + MDHE2 * (1 - MDHE1);
            _probably = (BayesFormula + ShortliffFormula) / 2;
            _shipSpeed = speed;
        }

        public void WaveInit(double angle, double teta, double psi) 
        {
            //Кажущийся период волны
            _teta = teta;
            _psi = psi;
            _waveApparentPeriod = _waveLenght / (_waveSpeed - _shipSpeed * Math.Cos(angle * Math.PI / 180));
        }

        public string GetKnowledgeParameters() 
        {
            return String.Format("WS\tSPI\tKPI\tWAPP\tθm\tψm\n" +
                                 "{0}\t{1}\t{2}\t{3}\t{4}\t{5}\n\n" +
                                 "Bayes: {6}\n" +
                                 "Shortliff: {7}\n" +
                                 "Probably: {8}",
                                 Math.Round(_waveSpeed,2), 
                                 Math.Round(_sidePith,2), 
                                 Math.Round(_keelPith,2), 
                                 Math.Round(_waveApparentPeriod,2),
                                 _tetaM,_psiM,BayesFormula,ShortliffFormula,_probably);
        }

    }
}
