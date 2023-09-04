using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public enum DeformationType
{
    Width,
    Height
}

public class GateAppearance : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _text;

    [SerializeField] Image _topImage;
    [SerializeField] Image _cristalImage;

    [SerializeField] Color _colorPositive;
    [SerializeField] Color _colorNegative;
    
    // Увеличение/уменьшение ширины
    [SerializeField] GameObject _ExpendIcon;
    [SerializeField] GameObject _StenosisIcon;
    //Увеличение/уменьшение высоты
    [SerializeField] GameObject _UpIcon;
    [SerializeField] GameObject _DownIcon;

    public void UpdateVisual(DeformationType deformationType, int value)
    {
        string prefix = "";
                
        if(value > 0)
        {
            prefix = "+";
            SetColor(_colorPositive);
        }
        else if (value == 0)
        {
            SetColor(Color.gray);
        }
        else
        {
            SetColor(_colorNegative);
        }

        _text.text = prefix + value.ToString();

        _ExpendIcon.SetActive(false);
        _StenosisIcon.SetActive(false);
        _UpIcon.SetActive(false);
        _DownIcon.SetActive(false);

        if (deformationType == DeformationType.Width)
        {
            if (value > 0)
            {
                _ExpendIcon.SetActive(true);
            }
            else
            {
                _StenosisIcon.SetActive(true);
            }
        }
        else if (deformationType == DeformationType.Height)
        {
            if (value > 0)
            {
                _UpIcon.SetActive(true);
            }
            else
            {
                _DownIcon.SetActive(true);
            }
        }
    }
   void SetColor(Color color)
    {
        _topImage.color = color;
        _cristalImage.color = new Color(color.r, color.g, color.b, 0.5f);
    }

}
