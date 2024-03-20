using System;
using Xunit;

public class HashTest
{
	public void MD5Test()
	{
		[Fact]
		public void EmptyStringTest()
		{
            String result = Hashfunctions.MD5("");
            Assert.Equal("d41d8cd98f00b204e9800998ecf8427e", result);
        }		
        [Fact]
        public void ShortWordTest()
		{
            String result = Hashfunctions.MD5("hello");
            Assert.Equal("5d41402abc4b2a76b9719d911017c592", result);
        }
        [Fact]
		public void LongWordTest()
		{
            String result = Hashfunctions.MD5("Sed ut perspiciatis unde omnis iste natus error sit volume lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.");
            Assert.Equal("f5d7e3f0d895d4e332b1f6e2a5c1631e", result);
        }		
        [Fact]
		public void bitLenTest448()
		{
            String result = Hashfunctions.MD5("Sed ut perspiciatis unde omnis iste natus error sit volu");
            Assert.Equal("3e25960a79dbc69b674cd4ec67a72c62", result);
        }
		[Fact]
		public void bitLenTest512()
		{
            String result = Hashfunctions.MD5("Sed ut perspiciatis unde omnis iste natus error sit volume lorem");
            Assert.Equal("b2f5ff47436671b6e533d8dc3614845d", result);
        }
        [Fact]
        public void StartWhiteSpaceTest()
        {
            String result = Hashfunctions.MD5(" helloed ut perspiciatis unde omnis iste natus error sit volume lorem");
            Assert.Equal("5d41402abc4b2a76b9719d911017c592", result);
        }
        [Fact]
        public void EndWhiteSpaceTest()
        {
            String result = Hashfunctions.MD5("helloed ut perspiciatis unde omnis iste natus error sit volume lorem ");
            Assert.Equal("5d41402abc4b2a76b9719d911017c592", result);
        }
	}
}
