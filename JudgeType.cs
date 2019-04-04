using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgAdminMain
{
    /*用于判断用户输入数据的数据类型的类*/
    public class JudgeType
    {
        
        public bool IsDate(string strDate)
        {
            try
            {
                DateTime.Parse(strDate);
                return true;
            }

            catch
            {
                return false;
            }
        }

        public bool isInt(string s)
        {
            bool flag;
            try
            {
                int a = Convert.ToInt32(s);
                flag = true;
            }
            catch
            {
                flag = false;
            }
            return flag;
        }

        public bool isSmallint(string s)
        {
            bool flag;
            try
            {
                int a = Convert.ToInt16(s);
                flag = true;
            }
            catch
            {
                flag = false;
            }
            return flag;
        }

        public bool isChinese(string s)
        {
            bool flag = false;
            for (int i = 0; i < s.Length; i++)
                if ((int)s[i] > 127)
                    flag = true;
            return flag;
        }

        public bool isNoSignInt(string s)
        {
            bool flag = true;
            for (int i = 0; i < s.Length; i++)
                if (!char.IsNumber(s, i))
                    flag = false;
            return flag;
        }

        public bool judgeType(string type, string content, int length)
        {
            bool flag = true;
            switch (type)
            {
                case "Int":
                    flag = isInt(content);
                    break;
                case "character varying[]":
                    flag = (content.Length <= length);
                    break;
                case "date":
                    flag = IsDate(content);
                    break;
                case "smallint":
                    flag = isSmallint(content);
                    break;
                case "char":
                    flag = (content.Length <= length);
                    break;
                default:
                    flag = true;
                    break;
            }
            return flag;
        }


    }
}
