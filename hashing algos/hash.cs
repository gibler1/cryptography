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
		Word A = new Word(1, 35, 69, 103);
		Word B = new Word(137, 171, 205, 239);
        Word C = new Word(254, 222, 186, 152);
        Word D = new Word(118, 84, 50, 16);
		//Note: potential bug here since the buffer words are not initialised using low order bytes first

		//Step 4:process the message using 48 rounds
		
		/* auxillary equations outline:
		 * f(X,Y,Z) = XY v (X')Z
		 * g(X,Y,Z) = XY v XZ v YZ
		 * h(X,Y,Z) = X xor Y xor Z
		 */
		Word f(Word x,Word y, Word z)
		{
			return (x.and(y)).or((x.complement()).and(z));
		}
        Word g(Word x, Word y, Word z)
        {
            return (x.and(y)).or((x.complement()).and(z));
        }

    }
}
/*class to allow for easy bitwise operations on 32bits.
 *methods:xor, and, or, complement
 */
public class Word
{
	private byte[] bits = new byte[4];
	public Word(byte first, byte second, byte third, byte fourth)
	{
		bits[0] = first;
		bits[1] = second;
		bits[2] = third;
		bits[3] = fourth;
	}

	//returns the bitwise xor of 2 words without changing the state
	public Word xor(Word other)
	{
		byte[] newbytes = bits.Zip(other.bits, (a, b) => (byte)(a ^ b)).ToArray();
		Word newword = new Word(newbytes[0], newbytes[1], newbytes[2], newbytes[3]);
		return newword;
	}
    
	//returns the bitwise and of 2 words without changing the state
    public Word and(Word other)
	{
        byte[] newbytes = bits.Zip(other.bits, (a, b) => (byte)(a & b)).ToArray();
        Word newword = new Word(newbytes[0], newbytes[1], newbytes[2], newbytes[3]);
        return newword;
    }

    //returns the bitwise or of 2 words without changing the state
    public Word or(Word other)
	{
        byte[] newbytes = bits.Zip(other.bits, (a, b) => (byte)(a | b)).ToArray();
        Word newword = new Word(newbytes[0], newbytes[1], newbytes[2], newbytes[3]);
        return newword;
    }

    //returns the bitwise complement without changing the state
    public Word complement()
	{
        byte[] newbytes = new byte[4];
		for(int i= 0;i < 4; i++)
		{
			newbytes[i] = (byte)(~bits[i]);
		}
        Word newword = new Word(newbytes[0], newbytes[1], newbytes[2], newbytes[3]);
        return newword;
    }
}