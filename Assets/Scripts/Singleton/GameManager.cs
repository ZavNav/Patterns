using UnityEngine;

namespace Singleton
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance;
        private ViewController _viewController;
        private int _leftScore = 0;
        private int _rightScore = 0;
        
        private void Start()
        {
            if (Instance == null)
            {
                Instance = this;
            }
            else
            {
                Destroy(gameObject);
            }

            _viewController = FindObjectOfType<ViewController>();
        }

        public void UpdateScore(int scoreDelta, Cube cube)
        {
            if (cube is LeftCube)
            {
                _leftScore += scoreDelta;
                _viewController.UpdateScoreText(_leftScore, true);
            }
            else
            {
                _rightScore += scoreDelta;
                _viewController.UpdateScoreText(_rightScore, false);
            }
        }
    }
}
