using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class CommonClass
    {
        #region 普通方式
        /// <summary>
        /// 显示Int类型
        /// </summary>
        public void ShowInt(int iParam)
        {
            Console.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name + ":" + iParam.GetType());
        }

        /// <summary>
        /// 显示String类型
        /// </summary>
        public void ShowString(string sParam)
        {
            Console.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name + ":" + sParam.GetType());
        }

        /// <summary>
        /// 显示People类型
        /// </summary>
        public void ShowPeople(People people)
        {
            Console.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name + ":" + people.GetType());
        } 
        #endregion
    }
}
