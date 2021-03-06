/*
 * Copyright (c) 2005 Mike Bridge <mike@bridgecanada.com>
 * 
 * Permission is hereby granted, free of charge, to any 
 * person obtaining a copy of this software and associated 
 * documentation files (the "Software"), to deal in the 
 * Software without restriction, including without limitation
 * the rights to use, copy, modify, merge, publish, 
 * distribute, sublicense, and/or sell copies of the 
 * Software, and to permit persons to whom the Software 
 * is furnished to do so, subject to the following 
 * conditions:
 *
 * The above copyright notice and this permission notice 
 * shall be included in all copies or substantial portions 
 * of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF 
 * ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED 
 * TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A 
 * PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT 
 * SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR 
 * ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN 
 * ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, 
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE 
 * OR OTHER DEALINGS IN THE SOFTWARE.
 */

using System;
using System.Text;
using System.IO;

namespace DotNetOpenMail.Encoding
{
	/// <summary>
	/// Denotes 8bit encoding.  Note that this doesn't really
	/// encode anything; it just specifies that this email is already
	/// in 8-bit encoding.
	/// </summary>
	public class EightBitEncoder  : DoNothingEncoder
	{
		#region EightBitEncoder
		/// <summary>
		/// Empty Constructor
		/// </summary>
		private EightBitEncoder()
		{
		}
		#endregion

		#region GetInstance
		/// <summary>
		/// Create the EightBitEncoder object.
		/// </summary>
		public static EightBitEncoder GetInstance() 
		{
			return new EightBitEncoder();
		}
		#endregion

		#region ContentTransferEncodingString
		/// <summary>
		/// The String that goes in the content transfer encoding header
		/// </summary>
		public override String ContentTransferEncodingString
		{
			get {return "8bit";}
		}
		#endregion


	}
}
