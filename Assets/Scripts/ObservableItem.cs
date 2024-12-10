using UnityEditor;
using UnityEngine;

public class ObservableItem : MonoBehaviour
{
    public static Object HintPrefab;
    private Object HintIndicator;
    [SerializeField] private Vector2? HintPosition;

    void Start()
    {
        HintPrefab = AssetDatabase.LoadAssetAtPath("Assets/Prefabs/Hint.prefab", typeof(Object));
    }

    void OnMouseEnter()
    {
        ShowIndicator();
    }


    void OnMouseExit()
    {
        RemoveIndicator();
    }


    #region Private methods

    private void ShowIndicator()
    {
        HintIndicator = Instantiate(HintPrefab, transform.position, Quaternion.identity, this.transform);
        HintIndicator.name = "Hint";
    }

    private void RemoveIndicator()
    {
        if (HintIndicator != null)
        {
            Destroy(HintIndicator);
            HintIndicator = null;
        }
    }

    #endregion



}
