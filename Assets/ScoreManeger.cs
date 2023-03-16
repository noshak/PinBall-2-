using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManeger : MonoBehaviour
{

    private GameObject scoreText;  //得点を表示するテキスト
    private int score;

    void OnCollisionEnter(Collision other) //衝突 
    {
        if (other.gameObject.tag == "SmallStarTag" || other.gameObject.tag == "LargeStarTag") //星衝突時は1点プラス
        {
            this.score += 1;
        }
        else if (other.gameObject.tag == "SmallCloudTag")　//小さい雲衝突時は3点プラス
        {
            this.score += 3;
        }
        else if (other.gameObject.tag == "LargeCloudTag")　//大きい雲衝突時は10点プラス
        {
            this.score += 10;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        score = 0;

        this.scoreText = GameObject.Find("ScoreText");　//シーン中のScoreTextオブジェクトを取得
    }

    // Update is called once per frame
    void Update()
    {
        //ScoreTextに得点を表示
        this.scoreText.GetComponent<Text>().text = "Score:" + this.score;
    }
}
