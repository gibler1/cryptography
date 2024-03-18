using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

class Hashfunctions
{
	 static public void MD4(string message)
	{
		List<byte> words = Encoding.ASCII.GetBytes(message).ToList();//turn string into byte format to make it easier to work with
		foreach(byte word in words)//testing loop
		{
			Console.WriteLine(word);
		}
		//Step 1: appending padding bits to message
		long b = 8*words.Count;
		words.Add(128);
		long bitlength = b+8;
		long padlength = 0;
		if(bitlength%512 > 448)
		{
			padlength = 960 - bitlength%512;
		}
		else if(bitlength%512 < 448)
		{
			padlength = 448 - bitlength%512;
		}
		//Assert(padlength%8==0);
		while(padlength > 0)//loop to add continuous zeroes onto the end of out bit message till bitlength=448mod512
		{
			words.Add(0);
			padlength -= 8;
		}
		//Note:above code can be shortened by changing while loop condition and continuously updating bitlength

		//Step 2: Append the 64-bit representation of the original number of bits to the list
		List<>BitConverter.GetBytes(b).ToList();

	}
}
