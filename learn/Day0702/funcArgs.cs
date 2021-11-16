using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day0702
{
    class funcArgs_Value
    {
        // 按值传递参数
        public void swap_value(int x, int y)
        {
            int temp;

            temp = x; /* 保存 x 的值 */
            x = y;    /* 把 y 赋值给 x */
            y = temp; /* 把 temp 赋值给 y */
        }

        // 按引用传递参数

        public void swap_ref(ref int x, ref int y)
        {
            int temp;

            temp = x; /* 保存 x 的值 */
            x = y;    /* 把 y 赋值给 x */
            y = temp; /* 把 temp 赋值给 y */
        }

        //按输出传递参数





        public void getValue(out int x)
        {
            int temp = 5;
            x = temp;
        }
    }
}
