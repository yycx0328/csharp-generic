using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class GenericClass
    {
        /// <summary>
        /// 泛型方式
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        public void ShowT<T>(T t)
        {
            Console.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name + ":" + t.GetType());
        }

        /// <summary>
        /// 约束泛型为引用类型
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        public void ShowStruct<T>(T t) where T : struct
        {
            Console.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name + ":" + t.GetType());
        }

        /// <summary>
        /// 约束泛型为引用类型
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        public void ShowClass1<T>(T t) where T : class
        {
            // T nteT = new T();    // 错误
            Console.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name + ":" + t.GetType());
        }

        /// <summary>
        /// 约束泛型为引用类型，并且有无参构造函数
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        public void ShowClass2<T>(T t) where T : class, new()
        {
            T nteT = new T();
            Console.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name + ":" + t.GetType());
        }

        /// <summary>
        /// 约束泛型为People类或者其子类
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        public void ShowPeople<T>(T t) where T : People
        {
            Console.WriteLine("{0}的生日是{1}", t.Name, t.Birthday);
            Console.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name + ":" + t.GetType());
        }
    }
}
