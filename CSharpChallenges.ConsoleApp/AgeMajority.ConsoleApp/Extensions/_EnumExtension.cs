﻿using System;
using System.ComponentModel;
using System.Globalization;
using System.Linq;

namespace AgeMajority.ConsoleApp.Extensions
{
    public static class _EnumExtension
    {
        //how to use
        //Console.WriteLine(_EnumExtension.GetDescription(_CodeMessageEnum.ENTER_AGE_OR_PRESS_Q_QUIT));


        public static string GetDescription<T>(this T e) where T : IConvertible
        {
            if (e is Enum)
            {
                Type type = e.GetType();
                Array values = System.Enum.GetValues(type);

                foreach (int val in values)
                {
                    if (val == e.ToInt32(CultureInfo.InvariantCulture))
                    {
                        var memInfo = type.GetMember(type.GetEnumName(val));
                        var descriptionAttribute = memInfo[0]
                            .GetCustomAttributes(typeof(DescriptionAttribute), false)
                            .FirstOrDefault() as DescriptionAttribute;

                        if (descriptionAttribute != null)
                        {
                            return descriptionAttribute.Description;
                        }
                    }
                }
            }

            return null; // could also return string.Empty
        }
    }          
}

