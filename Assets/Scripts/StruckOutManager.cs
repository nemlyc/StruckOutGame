using UnityEngine;
using Valve.VR;
using TMPro;

public class StruckOutManager : MonoBehaviour
{
    /*
     * ゲームの状態管理を行う。
     */
    private enum View
    {
        Game,
        Result
    }

    [SerializeField]
    TMP_Text scoreText;
    [SerializeField]
    GameObject GameView, ResultView;

    SteamVR_Input_Sources resetButton = SteamVR_Input_Sources.Any;
    SteamVR_Action_Boolean reset = SteamVR_Actions.VRThrow.reset;

    private static int score;
    private const int Point = 10;
    private static int viewIndex;

    private static ObjectSpawner spawner;


    private void Awake() {
        // スポナーの初期化
        spawner = GetComponent<ObjectSpawner>();
        score = 0;
        viewIndex = 0;

        if (scoreText == null) {
            scoreText =  GameObject.Find("ScoreText").GetComponent<TMP_Text>();
        }
    }

    private void Start() {
        spawner.RespawnBalls();
        spawner.RespawnTarget();
        scoreText.text = score.ToString();
        GameView.SetActive(true);
        ResultView.SetActive(false);
    }

    private void Update() {
        switch (viewIndex) {
            case (int)View.Game:
                ResultView.SetActive(false);
                GameView.SetActive(true);
                break;
            case (int)View.Result:
                GameView.SetActive(false);
                ResultView.SetActive(true);
                break;
        }

        if (reset.GetStateDown(resetButton)) {
            spawner.RespawnBalls();
        }
        scoreText.text = score.ToString();
        if(score > 80) {
            viewIndex = (int)View.Result;
        }
    }

    /// <summary>
    /// スコアのカウントをプラスする。
    /// </summary>
    public static void CountPlus() {
        score += Point;
    }

    public static void Retry() {
        score = 0;
        viewIndex = 0;
        spawner.RespawnBalls();
        spawner.RespawnTarget();
    }
}
