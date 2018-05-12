﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrange_all
{
    class Program
    {
        static void Main(string[] args)
        {
            //輸入全班資料
            string[] blood = { "O", "其他", "O", "O", "A", "O", "A", "A", "O", "O", "A", "O", "A", "B", "O", "O", "A", "其他", "O", "O", "A", "", "B", "O", "", "O", "B", "O", "B", "B", "B", "O", "O", "AB", "O", "B", "A", "O", "O", "", "O", "A", "", "O", "O", "A", "O", "O", "其他", "B", "O", "O", "O", "A", "AB", "A", "O", "", "AB", "", "O", "O", "O", "", "O" };
            string[] fm = { "男", "男", "男", "女", "男", "男", "女", "男", "男", "男", "男", "男", "女", "男", "男", "男", "女", "女", "男", "男", "女", "男", "女", "男", "男", "女", "男", "男", "女", "男", "男", "男", "男", "女", "男", "男", "女", "女", "男", "男", "女", "女", "男", "男", "男", "男", "男", "男", "女", "男", "女", "女", "女", "女", "女", "女", "男", "女", "女", "女", "女", "女", "男", "男", "女" };
            string[] star = { "金牛", "", "巨蟹", "白羊", "雙魚", "雙子", "天蠍", "巨蟹", "獅子", "雙魚", "雙子", "雙子", "獅子", "雙魚", "天蠍", "天蠍", "處女", "處女", "金牛", "雙魚", "處女", "摩羯", "雙魚", "白羊", "天蠍", "處女", "雙子", "金牛", "雙子", "白羊", "白羊", "摩羯", "射手", "巨蟹", "雙魚", "獅子", "射手", "摩羯", "天蠍", "", "雙魚", "雙子", "", "雙魚", "處女", "金牛", "天秤", "水瓶", "巨蟹", "處女", "白羊", "摩羯", "水瓶", "天秤", "金牛", "天蠍", "天蠍", "", "", "", "摩羯", "天蠍", "雙子", "", "獅子" };
            string[] number = { "A106082026", "A106082016", "A106082062", "A106082054", "A104082006", "A106082029", "A106082046", "A106082030", "A106082022", "A106082034", "A103082022", "A106082020", "A106082011", "A106082024", "A105082201", "106082010", "A106082028", "a106082056", "a106082043", "A106082006", "A106082051", "A106082032", "a106082058", "A106082035", "a106082017", "A104082036", "A106082009", "a106082007", "A106082052", "A106082008", "A106082063", "A106082038", "A106082025", "A106082057", "A106082013", "A106082027", "A106082048", "a106082036", "A106082059", "a106082045", "A106082012", "A106082037", "A106082021", "A106082031", "A106082061", "A106082042", "A106082023", "A106082040", "A106082001", "a106082002", "A106082014", "A106082041", "A106082049", "A106082015", "A106082044", "A106082047", "A106082018", "A106082005", "A106082050", "a106082055", "A106082039", "A104082013", "A106082029", "", "A104040024" };
            string[] name = { "葉俊廷", "張澤瑜", "王程捷", "江儀婷", "張秉華", "陳柏霖", "黃紀瑜", "黃昱維", "蔡逸群", "登琳", "世新魏鈞孝吧", "劉定南", "陳信如", "童信傑", "李岳倫", "鄒和恆", "簡毓玟", "劉子瑄", "蕭紹洋", "李亞宸la", "張以潔", "邱仕紳", "呂家瑩", "世新林鑫佑", "徐均得", "陳佳欣", "張恩瑋", "周詮", "王湘婷", "蕭宇成", "Max Cheung(BANG)", "馬嘉誠", "陳昱嘉", "康珈熏", "盧奕宏", "黃博涵", "遲正雯", "世新林星彤", "許晏誠　", "許子安", "高子晴", "陳思婷", "矝鵘鮿", "余彥廷", "吳耀輝", "鄭丞智", "林冠廷", "世新何曜宇", "邵喬雨", "張豐愷", "林子晴", "邱雁回", "陳家欣是韓妞", "鄧雅馨", "謝汶珊", "李曼寧", "世新徐偉哲", "张钰慈", "鍾宜珊", "raer_tsai", "世新李姳諼", "鄭曼君", "世新陳柏霖", "世新許子安", "世新方若帆" };
            int[] height = { 173, 170, 179, 155, 183, 170, 163, 174, 165, 189, 177, 180, 154, 170, 170, 173, 165, 158, 180, 165, 153, 175, 162, 165, 0, 160, 165, 173, 164, 177, 177, 180, 170, 151, 176, 180, 168, 152, 180, 180, 165, 155, 180, 173, 169, 170, 169, 171, 190, 170, 150, 160, 155, 164, 163, 165, 184, 170, 155, 170, 168, 160, 169, 0, 150 };

            Console.WriteLine(" 根據不完全統計：");
            Console.WriteLine();

            //定義用於血型統計的數
            int O = 0;
            int A = 0;
            int B = 0;
            int C = 0;

            //統計各血型的人數
            for (int j = 0; j < blood.Length; j++)
            {
                if (blood[j] == "O")
                {
                   O++;
                }
                else if (blood[j] == "A")
                {
                    A++;
                }
                else if (blood[j] == "B")
                {
                    B++;
                }
                else if (blood[j] == "AB")
                {
                    C++;
                }
            }

            //計算百分比
            double o = (double)O / blood.Length * 100;
            double a = (double)A / blood.Length * 100;
            double b = (double)B / blood.Length * 100;
            double ab = (double)C / blood.Length * 100;

            Console.WriteLine(" O型血的人數為" + O + "人，佔比為" +Math.Round(o) +"%");
            Console.WriteLine(" A型血的人數為" + A + "人，佔比為" +Math.Round(a) + "% ");
            Console.WriteLine(" B型血的人數為" + B + "人， 佔比為" + Math.Round(b) + "% ");
            Console.WriteLine(" AB型血的人數為" + C +"人，佔比為" + Math.Round(ab) + "% ");
            Console.WriteLine();

            //定義用來放人數的變量
            int girlN=0;
            int boyN=0;

            //計算男生女生人數
            for(int n = 0; n < fm.Length; n++)
            {
                if (fm[n] == "男")
                {
                    boyN++;
                }
                else if (fm[n] == "女")
                {
                    girlN++;
                }
            }

            //計算人數百分比
            double gN = (double)girlN / fm.Length * 100;
            double bN = (double)boyN / fm.Length * 100;

            Console.WriteLine(" 遊戲一甲的男生人數為"+boyN+"人，且占全班的"+Math.Round(bN)+"%");
            Console.WriteLine(" 遊戲一甲的女生人數為"+girlN+"人，且佔全班的"+Math.Round(gN)+"%");
            Console.WriteLine();

            //定義變量用於裝總身高和人數
            int boyH = 0;
            int girlH = 0;
            int g=0;
            int by=0;

            //計算男女生人數以及身高的總計
            for(int h = 0; h < height.Length; h++)
            {
                if(fm[h] == "女")
                {
                    g++;
                    girlH = girlH + height[h];
                }
                else if (fm[h] == "男")
                {
                    by++;
                    boyH = boyH + height[h];
                }
            }

            //計算平均身高
            double bH = (double)boyH / by ;
            double gH = (double)girlH / g ;
            double all = (double)boyH + (double)girlH;
            double allH = all / height.Length;

            Console.WriteLine(" 男生身高平均為"+Math.Round(bH)+"cm");
            Console.WriteLine(" 女生身高平均為"+Math.Round(gH)+"cm");
            Console.WriteLine(" 全班的平均身高為" + Math.Round(allH)+"cm");
            Console.WriteLine();

            int maxH = -1;
            int minH = 1000;
            for(int m = 0; m < height.Length; m++)
            {
                if (maxH < height[m])
                {
                    maxH = height[m];
                }
                if (minH > height[m])
                {
                    minH = height[m];
                }
                
            }
            Console.WriteLine(" 班裡最矮身高為"+minH+"cm，班裡最高身高為"+maxH+"cm");

            Console.ReadLine();

        }
    }
}
