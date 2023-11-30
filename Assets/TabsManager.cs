using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabsManager : MonoBehaviour
{
    public GameObject screen;
    float speed = 10f;
    public Vector2[] positions;
    Vector2 target;

    // Update is called once per frame
    void FixedUpdate()
    {
        screen.transform.position = Vector2.MoveTowards(screen.transform.position, target, speed * Time.deltaTime);
    }

    public void Press(int num)
    {
        target = positions[num];
    }
}
