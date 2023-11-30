using UnityEngine;

public class TabsManager : MonoBehaviour
{
    public GameObject screen; // the background - mine is the Screen GameObject
    float speed = 10f; // the transition speed
    public Vector2[] positions; // the positions of your screens
    Vector2 target; // the position being targeted

    void FixedUpdate()
    { // moves towards the target. If the target is reached it stop
        screen.transform.position = Vector2.MoveTowards(screen.transform.position, target, speed * Time.deltaTime);
    }

    public void Press(int num)
    { // set the target position
        target = positions[num];
    }
}
