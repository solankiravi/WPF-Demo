﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Skin_Support
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class SkinApp : Application
    {
        public void ApplySkin(Uri skinDictionaryUri)
        {
            // Load the ResourceDictionary into memory.
            ResourceDictionary skinDict = Application.LoadComponent(skinDictionaryUri) as ResourceDictionary;

            Collection<ResourceDictionary> mergedDicts = base.Resources.MergedDictionaries;

            // Remove the existing skin dictionary, if one exists.
            // NOTE: In a real application, this logic might need
            // to be more complex, because there might be dictionaries
            // which should not be removed.
            if (mergedDicts.Count > 0)
                mergedDicts.Clear();

            // Apply the selected skin so that all elements in the
            // application will honor the new look and feel.
            mergedDicts.Add(skinDict);
        }
    }
}
