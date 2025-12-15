using System.Collections;
using System.Collections.Generic;
using GameFramework.Localization;
using UnityGameFramework.Runtime;
using UnityEngine;

public class LocalizationHelper : DefaultLocalizationHelper
{

    /// <inheritdoc />
    public override bool ParseData(ILocalizationManager localizationManager, string dictionaryString, object userData)
    {
        return base.ParseData(localizationManager, dictionaryString, userData);
    }

    /// <inheritdoc />
    public override bool ParseData(ILocalizationManager localizationManager, byte[] dictionaryBytes, int startIndex, int length, object userData)
    {
        return base.ParseData(localizationManager, dictionaryBytes, startIndex, length, userData);
    }
}
