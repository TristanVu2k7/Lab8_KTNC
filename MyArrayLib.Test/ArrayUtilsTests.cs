using Xunit;
namespace MyArrayLib.Test
{
    public class ArrayUtilsTests
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 5)]
        [InlineData(new int[] { -1, -2, -3, -4, -5 }, -1)]
        [InlineData(new int[] { 0, 0, 0, 0 }, 0)]
        public void Max_ValidArray_ReturnsMax(int[] arr, int expectedMax)
        {
            int result = MyArrayLib.ArrayUtils.Max(arr);
            Assert.Equal(expectedMax, result);
        }
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 1)]
        [InlineData(new int[] { -1, -2, -3, -4, -5 }, -5)]
        [InlineData(new int[] { 0, 0, 0, 0 }, 0)]
        public void Min_ValidArray_ReturnsMin(int[] arr, int expectedMin)
        {
            int result = MyArrayLib.ArrayUtils.Min(arr);
            Assert.Equal(expectedMin, result);
        }
        [Fact]
        public void Max_NullArray_ThrowsArgumentException()
        {
            Assert.Throws<System.ArgumentException>(() => MyArrayLib.ArrayUtils.Max(null));
        }
        [Fact]
        public void Min_NullArray_ThrowsArgumentException()
        {
            Assert.Throws<System.ArgumentException>(() => MyArrayLib.ArrayUtils.Min(null));
        }
    }
}