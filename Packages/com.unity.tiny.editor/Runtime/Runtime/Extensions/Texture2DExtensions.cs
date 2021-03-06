﻿#if NET_4_6
using UnityEngine;

namespace Unity.Tiny.Extensions
{
    public static class Texture2DExtensions
    {
        public static void SetColor(this Texture2D tex2, Color32 color)
        {
            var fillColorArray = tex2.GetPixels32();

            for (var i = 0; i < fillColorArray.Length; ++i)
            {
                fillColorArray[i] = color;
            }

            tex2.SetPixels32(fillColorArray);
            tex2.Apply();
        }
    }
}
#endif // NET_4_6
