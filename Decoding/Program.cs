using static System.Console;
using static System.Convert;
using static System.Math;


int n;
string str,testCase,res="";


n = ToInt32(ReadLine());
str = ReadLine();

testCase = str;


while(testCase.Length > 0)
{
    if(testCase.Length % 2 == 0)
    {
        res = testCase[0] + res;
    }
    else
    {
        res += testCase[0];

    }
    testCase =testCase.Remove(0,1);
}


WriteLine(res);