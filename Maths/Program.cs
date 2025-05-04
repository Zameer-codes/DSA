using System;
//if i want to get the last digit of a number then do modulo (%) by 10
//if i want to remove the last digit of a number then do division (/) by 10

Count(193840);
Reverse(193840);
Palindrome(1221);
Armstrong(153);
Divisors(16);
Prime(2);
GCD(12, 16);

//TC: O(logn)
void Count(int n){
    int count = 0;

    while(n>0){
        n=n/10;
        count++;
    }
    Console.WriteLine(count);
}

//TC:  O(logn)
void Reverse(int n){
    int reverse = 0;
    while(n>0){
        int eachDigit = n%10;
        reverse = (reverse *10)+eachDigit;
        n=n/10;
    }
    Console.WriteLine($"reverse : {reverse}");
}

//TC: O(logn)
void Palindrome(int n){
    int originalNumber = n;
    int reverse= 0;
    while(n>0){
        int eachDigit =n%10;
        reverse =(reverse*10)+eachDigit;
        n=n/10;
    }
    if(originalNumber == reverse){
        Console.WriteLine($"{originalNumber} is a palindrome");
    }
    else{
        Console.WriteLine($"{originalNumber} is not a palindrome");
    }
}

void Armstrong(int n){
    int originalNumber = n;
    int count = 0;
    int numberForCounting = n;
    while(numberForCounting>0){
        numberForCounting=numberForCounting/10;
        count++;
    }

    double ArmstrongNumber = 0;
    //next i have to calculate the power of each digit
    while(n>0){
        int eachDigit = n%10;
        ArmstrongNumber += Math.Pow(eachDigit, count);
        n=n/10;
    }
    if(originalNumber == ArmstrongNumber){
        Console.WriteLine($"{originalNumber} is an Armstrong number");
    }
    else{
        Console.WriteLine($"{originalNumber} is not an Armstrong number");
    }
}

//TC: O(sqrt(n))
void Divisors(int n){
    for(int i= 1; i<=n/i; i++){
        if(n%i == 0){
            Console.WriteLine(i);
            if(i != n/i){
                Console.WriteLine(n/i);
            }
        }
    }
}

//TC: O(sqrt(n))
void Prime(int n){
    int factorsCount = 0;
    for(int i =1; i<n/i; i++){
        if(n%i == 0){
            factorsCount++;
            if(i != n/i){
                factorsCount++;
            }
        }
    }
    if(factorsCount == 2){
        Console.WriteLine($"{n} is a prime number");
    }
    else{
        Console.WriteLine($"{n} is not a prime number");
    }
}

//TC: O(min(n, m))
void GCD(int n, int m){
    for(int i=Math.Min(n, m); i>0; i--){
        if(n%i == 0 && m%i == 0){
            Console.WriteLine($"GCD of {n}, {m} is {i}");
            break;
        }
    }
}