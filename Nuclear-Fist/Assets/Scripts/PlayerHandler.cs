using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHandler : MonoBehaviour {

    public Rigidbody player;

    private bool canJump = true;

    // Update is called once per frame
    void FixedUpdate() {
        transform.Translate(new Vector3(Input.GetAxis("Horizontal") / 2, 0, Input.GetAxis("Vertical") / 2));

        transform.Rotate(new Vector3(0, Input.GetAxis("Mouse X") * 2, 0));

        if (Input.GetKeyDown(KeyCode.Space) && canJump) {
            player.AddForce(new Vector3(0, 5, 0), ForceMode.Impulse);
            canJump = false;
        }
    }

    private void OnCollisionEnter(Collision collision) {
        if (collision.collider.CompareTag("Floor")) {
            canJump = true;
        }
    }
}
