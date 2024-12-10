using UnityEngine;

[CreateAssetMenu(menuName = "Interactuable Item/Content")]
public class ContentInteractuableInfo : InteractuableInfo
{
    public Container Container;


    public ContentInteractuableInfo()
    {
        this.Container = new Container();
    }

}

