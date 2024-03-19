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
		foreach (byte wor in words)//testing loop
		{
			Console.WriteLine(wor);
		}
		//Step 1: appending padding bits to message
		long b = 8 * words.Count;
		words.Add(128);
		long bitlength = b + 8;
		long padlength = 0;
		if (bitlength % 512 > 448)
		{
			padlength = 960 - bitlength % 512;
		}
		else if (bitlength % 512 < 448)
		{
			padlength = 448 - bitlength % 512;
		}
		//Assert(padlength%8==0);
		while (padlength > 0)//loop to add continuous zeroes onto the end of out bit message till bitlength=448mod512
		{
			words.Add(0);
			padlength -= 8;
		}
		//Note:above code can be shortened by changing while loop condition and continuously updating bitlength

		//Step 2: Append the 64-bit representation of the original number of bits to the list
		List<byte> bitrep = BitConverter.GetBytes(b).ToList();
		words.AddRange(bitrep.GetRange(4, 4));//add the low-order bits first
		words.AddRange(bitrep.GetRange(0, 4));

		//Step 3: Initialising message digest(MD) buffer
		List<byte> A = new List<byte> { 1, 35, 69, 103};
		List<byte> B = new List<byte> { 137, 171, 205, 239};
        List<byte> C = new List<byte> { 254, 222, 186, 152 };
        List<byte> D = new List<byte> { 118, 84, 50, 16 };
		//Note: potential bug here since the buffer words are not initialised using low order bytes first

		//Step 4:process the message using 48 rounds
		
		/* auxillary equations outline:
		 * f(X,Y,Z) = XY v (X')Z
		 * g(X,Y,Z) = XY v XZ v YZ
		 * h(X,Y,Z) = X xor Y xor Z
		 */
		
    }
}
//class to allow for easy bitwise operations on 32
public class Word
{
	private byte[] bits = new byte[4];
	void makeword(byte first, byte second, byte third, byte fourth)
	{
		bits[0] = first;
		bits[1] = second;
		bits[2] = third;
		bits[3] = fourth;
	}
}