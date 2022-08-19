using NullLibrary;

namespace NullLibraryTest
{
    internal static class TestUtilities
    {
        public const string original = "The original string";
        public const string optional = "The optional string";
        public const string transformed = "The transformed string";

        public static MaybeNull<string?> MakeMaybeWithValue() => new(original);
        public static MaybeNull<string?> MakeMaybeWithNull() => new(null);
        public static MaybeNull<string?> MakeMaybeDefault() => new();
        public static MaybeNull<string?> MakeMaybeSetValue() => new() { Value = original };
        public static MaybeNull<string?> MakeMaybeSetNull() => new(original) { Value = null };

        public static MaybeNull<string?> TransformMaybe(string? s) => string.IsNullOrWhiteSpace(s) ? new MaybeNull<string?>() : transformed;
        public static string? Transform(string? s) => transformed;

        public static MaybeNull<string?> CastOriginal() => original;

        public static NotNull<string> MakeNotNullWithValue() => new(original);
        public static NotNull<string> MakeNotNullWithNull() => new(null);
        public static NotNull<string> MakeNotNullSetValue() => new("") { Value = original };
        public static NotNull<string> MakeNotNullSetNull() => new(original) { Value = null! };
    }
}
