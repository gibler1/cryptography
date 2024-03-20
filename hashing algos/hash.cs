using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

class Hashfunctions
{
	static public String MD4(string message)
	{
		List<byte> words = Encoding.ASCII.GetBytes(message).ToList();//turn string into byte format to make it easier to work with

		//Step 1: appending padding bits to message
		long originalBitLen = 8 * words.Count;
		words.Add((byte)128);
		long bitlength = originalBitLen + 8;
		while (bitlength%512 != 448)//loop to add continuous zeroes onto the end of out bit message till bitlength=448mod512
		{
			words.Add((byte)0);
			bitlength += 8;
		}

		//Step 2: Append the 64-bit representation of the original number of bits to the list
		List<byte> bitrep = BitConverter.GetBytes(originalBitLen).ToList();
		words.AddRange(bitrep);
		long N = words.Count/4;//number of 32-bit blocks

        //Step 3: Initialising message digest(MD) buffer
        Word A = new Word((byte)103, (byte)69, (byte)35, (byte)1);//01 23 45 67
        Word B = new Word((byte)239, (byte)205, (byte)171, (byte)137);//89 ab cd ef
        Word C = new Word((byte)152, (byte)186, (byte)220, (byte)254);//fe de ba 98
        Word D = new Word((byte)16, (byte)50, (byte)84, (byte)118);//76 54 32 10

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
            return ((x.and(y)).or(x.and(z))).or(y.and(z));
        }
        Word h(Word x, Word y, Word z)
        {
            return (x.xor(y)).xor(z);
        }

        //Loop to iterate over the padded message in 512bit blocks using 48 rounds for each block:
        for (int i = 0; i < N / 16; i++)
		{
			//initialise the variables which will be used in this block
			Word[] X = new Word[16];
			for (int j = 0; j < 16; j++)
			{
				X[j] = new Word(words[(i * 16 + j) * 4 + 3], words[(i * 16 + j) * 4 + 2], words[(i * 16 + j) * 4 + 1], words[(i * 16 + j) * 4]);
            }
            Word AA = (Word)A.Clone();
            Word BB = (Word)B.Clone();
            Word CC = (Word)C.Clone();
            Word DD = (Word)D.Clone();

            //Round 1
            //r1 represents [A B C D i s] which denotes: A = (A+ f(B,C,D) + X[i]) <<< s 
            void r1(ref Word f1,Word f2, Word f3, Word f4, int a, int s)
			{
				Word temp = (X[a].add((f1.add(f(f2, f3, f4)))));
				temp.shift(s);
				f1 = temp;
			}
			r1(ref A, B, C, D, 0, 3);
			r1(ref D, A, B, C, 1, 7);
			r1(ref C, D, A, B, 2, 11);
			r1(ref B, C, D, A, 3, 19);
			r1(ref A, B, C, D, 4, 3);
			r1(ref D, A, B, C, 5, 7);
			r1(ref C, D, A, B, 6, 11);
			r1(ref B, C, D, A, 7, 19);
			r1(ref A, B, C, D, 8, 3);
			r1(ref D, A, B, C, 9, 7);
			r1(ref C, D, A, B, 10, 11);
			r1(ref B, C, D, A, 11, 19);
			r1(ref A, B, C, D, 12, 3);
			r1(ref D, A, B, C, 13, 7);
			r1(ref C, D, A, B, 14, 11);
			r1(ref B, C, D, A, 15, 19);

            //Round 2
            //r2 represents [A B C D i s] which now denotes: A = (A+ g(B,C,D) + X[i] + 5A827999) <<< s 
            void r2(ref Word f1, Word f2, Word f3, Word f4, int a, int s)
            {
				Word constant = new Word((byte)90, (byte)130, (byte)121, (byte)153);//5A827999
                Word temp = (X[a].add((f1.add(g(f2, f3, f4))))).add(constant);
                temp.shift(s);
                f1 = temp;
            }
            r2(ref A, B, C, D, 0, 3);
            r2(ref D, A, B, C, 4, 5);
            r2(ref C, D, A, B, 8, 9);
            r2(ref B, C, D, A, 12, 13);
            r2(ref A, B, C, D, 1, 3);
            r2(ref D, A, B, C, 5, 5);
            r2(ref C, D, A, B, 9, 9);
            r2(ref B, C, D, A, 13, 13);
            r2(ref A, B, C, D, 2, 3);
			r2(ref D, A, B, C, 6, 5);
            r2(ref C, D, A, B, 10, 9);
            r2(ref B, C, D, A, 14, 13);
            r2(ref A, B, C, D, 3, 3);
            r2(ref D, A, B, C, 7, 5);
            r2(ref C, D, A, B, 11, 9);
            r2(ref B, C, D, A, 15, 13);

            //Round 3
            //r3 represents [A B C D i s] which now denotes: A = (A+ h(B,C,D) + X[i] + 6ED9EBA1) <<< s
            void r3(ref Word f1, Word f2, Word f3, Word f4, int a, int s)
            {
                Word constant = new Word((byte)110, (byte)217, (byte)235, (byte)161);//6ED9EBA1
                Word temp = (X[a].add(f1.add(h(f2, f3, f4)))).add(constant);
                temp.shift(s);
                f1 = temp;
            }
            r3(ref A, B, C, D, 0, 3);
            r3(ref D, A, B, C, 8, 9);
            r3(ref C, D, A, B, 4, 11);
            r3(ref B, C, D, A, 12, 15);
            r3(ref A, B, C, D, 2, 3);
            r3(ref D, A, B, C, 10, 9);
            r3(ref C, D, A, B, 6, 11);
            r3(ref B, C, D, A, 14, 15);
            r3(ref A, B, C, D, 1, 3);
            r3(ref D, A, B, C, 9, 9);
            r3(ref C, D, A, B, 5, 11);
            r3(ref B, C, D, A, 13, 15);
            r3(ref A, B, C, D, 3, 3);
            r3(ref D, A, B, C, 11, 9);
            r3(ref C, D, A, B, 7, 11);
            r3(ref B, C, D, A, 15, 15);

            /*END of rounds*/
            //final block additions
            A = A.add(AA);
            B = B.add(BB);
            C = C.add(CC);
            D = D.add(DD);

        }
        //returning the 128-bit sequence (ABCD) in hexadecimal format
        return (A.toHexString()+B.toHexString()+C.toHexString()+D.toHexString());
		
    }
}


/*class to allow for easy bitwise operations on 32bits.
 *methods:xor, and, or, complement, add, clone, shift, toHexString,Rev
 */
public class Word : ICloneable
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

	//shifts the bits of this word by a given value - this changes the object state
	public void shift(int s)
	{
		Array.Reverse(bits);
		uint shifted = BitConverter.ToUInt32(bits, 0);
		shifted = (shifted << s | shifted >> (32 - s));
		bits = BitConverter.GetBytes(shifted);
		Array.Reverse(bits);
	}

	//adds 2 words together and returns the result without changing state
	public Word add(Word other)
	{
		Array.Reverse(bits);//we reverse the order of the bytes since we are using big endian notation whiles the BitConverter class uses little endian notation
		other.Rev();
        uint thisbytes = BitConverter.ToUInt32(bits, 0);
        uint otherbytes = BitConverter.ToUInt32(other.bits, 0);
		ulong sum = (thisbytes + otherbytes);
		byte[] result = BitConverter.GetBytes((uint)(sum%4294967296));
		Array.Reverse(result);
        Array.Reverse(bits);
        other.Rev();
        return new Word(result[0], result[1], result[2], result[3]);
    }

	//returns the words' its hexadecimal string equivalent assuming low endian notation(no change to state)
	public String toHexString()
	{
		Array.Reverse(bits);
        String answer =  BitConverter.ToString(bits).Replace("-", "");
		Array.Reverse(bits);
		return answer;
    }

    //method to reverse the order/endianness of the bytes - changes the state
    public void Rev()
	{
		   Array.Reverse(bits);
	}

    //method to allow for easy copying of words without changing the state
    public object Clone()
	{
		return new Word(bits[0], bits[1], bits[2], bits[3]);
	}
}