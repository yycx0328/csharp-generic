using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class ObjectClass
    {
        /// <summary>
        /// 使用object封装对象，因为object是所有类型的父类
        /// </summary>
        /// <param name="oParameter"></param>
        public void ShowObject(object oParam)
        {
            Console.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name + ":" + oParam.GetType());
        }
    }
}
