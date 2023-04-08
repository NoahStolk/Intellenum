﻿namespace ConsumerTests.TestEnums
{
    [Intellenum(conversions: Conversions.None, underlyingType: typeof(bool))]
    [Instance("No", false)]
    [Instance("Yes", true)]
    public partial class NoConverterBoolEnum { }

    [Intellenum(conversions: Conversions.TypeConverter, underlyingType: typeof(bool))]
    [Instance("No", false)]
    [Instance("Yes", true)]
    public partial class NoJsonBoolEnum { }

    [Intellenum(conversions: Conversions.NewtonsoftJson, underlyingType: typeof(bool))]
    [Instance("No", false)]
    [Instance("Yes", true)]
    public partial class NewtonsoftJsonBoolEnum { }

    [Intellenum(conversions: Conversions.SystemTextJson, underlyingType: typeof(bool))]
    [Instance("No", false)]
    [Instance("Yes", true)]
    public partial class SystemTextJsonBoolEnum { }

    [Intellenum(conversions: Conversions.NewtonsoftJson | Conversions.SystemTextJson, underlyingType: typeof(bool))]
    [Instance("No", false)]
    [Instance("Yes", true)]
    public partial class BothJsonBoolEnum { }

    [Intellenum(conversions: Conversions.EfCoreValueConverter, underlyingType: typeof(bool))]
    [Instance("No", false)]
    [Instance("Yes", true)]
    public partial class EfCoreBoolEnum { }

    [Intellenum(conversions: Conversions.DapperTypeHandler, underlyingType: typeof(bool))]
    [Instance("No", false)]
    [Instance("Yes", true)]
    public partial class DapperBoolVo { }

    [Intellenum(conversions: Conversions.LinqToDbValueConverter, underlyingType: typeof(bool))]
    [Instance("No", false)]
    [Instance("Yes", true)]
    public partial class LinqToDbBoolEnum { }
}
