using FluentAssertions;
using System;
using Xunit;
using static NullLibraryTest.TestUtilities;

namespace NullLibraryTest
{
    public class NotNullTest
    {
        [Fact]
        public void WhenInstantiatedNotNull_ValueEqualsCast()
        {
            var notNull = MakeNotNullWithValue();

            notNull.Value.Should().Be(notNull);
        }

        [Fact]
        public void WhenInstantiatedNotNull_EqualsOriginal()
        {
            MakeNotNullWithValue().Value.Should().Be(original);
        }

        [Fact]
        public void WhenInstantiatedNotNull_ToStringEqualsOriginal()
        {
            MakeNotNullWithValue().ToString().Should().Be(original);
        }

        [Fact]
        public void WhenInstantiatedNotNull_CastEqualsOriginal()
        {
            ((string)MakeNotNullWithValue()).Should().Be(original);
        }

        [Fact]
        public void WhenSetNotNull_ValueEqualsCast()
        {
            var notNull = MakeNotNullSetValue();
            notNull.Value.Should().Be(notNull);
        }

        [Fact]
        public void WhenSetNotNull_EqualsOriginal()
        {
            MakeNotNullSetValue().Value.Should().Be(original);
        }

        [Fact]
        public void WhenSetNotNull_ToStringEqualsOriginal()
        {
            MakeNotNullSetValue().ToString().Should().Be(original);
        }

        [Fact]
        public void WhenSetNotNull_CastEqualsOriginal()
        {
            ((string)MakeNotNullSetValue()).Should().Be(original);
        }

        [Fact]
        public void WhenInstantiatedNull_ThrowsNullReferenceException()
        {
            Action createNotNull = () =>
            {
                var notNull = MakeNotNullWithNull();
            };

            createNotNull.Should().Throw<ArgumentNullException>();
        }

        [Fact]
        public void WhenSetNull_ThrowsNullReferenceException()
        {
            Action createNotNull = () =>
            {
                var notNull = MakeNotNullSetNull();
            };

            createNotNull.Should().Throw<ArgumentNullException>();
        }
    }
}
