using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject PlayerPrefab;
    public Text scoreText;
    public Text lifeText;
    public Text timeText;
    public Text levelText;
    public GameObject panelMenu;
    public GameObject panelPlay;
    public GameObject panelLevelCompleted;
    public GameObject panelGameOver;

    public GameObject[] levels;

    public static GameManager Instance {get; private set;}

    public enum State { MENU, INIT, PLAY, LEVELCOMPLETED, LOADLEVEL, GAMEOVER }
    State _state;
    //GameObject _currentBall;
    GameObject _currentPlayer;
    GameObject _currentLevel;
    bool _isSwitchingState;
    bool wyjscieGracza;
    Exit exitPlayer;
    public void UpdateExit(bool exit)
    {
        wyjscieGracza = exit;
    }
    

    private int _score;
    public int Score
    {
        get { return _score; }
        set 
        { 
            _score = value;
            scoreText.text = "SCORE: " + _score;
        }
    }

    private int _level;
    public int Level
    {
        get { return _level; }
        set 
        {
            _level = value;
            levelText.text = "LEVEL: " + _level;
        }
    }

    private int _life;
    public int Life
    {
        get { return _life; }
        set 
        { 
            _life = value;
            lifeText.text = "LIFE: " + _life;
        }
    }
    private int _time;
    public int Time
    {
        get { return _time; }
        set 
        {
            _time = value;
            timeText.text = "TIME: " + _time;
        }
    }
    
    
    
    public void PlayClicked()
    {
        SwitchState(State.INIT);
    }

    void Start()
    {
        exitPlayer = FindObjectOfType<Exit>();
        
        Instance = this;
        SwitchState(State.MENU);
    }
    

    public void SwitchState(State newState, float delay = 0)
    {
        StartCoroutine(SwitchDelay(newState, delay));

    }
    IEnumerator SwitchDelay(State newState, float delay)
    {
        _isSwitchingState = true;
        yield return new WaitForSeconds(delay);
        EndState();
        _state = newState;
        BeginState(newState);
        _isSwitchingState = false;
    }
    void BeginState(State newState)
    {
        switch (newState)
        {
            case State.MENU:
                panelMenu.SetActive(true);
                break;
            case State.INIT:
                panelPlay.SetActive(true);
                Score = 0;
                Level = 0;
                Life = 3;
                Time = 0;
                if(_currentLevel != null)
                {
                    Destroy(_currentLevel);
                }
                //Instantiate(PlayerPrefab);
                SwitchState(State.LOADLEVEL);
                break;
            case State.PLAY:
                break;
            case State.LEVELCOMPLETED:
                Destroy(_currentPlayer);
                Destroy(_currentLevel);
                Level++;
                panelLevelCompleted.SetActive(true);
                SwitchState(State.LOADLEVEL, 2f);
                wyjscieGracza = false;
                break;
            case State.LOADLEVEL:
                if(Level >= levels.Length)
                {
                    SwitchState(State.GAMEOVER);
                }
                else
                {
                    _currentLevel = Instantiate(levels[Level]);
                    SwitchState(State.PLAY);
                }
                break;
            case State.GAMEOVER:
                panelGameOver.SetActive(true);
                break;
        }
    }

    void Update()
    {
        //Debug.Log(wyjscieGracza);

        switch (_state)
        {
            case State.MENU:
                break;
            case State.INIT:
                break;
            case State.PLAY:
                if(_currentPlayer == null)
                {
                    if(Life >0 )
                    {
                        _currentPlayer = Instantiate(PlayerPrefab);
                    }
                    else
                    {
                        SwitchState(State.GAMEOVER);
                    }
                }
               
                if(_currentLevel != null && GameObject.FindGameObjectsWithTag("Diamont").Length == 0 && !_isSwitchingState && wyjscieGracza)
                {
                    SwitchState(State.LEVELCOMPLETED);
                }
                break;
            case State.LEVELCOMPLETED:
                break;
            case State.LOADLEVEL:
                break;
            case State.GAMEOVER:
                if(Input.anyKeyDown)
                {
                    SwitchState(State.MENU);
                }
                break;
        }
    }

    void EndState()
    {
        switch (_state)
        {
            case State.MENU:
                panelMenu.SetActive(false);
                break;
            case State.INIT:
                break;
            case State.PLAY:
                break;
            case State.LEVELCOMPLETED:
                panelLevelCompleted.SetActive(false);
                break;
            case State.LOADLEVEL:
                break;
            case State.GAMEOVER:
                panelPlay.SetActive(false);
                panelGameOver.SetActive(false);
                break;
        }
    }
    
}
