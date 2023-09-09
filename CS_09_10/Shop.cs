using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_09_10
{
    public class Shop
    {
        private float s; // площадь

        public float S { get { return s; } set { s = value; } }

        public Shop(float s)
        {
            S = s;
        }

        // Перегрузка операторов
        // + (для увеличения площади магазина на указанную величину)
        public static Shop operator +(Shop shop, float num)
        {
            Shop result = new Shop(0f);
            result.S = shop.S + num;
            return result;
        }

        // - (для уменьшения площади магазина на указанную величину)
        public static Shop operator -(Shop shop, float num)
        {
            Shop result = new Shop(0f);
            result.S = shop.S - num;
            return result;
        }

        // == (проверка на равенство площадей магазинов)
        public static bool operator ==(Shop shop1, Shop shop2)
        {
            return shop1.S == shop2.S;
        }

        // != (проверки на неравенство площадей магазинов)
        public static bool operator !=(Shop shop1, Shop shop2)
        {
            return shop1.S != shop2.S;
        }

        // < (проверка на меньше площади магазина)
        public static bool operator <(Shop shop1, Shop shop2)
        {
            return shop1.S < shop2.S;
        }

        // > (проверка на больше площади магазина)
        public static bool operator >(Shop shop1, Shop shop2)
        {
            return shop1.S > shop2.S;
        }


        // Перегрузка метода Equals
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            Shop temp = (Shop)obj;
            //return this.S == temp.S;
            return this.S.Equals(temp.S);
        }

        // Переопределение GetHashCode для Equals
        public override int GetHashCode()
        {
            return S.GetHashCode();
        }

        public override string ToString()
        {
            return $"{S}";
        }
    }
}
