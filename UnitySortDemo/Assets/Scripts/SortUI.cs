using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SortUI : MonoBehaviour
{
    // Start is called before the first frame update
    public List<InputField> InputFields = new List<InputField>();
    public string SortResultsPre = "排序结果：";
    public List<Text> SortResults = new List<Text>();

    void Start()
    {
    }

    public void SortShowUI(int sortType)
    {
        switch (sortType)
        {
            case 1:
                //插入
                // Debug.Log("排序前的值："+ InputFields[sortType-1].text);
                // var temp = SortController.GetInstance()
                //     .InsertSort(ToIntArray(InputFields[sortType - 1].text.ToString().Split(',')));
                SortResults[sortType - 1].text = SortResultsPre + ToStringArray(SortController.GetInstance()
                    .InsertSort(ToIntArray(InputFields[sortType - 1].text.ToString().Split(','))));
                // Debug.Log("排序后的结果："+  SortResults[sortType-1].text);
                break;
            case 2:
                //希尔
                SortResults[sortType - 1].text = SortResultsPre + ToStringArray(SortController.GetInstance()
                    .ShellSort(ToIntArray(InputFields[sortType - 1].text.ToString().Split(','))));
                break;
            case 3:
                //选择
                SortResults[sortType - 1].text = SortResultsPre + ToStringArray(SortController.GetInstance()
                    .SelectSort(ToIntArray(InputFields[sortType - 1].text.ToString().Split(','))));
                break;
            case 4:
                //堆
                SortResults[sortType - 1].text = SortResultsPre + ToStringArray(SortController.GetInstance()
                    .HeadSort(ToIntArray(InputFields[sortType - 1].text.ToString().Split(','))));
                break;
            case 5:
                SortResults[sortType - 1].text = SortResultsPre + ToStringArray(SortController.GetInstance()
                    .BubbleSort(ToIntArray(InputFields[sortType - 1].text.ToString().Split(','))));
                //冒泡
                break;
            case 6:
                //快速
                var qSort = ToIntArray(InputFields[sortType - 1].text.ToString().Split(','));
                SortResults[sortType - 1].text = SortResultsPre + ToStringArray(SortController.GetInstance()
                    .QuickSort(qSort, 0, qSort.Length - 1));
                break;
            case 7:
                //归并
                var mSort = ToIntArray(InputFields[sortType - 1].text.ToString().Split(','));
                // SortResults[sortType - 1].text = SortResultsPre + ToStringArray(SortController.GetInstance()
                //     .MergeSort(mSort, 0, mSort.Length));
                SortResults[sortType - 1].text = SortResultsPre + ToStringArray(SortController.GetInstance()
                    .MergeNonFuncSort(ToIntArray(InputFields[sortType - 1].text.ToString().Split(','))));
                break;
            case 8:
                //计算
                SortResults[sortType - 1].text = SortResultsPre + ToStringArray(SortController.GetInstance()
                    .CountSort(ToIntArray(InputFields[sortType - 1].text.ToString().Split(','))));
                break;
            case 9:
                //桶
                var bSort = ToDoubleArray(InputFields[sortType - 1].text.ToString().Split(','));
                SortResults[sortType - 1].text = SortResultsPre + ToStringArrayByDouble(SortController.GetInstance()
                    .BucketSort(bSort, 10));
                break;
            case 10:
                //基数
                SortResults[sortType - 1].text = SortResultsPre + ToStringArray(SortController.GetInstance()
                    .RandixSort(ToIntArray(InputFields[sortType - 1].text.ToString().Split(',')), 3));
                break;
        }
    }


    #region 方法封装
    /// <summary>
    /// 字符串数组转换整形数组
    /// </summary>
    /// <param name="Content">字符串数组</param>
    /// <returns></returns>
    private int[] ToIntArray(string[] Content)
    {
        int[] c = new int[Content.Length];
        for (int i = 0; i < Content.Length; i++)
        {
            c[i] = Convert.ToInt32(Content[i].ToString());
        }

        return c;
    }

    /// <summary>
    /// 整型转为字符串
    /// </summary>
    /// <param name="intArray"></param>
    /// <returns></returns>
    private string ToStringArray(int[] intArray)
    {
        string result = string.Empty;
        for (int i = 0; i < intArray.Length; i++)
        {
            if (!string.IsNullOrEmpty(result))
                result += "," + intArray[i];
            else
                result = intArray[i].ToString();
        }

        return result;
    }

    /// <summary>
    /// 字符串数组转换double数组
    /// </summary>
    /// <param name="Content">字符串数组</param>
    /// <returns></returns>
    private double[] ToDoubleArray(string[] Content)
    {
        double[] c = new double[Content.Length];
        for (int i = 0; i < Content.Length; i++)
        {
            c[i] = Convert.ToDouble(Content[i].ToString());
        }

        return c;
    }

    /// <summary>
    /// double 转为字符串
    /// </summary>
    /// <param name="intArray"></param>
    /// <returns></returns>
    private string ToStringArrayByDouble(double[] intArray)
    {
        string result = string.Empty;
        for (int i = 0; i < intArray.Length; i++)
        {
            if (!string.IsNullOrEmpty(result))
                result += "," + intArray[i];
            else
                result = intArray[i].ToString();
        }

        return result;
    }
    #endregion
}