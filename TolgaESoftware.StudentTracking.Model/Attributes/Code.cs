using System;

namespace TolgaESoftware.StudentTracking.Model.Attributes
{
    public class Code:Attribute
    {
        public string Description { get; }
        public string ControlName { get; }

        /// <summary>
        /// Using For Marks The RequiredField On Validation Processes - Tolga. 
        /// </summary>
        /// <param name="description"> Will Showing Statement On Warning Message </param>
        /// <param name="controlName"> Will Focused Control Name After Warning Message </param>
        public Code(string description, string controlName)
        {
            Description = description;
            ControlName = controlName;
        }
    }
}