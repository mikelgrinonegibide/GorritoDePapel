using UnityEngine;

public class HintBehaviour : MonoBehaviour
{
    //public List<Actions>
    public InteractuableInfo Info;


    #region Unity methods
    void OnMouseDown()
    {
        Debug.Log("Click");
        //ShowActions();
    }

    #endregion

    #region Private methods

    private void ShowActions()
    {
        if (Info.Action == ActionTypes.Look)
        {
            var contentInfo = (ContentInteractuableInfo)Info;

            LookAction(contentInfo.Container);

        }

    }

    private void LookAction(Container container)
    {
        ShowContent(container);
    }

    #endregion


}
