using System;
using System.Collections.Generic;
using System.Text;


namespace blackjack
{
    class Card                           //Card类：表示一张牌
    {       
        public int value;                //card的值                
        public Card(int num)              // 计算可得纸牌对应的值
        {
            this.value = countCardValue(num);
          
            
        }      
        public  int countCardValue(int num)         //计算卡牌的值
        {
            int value;
            if (num <= 40)
            {
                if (num % 4 == 0) { value = num / 4; }
                else { value = (num / 4) + 1; }
            }
            else { value = 10; }                    //大于10的纸牌数值都为10
            return value;
        }
    }
}
