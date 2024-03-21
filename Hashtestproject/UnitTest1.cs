using System;
using Xunit;
using Hashfunction;

namespace Hashtestproject
{
    public class UnitTest1
    {
        Hashfunctions Hashfunctions = new Hashfunctions();
        [Fact]
        public void EmptyStringTestMD5()
        {
            String result = Hashfunctions.MD5("");
            Assert.Equal("d41d8cd98f00b204e9800998ecf8427e", result);
        }
        [Fact]
        public void ShortWordTestMD5()
        {
            String result = Hashfunctions.MD5("hello");
            Assert.Equal("5d41402abc4b2a76b9719d911017c592", result);
        }
        [Fact]
        public void LongWordTestMD5()
        {
            String result = Hashfunctions.MD5("Sed ut perspiciatis unde omnis iste natus error sit volume lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.");
            Assert.Equal("c1686d23135c8bbe3e62f3acb1ff1f74", result);
        }
        [Fact]
        public void bitLenTest448MD5()
        {
            String result = Hashfunctions.MD5("Sed ut perspiciatis unde omnis iste natus error sit volu");
            Assert.Equal("5f5193c9c036584052aea04a0ade39b6", result);
        }
        [Fact]
        public void bitLenTest512MD5()
        {
            String result = Hashfunctions.MD5("Sed ut perspiciatis unde omnis iste natus error sit volume lorem");
            Assert.Equal("d5b74be96f916d45ae352a0622a38589", result);
        }
        [Fact]
        public void StartWhiteSpaceTestMD5()
        {
            String result = Hashfunctions.MD5(" helloed ut perspiciatis unde omnis iste natus error sit volume lorem");
            Assert.Equal("99d90197a8cf3d59616f6a15271ea113", result);
        }
        [Fact]
        public void EndWhiteSpaceTestMD5()
        {
            String result = Hashfunctions.MD5("helloed ut perspiciatis unde omnis iste natus error sit volume lorem ");
            Assert.Equal("ca83ca3457c9e427e01a344c7b615f8d", result);
        }
        
        [Fact]
        public void EmptyStringTestMD4()
        {
            String result = Hashfunctions.MD4("");
            Assert.Equal("31d6cfe0d16ae931b73c59d7e0c089c0", result);
        }
        [Fact]
        public void ShortWordTestMD4()
        {
            String result = Hashfunctions.MD4("hello");
            Assert.Equal("866437cb7a794bce2b727acc0362ee27", result);
        }
        [Fact]
        public void LongWordTestMD4()
        {
            String result = Hashfunctions.MD4("Sed ut perspiciatis unde omnis iste natus error sit volume lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.");
            Assert.Equal("bce496eca2aed2c5025c904a743217b7", result);
        }
        [Fact]
        public void bitLenTest448MD4()
        {
            String result = Hashfunctions.MD4("Sed ut perspiciatis unde omnis iste natus error sit volu");
            Assert.Equal("2c1827a68b6f05a2a604ce9705ec91a4", result);
        }
        [Fact]
        public void bitLenTest512MD4()
        {
            String result = Hashfunctions.MD4("Sed ut perspiciatis unde omnis iste natus error sit volume lorem");
            Assert.Equal("6c89370d7a620b12f0f674ad377de072", result);
        }
        [Fact]
        public void StartWhiteSpaceTestMD4()
        {
            String result = Hashfunctions.MD4(" helloed ut perspiciatis unde omnis iste natus error sit volume lorem");
            Assert.Equal("0fd9b5fdbde2731dc8ef5cdc3f1a63c8", result);
        }
        [Fact]
        public void EndWhiteSpaceTestMD4()
        {
            String result = Hashfunctions.MD4("helloed ut perspiciatis unde omnis iste natus error sit volume lorem ");
            Assert.Equal("42e44898a3c7e8f27d68512b7982e83b", result);
        }
    }
}