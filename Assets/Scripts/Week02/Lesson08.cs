using UnityEngine;

public class Lesson08 : MonoBehaviour
{
    private void Awake()
    {
        for (int index = 0; index < 10; ++index)
        {
            Debug.Log(index);
        }

        {
            int result = 0;
            int index = 1;
            while (index <= 100)
            {
                result += index;
                index++;
            }
            Debug.Log($"1부터 100까지의 합은 {result}");
        }

        {
            int index = 0;
            do
            {
                Debug.Log(index);
                index++;
            } while (index < 10);
        }

        for (int index = 0; index < 10; ++index)
        {
            if (index == 5)
            {
                break;
            }
            Debug.Log(index);
        }

        for (int index = 0; index < 10; ++index)
        {
            if (index == 5)
            {
                continue;
            }
            Debug.Log(index);
        }
    }
}
