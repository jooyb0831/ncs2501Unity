using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumScript : MonoBehaviour
{
    enum Direction {None, North, East, South, West, Error}

    // Start is called before the first frame update
    void Start()
    {

        Direction myDir;
        myDir = Direction.Error;
        Debug.Log($"CurDir : {myDir}");
        if(!myDir.Equals(Direction.Error))
        {
            Debug.Log($"NewDir : {ReverseDricetion(myDir)}");
        }
    }

    Direction ReverseDricetion(Direction dir)
    {
        /*
        if(dir.Equals(Direction.North))
        {
            dir = Direction.South;
        }
        else if (dir.Equals(Direction.South))
        {
            dir = Direction.North;
        }
        else if(dir.Equals(Direction.East))
        {
            dir = Direction.West;
        }
        else if(dir.Equals(Direction.West))
        {
            dir = Direction.East;
        }
        return dir;
        */
        //case 쓸 때 Enum 인덱스 순서에 맞춰 적으면 아주 미세하게 속도가 빠름.
        switch(dir)
        {
            case Direction.North:
                dir = Direction.South;
                break;
            case Direction.South:
                dir = Direction.North;
                break;
            case Direction.East:
                dir = Direction.West;
                break;
            case Direction.West:
                dir = Direction.East;
                break;
            default :
                Debug.Log($"알 수 없는 방향 : {dir}");
                dir = Direction.Error;
                break;
        }   
        return dir;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
