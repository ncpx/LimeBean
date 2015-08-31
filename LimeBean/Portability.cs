﻿using System;

namespace LimeBean {

#if DOTNET || PCL

    using System.Reflection;

    static partial class Extensions {
        internal static bool IsEnum(this Type type) {
            return type.GetTypeInfo().IsEnum;
        }
        internal static bool IsGenericType(this Type type) {
            return type.GetTypeInfo().IsGenericType;
        }
    }

#else

    using System.Data.Common;

    [Serializable]
    public partial class Bean {
    }

    static partial class Extensions {
        internal static bool IsEnum(this Type type) {
            return type.IsEnum;
        }
        internal static bool IsGenericType(this Type type) {
            return type.IsGenericType;
        }
    }

#endif

#if !DOTNET && !PCL && !XAMARIN

    public partial class BeanApi {
        public BeanApi(string connectionString, string providerName)
            : this(connectionString, DbProviderFactories.GetFactory(providerName)) {
        }
    }

#endif

}


