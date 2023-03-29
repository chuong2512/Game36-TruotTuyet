using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using JumpFrog;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public enum State
{
    Running, Stop
}

public class GameUI : Singleton<GameUI>
{
    public Button back;
    public Button playAgain;
    public Button menu;
    public background bg;

    private GameObject level;
    public GameObject lose;
    public GameObject[] levels;

    public State currentState;

    // Start is called before the first frame update
    void Start()
    {
        RandomLevel();

        back.onClick.AddListener(ExitGame);
        menu.onClick.AddListener(RestartGame);
        playAgain.onClick.AddListener(playAgainGame);
    }

    private void playAgainGame()
    {
        //continue game
    }

    private void ExitGame()
    {
        SceneManager.LoadScene("Menu");
    }

    [Button]
    public void ShowLose()
    {
        SetState(State.Stop);
        lose.SetActive(true);
    }

    public float countTime;
    public float timeee = 1;
    
    public void Update()
    {
        if (currentState == State.Running)
        {
            countTime -= Time.deltaTime;

            if (countTime <= 0)
            {
                PointTMP.Instance.Add();

                countTime = timeee;
            }

            if (Input.GetMouseButtonDown(0))
            {
                Jump();
            }
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void NextLevel()
    {
        bg.Show();
        RandomLevel();
    }

    private void RandomLevel()
    {
        /*if (level != null)
        {
            Destroy(level);
        }

        level = Instantiate(levels[Random.Range(0, levels.Length)]);*/
    }

    [Button]
    public void Jump()
    {
      Player.Instance.Jump();
    }

    private float duration = 1f;
    
    
    public void EndJump()
    {
    }

    public void SetState(State state)
    {
        currentState = state;
    }
}