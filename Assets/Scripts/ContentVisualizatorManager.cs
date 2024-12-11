using TMPro;
using UnityEngine;

public class ContentVisualizatorManager : MonoBehaviour
{

    [SerializeField] public GameObject ContentVisualizator;
    private GameObject Container;
    private TMP_Text Title;
    private Container Content;


    public static ContentVisualizatorManager Instance { get; private set; }

    #region Unity methods

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

    private void Start()
    {
        this.Container = this.transform.Find("ContentVisualizator/Container").gameObject;
        this.Title = this.transform.Find("ContentVisualizator/Title").gameObject.GetComponent<TMP_Text>();
    }

    #endregion

    public void ShowContent(string title, Container container)
    {
        this.Content = container;
        SetTitle(title);
        this.ContentVisualizator.SetActive(true);
    }

    public void ClearContent()
    {
        this.Content = null;
        this.ContentVisualizator.SetActive(false);
    }


    #region Events handlers

    public void OnContainerExit()
    {
        ClearContent();
    }

    #endregion

    #region Private methods

    private void SetTitle(string title)
    {
        this.Title.text = title;
    }

    #endregion



}
