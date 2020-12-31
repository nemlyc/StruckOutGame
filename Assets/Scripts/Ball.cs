using UnityEngine;

public class Ball : MonoBehaviour
{
    readonly string targetTag = "Target";
    readonly string retry = "RetryButton";
    readonly string ground = "Ground";

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag(targetTag)) {
            Destroy(other.gameObject);
            StruckOutManager.CountPlus();

            Destroy(gameObject);
        }
        if (other.gameObject.name.Equals(retry)) {
            StruckOutManager.Retry();
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.name.Equals(ground)) {
            Destroy(gameObject);
        }
    }
}
