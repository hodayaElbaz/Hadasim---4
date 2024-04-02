﻿using System;

namespace EX_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int op, height, width;
            Console.WriteLine("Option 1: enter 1 to select a rectangle");
            Console.WriteLine("Option 2: enter 1 to select a trainagle");
            Console.WriteLine("Option 3: enter 1 to exit");
            op = int.Parse(Console.ReadLine());

            while (op == 1 || op == 2)
            {
                Console.Write("enter width of the tower: ");
                 width = int.Parse(Console.ReadLine());
                Console.Write("enter height of the tower: ");
                height = int.Parse(Console.ReadLine());

                //אם זה מלבן
                if (op == 1)
                {
                    //אם ההפרש בין אורכי הצלעות גדול מ-5
                    if (Math.Abs(height - width) > 5 || Math.Abs(width - height) > 5)
                        Console.WriteLine("The area of rectangle is: " + height * width);
                    //אם זה ריבוע
                    else if (height == width)
                        Console.WriteLine("The area of squre is: " + height * width);
                    //בכל מקרה אחר ידפיס היקף
                    else
                        Console.WriteLine("The scope of rectangle is: " + ((height * 2) + (width * 2)));
                }

                //אם זה משולש
                if (op == 2)
                {
                    Console.WriteLine("press 1: To triangle perimeter");
                    Console.WriteLine("press 2: To triangle print");
                    string choose = Console.ReadLine();

                    //היקף משולש
                    if (choose == "1")
                    { 
                        double yeter = Math.Sqrt(Math.Pow(height, 2) + Math.Pow(width, 2));
                        Console.WriteLine("The triangle perimeter:" + (width + (2 * yeter)));
                    }

                    //נדפסת המשולש-במידה ואפשרי
                    else
                    {
                        // אם הרוחב הוא זוגי או גובה*2 קטן מהרוחב
                        if ((width % 2 == 0) || (height * 2 < width))
                        {
                            Console.WriteLine("The traingle can't be printed");
                            break;
                        }
                        //אם הרוחב הוא אי זוגי וגם גובה*2 גדול מהרוחב
                        else if ((width % 2 != 0) && (height * 2 > width))
                        {
                            //שורות הדפסה - לא כולל ראשון ואחרון
                            int LinePrint = height - 2;

                            //כמות המספרים האי זוגיים שיודפסו  - לא כולל ראשון ואחרון
                            int countNum = (width - 2) / 2;

                            // כמות שורות מכל מספר - לא כולל ראשון ואחרון
                            int countLineNum;

                            // כמות שורות שארית לשכבה העליונה
                            int countDivision;

                            // משמש למקרה קצה רוחב=3
                            int count1 = 0;


                            //נבדוק מקרי קצה:
                            // גובה- כי פחות מהנתון זה שונה
                            //



                            /*if ( height >= 3 ||  ( (width == 3) && (width > height) && (height != 2)
                             {
                                 //if ((height != 3) && (width != 3))

                                     countLineNum = LinePrint / countNum;
                                     Console.WriteLine("כמות שורות מכל מספר" + countLineNum);
                                     countDivision = LinePrint % countNum;
                                     Console.WriteLine("כמות שורות שארית" + countDivision);

                             }

                             else if (height == 3 )
                             {
                                 countLineNum = 0;
                                 countDivision = 1;
                             }

                             else 
                             {
                                 countLineNum = 0;
                                 countDivision = 0;
                             }*/

                            //בדיקת מקרי קצה
                            if (height >= 2 && width == 3)
                            {
                                countLineNum = LinePrint;
                                countDivision = LinePrint;
                                count1 = LinePrint;
                            }
                            else if (height == 3)
                            {
                                countLineNum = 0;
                                countDivision = 1;
                            }
                            else
                            {
                                countLineNum = LinePrint / countNum;
                                countDivision = LinePrint % countNum;
                            }


                            //הדפסת המשולש

                            //הדפסת שורה ראשונה
                            //רווחים בשורה הראשונה
                            for (int i = 0; i < width / 2; i++)
                                Console.Write(" ");
                            Console.Write("*");
                            Console.WriteLine("");

                            //מקרה קצה רוחב = 3
                            if (count1 > 0)
                            {
                                //count1-מוסיף כוכבית אחת בעבור כל שורה שצריך להוסיף,לפי ה
                                for (int j = 0; j < count1; j++)
                                {
                                    for (int i = 0; i < width / 2; i++)
                                        Console.Write(" ");
                                    Console.WriteLine("*");
                                }
                            }

                            //הדפסת שורות אמצעיות
                            for (int i = 3; i < width; i = i + 2)
                            {
                                int countSpace = (width - i) / 2;

                                // אם יש שארית-מוסיפים לשכבה העליונה
                                if (i == 3 && countDivision != 0)
                                {
                                    for (int x = 0; x < countDivision; x++)
                                    {
                                        for (int y = 0; y < countSpace; y++)
                                            Console.Write(" ");
                                        Console.Write("***");
                                        Console.WriteLine("");
                                    }
                                }
                                for (int a = 0; a < countLineNum; a++)
                                {

                                    //הדפסת רווחים
                                    for (int j = 0; j < countSpace; j++)
                                        Console.Write(" ");
                                    //הדפסת כוכביות
                                    for (int k = 0; k < i; k++)
                                        Console.Write("*");
                                    Console.WriteLine("");

                                }
                            }

                            //שורה אחרונה
                            for (int i = 0; i < width; i++)
                                Console.Write("*");
                            Console.WriteLine("");
                        }
                    }
                    

                    
                }
                Console.WriteLine("Option 1: enter 1 to select a rectangle");
                Console.WriteLine("Option 2: enter 1 to select a trainagle");
                Console.WriteLine("Option 3: enter 1 to exit");
                op = int.Parse(Console.ReadLine());
            }
            //יציאה מהתוכנית
            if (op == 3)
                return;
        }

    }
}
