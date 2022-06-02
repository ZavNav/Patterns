using System;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Singleton
{
    public class ViewController : MonoBehaviour
    {
        [SerializeField] private Text leftScoreText;
        [SerializeField] private Text rightScoreText;

        private void Start()
        {
            leftScoreText.text = "0";
            rightScoreText.text = "0";
        }

        public void UpdateScoreText(int score, bool isLeft)
        {
            if (isLeft) leftScoreText.text = score.ToString();
            else rightScoreText.text = score.ToString();
        }
    }
}
