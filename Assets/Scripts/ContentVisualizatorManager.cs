using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

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
        SetItems(container);
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

    private void SetItems(Container container)
    {
        DestroyContainerChildren();
        var itemPrefab = (GameObject)AssetDatabase.LoadAssetAtPath("Assets/Prefabs/Item.prefab", typeof(GameObject));

        //foreach (var item in container.Items)
        for (int i = 0; i < container.Items.Count; i++)
        {
            var item = container.Items[i];
            var itemGameObject = Instantiate(itemPrefab, Container.transform, false);
            itemGameObject.name = item.name;

            var rt = itemGameObject.GetComponent<RectTransform>();

            rt.anchoredPosition.Set(0, 0);
            rt.anchorMin.Set(0, 1);
            rt.anchorMax.Set(0, 1);
            rt.pivot.Set(0, 0);

            itemGameObject.transform.localPosition = new Vector3(0 + (i * 80), 0, 0);


            var image = itemGameObject.GetComponent<Image>();
            image.sprite = item.Image;

            var itemBeh = itemGameObject.GetComponent<ItemBehaviour>();
            itemBeh.Item = item;

        }

    }

    private void DestroyContainerChildren()
    {
        while (Container.transform.childCount > 0)
        {
            Destroy(Container.transform.GetChild(0).gameObject);
        }
    }


    #endregion



}
