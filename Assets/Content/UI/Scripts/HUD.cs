using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class HUD : MonoBehaviour
{
    Label scoreLabel, timerLabel;
    private InputSystem_Actions input;

    private void Update()
    {

        SetTime((int)Time.time);

    }

    void OnEnable()
    {

        var root = GetComponent<UIDocument>().rootVisualElement;
        scoreLabel = root.Q<Label>("ScoreLabel");
        timerLabel = root.Q<Label>("TimerLabel");
        SetScore(0);
        SetTime(30);

        input = new InputSystem_Actions();

        input.Player.Enable();

        input.Player.FeedAnimal.performed += OnFeedAnimal;

    }

    public void SetScore(int value)
    {

        if (scoreLabel != null) scoreLabel.text = $"Score: {value}";

    }

    public void SetTime(int seconds)
    {

        if (timerLabel != null) timerLabel.text = $"{seconds}s";

    }

    private int score = 0;


    private void OnDisable()
    {

        input.Player.FeedAnimal.performed -= OnFeedAnimal;
        input.Player.Disable();

    }

    private void OnFeedAnimal(InputAction.CallbackContext context)
    {

        score++;
        SetScore(score);

    }


}

