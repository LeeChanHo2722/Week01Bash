using UnityEngine;

public class Lesson06 : MonoBehaviour
{
    private void Awake()
    {
        {
            int a = 5 + 6;
            int b = a - 3;
            int c = a * b;
            int d = c / 8;
            int e = d % 4;
        }

        {
            int a = 10;
            Debug.Log($"a = 10 : {a}");
            a += 10;
            Debug.Log($"a += 10 : 결과 값 {a}");
            Debug.Log($"a -= 9 : 결과 값 {a -= 9}");
            Debug.Log($"a *= 8 : 결과 값 {a *= 8}");
            Debug.Log($"a /= 7 : 결과 값 {a /= 7}");
            Debug.Log($"a %= 6 : 결과 값 {a %= 6}");
            Debug.Log($"a &= 5 : 결과 값 {a &= 5}");
            Debug.Log($"a |= 4 : 결과 값 {a |= 4}");
            Debug.Log($"a ^= 3 : 결과 값 {a ^= 3}");
            Debug.Log($"a <<= 2 : 결과 값 {a <<= 2}");
            Debug.Log($"a >>= 1 : 결과 값 {a >>= 1}");
        }

        {
            int a = 10;
            Debug.Log(a);
            a++;
            Debug.Log(a);
            ++a;
            Debug.Log(a);
            Debug.Log(a++);
            Debug.Log(a);
            Debug.Log(++a);
            Debug.Log(a);
        }

        {
            bool result = false;
            int x = 5, y = 2;
            result = (x > y);
            result = (x < y);
            result = (x >= y);
            result = (x <= y);
            result = (x == y);
            result = (x != y);
            result = x > 2 && y != 5;
            Debug.Log($"{x} > 2 && {y} != 5 = {result}");
            result = x < 4 || y == 3;
            Debug.Log($"{x} < 4 || {y} == 3 = {result}");
            Debug.Log(result);
            result = !result;
            Debug.Log(result);
            int hp = -10;
            hp = hp < 0 ? 0 : hp;
            Debug.Log("체력 : " + hp);
        }

        {
            int a = 3;
            Debug.Log($"{a} << 1 = {a << 1}");
            a = 255;
            Debug.Log($"{a} >> 1 = {a >> 1}");
            a = -255;
            Debug.Log($"{a} >> 1 = {a >> 1}");
            Debug.Log($"{a} >> 4 = {a >> 4}");
            Debug.Log(System.Convert.ToString(a >> 4, 2));
            Debug.Log($"10 & 6 = {10 & 6}");
        }
    }
}
