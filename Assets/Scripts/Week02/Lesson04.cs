using UnityEngine;

public class Lesson04 : MonoBehaviour
{
    enum PlayerState { Idle, Move, Attack }

    private void Awake()
    {
        const int MaxHP = 100;

        PlayerState playerState = PlayerState.Idle;
        switch (playerState)
        {
            case PlayerState.Idle:
                Debug.Log("플레이어 상태 : 대기");
                break;
            case PlayerState.Move:
                Debug.Log("플레이어 상태 : 이동");
                break;
            case PlayerState.Attack:
                Debug.Log("플레이어 상태 : 공격");
                break;
        }

        int? intValue;
        intValue = null;
        Debug.Log(intValue.HasValue);
        intValue = 30;
        Debug.Log(intValue.HasValue);
        Debug.Log(intValue.Value);

        var valueInt = 33;
        var valueFloat = 33.4567f;
        var valueString = "문자열";
        Debug.Log("정수 : " + valueInt);
        Debug.Log("실수 : " + valueFloat);
        Debug.Log("문자열 : " + valueString);
    }
}
