using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConvertSpriteToImg : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void ConvertToUIIMG()
    {
        ConvertSpriteToImgRec(transform);
        ReverseOrder(transform);
        return;
        //USING_UI_IMAGE = true;
        //ConvertSpriteToImg(transform);
        //ReverseOrder(transform);
        //ApplyStart();
        //CreatePrefab();
    }
    
    /// <summary>
    /// THIS IS A ONE TIME EFFECT
    /// Recursive converts all sprite renderers to UI.Image
    /// //TODO: make a version that adds this to the prefab
    /// </summary>
    /// <returns>This isn't used in the function only to get the top value out</returns>
    /// <param name="form"></param>
    private Transform ConvertSpriteToImgRec(Transform form)
    {
        if (form.childCount > 0)
        {
            for (int i = 0; i < form.childCount; i++)
            {
                ConvertSpriteToImgRec(form.GetChild(i));
            }
        }
        
        SpriteRenderer spriteRenderer = form.GetComponent<SpriteRenderer>();
        if (spriteRenderer != null)
        {
            Debug.Log(form);
            Debug.Log(spriteRenderer);
            form.gameObject.AddComponent<Image>().sprite = spriteRenderer.sprite;
            spriteRenderer.enabled = false;
        }

        return form;
    }

    /// <summary>
    /// reverses the order
    /// currently gives a weird error message "Invalid AABB inAABB"
    /// </summary>
    /// <param name="form"></param>
    private void ReverseOrder(Transform form)
    {
        for (int i = 0; i < form.childCount; i++)
        {
            form.GetChild(0).SetSiblingIndex(form.childCount - 1 - i);
        }
        for (int i = 0; i < form.childCount; i++)
        {
            if (form.GetChild(i).childCount > 0)
            {
                ReverseOrder(form.GetChild(i));
            }
            
        }
    }
}
