using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityLesson_CSharp_Operator
{
    static public class OperatorMethods
    {
          // 산술연산
          // ======================================================
          // 더하기
          static public int 더하기(int a,int b)
          {
            return a + b; 
          }
          static public int 빼기(int a,int b)
          {
            return a - b;
          }
          static public int 나누기(int a, int b)
          {
            return a / b;
          }
          // 만약 int가 아니라 실수인 float를 인자로 쓰고 싶다면?
          // 오버라이딩(overriding) 기능을 사용하면 됨.
          // 기존 함수를 그대로 가져다 쓰는 것
          static public float 나누기(float a,float b)
          {
            return a / b;
          }
          static public int 곱하기(int a,int b)
          {
            return a * b;
          }
          static public int 나머지(int a,int b)
          {
            return a % b;
          }

        // 증감 연산
         static public int 증가연산(int c)
         {
            int value = c;
            value++;
            return value
         }
        // 감소 연산
         static public int 감소연산(int c)
         {
            return c--;
         }
    }
}
