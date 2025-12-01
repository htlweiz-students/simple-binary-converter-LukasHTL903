namespace SimpleBinaryConverter;

using System;

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
