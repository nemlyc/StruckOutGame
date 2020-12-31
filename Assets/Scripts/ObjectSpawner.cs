using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField]
    GameObject ballPrefab, targetPrefab;

    const string BallTag = "Ball";
    const string Target = "Target";

    static readonly Vector3 SpawnPoint1 = new Vector3(0, 0.6f, 0.8f);
    static readonly Vector3 SpawnPoint2 = new Vector3(0.4f, 0.6f, 0.8f);
    static readonly Vector3 SpawnPoint3 = new Vector3(-0.4f, 0.6f, 0.8f);

    static readonly Vector3 targetPoint = new Vector3(0, 3, 10);

    public void RespawnBalls() {
        if (!CheckEmpty(BallTag))
            return;

        Instantiate(ballPrefab, SpawnPoint1, Quaternion.identity);
        Instantiate(ballPrefab, SpawnPoint2, Quaternion.identity);
        Instantiate(ballPrefab, SpawnPoint3, Quaternion.identity);
    }

    public void RespawnTarget() {
        //if (!CheckEmpty(Target))
        Destroy(GameObject.FindGameObjectWithTag(Target));

        Instantiate(targetPrefab, targetPoint, Quaternion.identity);
    }

    bool CheckEmpty(string name) {
        if (GameObject.FindGameObjectsWithTag(name).Length == 0) {
            return true;
        } else {
            return false;
        }
    }
}
