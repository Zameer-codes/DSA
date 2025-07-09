using System;

public static class Patterns
{
    public static void P1(int n){
        for (int i=0; i<n; i++){
            for(int j=0; j<n; j++){
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }

    public static void P2(int n){
        for(int i=0; i<n; i++){
            for(int j=0;j<=i; j++){
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }

    public static void P3(int n){
        for(int i=1; i<=n; i++){
            for(int j=1; j<=i; j++){
                Console.Write(j);
            }
            Console.WriteLine();
        }
    }
    
    public static void P4(int n){
        for(int i=1; i<=n; i++){
            for(int j=1; j<=i; j++){
                Console.Write(i);
            }
            Console.WriteLine();
        }
    }

    public static void P5(int n){
        for(int i=0; i<n; i++){
            for(int j=0; j<n-i; j++){
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }

    public static void P6(int n){
        for(int i=0; i<n; i++){
            for(int j=0; j<n-i; j++){
                Console.Write(j+1);
            }
            Console.WriteLine();
        }
    }

    public static void P7(int n){
        for(int i=1; i<=n; i++){
            //startig spaces
            for(int j=1; j<=n-i; j++){
                Console.Write(" ");
            }

            //stars
            for(int j=1; j<=2*i-1; j++){
                Console.Write("*");
            }

            //ending spaces
            for(int j=1; j<n-i; j++){
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }

    public static void P8(int n){
        for(int i=0; i<n; i++){
            //starting spaces
            for(int j=0; j<i; j++){
                Console.Write(" ");
            }

            //stars
            for(int j=0; j<2*(n-i)-1; j++){
                Console.Write("*");
            }

            //ending spaces
            for(int j=0; j<i; j++){
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }


    public static void P9(int n){
        for(int i=0; i<2*n-1; i++){
            int starIndex = i+1;
            if(i>=n){
                starIndex = 2*n-i-1;
            }
            for(int j=0; j<starIndex; j++){
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
    
    public static void P10(int n){
        for(int i=0; i<n; i++){
            int value =1;
            if(i%2!=0){
                value=0;
            }
            for(int j=0; j<i+1; j++){
                Console.Write(value);
                if(value==0){
                    value=1;
                }
                else{
                    value=0;
                }
            }
            Console.WriteLine();
        }
    }

    public static void P11(int n){
        for(int i=0; i<n; i++){
            for(int j=0; j<i+1; j++){
                Console.Write(j+1);
            }

            for(int j=0; j<2*(n-i-1); j++){
                Console.Write(" ");
            }

            for(int j=i+1; j>0; j--){
                Console.Write(j);
            }
            Console.WriteLine();
        }
    }

    public static void P12(int n){
        int counter=1;
        for(int i=0; i<n; i++){
            for(int j=0; j<i+1; j++){
                Console.Write($"{counter} ");
                counter++;
            }
            Console.WriteLine();
        }
    }

    public static void P13(int n){
        for(int i=0; i<n; i++){
            char ch = 'A';
            for(int j=0; j<i+1; j++){
                Console.Write(ch);
                ch++;
            }
            Console.WriteLine();
        }
    }
    
    public static void P14(int n){
        for(int i=0; i<n; i++){
            char ch= 'A';
            for(int j=n-i; j>0; j--){
                Console.Write(ch);
                ch++;
            }
            Console.WriteLine();
        }
    }

    public static void P15(int n){
        char ch = 'A';
        for(int i=0; i<n; i++){
            for(int j=0; j<i+1; j++){
                Console.Write(ch);
            }
            ch++;
            Console.WriteLine();
        }
    }
    public static void P16(int n){
         for(int i=1; i<=n; i++){
            //startig spaces
            for(int j=1; j<=n-i; j++){
                Console.Write(" ");
            }

            //chars

            char ch='A';
            int breakpoint = (2*i-1)/2;
            for(int j=1; j<=2*i-1; j++){
                Console.Write(ch);
                if(j<=breakpoint){
                    ch++;
                }
                else{
                    ch--;
                }
            }

            //ending spaces
            for(int j=1; j<n-i; j++){
                Console.Write(" ");
            }
            Console.WriteLine();
         }
    }

    public static void P17(int n){
        for(int i=0; i<n; i++){
            char ch= (char)('A'+n-i-1);
            for(int j=n-i-1; j<n; j++){
                Console.Write(ch);
                ch++;
            }
            Console.WriteLine();
        }        
    }

    public static void P18(int n){
        for(int i=0; i<n; i++){
            for(int j=0; j<n-i; j++){
                Console.Write("*");
            }

            for(int j=0; j<2*i; j++){
                Console.Write(" ");
            }

            for(int j=0; j<n-i; j++){
                Console.Write("*");
            }
            Console.WriteLine();
        }
        for(int i=0; i<n; i++){
            for(int j=0; j<i+1; j++){
                Console.Write("*");
            }

            for(int j=0; j<2*(n-i-1); j++){
                Console.Write(" ");
            }

            for(int j=i+1; j>0; j--){
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    public static void P19(int n){
        int starCount = 0;
        int spaceCount = 0;
        for(int i =1; i<=2*n-1; i++){
            starCount = i;
            if(i>n){
                starCount = 2*n-i;
            }

            spaceCount = 2*(n-i);
            if(i>n){
                spaceCount = 2*(i-n);
            }

            //initial stars
            for(int j=1; j<=starCount; j++){
                Console.Write("*");
            }
            //spaces
            for(int j=1; j<=spaceCount; j++){
                Console.Write(" ");
            }

            //ending stars
            for(int j=1; j<=starCount; j++){
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    public static void P20(int n){
        for(int i=0; i<n; i++){
            for(int j=0; j<n; j++){
                if(i==0 || i==n-1 || j==0 || j==n-1){
                    Console.Write("*");
                }
                else{
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }

    public static void P21(int n){
        for(int i=0; i<2*n-1; i++){
            for(int j=0; j<2*n-1; j++){
                int top = i;
                int left = j;
                int right = 2*n-1-j-1;
                int bottom = 2*n-1-i-1;
                int min = Math.Min(Math.Min(top, left), Math.Min(right, bottom));
                Console.Write($"{n-min} ");
            }
            Console.WriteLine();
        }
    }
}

/*

****
***
**
*

no of lines = n
relation = n-i where 0<i<n
0<j<n-i
print *

----------------

1234
123
12
1

no of lines = n
relation = n-i where 0<i<n
0<j<n-i
print j+1

----------------

    *    
   ***   
  *****  
 ******* 
*********

no of lines = n
relation :
1<i<=n
n-i spaces --> print " "
2i-1 stars --> print "*"
n-i spaces --> print " "

-------------------------

*********
 ******* 
  *****   
   ***
    *

no of lines = n
relation :
0<i<n

i spaces
2(n-i)-1 stars
i spaces

---------------

*
**
***
****
***
**
*

no of lines = 2n-1
relation : 

0<i<2n-1

stars

i<n : i+1
i>=n : 2n-i-1

-----------------------

1
01
101
0101
10101

no of lines = n
relation :

i%2!=0 : startValue=1
i%2==0 : startValue=0

-------------------------

1      1
12    21
123  321
12344321

no of lines : n
relation : 

spaces : 2n-i-1

startDigit : i+1 --> 0<j<i+1
endDigit : i+1 --> i+1<j<0

--------------------------
E
DE
CDE
BCDE
ABCDE

no of lines : n
relation : 

it is in incrementing order
right shifting the char by i+1 from last

char+n-i-1

then increment upto n


--------------------------


**********
****  ****
***    ***
**      **
*        *
*        *
**      **
***    ***
****  ****
**********


no of lines : 2n

-----------------------


*/