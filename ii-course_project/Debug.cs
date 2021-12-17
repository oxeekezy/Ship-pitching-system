using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ii_course_project
{
    internal class Debug
    {
        Knowleges _k;

        public Debug(Knowleges know) 
        {
            _k = know;
        }

        public string GetString(int angle, string result) 
        {
            return String.Format("Ang\tTeta\tTetaM\tPsi\tPsiM\tWS\tWAPP\tSPI\tKPI\n" +
                                 "{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}\n"+
                                 "Bayes: {9}\n" +
                                 "Shortliff: {10}\n" +
                                 "Result: {11}\n\n",angle,_k._teta, _k._tetaM, _k._psi, _k._psiM, 
                                 Math.Round(_k._waveSpeed,3), Math.Round(_k._waveApparentPeriod,3), 
                                 Math.Round(_k._sidePith,3), Math.Round(_k._keelPith,3),
                                 _k.BayesFormula, _k.ShortliffFormula,result);
        }
    }
}
