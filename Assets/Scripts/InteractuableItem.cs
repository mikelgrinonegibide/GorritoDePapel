using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class InteractuableItem : MonoBehaviour
{
    public static Object HintPrefab;
    private Object HintIndicator;
    [SerializeField] private Vector2? HintPosition;
    [SerializeField] private InteractuableInfo Info;

    #region Unity methods

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


    #endregion

    #region Private methods

    private void ShowIndicator()
    {
        HintIndicator = Instantiate(HintPrefab, transform.position, Quaternion.identity, this.transform);
        HintIndicator.name = "Hint";


        HintBehaviour hb = HintIndicator.GetComponent<HintBehaviour>();
        hb.Info = this.Info;

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
