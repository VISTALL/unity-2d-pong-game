using System;
using System.Collections;
using UnityEngine;

public class MoveRacket : MonoBehaviour {
    public float speed = 30;
    public string axis = "Vertical";

    void FixedUpdate () {
        float v = Input.GetAxisRaw(axis);
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, v) * speed;

        bb();
    }

    public static void bb()
    {
        test(x => {
            Console.WriteLine(x);

        });
    }

    private static void test(Action<String> actionString)
    {
        actionString.Invoke("test");
    }
}
