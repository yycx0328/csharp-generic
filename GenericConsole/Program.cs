using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business;

namespace GenericConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int iParam = 123;
            string sParam = "Hello!";
            People people = new People
            {
                Name = "大胖",
                Gender = true,
                Birthday = DateTime.Now
            };

            #region 普通方式
            //CommonClass common = new CommonClass();
            //common.ShowInt(iParam);
            //common.ShowString(sParam);
            //common.ShowPeople(people); 
            #endregion

            #region 重载方式
            //OverrideClass over = new OverrideClass();
            //over.Show(iParam);
            //over.Show(sParam);
            //over.Show(people); 
            #endregion

            #region 用object传递方式
            //ObjectClass obj = new ObjectClass();
            //obj.ShowObject(iParam);
            //obj.ShowObject(sParam);
            //obj.ShowObject(people);
            #endregion

            #region 泛型方式
            //GenericClass gen = new GenericClass();
            //gen.ShowT(iParam);
            //gen.ShowT(sParam);
            //gen.ShowT(people);

            //gen.ShowStruct(iParam); // 正确
            //gen.ShowStruct(sParam); // 错误
            //gen.ShowStruct(people); // 错误

            //gen.ShowClass1(iParam);  // 错误
            //gen.ShowClass1(sParam);  // 正确
            //gen.ShowClass1(people);  // 正确

            //gen.ShowClass2(iParam);  // 错误
            //gen.ShowClass2(sParam);  // 错误
            //gen.ShowClass2(people);  // 正确

            //gen.ShowPeople(iParam);  // 错误
            //gen.ShowPeople(sParam);  // 错误
            //gen.ShowPeople(people);  // 正确
            #endregion
        }
    }
}
