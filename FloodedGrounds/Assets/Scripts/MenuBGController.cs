using UnityEngine;
using UnityEngine.UI;

public class MenuBGController : MonoBehaviour
{    
    public float displayTime;
    public Image[] imageArray;

    private Animator anim;
    private bool BGMaskSet = false;
    private int index = 0;
    private int lastIndex = 0;  
    // Start is called before the first frame update
    void Awake()
    {
        anim = GetComponent<Animator>();       
    }

    // Update is called once per frame
    void Update()
    {
        if (!anim.GetBool("ChangingBGImg"))
        {
            anim.SetBool("ChangingBGImg", true);
            index++;
            if (index > imageArray.Length) index = 0;
        } else
        {
            anim.SetBool("ChangingBGImg", false);
        }
    }

}
