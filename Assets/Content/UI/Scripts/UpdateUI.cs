using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
using System.Collections;

public class UpdateUI : MonoBehaviour
{

    private Button startButton;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    private void OnEnable()
    {
        var doc = GetComponent<UIDocument>();
        var root = doc.rootVisualElement;

        startButton = root.Q<Button>("StartButton");
        startButton.clicked += OnStartPressed;
    }

    private void OnDisable()
    {
        startButton.clicked -= OnStartPressed;
    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnStartPressed()
    {
        Debug.Log("Pressed Start");
        StartCoroutine(StartGame());
    }

    private IEnumerator StartGame()
    {

        // Load Main additivt (managers, systems)
        yield return SceneManager.LoadSceneAsync("FeedTheAnimal", LoadSceneMode.Additive);

        // Load UI additivt (menus, HUD)
        yield return SceneManager.LoadSceneAsync("UI", LoadSceneMode.Additive);

        // Når Main + UI kører, kan vi fjerne Bootstrap-scenen
        yield return SceneManager.UnloadSceneAsync(gameObject.scene);
    }

}
