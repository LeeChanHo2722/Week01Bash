using UnityEngine;

public class Lesson03 : MonoBehaviour
{
    private void Awake()
    {
        {
            sbyte sbyteValue = 10;
            int intValue = (int)sbyteValue;
            Debug.Log("sbyteValue : " + sbyteValue);
            Debug.Log("intValue : " + intValue);
            intValue = 130;
            sbyteValue = (sbyte)intValue;
            Debug.Log("sbyteValue : " + sbyteValue);
            Debug.Log("intValue : " + intValue);
        }

        {
            sbyte sbyteValue = 31;
            byte byteValue = (byte)sbyteValue;
            Debug.Log("sbyteValue : " + sbyteValue);
            Debug.Log("byteValue : " + byteValue);
            sbyteValue = -31;
            byteValue = (byte)sbyteValue;
            Debug.Log("sbyteValue : " + sbyteValue);
            Debug.Log("byteValue : " + byteValue);
        }

        {
            float floatValue = 69.6875f;
            double doubleValue = (double)floatValue;
            Debug.Log("floatValue : " + floatValue);
            Debug.Log("doubleValue : " + doubleValue);
            floatValue = 0.1f;
            doubleValue = (double)floatValue;
            Debug.Log("floatValue : " + floatValue);
            Debug.Log("doubleValue : " + doubleValue);
        }

        {
            float floatValue = 0.9f;
            int intValue = (int)floatValue;
            Debug.Log("floatValue : " + floatValue);
            Debug.Log("intValue : " + intValue);
            floatValue = 1.1f;
            intValue = (int)floatValue;
            Debug.Log("floatValue : " + floatValue);
            Debug.Log("intValue : " + intValue);
        }

        {
            int intValue = 10;
            float floatValue = 12.3456f;
            string stringValue = "33";
            Debug.Log("intValue : " + intValue);
            Debug.Log("floatValue : " + floatValue);
            Debug.Log("stringValue : " + stringValue);
            intValue = int.Parse(stringValue);
            stringValue = "33.4567";
            floatValue = float.Parse(stringValue);
            Debug.Log("intValue : " + intValue);
            Debug.Log("floatValue : " + floatValue);
            Debug.Log("stringValue : " + stringValue);
        }

        {
            string stringValue = "초기화";
            int intValue = 33;
            float floatValue = 12.3456f;
            Debug.Log("stringValue : " + stringValue);
            stringValue = intValue.ToString();
            Debug.Log("stringValue : " + stringValue);
            stringValue = floatValue.ToString();
            Debug.Log("stringValue : " + stringValue);
        }

        {
            string stringValue = "숫자가 아닙니다.";
            int intValue = 10;
            bool isConversion = int.TryParse(stringValue, out intValue);
            if (isConversion == true)
            {
                Debug.Log("stringValue : " + stringValue);
                Debug.Log("intValue : " + intValue);
            }
            else
            {
                Debug.Log("stringValue 변수에 들어있는 내용이 숫자가 아니어서 형변환에 실패하였습니다.");
            }
        }
    }
}
