using System;

namespace NullLibrary
{
    public struct MaybeNull<T> where T : class?
    {
        private T value_;

        public T Value
        {
            get => value_ ?? throw new ArgumentNullException(nameof(Value), $"{nameof(MaybeNull<T>)}.Value contains a null value");
            set => value_ = value;
        }

        public bool HasValue => value_ != null;

        public MaybeNull(T value = null!)
        {
            value_ = value;
        }

        public override string ToString() => value_?.ToString() ?? "";

        public T ValueOr(T other) => value_ ?? other ?? throw new ArgumentNullException(nameof(Value), $"{nameof(MaybeNull<T>)}.ValueOr({nameof(T)}) was passed a null value");

        public MaybeNull<U?> Bind<U>(Func<T, MaybeNull<U?>> func) where U : class
        {
            if (!HasValue) return null;

            return func(value_);
        }
        public MaybeNull<U?> Bind<U>(Func<T, U?> func) where U : class
        {
            if (!HasValue) return null;

            return func(value_);
        }

        public static implicit operator MaybeNull<T>(T t) => new MaybeNull<T>(t);
    }
}
