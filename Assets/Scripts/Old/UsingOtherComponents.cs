using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsingOtherComponents : MonoBehaviour
{
    public GameObject otherGameObject;

    private AnotherScripts anotherScripts;
    private YetAnotherScripts yetAnotherScripts;
    private BoxCollider coll;

    void Awake()
    {
        anotherScripts = GetComponent<AnotherScripts>();
        yetAnotherScripts = otherGameObject.GetComponent<YetAnotherScripts>();
        coll = otherGameObject.GetComponent<BoxCollider>();
    }
    // Start is called before the first frame update
    void Start()
    {
        coll.size = new Vector3(3,3,3);
        Debug.Log($"The player's score is {anotherScripts.playerScore}");
        Debug.Log($"The player has died {yetAnotherScripts.numberOfPlayerDeaths}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
