
using UnityEngine;

public class TopDownPlayerController : MonoBehaviour {

    public float forwardForce, turnForce;

    private Rigidbody2D rigidBody;

    private void Start () {

        rigidBody = GetComponent<Rigidbody2D>();
    }

    private void Update () {

        brake = Input.GetKey(KeyCode.Space);

        forward = Input.GetKey(KeyCode.W) && !brake;
        left = Input.GetKey(KeyCode.A) && !brake;
        right = Input.GetKey(KeyCode.D) && !brake;
    }

    private bool forward, left, right, brake;

    private void FixedUpdate () {

        if (forward)
            rigidBody.AddForce(transform.up * forwardForce);

        if (left)
            rigidBody.AddTorque(turnForce);

        if (right)
            rigidBody.AddTorque(-turnForce);
    }
}
