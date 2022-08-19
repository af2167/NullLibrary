using FluentAssertions;
using System;
using Xunit;
using static NullLibraryTest.TestUtilities;

namespace NullLibraryTest
{
    public class MaybeNullTest
    {
        [Fact]
        public void WhenInstantiatedNotNull_EqualsCastOriginal()
        {
            MakeMaybeWithValue().Value.Should().Be(CastOriginal().Value);
        }

        [Fact]
        public void WhenInstantiatedNotNull_EqualsOriginal()
        {
            MakeMaybeWithValue().Value.Should().Be(original);
        }

        [Fact]
        public void WhenInstantiatedNotNull_ToStringEqualsOriginal()
        {
            MakeMaybeWithValue().ToString().Should().Be(original);
        }

        [Fact]
        public void WhenInstantiatedNotNull_HasValueIsTrue()
        {
            MakeMaybeWithValue().HasValue.Should().BeTrue();
        }

        [Fact]
        public void WhenInstantiatedNotNull_ValueOrReturnsOriginal()
        {
            MakeMaybeWithValue().ValueOr(optional).Should().Be(original);
        }

        [Fact]
        public void WhenInstantiatedNotNull_BindMaybeReturnsValue()
        {
            MakeMaybeWithValue().Bind(TransformMaybe).Value.Should().Be(transformed);
        }

        [Fact]
        public void WhenInstantiatedNotNull_BindReturnsValue()
        {
            MakeMaybeWithValue().Bind(Transform).Value.Should().Be(transformed);
        }

        [Fact]
        public void WhenSetNotNull_EqualsCastOriginal()
        {
            MakeMaybeSetValue().Value.Should().Be(CastOriginal().Value);
        }

        [Fact]
        public void WhenSetNotNull_EqualsOriginal()
        {
            MakeMaybeSetValue().Value.Should().Be(original);
        }

        [Fact]
        public void WhenSetNotNull_ToStringEqualsOriginal()
        {
            MakeMaybeSetValue().ToString().Should().Be(original);
        }

        [Fact]
        public void WhenSetNotNull_HasValueIsTrue()
        {
            MakeMaybeSetValue().HasValue.Should().BeTrue();
        }

        [Fact]
        public void WhenSetNotNull_ValueOrReturnsOriginal()
        {
            MakeMaybeSetValue().ValueOr(optional).Should().Be(original);
        }

        [Fact]
        public void WhenSetNotNull_BindMaybeReturnsValue()
        {
            MakeMaybeSetValue().Bind(TransformMaybe).Value.Should().Be(transformed);
        }

        [Fact]
        public void WhenSetNotNull_BindReturnsValue()
        {
            MakeMaybeSetValue().Bind(Transform).Value.Should().Be(transformed);
        }

        [Fact]
        public void WhenInstantiatedDefault_HasValueIsFalse()
        {
            MakeMaybeDefault().HasValue.Should().BeFalse();
        }

        [Fact]
        public void WhenInstantiatedNull_HasValueIsFalse()
        {
            MakeMaybeWithNull().HasValue.Should().BeFalse();
        }

        [Fact]
        public void WhenInstantiatedNull_GetThrowsArgumentNullException()
        {
            Action createMaybeNull = () =>
            {
                var fail = MakeMaybeWithNull().Value;
            };

            createMaybeNull.Should().Throw<ArgumentNullException>();
        }

        [Fact]
        public void WhenInstantiatedNull_ValueOrReturnsOption()
        {
            MakeMaybeWithNull().ValueOr(optional).Should().Be(optional);
        }

        [Fact]
        public void WhenInstantiatedNullAndPassedNull_ValueOrThrowsArgumentNullException()
        {
            Action nullValueOrNull = () =>
            {
                var fail = MakeMaybeWithNull().ValueOr(null);
            };

            nullValueOrNull.Should().Throw<ArgumentNullException>();
        }

        [Fact]
        public void WhenInstantiatedNull_BindMaybeReturnsNull()
        {
            MakeMaybeWithNull().Bind(TransformMaybe).HasValue.Should().BeFalse();
        }

        [Fact]
        public void WhenInstantiatedNull_BindReturnsNull()
        {
            MakeMaybeWithNull().Bind(Transform).HasValue.Should().BeFalse();
        }

        [Fact]
        public void WhenSetNull_HasValueIsFalse()
        {
            MakeMaybeSetNull().HasValue.Should().BeFalse();
        }

        [Fact]
        public void WhenSetNull_GetThrowsArgumentNullException()
        {
            Action createMaybeNull = () =>
            {
                var fail = MakeMaybeSetNull().Value;
            };

            createMaybeNull.Should().Throw<ArgumentNullException>();
        }

        [Fact]
        public void WhenSetNull_ValueOrReturnsOption()
        {
            MakeMaybeSetNull().ValueOr(optional).Should().Be(optional);
        }

        [Fact]
        public void WhenSetNullAndPassedNull_ValueOrThrowsArgumentNullException()
        {
            Action nullValueOrNull = () =>
            {
                var fail = MakeMaybeSetNull().ValueOr(null);
            };

            nullValueOrNull.Should().Throw<ArgumentNullException>();
        }

        [Fact]
        public void WhenSetNull_BindMaybeReturnsNull()
        {
            MakeMaybeSetNull().Bind(TransformMaybe).HasValue.Should().BeFalse();
        }

        [Fact]
        public void WhenSetNull_BindReturnsNull()
        {
            MakeMaybeSetNull().Bind(Transform).HasValue.Should().BeFalse();
        }
    }
}
