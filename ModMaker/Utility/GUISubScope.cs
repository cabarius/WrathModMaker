using System;
using UnityEngine;

namespace ModMaker.Utility
{
    public class GUISubScope : IDisposable
    {
        public GUISubScope() : this(null) { }

        public GUISubScope(string subtitle, string param = "")
        {
            if (!string.IsNullOrEmpty(subtitle))
                GUILayout.Label(subtitle.Bold());
            GUILayout.BeginHorizontal();
            GUILayout.Space(10f);
            GUILayout.BeginVertical(param);
        }

        public void Dispose()
        {
            GUILayout.EndVertical();
            GUILayout.EndHorizontal();
        }
    }
}
