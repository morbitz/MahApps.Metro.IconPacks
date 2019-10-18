﻿using System;
#if (NETFX_CORE || WINDOWS_UWP)
using Windows.UI.Xaml;
using Windows.UI.Xaml.Markup;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
#else
using System.Windows.Markup;
using System.Windows.Media.Animation;
#endif

namespace MahApps.Metro.IconPacks
{
#if (NETFX_CORE || WINDOWS_UWP)
    [MarkupExtensionReturnType(ReturnType = typeof(PackIconUnicons))]
#else
    [MarkupExtensionReturnType(typeof(PackIconUnicons))]
#endif
    public class UniconsExtension : BasePackIconExtension
    {
        public UniconsExtension()
        {
        }

#if !(NETFX_CORE || WINDOWS_UWP)
        public UniconsExtension(PackIconUniconsKind kind)
        {
            this.Kind = kind;
        }

        [ConstructorArgument("kind")]
#endif
        public PackIconUniconsKind Kind { get; set; }

#if (NETFX_CORE || WINDOWS_UWP)
        protected override object ProvideValue()
#else
        public override object ProvideValue(IServiceProvider serviceProvider)
#endif
        {
            return this.GetPackIcon<PackIconUnicons, PackIconUniconsKind>(this.Kind);
        }
    }
}