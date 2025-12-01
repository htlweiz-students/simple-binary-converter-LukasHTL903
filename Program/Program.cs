namespace SimpleBinaryConverter;

using System;
using SimpleBinaryConverter;

public class DecimalConv{
    public static Int64 Bi_to_Decimal(bool[] bi_numb, int bi_lenght){
        
        Int64 deci_numb = 0;

        for(int count = 0; count < bi_lenght; count ++){
            
            if(bi_numb[count] == true){
                deci_numb += Convert.ToInt64(Math.Pow(2, bi_lenght-(count+1)));
            }
        }

        return deci_numb;
    }
}

public class Program{
    public static void Main(){
        bool[] bi_numb = {true, false, false, false};
        
       Console.WriteLine(DecimalConv.Bi_to_Decimal(bi_numb, bi_numb.Length));

    }
}