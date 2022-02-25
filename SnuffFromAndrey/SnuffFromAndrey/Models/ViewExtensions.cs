using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using static Xamarin.Forms.RelativeLayout;

namespace SnuffFromAndrey.Models
{
    public static class ViewExtensions
    {
        public static void AddUnit(this IRelativeList<View> children, Unit unit)
        {
            children.Add(unit.Face, unit.XConstraint, unit.YConstraint);
        }

        public static void RemoveUnit(this IRelativeList<View> children, Unit unit)
        {
            children.Remove(unit.Face);
        }
    }
}
