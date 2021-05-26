using System;
using System.Collections.Generic;
using System.Text;

namespace ARIN
{
    public static class MyExtensions
    {
        public static string MyToString(this ulong ul)
        {
            int 조_val = (int)(ul / ConstValues.조);
            ul = ul % ConstValues.조;
            int 억_val = (int)(ul / ConstValues.억);
            ul = ul % ConstValues.억;
            int 만_val = (int)(ul / ConstValues.만);
            ul = ul % ConstValues.만;

            StringBuilder sb = new StringBuilder();
            if (조_val != 0)
            {
                sb.Append(조_val.ToString());
                sb.Append("조 ");
            }
            if (억_val != 0)
            {
                sb.Append(억_val.ToString());
                sb.Append("억 ");
            }

            if (만_val != 0)
            {
                sb.Append(만_val.ToString());
                sb.Append("만 ");
            }

            if (sb.Length == 0)
                return "0";

            return sb.ToString();
        }
    }


    public enum E_Combobox_num
    {
        User_Custom,
        Ozma_0,
        Ozma_1,
        Ozma_2,
        Ozma_3,
    }

    public class ConstValues
    {
        public const ulong 조 = 1000000000000;
        public const ulong 억 = 100000000;
        public const ulong 만 = 10000;

        public ulong cur_input_value { get; private set; }

        public Dictionary<E_Combobox_num, ulong> m_bosshp_dic;

        public ConstValues()
        {
            cur_input_value = 0;

            Init_dic();
        }

        private void Init_dic()
        {
            m_bosshp_dic = new Dictionary<E_Combobox_num, ulong>();
            m_bosshp_dic.Add(E_Combobox_num.User_Custom, cur_input_value);
            m_bosshp_dic.Add(E_Combobox_num.Ozma_0, 127 * 조 + 4574 * 억);
            m_bosshp_dic.Add(E_Combobox_num.Ozma_1, 191 * 조 + 1860 * 억);
            m_bosshp_dic.Add(E_Combobox_num.Ozma_2, 371 * 조 + 7506 * 억);
            m_bosshp_dic.Add(E_Combobox_num.Ozma_3, 531 * 조 + 700 * 억);
        }

        public void SetCurInputValue(ulong _val)
        {
            m_bosshp_dic[E_Combobox_num.User_Custom] = _val;
        }
    }
}
