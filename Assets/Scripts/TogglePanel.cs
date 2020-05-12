using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TogglePanel : MonoBehaviour
{
    CanvasGroup canvasGroup;

    // Start is called before the first frame update
    void Start()
    {
        DOTween.Init();
        this.canvasGroup = GetComponent<CanvasGroup>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void toggle() {
        if (this.canvasGroup.alpha>0.5) {
            this.hide();
        } else {
            this.show();
        }
    }

    public void show() {
        RectTransform rectTransform = GetComponent<RectTransform>(); //getting reference to this component 
        CanvasGroup canvasGroup = GetComponent<CanvasGroup>(); //getting reference to this component 
        // this.gameObject.SetActive(true);
        canvasGroup.DOFade(1, 0.2f);
    }

    public void hide() {
        RectTransform rectTransform = GetComponent<RectTransform>(); //getting reference to this component 
        CanvasGroup canvasGroup = GetComponent<CanvasGroup>(); //getting reference to this component 
        // this.gameObject.SetActive(false);
        canvasGroup.DOFade(0, 0.2f);
    }
}
