using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using static Xamarin.Forms.RelativeLayout;

namespace SnuffFromAndrey.Models
{
    public static class ViewExtensions
    {
        public static void AddHero(this IRelativeList<View> children, Hero hero)
        {
            children.Add(hero.Face, hero.XConstraint, hero.YConstraint);
        }
    }
}
