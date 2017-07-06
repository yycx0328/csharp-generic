using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class OverrideClass
    {
        #region 重载方式
        /// <summary>
        /// 显示Int类型
        /// </summary>
        public void Show(int iParam)
        {
            Console.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name + ":" + iParam.GetType());
        }

        /// <summary>
        /// 显示String类型
        /// </summary>
        public void Show(string sParam)
        {
            Console.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name + ":" + sParam.GetType());
        }

        /// <summary>
        /// 显示People类型
        /// </summary>
        public void Show(People people)
        {
            Console.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name + ":" + people.GetType());
        }
        #endregion
    }
}
