﻿using System;
using System.Resources;

using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace $rootnamespace$
{
    sealed class $safeitemname$ : IExternalCommandAvailability
    {
        /// <summary>
        /// This method provides the control over whether an 
        /// external command is enabled or disabled.
        /// </summary>
        /// <param name="applicationData">An 
        /// ApplicationServices.Application object which 
        /// contains reference to Application needed by 
        /// external command.</param>
        /// <param name="selectedCategories">An list of 
        /// categories of the elements which have been selected
        /// in Revit in the active document, or an empty set if
        /// no elements are selected or there is no active 
        /// document.</param>
        /// <returns>Indicates whether Revit should enable or 
        /// disable the corresponding external command.
        /// </returns>
        bool IExternalCommandAvailability.IsCommandAvailable(UIApplication applicationData, CategorySet selectedCategories)
        {

            ResourceManager resourceManager = new ResourceManager(GetType());
            ResourceManager defaultResourceManager = new ResourceManager(typeof(Properties.Resources));

            bool result = false;

            try
            {

                // ============================================
                // TODO: delete these code rows and put your code 
                // here.
                if (applicationData.ActiveUIDocument != null &&
                selectedCategories.IsEmpty)
                {

                    result = true;
                }
                // ============================================
            }
            catch (Exception ex)
            {

                TaskDialog.Show(defaultResourceManager.GetString("_Error"), ex.Message);

                result = false;
            }
            finally
            {

                resourceManager.ReleaseAllResources();
                defaultResourceManager.ReleaseAllResources();
            }

            return result;
        }
    }
}
