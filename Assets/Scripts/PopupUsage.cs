using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PopupUsage : MonoBehaviour
{
    [SerializeField]
    GameObject prefabPopup;
    public void TryBuyItem()
    {
        GameObject newPopup = Instantiate(prefabPopup);
        SomePopup popupScript = newPopup.GetComponent<SomePopup>();
        popupScript.OnClose += CompletePurhase;
        CancellationTokenSource cts = new CancellationTokenSource();
        CancellationToken ct = cts.Token;
        popupScript.ActivatePopup(ct);
    }
    void CompletePurhase(bool completed)
    {
        if (completed) Debug.Log("Покупка совершена!");
        else Debug.Log("Покупка отменена!");
    }
}
