using System;

namespace NullLibrary
{
    public struct NotNull<T> where T : class
    {
        private T value_;

        public T Value
        {
            get => value_;
            set => value_ = value ?? throw new ArgumentNullException(nameof(Value), $"{nameof(NotNull<T>)}.Value cannot be set to a null value");
        }

        public NotNull(T? value)
        {
            value_ = value ?? throw new ArgumentNullException(nameof(Value), $"{nameof(NotNull<T>)}.Value cannot be set to a null value");
        }

        public override string ToString() => Value.ToString();

        public static implicit operator T(NotNull<T> t) => t.Value;
    }
}
