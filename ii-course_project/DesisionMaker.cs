using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ii_course_project
{
    internal class DesisionMaker
    {
        Knowleges _k;
        string _recomendation = "\n\nРекомендуется изменить курсовой угол и скорость судна при помощи диаграммы качки.\n\n";
        
        public DesisionMaker(Knowleges know) 
        {
            _k = know;
        }
        public string ClearMaker() 
        {
            if (_k._teta > _k._tetaM &&
               (_k._waveApparentPeriod / _k._sidePith > 0.8) &&
               (_k._waveApparentPeriod / _k._sidePith < 1.2))
                return "Обнаружен основной резонанс бортовой качки" + _recomendation;
            else
                if (_k._teta > _k._tetaM &&
                   (_k._waveApparentPeriod / _k._sidePith > 1.85) &&
                   (_k._waveApparentPeriod / _k._sidePith < 2.15))
                return "Обнаружен параметрический резонанс бортовой качки"+_recomendation;
            else
                if (_k._psi > _k._psiM &&
                   (_k._waveApparentPeriod / _k._keelPith > 0.8) &&
                   (_k._waveApparentPeriod / _k._keelPith < 1.2))
                return "Обнаружен основной резонанс килевой качки" + _recomendation;
            else
                return "Резонансных качек не обнаружено.";

        }
    }
}
