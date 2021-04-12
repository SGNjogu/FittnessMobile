using System;

namespace FittnessApp.Utils
{
    public static class EnumsConverter
    {
        /// <summary>
        /// Method to Convert enum to string
        /// </summary>
        /// <param name="eff"></param>
        /// <returns>String representing the enum</returns>
        public static string ConvertToString(this Enum eff)
        {
            return Enum.GetName(eff.GetType(), eff);
        }

        /// <summary>
        /// Method to convert string to enum
        /// </summary>
        /// <typeparam name="EnumType"></typeparam>
        /// <param name="enumValue"></param>
        /// <returns>Enum</returns>
        public static EnumType ConvertToEnum<EnumType>(this string enumValue)
        {
            return (EnumType)Enum.Parse(typeof(EnumType), enumValue);
        }
    }
}
