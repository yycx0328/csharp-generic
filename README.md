# csharp-generic
实例源码地址：https://github.com/yycx0328/csharp-generic.git<br />
C#中泛型是.NET Framework 2.0的一个新增加的特性，它为使用c#语言编写面向对象程序增加了极大的效力和灵活性。
先不说那么多汤水，我们先引入一个场景：我现在想显示传入参数的类型，我们一般会有一下几种声明方式：<br />
一、普通方式：<br />

    public class CommonClass
    {
        #region 普通方式<br />
        /// <summary><br />
        /// 显示Int类型<br />
        /// </summary><br />
        public void ShowInt(int iParam)
        {
            Console.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name + ":" + iParam.GetType());
        }

        /// <summary><br />
        /// 显示String类型<br />
        /// </summary><br />
        public void ShowString(string sParam)
        {
            Console.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name + ":" + sParam.GetType());
        }

        /// <summary><br />
        /// 显示People类型<br />
        /// </summary><br />
        public void ShowPeople(People people)
        {
            Console.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name + ":" + people.GetType());
        }
        #endregion
    }

二、重载方式：<br />

    public class OverrideClass
    {
        #region 重载方式<br />
        /// <summary><br />
        /// 显示Int类型<br />
        /// </summary><br />
        public void Show(int iParam)
        {
            Console.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name + ":" + iParam.GetType());
        }

        /// <summary><br />
        /// 显示String类型<br />
        /// </summary><br />
        public void Show(string sParam)
        {
            Console.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name + ":" + sParam.GetType());
        }

        /// <summary><br />
        /// 显示People类型<br />
        /// </summary><br />
        public void Show(People people)
        {
            Console.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name + ":" + people.GetType());
        }
        #endregion
    }

三、采用object方式：<br />

    public class ObjectClass
    {
        /// <summary><br />
        /// 使用object封装对象，因为object是所有类型的父类<br />
        /// </summary><br />
        /// <param name="oParameter"></param><br />
        public void ShowObject(object oParam)
        {
            Console.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name + ":" + oParam.GetType());
        }
    }

四、泛型方式：<br />

    public class GenericClass
    {
        /// <summary><br />
        /// 泛型方式<br />
        /// </summary><br />
        /// <typeparam name="T"></typeparam><br />
        /// <param name="t"></param><br />
        public void ShowT<T>(T t)
        {
            Console.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name + ":" + t.GetType());
        }
    }

下面我们来分析一下这几种方式的差异，至于第一种和第二种方式其实实现的效果是一样的，它们的缺点代码量大，且对扩展性不好,当增加一种数据类型时，就需要再增加一个实现方法；
第三种方式将参数以object类型来接收（因为C#中object是所有对象的父类），这样看起来代码也简洁，但有一个不好的地方容易造成效率损失，因为在值类型和引用类型之间的转换会有一个装箱和拆箱的操作，而object又太过于松散，无法对其约束，如果想在某一个函数中是用类属性或者方法，只能通过强转和判断来实现，而当类型传错，在强转时便很容易出错；
泛型的出现提供了一种完美的解决方案，它避免了代码的冗余，而且易于扩展，不存在装箱/拆箱的效率损耗，而且泛型还提供了各种约束方式，引用类型约束（class）、值类型约束（struct）、构造函数约束（new）、以及具体某个类约束等。<br />

  /// <summary><br />
  /// 约束泛型为引用类型<br />
  /// </summary><br />
  /// <typeparam name="T"></typeparam><br />
  /// <param name="t"></param><br />
  public void ShowStruct<T>(T t) where T : struct
  {
      Console.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name + ":" + t.GetType());
  }

  /// <summary><br />
  /// 约束泛型为引用类型<br />
  /// </summary><br />
  /// <typeparam name="T"></typeparam><br />
  /// <param name="t"></param><br />
  public void ShowClass1<T>(T t) where T : class
  {
      // T nteT = new T(); // 错误
      Console.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name + ":" + t.GetType());
  }

  /// <summary><br />
  /// 约束泛型为引用类型，并且有无参构造函数<br />
  /// </summary><br />
  /// <typeparam name="T"></typeparam><br />
  /// <param name="t"></param><br />
  public void ShowClass2<T>(T t) where T : class, new()
  {
      T nteT = new T();
      Console.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name + ":" + t.GetType());
  }

  /// <summary><br />
  /// 约束泛型为People类或者其子类<br />
  /// </summary><br />
  /// <typeparam name="T"></typeparam><br />
  /// <param name="t"></param><br />
  public void ShowPeople<T>(T t) where T : People
  {
      Console.WriteLine("{0}的生日是{1}", t.Name, t.Birthday);
      Console.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name + ":" + t.GetType());
  }

细心的人会发现泛型约束某一个类其实跟直接将类对象作为参数传入的方式实现的效果是一样的，的确，你没有理解错，就是完全一模一样的。也许你可能会疑惑，那为什么还要泛型约束呢？首先泛型约束它可以约束值类型和引用类型，并且约束引用类型是否有无参构造函数，这在直接传参的方法中是无法做到的；其次，作为追求技术的程序猿，良好的开发习惯是非常有必要的。