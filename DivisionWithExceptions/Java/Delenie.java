package com.company;
import java.util.Scanner;
public class Main
{
    public static void main(String[] args)
    {
        try
        {
            Scanner in = new Scanner(System.in);

            System.out.println("Введите первое число");
            double num1 = in.nextDouble();

            System.out.println("Введите второе число");
            double num2 = in.nextDouble();

            if(num2 == 0)
            {
             System.out.println ("Вы не можете делить на 0");
            }
            else
            {

                double res = num1 / num2;
                System.out.print("Результат: ");
                System.out.println(res);
            }
        }
        catch (Exception err)
        {
            System.out.println("Ошибка ввода");
        }
        finally
        {
            System.out.println("Конец");
        }

    }


}
