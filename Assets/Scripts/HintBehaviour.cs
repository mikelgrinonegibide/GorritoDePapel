using UnityEngine;

public class HintBehaviour : MonoBehaviour
{
    public InteractuableInfo Info;


    #region Unity methods
    void OnMouseDown()
    {
        Debug.Log("Click");
        ShowAction();
    }

    #endregion

    #region Private methods

    private void ShowAction()
    {
        if (Info.Action == ActionTypes.Look)
        {
            var contentInfo = (ContentInteractuableInfo)Info;

            LookAction(Info.Name, contentInfo.Container);

        }

    }

    private void LookAction(string title, Container container)
    {
        ContentVisualizatorManager.Instance.ShowContent(title, container);
    }

    #endregion


}
