using System;

namespace DF.Core
{
    /// <summary>
    /// 这是一个测试类
    /// </summary>
    public class Class1
    {
        public struct Arg
        {
        }

        /// <summary>
        /// 这是一个public的方法
        /// </summary>
        /// <param name="arg1"></param>
        /// <param name="arg2"></param>
        /// <returns>int</returns>
        /// <exception cref="Exception">exception</exception>
        public int Fun(Arg arg1, Object arg2)
        {
            return 0;
        }

        /// <summary>
        /// internal fun1
        /// </summary>
        internal void Fun1()
        { }

        /// <summary>
        /// private fun2
        /// </summary>
        void Fun2()
        { }
    }

    /// <summary>
    /// internal class
    /// </summary>
    internal class InternalClass
    { }
}
