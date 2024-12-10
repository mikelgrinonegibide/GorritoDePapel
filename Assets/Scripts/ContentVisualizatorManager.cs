using UnityEngine;

public class ContentVisualizatorManager : MonoBehaviour
{

    [SerializeField] public GameObject ContentVisualizator;


    public static ContentVisualizatorManager Instance { get; private set; }


    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void ShowContent(Container container)
    {
        this.ContentVisualizator.SetActive(true);
    }

    public void HideContent()
    {

    }


}
