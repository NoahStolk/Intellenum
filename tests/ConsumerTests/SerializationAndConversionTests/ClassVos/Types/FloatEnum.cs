﻿namespace ConsumerTests.TestEnums;

[Intellenum(conversions: Conversions.None, underlyingType: typeof(float))]
[Instance("Item1", 1.1f)]
[Instance("Item2", 2.2f)]
public partial class FloatEnum { }

[Intellenum(conversions: Conversions.None, underlyingType: typeof(float))]
[Instance("Item1", 1.1f)]
[Instance("Item2", 2.2f)]
public partial class NoConverterFloatEnum { }

[Intellenum(conversions: Conversions.TypeConverter, underlyingType: typeof(float))]
[Instance("Item1", 1.1f)]
[Instance("Item2", 2.2f)]
public partial class NoJsonFloatEnum { }

[Intellenum(conversions: Conversions.NewtonsoftJson, underlyingType: typeof(float))]
[Instance("Item1", 1.1f)]
[Instance("Item2", 2.2f)]
public partial class NewtonsoftJsonFloatEnum { }

[Intellenum(conversions: Conversions.SystemTextJson, underlyingType: typeof(float))]
[Instance("Item1", 1.1f)]
[Instance("Item2", 2.2f)]
public partial class SystemTextJsonFloatEnum { }

[Intellenum(conversions: Conversions.SystemTextJson, underlyingType: typeof(float), customizations: Customizations.TreatNumberAsStringInSystemTextJson)]
[Instance("Item1", 1.1f)]
[Instance("Item2", 2.2f)]
public partial class SystemTextJsonFloatEnum_Treating_numbers_as_string { }

[Intellenum(conversions: Conversions.NewtonsoftJson | Conversions.SystemTextJson, underlyingType: typeof(float))]
[Instance("Item1", 1.1f)]
[Instance("Item2", 2.2f)]
public partial class BothJsonFloatEnum { }

[Intellenum(conversions: Conversions.EfCoreValueConverter, underlyingType: typeof(float))]
[Instance("Item1", 1.1f)]
[Instance("Item2", 2.2f)]
public partial class EfCoreFloatEnum { }

[Intellenum(conversions: Conversions.DapperTypeHandler, underlyingType: typeof(float))]
[Instance("Item1", 1.1f)]
[Instance("Item2", 2.2f)]
public partial class DapperFloatEnum { }

[Intellenum(conversions: Conversions.LinqToDbValueConverter, underlyingType: typeof(float))]
[Instance("Item1", 1.1f)]
[Instance("Item2", 2.2f)]
public partial class LinqToDbFloatEnum { }