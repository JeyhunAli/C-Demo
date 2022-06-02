using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodeDemo
{
    internal class operators
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 3;
            int num3;

            //So the first one of them want to show you is going to store the value of minus number one in number three.
            //So that's going to do is it will multiply number one with minus one.
            //If we run that, so CW console, right, line, double tap, and in here I'm going to write something like it.
            //Number three is and here I use curly brackets zero four.
            //That will do is it will simply replace this whole thing here with the first variable that comes after
            // unary operators
            num3 = -num1;
            Console.WriteLine("num3 is {0}", num3);

            bool isSunny = true;
            Console.WriteLine("is it sunny? {0}", !isSunny);

            // increment operators
            int num = 0;
            num++;
            Console.WriteLine("num is {0}", num);
            Console.WriteLine("num is {0}", num++);
            // pre increment
            Console.WriteLine("num is {0}", ++num);

            // decrement opertor
            num--;
            Console.WriteLine("num is {0}", num);
            Console.WriteLine("num is {0}", num--);
            // pre decrement
            Console.WriteLine("num is {0}", --num);

            int result;

            result = num1 + num2;
            Console.WriteLine("result of num1 + num2 is {0}", result);
            result = num1 - num2;
            Console.WriteLine("result of num1 - num2 is {0}", result);
            result = num1 / num2;
            Console.WriteLine("result of num1 / num2 is {0}", result);
            result = num1 * num2;
            Console.WriteLine("result of num1 * num2 is {0}", result);
            result = num1 % num2;
            Console.WriteLine("result of num1 % num2 is {0}", result);

            // relational and type operators
            bool isLower;
            isLower = num1 < num2;
            Console.WriteLine("result of num1 < num2 is {0}", isLower);

            // equality operator
            bool isEqual;
            isEqual = num1 == num2;
            Console.WriteLine("result of num1 == num2 is {0}", isEqual);

            isEqual = num1 != num2;
            Console.WriteLine("result of num1 != num2 is {0}", isEqual);

            // conditional operators
            bool isLowerAndSunny;
            // condition1 AND condition2
            isLowerAndSunny = isLower && isSunny;
            Console.WriteLine("result of isLower && isSunny is {0}", isLowerAndSunny);

            // condition1 OR condition2
            isLowerAndSunny = isLower || isSunny;
            Console.WriteLine("result of isLower || isSunny is {0}", isLowerAndSunny);
            Console.ReadKey();
        }
    }
}
/*
 * +	Adds two operands	A + B = 30
-	Subtracts second operand from the first	A - B = -10
*	Multiplies both operands	A * B = 200
/	Divides numerator by de-numerator	B / A = 2
%	Modulus Operator and remainder of after an integer division	B % A = 0
++	Increment operator increases integer value by one	A++ = 11
--	Decrement operator decreases integer value by one	A-- = 9


 * ==	Checks if the values of two operands are equal or not, if yes then condition becomes true.	(A == B) is not true.
!=	Checks if the values of two operands are equal or not, if values are not equal then condition becomes true.	(A != B) is true.
>	Checks if the value of left operand is greater than the value of right operand, if yes then condition becomes true.	(A > B) is not true.
<	Checks if the value of left operand is less than the value of right operand, if yes then condition becomes true.	(A < B) is true.
>=	Checks if the value of left operand is greater than or equal to the value of right operand, if yes then condition becomes true.	(A >= B) is not true.
<=	Checks if the value of left operand is less than or equal to the value of right operand, if yes then condition becomes true.	(A <= B) is true.
 * 
 * &&	Called Logical AND operator. If both the operands are non zero then condition becomes true.	(A && B) is false.
||	Called Logical OR Operator. If any of the two operands is non zero then condition becomes true.	(A || B) is true.
!	Called Logical NOT Operator. Use to reverses the logical state of its operand. If a condition is true then Logical NOT operator will make false.	!(A && B) is true.


=	Simple assignment operator, Assigns values from right side operands to left side operand	C = A + B assigns value of A + B into C
+=	Add AND assignment operator, It adds right operand to the left operand and assign the result to left operand	C += A is equivalent to C = C + A
-=	Subtract AND assignment operator, It subtracts right operand from the left operand and assign the result to left operand	C -= A is equivalent to C = C - A
*=	Multiply AND assignment operator, It multiplies right operand with the left operand and assign the result to left operand	C *= A is equivalent to C = C * A
/=	Divide AND assignment operator, It divides left operand with the right operand and assign the result to left operand	C /= A is equivalent to C = C / A
%=	Modulus AND assignment operator, It takes modulus using two operands and assign the result to left operand	C %= A is equivalent to C = C % A
<<=	Left shift AND assignment operator	C <<= 2 is same as C = C << 2
>>=	Right shift AND assignment operator	C >>= 2 is same as C = C >> 2
&=	Bitwise AND assignment operator	C &= 2 is same as C = C & 2
^=	bitwise exclusive OR and assignment operator	C ^= 2 is same as C = C ^ 2
|=	bitwise inclusive OR and assignment operator	C |= 2 is same as C = C | 2


sizeof()	Returns the size of a data type.	sizeof(int), returns 4.
typeof()	Returns the type of a class.	typeof(StreamReader);
&	Returns the address of an variable.	&a; returns actual address of the variable.
*	Pointer to a variable.	*a; creates pointer named 'a' to a variable.
? :	Conditional Expression	If Condition is true ? Then value X : Otherwise value Y
is	Determines whether an object is of a certain type.	If( Ford is Car) // checks if Ford is an object of the Car class.
as	Cast without raising an exception if the cast fails.	Object obj = new StringReader("Hello");
StringReader r = obj as StringReader;

Postfix	() [] -> . ++ - -	Left to right
Unary	+ - ! ~ ++ - - (type)* & sizeof	Right to left
Multiplicative	* / %	Left to right
Additive	+ -	Left to right
Shift	<< >>	Left to right
Relational	< <= > >=	Left to right
Equality	== !=	Left to right
Bitwise AND	&	Left to right
Bitwise XOR	^	Left to right
Bitwise OR	|	Left to right
Logical AND	&&	Left to right
Logical OR	||	Left to right
Conditional	?:	Right to left
Assignment	= += -= *= /= %=>>= <<= &= ^= |=	Right to left
Comma	,	Left to right

 * 
 */